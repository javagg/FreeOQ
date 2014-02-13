using OpenQuant.API;
using OpenQuant.Shared.Options;
using System;
using System.Threading;

namespace OpenQuant.Shared.Scripts
{
	public class ScriptRunner
	{
		private ScriptKey key;
		private Script script;
		private ScriptsOptions options;
		private string id;
		private Thread thread;
		private bool isRunning;

		public ScriptKey Key
		{
			get
			{
				return this.key;
			}
		}

		public Script Script
		{
			get
			{
				return this.script;
			}
		}

		public event EventHandler Starting;
		public event EventHandler Started;
		public event EventHandler Stopping;
		public event EventHandler Stopped;
		public event EventHandler<ScriptRunnerErrorEventArgs> Error;

		internal ScriptRunner(ScriptKey key, Script script, ScriptsOptions options, string id)
		{
			this.key = key;
			this.script = script;
			this.options = options;
			this.id = id;
			this.isRunning = false;
		}

		private void OnStarting()
		{
			if (this.Starting == null)
				return;
			this.Starting(this, EventArgs.Empty);
		}

		private void OnStarted()
		{
			if (this.Started == null)
				return;
			this.Started(this, EventArgs.Empty);
		}

		private void OnStopping()
		{
			if (this.Stopping == null)
				return;
			this.Stopping(this, EventArgs.Empty);
		}

		private void OnStopped()
		{
			if (this.Stopped == null)
				return;
			this.Stopped(this, EventArgs.Empty);
		}

		private void OnError(Exception exception)
		{
			if (this.Error == null)
				return;
			this.Error(this, new ScriptRunnerErrorEventArgs(this, new ScriptRunnerError(exception)));
		}

		public void Start()
		{
			if (this.isRunning)
			{
				this.OnError((Exception)new InvalidOperationException("Already running."));
			}
			else
			{
				this.OnStarting();
				this.thread = new Thread(new ThreadStart(this.Run));
				this.thread.Name = string.Format("Script runner - {0}", this.id);
				if (this.options != null)
					this.thread.SetApartmentState(this.options.ApartmentState);
				this.thread.Start();
			}
		}

		public void Stop()
		{
			if (!this.isRunning)
			{
				this.OnError((Exception)new InvalidOperationException("Not running."));
			}
			else
			{
				this.script.OnStop();
				this.thread.Abort();
			}
		}

		private void Run()
		{
			try
			{
				this.isRunning = true;
				this.OnStarted();
				this.script.Run();
			}
			catch (ThreadAbortException ex)
			{
				Thread.ResetAbort();
			}
			catch (Exception ex)
			{
				this.OnError(ex);
			}
			finally
			{
				this.isRunning = false;
				this.OnStopped();
			}
		}
	}
}
