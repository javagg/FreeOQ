using FreeQuant.Providers;
using System;
using System.Windows.Forms;

namespace OpenQuant.Shared.Providers
{
  class ProviderNode : TreeNode
  {
    private IProvider provider;

    public IProvider Provider
    {
      get
      {
        return this.provider;
      }
    }

    public ProviderNode(IProvider provider)
    {
      this.provider = provider;
      this.Text = provider.Name;
      this.ToolTipText = string.Format("{0}{1}{2}", provider.Title, Environment.NewLine, provider.URL);
      this.UpdateStatus();
    }

    public void UpdateStatus()
    {
      this.ImageIndex = this.SelectedImageIndex = this.provider.IsConnected ? 3 : 2;
    }
  }
}
