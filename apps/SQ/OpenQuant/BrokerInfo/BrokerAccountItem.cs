// Type: OpenQuant.BrokerInfo.BrokerAccountItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Providers;

namespace OpenQuant.BrokerInfo
{
  internal class BrokerAccountItem
  {
    private BrokerAccount account;

    public BrokerAccount Account
    {
      get
      {
        return this.account;
      }
    }

    public BrokerAccountItem(BrokerAccount account)
    {
      this.account = account;
    }

    public override string ToString()
    {
      return this.account.Name;
    }
  }
}
