using OpenQuant.Shared.Compiler;
using System;

namespace OpenQuant.Shared.Scripts
{
	class CodeLangItem
	{
		public CodeLang CodeLang { get; private set; }

		public CodeLangItem(CodeLang codeLang)
		{
			this.CodeLang = codeLang;
		}

		public override string ToString()
		{
			switch (this.CodeLang)
			{
				case CodeLang.CSharp:
					return "Visual C#";
				case CodeLang.VisualBasic:
					return "Visual Basic";
				default:
					throw new ArgumentException(string.Format("Not supported code language - {0}", this.CodeLang));
			}
		}
	}
}
