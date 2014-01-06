// Type: SmartQuant.FIX.FIXSecurityAltIDGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXSecurityAltIDGroup : FIXGroup
  {
    public override int Tag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return 454;
      }
    }

    [FIXField("455", EFieldOption.Optional)]
    public string SecurityAltID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(455);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(455, value);
      }
    }

    [FIXField("456", EFieldOption.Optional)]
    public string SecurityAltIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(456);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(456, value);
      }
    }

    [FIXField("12100", EFieldOption.Optional)]
    public string SecurityAltExchange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(12100);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(12100, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityAltIDGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      if (this.SecurityAltID == "")
        return Ugjylcah9mCMM4kO7N.tLah92SpBQ(38688);
      if (this.SecurityAltExchange == "")
        return string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(38714), (object) this.SecurityAltIDSource, (object) this.SecurityAltID);
      else
        return string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(38736), (object) this.SecurityAltIDSource, (object) this.SecurityAltID, (object) this.SecurityAltExchange);
    }
  }
}
