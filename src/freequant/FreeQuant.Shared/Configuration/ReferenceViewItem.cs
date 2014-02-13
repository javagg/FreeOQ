using FreeQuant;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FreeQuant.Shared.Configuration
{
	public class ReferenceViewItem : ListViewItem
	{
		private Reference DkuxB5HrTK;

		public Reference Reference
		{
			get
			{
				return this.DkuxB5HrTK;
			}
		}

		
		public ReferenceViewItem(Reference reference):base(new string[3])
		{
			this.DkuxB5HrTK = reference;
			this.SubItems[0].Text = reference.AssemblyName.Name;
			this.SubItems[1].Text =  reference.AssemblyName.Version.ToString();
			this.SubItems[2].Text = reference.Path;
			this.Checked = reference.Enabled;
			this.UpdateIcon();
		}

		
		public void UpdateIcon()
		{
			if (this.DkuxB5HrTK.Valid)
				this.ImageIndex = this.DkuxB5HrTK.Enabled ? 0 : 1;
			else
				this.ImageIndex = 2;
		}
	}
}
