// Type: SmartQuant.FIX.FIXTrdRegTimestampsGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTrdRegTimestampsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
