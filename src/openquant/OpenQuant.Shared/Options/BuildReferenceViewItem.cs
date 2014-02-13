using OpenQuant.Shared.Compiler;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
	internal class BuildReferenceViewItem : ListViewItem
	{
		private BuildReference reference;

		public BuildReference Reference
		{
			get
			{
				return this.reference;
			}
		}

		public BuildReferenceViewItem(BuildReference reference)
      : base(new string[3])
		{
			this.reference = reference;
			this.SubItems[0].Text = reference.Name;
			this.SubItems[1].Text = reference.Version.ToString(4);
			if (reference.Valid)
			{
				this.SubItems[2].Text = reference.Path;
				this.ImageIndex = 0;
			}
			else
			{
				this.SubItems[2].Text = reference.HintPath;
				this.ImageIndex = 1;
			}
		}
	}
}
