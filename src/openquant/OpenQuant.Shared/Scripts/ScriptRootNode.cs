using System.IO;

namespace OpenQuant.Shared.Scripts
{
	class ScriptRootNode : ScriptDirectoryNode
	{
		public ScriptRootNode(DirectoryInfo rootDirectory) : base("Scripts")
		{
			this.Name = rootDirectory.FullName;
		}

		public override void UpdateImage()
		{
			this.ImageIndex = this.SelectedImageIndex = 0;
		}
	}
}
