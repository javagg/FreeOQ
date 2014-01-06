// Type: SmartQuant.FIX.FIXCompIDsGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXCompIDsGroup : FIXGroup
  {
    [FIXField("930", EFieldOption.Optional)]
    public string RefCompID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(930).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(930, value);
      }
    }

    [FIXField("931", EFieldOption.Optional)]
    public string RefSubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(931).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(931, value);
      }
    }

    [FIXField("283", EFieldOption.Optional)]
    public string LocationID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(283).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(283, value);
      }
    }

    [FIXField("284", EFieldOption.Optional)]
    public string DeskID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(284).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(284, value);
      }
    }

    [FIXField("928", EFieldOption.Optional)]
    public int StatusValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(928).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(928, value);
      }
    }

    [FIXField("929", EFieldOption.Optional)]
    public string StatusText
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(929).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(929, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXCompIDsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
