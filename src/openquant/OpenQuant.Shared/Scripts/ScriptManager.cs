using OpenQuant.API;
using OpenQuant.Shared;
using OpenQuant.Shared.Compiler;
using OpenQuant.Shared.Options;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace OpenQuant.Shared.Scripts
{
	public class ScriptManager
	{
		private DirectoryInfo scriptsDirectory;
		private FileInfo configFile;
		private Dictionary<ScriptKey, ScriptRunner> runners;
		private Dictionary<ScriptKey, ScriptSettings> settings;
		private HashSet<ScriptKey> startupScripts;
		private int scriptID;

		internal DirectoryInfo ScriptsDirectory
		{
			get
			{
				return this.scriptsDirectory;
			}
		}

		public event EventHandler<ScriptRunnerEventArgs> Starting;
		public event EventHandler<ScriptRunnerEventArgs> Started;
		public event EventHandler<ScriptRunnerEventArgs> Stopping;
		public event EventHandler<ScriptRunnerEventArgs> Stopped;
		public event EventHandler<ScriptRunnerErrorEventArgs> Error;

		public ScriptManager(DirectoryInfo scriptsDirectory, FileInfo configFile)
		{
			this.scriptsDirectory = scriptsDirectory;
			this.configFile = configFile;
			this.runners = new Dictionary<ScriptKey, ScriptRunner>();
			this.settings = new Dictionary<ScriptKey, ScriptSettings>();
			this.startupScripts = new HashSet<ScriptKey>();
			this.scriptID = 1;
			this.LoadConfig();
		}

		public Script[] GetRunningScripts()
		{
			List<Script> list = new List<Script>();
			foreach (ScriptRunner scriptRunner in this.runners.Values)
				list.Add(scriptRunner.Script);
			return list.ToArray();
		}

		private void LoadConfig()
		{
			if (!this.configFile.Exists)
				return;
			ConfigXmlDocument configXmlDocument = new ConfigXmlDocument();
			((XmlDocument)configXmlDocument).Load(this.configFile.FullName);
			IEnumerator enumerator = configXmlDocument.StartupScripts.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
					this.startupScripts.Add(new ScriptKey(((StartupScriptXmlNode)enumerator.Current).Path.GetValue(this.scriptsDirectory)));
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
					disposable.Dispose();
			}
		}

		private void SaveConfig()
		{
			ConfigXmlDocument configXmlDocument = new ConfigXmlDocument();
			foreach (ScriptKey scriptKey in this.startupScripts)
				configXmlDocument.StartupScripts.Add(scriptKey.File, this.scriptsDirectory);
			((XmlDocument)configXmlDocument).Save(this.configFile.FullName);
		}

		public void RunStartupScripts(BuildOptions buildOptions, ScriptsOptions scriptsOptions)
		{
			foreach (ScriptKey scriptKey in this.startupScripts)
				this.Run(scriptKey.File, buildOptions, scriptsOptions);
		}

		internal bool IsStartupScript(FileInfo file)
		{
			return this.startupScripts.Contains(new ScriptKey(file));
		}

		internal void AddStartupScript(FileInfo file)
		{
			if (!this.startupScripts.Add(new ScriptKey(file)))
				return;
			this.SaveConfig();
		}

		internal void RemoveStartupScript(FileInfo file)
		{
			if (!this.startupScripts.Remove(new ScriptKey(file)))
				return;
			this.SaveConfig();
		}

		public Script Build(FileInfo file, BuildOptions buildOptions)
		{
			Script script = this.BuildScript(file, buildOptions);
			ScriptKey key = new ScriptKey(file);
			ScriptSettings scriptSettings;
			if (!this.settings.TryGetValue(key, out scriptSettings))
			{
				scriptSettings = new ScriptSettings(file);
				this.settings.Add(key, scriptSettings);
			}
			scriptSettings.Script = script;
			if (script != null)
			{
				scriptSettings.Merge(script);
				scriptSettings.Populate(script);
				scriptSettings.Save();
			}
			return script;
		}

		public void Run(FileInfo file, BuildOptions buildOptions, ScriptsOptions scriptsOptions)
		{
			this.Run(file, buildOptions, scriptsOptions, null);
		}

		public void Run(FileInfo file, BuildOptions buildOptions, ScriptsOptions scriptsOptions, OpenQuant.API.ScriptSettings scriptSettings)
		{
			ScriptKey key = new ScriptKey(file);
			if (this.runners.ContainsKey(key))
				throw new InvalidOperationException("The script " + file.Name + " is already running");
			Script script = this.Build(file, buildOptions);
			if (script == null)
				return;
			if (scriptSettings != null)
			{
				foreach (KeyValuePair<string, object> keyValuePair in scriptSettings)
				{
					FieldInfo field = script.GetType().GetField(keyValuePair.Key, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetField);
					if (field != (FieldInfo)null)
					{
						if (field.GetCustomAttributes(typeof(ParameterAttribute), true).Length > 0)
						{
							try
							{
								field.SetValue(script, keyValuePair.Value);
							}
							catch
							{
							}
						}
					}
				}
			}
			ScriptRunner scriptRunner = new ScriptRunner(key, script, scriptsOptions, this.scriptID.ToString());
			scriptRunner.Starting += new EventHandler(this.runner_Starting);
			scriptRunner.Started += new EventHandler(this.runner_Started);
			scriptRunner.Stopping += new EventHandler(this.runner_Stopping);
			scriptRunner.Stopped += new EventHandler(this.runner_Stopped);
			scriptRunner.Error += new EventHandler<ScriptRunnerErrorEventArgs>(this.runner_Error);
			this.runners.Add(key, scriptRunner);
			scriptRunner.Start();
		}

		private void runner_Starting(object sender, EventArgs e)
		{
			if (this.Starting == null)
				return;
			this.Starting(this, new ScriptRunnerEventArgs((ScriptRunner)sender));
		}

		private void runner_Started(object sender, EventArgs e)
		{
			if (this.Started == null)
				return;
			this.Started(this, new ScriptRunnerEventArgs((ScriptRunner)sender));
		}

		private void runner_Stopping(object sender, EventArgs e)
		{
			if (this.Stopping == null)
				return;
			this.Stopping((object)this, new ScriptRunnerEventArgs((ScriptRunner)sender));
		}

		private void runner_Stopped(object sender, EventArgs e)
		{
			ScriptRunner runner = (ScriptRunner)sender;
			runner.Started -= new EventHandler(this.runner_Started);
			runner.Starting -= new EventHandler(this.runner_Starting);
			runner.Stopped -= new EventHandler(this.runner_Stopped);
			runner.Stopping -= new EventHandler(this.runner_Stopping);
			runner.Error -= new EventHandler<ScriptRunnerErrorEventArgs>(this.runner_Error);
			this.runners.Remove(runner.Key);
			if (this.Stopped == null)
				return;
			this.Stopped((object)this, new ScriptRunnerEventArgs(runner));
		}

		private void runner_Error(object sender, ScriptRunnerErrorEventArgs e)
		{
			if (this.Error == null)
				return;
			this.Error((object)this, e);
		}

		public void Stop(FileInfo file)
		{
			ScriptRunner scriptRunner;
			if (!this.runners.TryGetValue(new ScriptKey(file), out scriptRunner))
				return;
			scriptRunner.Stop();
		}

		private Script BuildScript(FileInfo file, BuildOptions buildOptions)
		{
			Script script = (Script)null;
			Global.ToolWindowManager.ClearErrorList();
			Console.WriteLine(string.Format("Building script {0}...", file.Name));
			Global.EditorManager.Save(file);
			CompilingServices compilingServices = new CompilingServices(CodeHelper.GetCodeLang(file));
			if (buildOptions != null)
			{
				foreach (BuildReference buildReference in buildOptions.GetReferences())
				{
					if (buildReference.Valid)
						compilingServices.AddReference(buildReference.Path);
				}
			}
			compilingServices.AddFile(file.FullName);
			CompilerResults compilerResults = compilingServices.Compile();
			if (compilerResults.Errors.HasErrors)
			{
				Console.WriteLine("Built with errors.");
				this.OnBuildErrors(compilerResults.Errors);
				return null;
			}
			else
			{
				if (compilerResults.Errors.HasWarnings)
				{
					Console.WriteLine("Built with warnings.");
					this.OnBuildErrors(compilerResults.Errors);
				}
				System.Type type1 = (System.Type)null;
				foreach (System.Type type2 in compilerResults.CompiledAssembly.GetTypes())
				{
					if (type2.IsSubclassOf(typeof(Script)))
					{
						type1 = type2;
						break;
					}
				}
				if (type1 == null)
				{
					Console.WriteLine("Built with errors.");
					this.OnBuildErrors(new CompilerErrorCollection()
					{
						new CompilerError(file.FullName, 1, 1, "", "Script is not found, make sure that the code contains a class derived from the OpenQuant.API.Script class")
					});
				}
				else
				{
					script = Activator.CreateInstance(type1, false) as Script;
					if (Application.OpenForms.Count > 0)
						typeof(Script).GetField("mainForm", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue((object)script, (object)Application.OpenForms[0]);
					++this.scriptID;
					Console.WriteLine("Build succeeded.");
				}
				return script;
			}
		}

		internal bool IsScriptRunning(FileInfo file)
		{
			return this.runners.ContainsKey(new ScriptKey(file));
		}

		internal ScriptSettings GetScriptSettings(FileInfo file, BuildOptions buildOptions)
		{
			ScriptKey key = new ScriptKey(file);
			if (!this.settings.ContainsKey(key))
				this.Build(file, buildOptions);
			return this.settings[key];
		}

		protected virtual void OnBuildErrors(CompilerErrorCollection errors)
		{
		}
	}
}
