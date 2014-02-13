using OpenQuant.Shared.Compiler;
using System.IO;

namespace OpenQuant.Shared.Scripts
{
	class ScriptFileNode : FileSystemEntryNode
	{
		public FileInfo File { get; set; }

		public ScriptFileNode(string name) : base(name)
		{
		}

		public override void RenameTo(string name)
		{
			base.RenameTo(name);
			int num = 0;
			switch (CodeHelper.GetCodeLang(name))
			{
				case CodeLang.None:
					num = 5;
					break;
				case CodeLang.CSharp:
					num = 3;
					break;
				case CodeLang.VisualBasic:
					num = 4;
					break;
			}
			this.ImageIndex = this.SelectedImageIndex = num;
		}
	}
}
