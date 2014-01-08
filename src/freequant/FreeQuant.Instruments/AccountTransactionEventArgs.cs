using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class AccountTransactionEventArgs : EventArgs
  {
    private AccountTransaction z84W50hjS3;

    public AccountTransaction Transaction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.z84W50hjS3;
      }
    }

    public AccountTransactionEventArgs(AccountTransaction transaction)
    {
      this.z84W50hjS3 = transaction;
    }
  }
}
