using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNetworkCounterpartySystemStatusResponseEventArgs : EventArgs
  {
    private FIXNetworkCounterpartySystemStatusResponse AgragggDB;

    public FIXNetworkCounterpartySystemStatusResponse NetworkCounterpartySystemStatusResponse
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.AgragggDB;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AgragggDB = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNetworkCounterpartySystemStatusResponseEventArgs(FIXNetworkCounterpartySystemStatusResponse NetworkCounterpartySystemStatusResponse)
    {
      this.AgragggDB = NetworkCounterpartySystemStatusResponse;
    }
  }
}
