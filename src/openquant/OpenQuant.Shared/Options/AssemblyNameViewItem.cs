using System.Reflection;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
	class AssemblyNameViewItem : ListViewItem
	{
		private AssemblyName assembly;

		public AssemblyName Assembly
		{
			get
			{
				return this.assembly;
			}
		}

		public AssemblyNameViewItem(AssemblyName assembly) : base(new string[3], 0)
		{
			this.assembly = assembly;
			this.SubItems[0].Text = assembly.Name;
			this.SubItems[1].Text = assembly.Version.ToString(4);
			this.SubItems[2].Text = ((object)assembly.ProcessorArchitecture).ToString();
		}
	}
}
