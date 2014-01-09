using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXEventsGroup : FIXGroup
  {
    [FIXField("865", EFieldOption.Optional)]
    public int EventType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(865).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(865, value);
      }
    }

    [FIXField("866", EFieldOption.Optional)]
    public DateTime EventDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(866).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(866, value);
      }
    }

    [FIXField("867", EFieldOption.Optional)]
    public double EventPx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(867).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(867, value);
      }
    }

    [FIXField("868", EFieldOption.Optional)]
    public string EventText
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(868).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(868, value);
      }
    }

  }
}
