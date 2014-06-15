using System;
using System.IO;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using FreeQuant;
using Microsoft.CSharp;
using Microsoft.VisualBasic;

namespace OpenQuant.Shared.Compiler
{
    public class CompilingServices
    {
        private CodeLang codeLang;
        private List<string> filenames;
        private List<string> references;
        private CompilerParameters parameters;

        public CompilerParameters Parameters
        { 
            get
            {
                return this.parameters;
            }
        }

        public CompilingServices(CodeLang codeLang)
        {
            this.codeLang = codeLang;
            this.parameters = new CompilerParameters();
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
            foreach (string reference in this.references)
                this.parameters.ReferencedAssemblies.Add(reference);
            if (this.codeLang == CodeLang.VisualBasic)
            {
                foreach (object obj in new List<string>()
                {  
                    "FreeQuant.FIX", 
                    "FreeQuant.Instruments", 
                    "FreeQuant.Series", 
                    "FreeQuant.Charting" 
                })
                    this.parameters.ReferencedAssemblies.Add(Path.Combine(Framework.Installation.BinDir.FullName, string.Format("{0}.dll", obj)));
            }
            return codeDomProvider.CompileAssemblyFromFile(this.parameters, this.filenames.ToArray());
        }
    }
}
