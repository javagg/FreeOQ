using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXStrikesGroup : FIXGroup
  {
    private ArrayList ovMtIkH9Mt;
    private ArrayList uLmtHcBqaV;

    [FIXField("55", EFieldOption.Optional)]
    public string Symbol
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(55).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(55, value);
      }
    }

    [FIXField("65", EFieldOption.Optional)]
    public string SymbolSfx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(65).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(65, value);
      }
    }

    [FIXField("48", EFieldOption.Optional)]
    public string SecurityID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(48).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(48, value);
      }
    }

    [FIXField("22", EFieldOption.Optional)]
    public string SecurityIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(22).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(22, value);
      }
    }

    [FIXField("454", EFieldOption.Optional)]
    public int NoSecurityAltID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(454).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(454, value);
      }
    }

    [FIXField("460", EFieldOption.Optional)]
    public int Product
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(460).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(460, value);
      }
    }

    [FIXField("461", EFieldOption.Optional)]
    public string CFICode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(461).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(461, value);
      }
    }

    [FIXField("167", EFieldOption.Optional)]
    public string SecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(167).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(167, value);
      }
    }

    [FIXField("762", EFieldOption.Optional)]
    public string SecuritySubType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(762).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(762, value);
      }
    }

    [FIXField("200", EFieldOption.Optional)]
    public string MaturityMonthYear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(200).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(200, value);
      }
    }

    [FIXField("541", EFieldOption.Optional)]
    public DateTime MaturityDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(541).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(541, value);
      }
    }

    [FIXField("224", EFieldOption.Optional)]
    public DateTime CouponPaymentDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(224).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(224, value);
      }
    }

    [FIXField("225", EFieldOption.Optional)]
    public DateTime IssueDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(225).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(225, value);
      }
    }

    [FIXField("239", EFieldOption.Optional)]
    public int RepoCollateralSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(239).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(239, value);
      }
    }

    [FIXField("226", EFieldOption.Optional)]
    public int RepurchaseTerm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(226).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(226, value);
      }
    }

    [FIXField("227", EFieldOption.Optional)]
    public double RepurchaseRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(227).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(227, value);
      }
    }

    [FIXField("228", EFieldOption.Optional)]
    public double Factor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(228).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(228, value);
      }
    }

    [FIXField("255", EFieldOption.Optional)]
    public string CreditRating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField((int) byte.MaxValue).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField((int) byte.MaxValue, value);
      }
    }

    [FIXField("543", EFieldOption.Optional)]
    public string InstrRegistry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(543).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(543, value);
      }
    }

    [FIXField("470", EFieldOption.Optional)]
    public string CountryOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(470).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(470, value);
      }
    }

    [FIXField("471", EFieldOption.Optional)]
    public string StateOrProvinceOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(471).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(471, value);
      }
    }

    [FIXField("472", EFieldOption.Optional)]
    public string LocaleOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(472).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(472, value);
      }
    }

    [FIXField("240", EFieldOption.Optional)]
    public DateTime RedemptionDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(240).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(240, value);
      }
    }

    [FIXField("202", EFieldOption.Optional)]
    public double StrikePrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(202).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(202, value);
      }
    }

    [FIXField("947", EFieldOption.Optional)]
    public double StrikeCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(947).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(947, value);
      }
    }

    [FIXField("206", EFieldOption.Optional)]
    public char OptAttribute
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(206).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(206, value);
      }
    }

    [FIXField("231", EFieldOption.Optional)]
    public double ContractMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(231).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(231, value);
      }
    }

    [FIXField("223", EFieldOption.Optional)]
    public double CouponRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(223).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(223, value);
      }
    }

    [FIXField("207", EFieldOption.Optional)]
    public string SecurityExchange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(207).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(207, value);
      }
    }

    [FIXField("106", EFieldOption.Optional)]
    public string Issuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(106).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(106, value);
      }
    }

    [FIXField("348", EFieldOption.Optional)]
    public int EncodedIssuerLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(348).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(348, value);
      }
    }

    [FIXField("349", EFieldOption.Optional)]
    public string EncodedIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(349).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(349, value);
      }
    }

    [FIXField("107", EFieldOption.Optional)]
    public string SecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(107).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(107, value);
      }
    }

    [FIXField("350", EFieldOption.Optional)]
    public int EncodedSecurityDescLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(350).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(350, value);
      }
    }

    [FIXField("351", EFieldOption.Optional)]
    public string EncodedSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(351).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(351, value);
      }
    }

    [FIXField("691", EFieldOption.Optional)]
    public string Pool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(691).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(691, value);
      }
    }

    [FIXField("667", EFieldOption.Optional)]
    public string ContractSettlMonth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(667).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(667, value);
      }
    }

    [FIXField("875", EFieldOption.Optional)]
    public int CPProgram
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(875).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(875, value);
      }
    }

    [FIXField("876", EFieldOption.Optional)]
    public string CPRegType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(876).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(876, value);
      }
    }

    [FIXField("864", EFieldOption.Optional)]
    public int NoEvents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(864).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(864, value);
      }
    }

    [FIXField("873", EFieldOption.Optional)]
    public DateTime DatedDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(873).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(873, value);
      }
    }

    [FIXField("874", EFieldOption.Optional)]
    public DateTime InterestAccrualDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(874).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(874, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXStrikesGroup():base()
    {
      this.ovMtIkH9Mt = new ArrayList();
      this.uLmtHcBqaV = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
    {
      if (i < this.NoSecurityAltID)
        return (FIXSecurityAltIDGroup) this.ovMtIkH9Mt[i];
      else
        return (FIXSecurityAltIDGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXSecurityAltIDGroup group)
    {
      this.ovMtIkH9Mt.Add((object) group);
      ++this.NoSecurityAltID;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXEventsGroup GetEventsGroup(int i)
    {
      if (i < this.NoEvents)
        return (FIXEventsGroup) this.uLmtHcBqaV[i];
      else
        return (FIXEventsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXEventsGroup group)
    {
      this.uLmtHcBqaV.Add((object) group);
      ++this.NoEvents;
    }
  }
}
