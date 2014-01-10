using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
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


//    public override string ToString()
//    {
//      if (this.SecurityAltID == "")
//        return Ugjylcah9mCMM4kO7N.tLah92SpBQ(38688);
//      if (this.SecurityAltExchange == "")
//        return string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(38714), (object) this.SecurityAltIDSource, (object) this.SecurityAltID);
//      else
//        return string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(38736), (object) this.SecurityAltIDSource, (object) this.SecurityAltID, (object) this.SecurityAltExchange);
//    }
  }
}
