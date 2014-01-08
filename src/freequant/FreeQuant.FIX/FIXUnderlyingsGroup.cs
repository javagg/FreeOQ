using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXUnderlyingsGroup : FIXGroup
  {
    private ArrayList jGPucy4iiH;
    private ArrayList hEjuzYXQZJ;

    [FIXField("311", EFieldOption.Optional)]
    public string UnderlyingSymbol
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(311);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(311, value);
      }
    }

    [FIXField("312", EFieldOption.Optional)]
    public string UnderlyingSymbolSfx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(312);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(312, value);
      }
    }

    [FIXField("309", EFieldOption.Optional)]
    public string UnderlyingSecurityID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(309);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(309, value);
      }
    }

    [FIXField("305", EFieldOption.Optional)]
    public string UnderlyingSecurityIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(305);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(305, value);
      }
    }

    [FIXField("457", EFieldOption.Optional)]
    public int NoUnderlyingSecurityAltID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(457);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(457, value);
      }
    }

    [FIXField("462", EFieldOption.Optional)]
    public int UnderlyingProduct
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(462);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(462, value);
      }
    }

    [FIXField("463", EFieldOption.Optional)]
    public string UnderlyingCFICode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(463);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(463, value);
      }
    }

    [FIXField("310", EFieldOption.Optional)]
    public string UnderlyingSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(310);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(310, value);
      }
    }

    [FIXField("763", EFieldOption.Optional)]
    public string UnderlyingSecuritySubType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(763);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(763, value);
      }
    }

    [FIXField("313", EFieldOption.Optional)]
    public string UnderlyingMaturityMonthYear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(313);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(313, value);
      }
    }

    [FIXField("542", EFieldOption.Optional)]
    public DateTime UnderlyingMaturityDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(542);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(542, value);
      }
    }

    [FIXField("241", EFieldOption.Optional)]
    public DateTime UnderlyingCouponPaymentDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(241);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(241, value);
      }
    }

    [FIXField("242", EFieldOption.Optional)]
    public DateTime UnderlyingIssueDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(242);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(242, value);
      }
    }

    [FIXField("243", EFieldOption.Optional)]
    public int UnderlyingRepoCollateralSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(243);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(243, value);
      }
    }

    [FIXField("244", EFieldOption.Optional)]
    public int UnderlyingRepurchaseTerm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(244);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(244, value);
      }
    }

    [FIXField("245", EFieldOption.Optional)]
    public double UnderlyingRepurchaseRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(245);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(245, value);
      }
    }

    [FIXField("246", EFieldOption.Optional)]
    public double UnderlyingFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(246);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(246, value);
      }
    }

    [FIXField("256", EFieldOption.Optional)]
    public string UnderlyingCreditRating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(256);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(256, value);
      }
    }

    [FIXField("595", EFieldOption.Optional)]
    public string UnderlyingInstrRegistry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(595);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(595, value);
      }
    }

    [FIXField("592", EFieldOption.Optional)]
    public string UnderlyingCountryOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(592);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(592, value);
      }
    }

    [FIXField("593", EFieldOption.Optional)]
    public string UnderlyingStateOrProvinceOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(593);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(593, value);
      }
    }

    [FIXField("594", EFieldOption.Optional)]
    public string UnderlyingLocaleOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(594);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(594, value);
      }
    }

    [FIXField("247", EFieldOption.Optional)]
    public DateTime UnderlyingRedemptionDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(247);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(247, value);
      }
    }

    [FIXField("316", EFieldOption.Optional)]
    public double UnderlyingStrikePrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(316);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(316, value);
      }
    }

    [FIXField("941", EFieldOption.Optional)]
    public double UnderlyingStrikeCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(941);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(941, value);
      }
    }

    [FIXField("317", EFieldOption.Optional)]
    public char UnderlyingOptAttribute
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(317);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(317, value);
      }
    }

    [FIXField("436", EFieldOption.Optional)]
    public double UnderlyingContractMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(436);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(436, value);
      }
    }

    [FIXField("435", EFieldOption.Optional)]
    public double UnderlyingCouponRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(435);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(435, value);
      }
    }

    [FIXField("308", EFieldOption.Optional)]
    public string UnderlyingSecurityExchange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(308);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(308, value);
      }
    }

    [FIXField("306", EFieldOption.Optional)]
    public string UnderlyingIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(306);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(306, value);
      }
    }

    [FIXField("362", EFieldOption.Optional)]
    public int EncodedUnderlyingIssuerLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(362);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(362, value);
      }
    }

    [FIXField("363", EFieldOption.Optional)]
    public string EncodedUnderlyingIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(363);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(363, value);
      }
    }

    [FIXField("307", EFieldOption.Optional)]
    public string UnderlyingSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(307);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(307, value);
      }
    }

    [FIXField("364", EFieldOption.Optional)]
    public int EncodedUnderlyingSecurityDescLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(364);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(364, value);
      }
    }

    [FIXField("365", EFieldOption.Optional)]
    public string EncodedUnderlyingSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(365);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(365, value);
      }
    }

    [FIXField("877", EFieldOption.Optional)]
    public string UnderlyingCPProgram
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(877);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(877, value);
      }
    }

    [FIXField("878", EFieldOption.Optional)]
    public string UnderlyingCPRegType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(878);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(878, value);
      }
    }

    [FIXField("318", EFieldOption.Optional)]
    public double UnderlyingCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(318);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(318, value);
      }
    }

    [FIXField("879", EFieldOption.Optional)]
    public double UnderlyingQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(879);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(879, value);
      }
    }

    [FIXField("810", EFieldOption.Optional)]
    public double UnderlyingPx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(810);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(810, value);
      }
    }

    [FIXField("882", EFieldOption.Optional)]
    public double UnderlyingDirtyPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(882);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(882, value);
      }
    }

    [FIXField("883", EFieldOption.Optional)]
    public double UnderlyingEndPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(883);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(883, value);
      }
    }

    [FIXField("884", EFieldOption.Optional)]
    public double UnderlyingStartValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(884);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(884, value);
      }
    }

    [FIXField("885", EFieldOption.Optional)]
    public double UnderlyingCurrentValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(885);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(885, value);
      }
    }

    [FIXField("886", EFieldOption.Optional)]
    public double UnderlyingEndValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(886);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(886, value);
      }
    }

    [FIXField("887", EFieldOption.Optional)]
    public int NoUnderlyingStips
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(887);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(887, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.jGPucy4iiH = new ArrayList();
      this.hEjuzYXQZJ = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingSecurityAltIDGroup GetUnderlyingSecurityAltIDGroup(int i)
    {
      if (i < this.NoUnderlyingSecurityAltID)
        return (FIXUnderlyingSecurityAltIDGroup) this.jGPucy4iiH[i];
      else
        return (FIXUnderlyingSecurityAltIDGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXUnderlyingSecurityAltIDGroup group)
    {
      this.jGPucy4iiH.Add((object) group);
      ++this.NoUnderlyingSecurityAltID;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
    {
      if (i < this.NoUnderlyingStips)
        return (FIXUnderlyingStipsGroup) this.hEjuzYXQZJ[i];
      else
        return (FIXUnderlyingStipsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXUnderlyingStipsGroup group)
    {
      this.hEjuzYXQZJ.Add((object) group);
      ++this.NoUnderlyingStips;
    }
  }
}
