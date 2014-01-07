// Type: OpenQuant.ProviderMenuItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Properties;
using SmartQuant.Providers;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant
{
  internal class ProviderMenuItem : ToolStripMenuItem
  {
    private IProvider provider;

    public IProvider Provider
    {
      get
      {
        return this.provider;
      }
    }

    public IMarketDataProvider ProviderAsMarketDataProvider
    {
      get
      {
        return this.provider as IMarketDataProvider;
      }
    }

    public IExecutionProvider ProviderAsExecutionProvider
    {
      get
      {
        return this.provider as IExecutionProvider;
      }
    }

    public IInstrumentProvider ProviderAsInstrumentProvider
    {
      get
      {
        return this.provider as IInstrumentProvider;
      }
    }

    public IHistoricalDataProvider ProviderAsHistoricalDataProvider
    {
      get
      {
        return this.provider as IHistoricalDataProvider;
      }
    }

    public ProviderMenuItem(IProvider provider)
      : base(provider.Name)
    {
      this.provider = provider;
      this.Image = provider.IsConnected ? (Image) Resources.provider_connected : (Image) Resources.provider_disconnected;
    }
  }
}
