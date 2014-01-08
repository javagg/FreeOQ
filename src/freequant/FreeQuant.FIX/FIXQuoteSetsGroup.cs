using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXQuoteSetsGroup : FIXGroup
  {
    private ArrayList sWMy6Q8LX7;
    private ArrayList Ql0yqqBwS0;

    [FIXField("302", EFieldOption.Optional)]
    public string QuoteSetID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(302).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(302, value);
      }
    }

    [FIXField("311", EFieldOption.Optional)]
    public string UnderlyingSymbol
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(311).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(311, value);
      }
    }

    [FIXField("312", EFieldOption.Optional)]
    public string UnderlyingSymbolSfx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(312).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(312, value);
      }
    }

    [FIXField("309", EFieldOption.Optional)]
    public string UnderlyingSecurityID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(309).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(309, value);
      }
    }

    [FIXField("305", EFieldOption.Optional)]
    public string UnderlyingSecurityIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(305).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(305, value);
      }
    }

    [FIXField("457", EFieldOption.Optional)]
    public int NoUnderlyingSecurityAltID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(457).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(457, value);
      }
    }

    [FIXField("462", EFieldOption.Optional)]
    public int UnderlyingProduct
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(462).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(462, value);
      }
    }

    [FIXField("463", EFieldOption.Optional)]
    public string UnderlyingCFICode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(463).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(463, value);
      }
    }

    [FIXField("310", EFieldOption.Optional)]
    public string UnderlyingSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(310).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(310, value);
      }
    }

    [FIXField("763", EFieldOption.Optional)]
    public string UnderlyingSecuritySubType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(763).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(763, value);
      }
    }

    [FIXField("313", EFieldOption.Optional)]
    public string UnderlyingMaturityMonthYear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(313).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(313, value);
      }
    }

    [FIXField("542", EFieldOption.Optional)]
    public DateTime UnderlyingMaturityDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(542).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(542, value);
      }
    }

    [FIXField("241", EFieldOption.Optional)]
    public DateTime UnderlyingCouponPaymentDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(241).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(241, value);
      }
    }

    [FIXField("242", EFieldOption.Optional)]
    public DateTime UnderlyingIssueDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(242).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(242, value);
      }
    }

    [FIXField("243", EFieldOption.Optional)]
    public int UnderlyingRepoCollateralSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(243).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(243, value);
      }
    }

    [FIXField("244", EFieldOption.Optional)]
    public int UnderlyingRepurchaseTerm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(244).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(244, value);
      }
    }

    [FIXField("245", EFieldOption.Optional)]
    public double UnderlyingRepurchaseRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(245).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(245, value);
      }
    }

    [FIXField("246", EFieldOption.Optional)]
    public double UnderlyingFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(246).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(246, value);
      }
    }

    [FIXField("256", EFieldOption.Optional)]
    public string UnderlyingCreditRating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(256).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(256, value);
      }
    }

    [FIXField("595", EFieldOption.Optional)]
    public string UnderlyingInstrRegistry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(595).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(595, value);
      }
    }

    [FIXField("592", EFieldOption.Optional)]
    public string UnderlyingCountryOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(592).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(592, value);
      }
    }

    [FIXField("593", EFieldOption.Optional)]
    public string UnderlyingStateOrProvinceOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(593).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(593, value);
      }
    }

    [FIXField("594", EFieldOption.Optional)]
    public string UnderlyingLocaleOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(594).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(594, value);
      }
    }

    [FIXField("247", EFieldOption.Optional)]
    public DateTime UnderlyingRedemptionDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(247).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(247, value);
      }
    }

    [FIXField("316", EFieldOption.Optional)]
    public double UnderlyingStrikePrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(316).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(316, value);
      }
    }

    [FIXField("941", EFieldOption.Optional)]
    public double UnderlyingStrikeCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(941).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(941, value);
      }
    }

    [FIXField("317", EFieldOption.Optional)]
    public char UnderlyingOptAttribute
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(317).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(317, value);
      }
    }

    [FIXField("436", EFieldOption.Optional)]
    public double UnderlyingContractMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(436).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(436, value);
      }
    }

    [FIXField("435", EFieldOption.Optional)]
    public double UnderlyingCouponRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(435).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(435, value);
      }
    }

    [FIXField("308", EFieldOption.Optional)]
    public string UnderlyingSecurityExchange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(308).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(308, value);
      }
    }

    [FIXField("306", EFieldOption.Optional)]
    public string UnderlyingIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(306).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(306, value);
      }
    }

    [FIXField("362", EFieldOption.Optional)]
    public int EncodedUnderlyingIssuerLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(362).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(362, value);
      }
    }

    [FIXField("363", EFieldOption.Optional)]
    public string EncodedUnderlyingIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(363).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(363, value);
      }
    }

    [FIXField("307", EFieldOption.Optional)]
    public string UnderlyingSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(307).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(307, value);
      }
    }

    [FIXField("364", EFieldOption.Optional)]
    public int EncodedUnderlyingSecurityDescLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(364).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(364, value);
      }
    }

    [FIXField("365", EFieldOption.Optional)]
    public string EncodedUnderlyingSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(365).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(365, value);
      }
    }

    [FIXField("877", EFieldOption.Optional)]
    public string UnderlyingCPProgram
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(877).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(877, value);
      }
    }

    [FIXField("878", EFieldOption.Optional)]
    public string UnderlyingCPRegType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(878).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(878, value);
      }
    }

    [FIXField("318", EFieldOption.Optional)]
    public double UnderlyingCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(318).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(318, value);
      }
    }

    [FIXField("879", EFieldOption.Optional)]
    public double UnderlyingQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(879).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(879, value);
      }
    }

    [FIXField("810", EFieldOption.Optional)]
    public double UnderlyingPx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(810).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(810, value);
      }
    }

    [FIXField("882", EFieldOption.Optional)]
    public double UnderlyingDirtyPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(882).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(882, value);
      }
    }

    [FIXField("883", EFieldOption.Optional)]
    public double UnderlyingEndPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(883).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(883, value);
      }
    }

    [FIXField("884", EFieldOption.Optional)]
    public double UnderlyingStartValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(884).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(884, value);
      }
    }

    [FIXField("885", EFieldOption.Optional)]
    public double UnderlyingCurrentValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(885).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(885, value);
      }
    }

    [FIXField("886", EFieldOption.Optional)]
    public double UnderlyingEndValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(886).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(886, value);
      }
    }

    [FIXField("887", EFieldOption.Optional)]
    public int NoUnderlyingStips
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(887).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(887, value);
      }
    }

    [FIXField("304", EFieldOption.Optional)]
    public int TotNoQuoteEntries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(304).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(304, value);
      }
    }

    [FIXField("893", EFieldOption.Optional)]
    public bool LastFragment
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBoolField(893).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddBoolField(893, value);
      }
    }

    [FIXField("295", EFieldOption.Optional)]
    public int NoQuoteEntries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(295).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(295, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXQuoteSetsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.sWMy6Q8LX7 = new ArrayList();
      this.Ql0yqqBwS0 = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingSecurityAltIDGroup GetUnderlyingSecurityAltIDGroup(int i)
    {
      if (i < this.NoUnderlyingSecurityAltID)
        return (FIXUnderlyingSecurityAltIDGroup) this.sWMy6Q8LX7[i];
      else
        return (FIXUnderlyingSecurityAltIDGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXUnderlyingSecurityAltIDGroup group)
    {
      this.sWMy6Q8LX7.Add((object) group);
      ++this.NoUnderlyingSecurityAltID;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
    {
      if (i < this.NoUnderlyingStips)
        return (FIXUnderlyingStipsGroup) this.Ql0yqqBwS0[i];
      else
        return (FIXUnderlyingStipsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXUnderlyingStipsGroup group)
    {
      this.Ql0yqqBwS0.Add((object) group);
      ++this.NoUnderlyingStips;
    }
  }
}
