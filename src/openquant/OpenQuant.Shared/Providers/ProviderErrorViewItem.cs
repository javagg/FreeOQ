using FreeQuant.Providers;
using System.Windows.Forms;

namespace OpenQuant.Shared.Providers
{
	class ProviderErrorViewItem : ListViewItem
	{
		private ProviderError error;

		public ProviderError Error
		{
			get
			{
				return this.error;
			}
		}

		public ProviderErrorViewItem(ProviderError error) : base(new string[5])
		{
			this.error = error;
			this.SubItems[0].Text = error.DateTime.ToString();
			this.SubItems[1].Text = error.Provider.Name;
			this.SubItems[2].Text = error.Id.ToString();
			this.SubItems[3].Text = error.Code.ToString();
			this.SubItems[4].Text = error.Message;
		}
	}
}
