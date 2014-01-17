using Microsoft.CSharp;
using Microsoft.VisualBasic;
using FreeQuant;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CleverQuant.Shared.Compiler
{
	public enum CodeLang
	{
		None,
		CSharp,
		VisualBasic,
	}

	public class CompilerParameters : System.CodeDom.Compiler.CompilerParameters
	{
		CompilerParameters()
		{
			this.GenerateInMemory = false;
			this.IncludeDebugInformation = true;
			this.GenerateExecutable = false;
			this.WarningLevel = 3;
			this.TempFiles.KeepFiles = true;
		}
	}

	public class CompilingServices
	{
		private CodeLang codeLang;
		private List<string> filenames;
		private List<string> references;

		public CompilerParameters Parameters { get; private set; }

		public CompilingServices(CodeLang codeLang)
		{
			this.codeLang = codeLang;
			this.Parameters = new CompilerParameters();
			this.filenames = new List<string>();
			this.references = new List<string>();
		}

		public void AddFile(string filename)
		{
			this.filenames.Add(filename);
		}

		public void AddReference(string reference)
		{
			this.references.Add(reference);
		}

		public CompilerResults Compile()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("CompilerVersion", "v4.0");
			CodeDomProvider codeDomProvider;
			switch (this.codeLang)
			{
				case CodeLang.CSharp:
					codeDomProvider = new CSharpCodeProvider(dictionary);
					break;
				case CodeLang.VisualBasic:
					codeDomProvider = new VBCodeProvider(dictionary);
					break;
				default:
					throw new NotSupportedException(string.Format("Not supported code language - {0}", this.codeLang));
			}
			foreach (string str in this.references)
				this.Parameters.ReferencedAssemblies.Add(str);

			if (this.codeLang == CodeLang.VisualBasic)
			{
				foreach (object obj in new List<string>()
					{
						"FreeQuant.FIX",
						"FreeQuant.Instruments",
						"FreeQuant.Series",
						"FreeQuant.Charting"
					})
					this.Parameters.ReferencedAssemblies.Add(string.Format("{0}\\{1}.dll", Framework.Installation.BinDir.FullName, obj));
			}
			return codeDomProvider.CompileAssemblyFromFile(this.Parameters, this.filenames.ToArray());
		}
	}
}
