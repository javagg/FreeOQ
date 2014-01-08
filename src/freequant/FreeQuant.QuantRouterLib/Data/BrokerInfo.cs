using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class BrokerInfo
  {
    private BrokerAccountList YZqfFTwQu;

    public byte ProviderId { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public BrokerAccountList Accounts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.YZqfFTwQu;
      }
    }
    public BrokerInfo()
    {
      this.YZqfFTwQu = new BrokerAccountList();
    }
  }
}
