using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXInstrumentLeg : FIXMessage
  {
    private ArrayList KFDYFq9ju9;

    [FIXField("600", EFieldOption.Optional)]
    public string LegSymbol
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(600).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(600, value);
      }
    }

    [FIXField("601", EFieldOption.Optional)]
    public string LegSymbolSfx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(601).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(601, value);
      }
    }

    [FIXField("602", EFieldOption.Optional)]
    public string LegSecurityID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(602).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(602, value);
      }
    }

    [FIXField("603", EFieldOption.Optional)]
    public string LegSecurityIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(603).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(603, value);
      }
    }

    [FIXField("604", EFieldOption.Optional)]
    public int NoLegSecurityAltID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(604).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(604, value);
      }
    }

    [FIXField("607", EFieldOption.Optional)]
    public int LegProduct
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(607).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(607, value);
      }
    }

    [FIXField("608", EFieldOption.Optional)]
    public string LegCFICode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(608).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(608, value);
      }
    }

    [FIXField("609", EFieldOption.Optional)]
    public string LegSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(609).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(609, value);
      }
    }

    [FIXField("764", EFieldOption.Optional)]
    public string LegSecuritySubType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(764).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(764, value);
      }
    }

    [FIXField("610", EFieldOption.Optional)]
    public string LegMaturityMonthYear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(610).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(610, value);
      }
    }

    [FIXField("611", EFieldOption.Optional)]
    public DateTime LegMaturityDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(611).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(611, value);
      }
    }

    [FIXField("248", EFieldOption.Optional)]
    public DateTime LegCouponPaymentDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(248).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(248, value);
      }
    }

    [FIXField("249", EFieldOption.Optional)]
    public DateTime LegIssueDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(249).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(249, value);
      }
    }

    [FIXField("250", EFieldOption.Optional)]
    public int LegRepoCollateralSecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(250).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(250, value);
      }
    }

    [FIXField("251", EFieldOption.Optional)]
    public int LegRepurchaseTerm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(251).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(251, value);
      }
    }

    [FIXField("252", EFieldOption.Optional)]
    public double LegRepurchaseRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(252).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(252, value);
      }
    }

    [FIXField("253", EFieldOption.Optional)]
    public double LegFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(253).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(253, value);
      }
    }

    [FIXField("257", EFieldOption.Optional)]
    public string LegCreditRating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(257).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(257, value);
      }
    }

    [FIXField("599", EFieldOption.Optional)]
    public string LegInstrRegistry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(599).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(599, value);
      }
    }

    [FIXField("596", EFieldOption.Optional)]
    public string LegCountryOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(596).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(596, value);
      }
    }

    [FIXField("597", EFieldOption.Optional)]
    public string LegStateOrProvinceOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(597).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(597, value);
      }
    }

    [FIXField("598", EFieldOption.Optional)]
    public string LegLocaleOfIssue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(598).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(598, value);
      }
    }

    [FIXField("254", EFieldOption.Optional)]
    public DateTime LegRedemptionDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(254).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(254, value);
      }
    }

    [FIXField("612", EFieldOption.Optional)]
    public double LegStrikePrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(612).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(612, value);
      }
    }

    [FIXField("942", EFieldOption.Optional)]
    public double LegStrikeCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(942).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(942, value);
      }
    }

    [FIXField("613", EFieldOption.Optional)]
    public char LegOptAttribute
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(613).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(613, value);
      }
    }

    [FIXField("614", EFieldOption.Optional)]
    public double LegContractMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(614).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(614, value);
      }
    }

    [FIXField("615", EFieldOption.Optional)]
    public double LegCouponRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(615).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(615, value);
      }
    }

    [FIXField("616", EFieldOption.Optional)]
    public string LegSecurityExchange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(616).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(616, value);
      }
    }

    [FIXField("617", EFieldOption.Optional)]
    public string LegIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(617).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(617, value);
      }
    }

    [FIXField("618", EFieldOption.Optional)]
    public int EncodedLegIssuerLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(618).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(618, value);
      }
    }

    [FIXField("619", EFieldOption.Optional)]
    public string EncodedLegIssuer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(619).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(619, value);
      }
    }

    [FIXField("620", EFieldOption.Optional)]
    public string LegSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(620).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(620, value);
      }
    }

    [FIXField("621", EFieldOption.Optional)]
    public int EncodedLegSecurityDescLen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(621).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(621, value);
      }
    }

    [FIXField("622", EFieldOption.Optional)]
    public string EncodedLegSecurityDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(622).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(622, value);
      }
    }

    [FIXField("623", EFieldOption.Optional)]
    public double LegRatioQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(623).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(623, value);
      }
    }

    [FIXField("624", EFieldOption.Optional)]
    public char LegSide
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(624).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(624, value);
      }
    }

    [FIXField("556", EFieldOption.Optional)]
    public double LegCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(556).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(556, value);
      }
    }

    [FIXField("740", EFieldOption.Optional)]
    public string LegPool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(740).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(740, value);
      }
    }

    [FIXField("739", EFieldOption.Optional)]
    public DateTime LegDatedDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(739).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(739, value);
      }
    }

    [FIXField("955", EFieldOption.Optional)]
    public string LegContractSettlMonth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(955).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(955, value);
      }
    }

    [FIXField("956", EFieldOption.Optional)]
    public DateTime LegInterestAccrualDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(956).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(956, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXInstrumentLeg()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.KFDYFq9ju9 = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXLegSecurityAltIDGroup GetLegSecurityAltIDGroup(int i)
    {
      if (i < this.NoLegSecurityAltID)
        return (FIXLegSecurityAltIDGroup) this.KFDYFq9ju9[i];
      else
        return (FIXLegSecurityAltIDGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXLegSecurityAltIDGroup group)
    {
      this.KFDYFq9ju9.Add((object) group);
      ++this.NoLegSecurityAltID;
    }
  }
}
