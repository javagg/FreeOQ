using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXDistribInstsGroup : FIXGroup
  {
    [FIXField("477", EFieldOption.Optional)]
    public int DistribPaymentMethod
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(477).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(477, value);
      }
    }

    [FIXField("512", EFieldOption.Optional)]
    public double DistribPercentage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(512).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(512, value);
      }
    }

    [FIXField("478", EFieldOption.Optional)]
    public double CashDistribCurr
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(478).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(478, value);
      }
    }

    [FIXField("498", EFieldOption.Optional)]
    public string CashDistribAgentName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(498).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(498, value);
      }
    }

    [FIXField("499", EFieldOption.Optional)]
    public string CashDistribAgentCode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(499).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(499, value);
      }
    }

    [FIXField("500", EFieldOption.Optional)]
    public string CashDistribAgentAcctNumber
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(500).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(500, value);
      }
    }

    [FIXField("501", EFieldOption.Optional)]
    public string CashDistribPayRef
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(501).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(501, value);
      }
    }

    [FIXField("502", EFieldOption.Optional)]
    public string CashDistribAgentAcctName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(502).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(502, value);
      }
    }

 
  }
}
