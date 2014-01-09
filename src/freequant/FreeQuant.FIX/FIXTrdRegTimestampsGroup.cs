using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTrdRegTimestampsGroup : FIXGroup
  {
    [FIXField("769", EFieldOption.Optional)]
    public DateTime TrdRegTimestamp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(769).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(769, value);
      }
    }

    [FIXField("770", EFieldOption.Optional)]
    public int TrdRegTimestampType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(770).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(770, value);
      }
    }

    [FIXField("771", EFieldOption.Optional)]
    public string TrdRegTimestampOrigin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(771).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(771, value);
      }
    }

  }
}
