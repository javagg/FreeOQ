using Microsoft.CSharp;
using Microsoft.VisualBasic;
using FreeQuant;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace OpenQuant.Shared.Compiler
{
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
					codeDomProvider = (CodeDomProvider)new CSharpCodeProvider((IDictionary<string, string>)dictionary);
					break;
				case CodeLang.VisualBasic:
					codeDomProvider = (CodeDomProvider)new VBCodeProvider((IDictionary<string, string>)dictionary);
					break;
				default:
					throw new NotSupportedException(string.Format("Not supported code language - {0}", (object)this.codeLang));
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
					this.Parameters.ReferencedAssemblies.Add(string.Format("{0}\\{1}.dll", (object)Framework.Installation.BinDir.FullName, obj));
			}
			return codeDomProvider.CompileAssemblyFromFile((System.CodeDom.Compiler.CompilerParameters)this.Parameters, this.filenames.ToArray());
		}
	}
}
