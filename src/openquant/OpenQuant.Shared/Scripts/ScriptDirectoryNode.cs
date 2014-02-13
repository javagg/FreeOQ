namespace OpenQuant.Shared.Scripts
{
	class ScriptDirectoryNode : FileSystemEntryNode
	{
		public ScriptDirectoryNode(string name) : base(name)
		{
			this.UpdateImage();
		}

		public virtual void UpdateImage()
		{
			this.ImageIndex = this.SelectedImageIndex = this.IsExpanded ? 2 : 1;
		}
	}
}
