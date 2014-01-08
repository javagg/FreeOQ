using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXHopsGroup : FIXGroup
  {
    [FIXField("628", EFieldOption.Optional)]
    public string HopCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(628).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(628, value);
      }
    }

    [FIXField("629", EFieldOption.Optional)]
    public DateTime HopSendingTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(629).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(629, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHopsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
