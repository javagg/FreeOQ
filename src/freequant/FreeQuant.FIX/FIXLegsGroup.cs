// Type: SmartQuant.FIX.FIXLegsGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXLegsGroup : FIXGroup
  {
    private ArrayList d0N7lcYTFP;

    [FIXField("600", EFieldOption.Optional)]
    public string LegSymbol
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(600);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(600, value);
      }
    }

    [FIXField("601", EFieldOption.Optional)]
    public string LegSymbolSfx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(601);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(601, value);
      }
    }

    [FIXField("602", EFieldOption.Optional)]
    public string LegSecurityID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(602);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(602, value);
      }
    }

    [FIXField("603", EFieldOption.Optional)]
    public string LegSecurityIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(603);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(603, value);
      }
    }

    [FIXField("604", EFieldOption.Optional)]
    public int NoLegSecurityAltID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(604);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(604, value);
      }
    }

    [FIXField("607", EFieldOption.Optional)]
    public int LegProduct
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(607);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(607, value);
      }
    }

    [FIXField("608", EFieldOption.Optional)]
    public string LegCFICode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(608);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(608, value);
      }
    }

    [FIXField("609", EFieldOption.Optional)]
    public string LegSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(609);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(609, value);
      }
    }

    [FIXField("764", EFieldOption.Optional)]
    public string LegSecuritySubType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(764);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(764, value);
      }
    }

    [FIXField("610", EFieldOption.Optional)]
    public string LegMaturityMonthYear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(610);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(610, value);
      }
    }

    [FIXField("611", EFieldOption.Optional)]
    public DateTime LegMaturityDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(611);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(611, value);
      }
    }

    [FIXField("248", EFieldOption.Optional)]
    public DateTime LegCouponPaymentDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(248);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(248, value);
      }
    }

    [FIXField("249", EFieldOption.Optional)]
    public DateTime LegIssueDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(249);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(249, value);
      }
    }

    [FIXField("250", EFieldOption.Optional)]
    public int LegRepoCollateralSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(250);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(250, value);
      }
    }

    [FIXField("251", EFieldOption.Optional)]
    public int LegRepurchaseTerm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(251);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(251, value);
      }
    }

    [FIXField("252", EFieldOption.Optional)]
    public double LegRepurchaseRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(252);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(252, value);
      }
    }

    [FIXField("253", EFieldOption.Optional)]
    public double LegFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(253);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(253, value);
      }
    }

    [FIXField("257", EFieldOption.Optional)]
    public string LegCreditRating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(257);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(257, value);
      }
    }

    [FIXField("599", EFieldOption.Optional)]
    public string LegInstrRegistry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(599);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(599, value);
      }
    }

    [FIXField("596", EFieldOption.Optional)]
    public string LegCountryOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(596);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(596, value);
      }
    }

    [FIXField("597", EFieldOption.Optional)]
    public string LegStateOrProvinceOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(597);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(597, value);
      }
    }

    [FIXField("598", EFieldOption.Optional)]
    public string LegLocaleOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(598);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(598, value);
      }
    }

    [FIXField("254", EFieldOption.Optional)]
    public DateTime LegRedemptionDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(254);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(254, value);
      }
    }

    [FIXField("612", EFieldOption.Optional)]
    public double LegStrikePrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(612);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(612, value);
      }
    }

    [FIXField("942", EFieldOption.Optional)]
    public double LegStrikeCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(942);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(942, value);
      }
    }

    [FIXField("613", EFieldOption.Optional)]
    public char LegOptAttribute
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(613);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(613, value);
      }
    }

    [FIXField("614", EFieldOption.Optional)]
    public double LegContractMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(614);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(614, value);
      }
    }

    [FIXField("615", EFieldOption.Optional)]
    public double LegCouponRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(615);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(615, value);
      }
    }

    [FIXField("616", EFieldOption.Optional)]
    public string LegSecurityExchange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(616);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(616, value);
      }
    }

    [FIXField("617", EFieldOption.Optional)]
    public string LegIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(617);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(617, value);
      }
    }

    [FIXField("618", EFieldOption.Optional)]
    public int EncodedLegIssuerLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(618);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(618, value);
      }
    }

    [FIXField("619", EFieldOption.Optional)]
    public string EncodedLegIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(619);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(619, value);
      }
    }

    [FIXField("620", EFieldOption.Optional)]
    public string LegSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(620);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(620, value);
      }
    }

    [FIXField("621", EFieldOption.Optional)]
    public int EncodedLegSecurityDescLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(621);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(621, value);
      }
    }

    [FIXField("622", EFieldOption.Optional)]
    public string EncodedLegSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(622);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(622, value);
      }
    }

    [FIXField("623", EFieldOption.Optional)]
    public double LegRatioQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(623);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(623, value);
      }
    }

    [FIXField("624", EFieldOption.Optional)]
    public char LegSide
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(624);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(624, value);
      }
    }

    [FIXField("556", EFieldOption.Optional)]
    public double LegCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(556);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(556, value);
      }
    }

    [FIXField("740", EFieldOption.Optional)]
    public string LegPool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(740);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(740, value);
      }
    }

    [FIXField("739", EFieldOption.Optional)]
    public DateTime LegDatedDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(739);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(739, value);
      }
    }

    [FIXField("955", EFieldOption.Optional)]
    public string LegContractSettlMonth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(955);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(955, value);
      }
    }

    [FIXField("956", EFieldOption.Optional)]
    public DateTime LegInterestAccrualDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue(956);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDateTimeValue(956, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXLegsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.d0N7lcYTFP = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXLegSecurityAltIDGroup GetLegSecurityAltIDGroup(int i)
    {
      if (i < this.NoLegSecurityAltID)
        return (FIXLegSecurityAltIDGroup) this.d0N7lcYTFP[i];
      else
        return (FIXLegSecurityAltIDGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXLegSecurityAltIDGroup group)
    {
      this.d0N7lcYTFP.Add((object) group);
      ++this.NoLegSecurityAltID;
    }
  }
}
