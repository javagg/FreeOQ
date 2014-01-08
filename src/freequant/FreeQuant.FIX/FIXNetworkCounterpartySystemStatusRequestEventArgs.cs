using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNetworkCounterpartySystemStatusRequestEventArgs : EventArgs
  {
    private FIXNetworkCounterpartySystemStatusRequest jjH8Lt1RRP;

    public FIXNetworkCounterpartySystemStatusRequest NetworkCounterpartySystemStatusRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jjH8Lt1RRP;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.jjH8Lt1RRP = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNetworkCounterpartySystemStatusRequestEventArgs(FIXNetworkCounterpartySystemStatusRequest NetworkCounterpartySystemStatusRequest)
    {
      this.jjH8Lt1RRP = NetworkCounterpartySystemStatusRequest;
    }
  }
}
