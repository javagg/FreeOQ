using System.Windows.Forms;

namespace OpenQuant.Shared.Scripts
{
	class FileSystemEntryNode : TreeNode
	{
		protected FileSystemEntryNode(string name)
		{
			this.RenameTo(name);
		}

		public virtual void RenameTo(string name)
		{
			this.Name = name;
			this.Text = name;
		}
	}
}
