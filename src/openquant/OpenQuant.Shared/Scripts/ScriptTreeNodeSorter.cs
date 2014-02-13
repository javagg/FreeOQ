using System.Collections;

namespace OpenQuant.Shared.Scripts
{
	class ScriptTreeNodeSorter : IComparer
	{
		public int Compare(object x, object y)
		{
			FileSystemEntryNode fileSystemEntryNode1 = (FileSystemEntryNode)x;
			FileSystemEntryNode fileSystemEntryNode2 = (FileSystemEntryNode)y;
			if (fileSystemEntryNode1 is ScriptDirectoryNode)
			{
				if (fileSystemEntryNode2 is ScriptDirectoryNode)
					return string.Compare(fileSystemEntryNode1.Text, fileSystemEntryNode2.Text);
				else
					return -1;
			}
			else
			{
				if (!(fileSystemEntryNode1 is ScriptFileNode))
					return 0;
				if (fileSystemEntryNode2 is ScriptFileNode)
					return string.Compare(fileSystemEntryNode1.Text, fileSystemEntryNode2.Text);
				else
					return 1;
			}
		}
	}
}
