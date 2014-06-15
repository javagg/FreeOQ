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
            get
            {
                return this.GetStringField(600).Value;
            }
            set
            {
                this.AddStringField(600, value);
            }
        }

        [FIXField("601", EFieldOption.Optional)]
        public string LegSymbolSfx
        {
            get
            {
                return this.GetStringField(601).Value;
            }
            set
            {
                this.AddStringField(601, value);
            }
        }

        [FIXField("602", EFieldOption.Optional)]
        public string LegSecurityID
        {
            get
            {
                return this.GetStringField(602).Value;
            }
            set
            {
                this.AddStringField(602, value);
            }
        }

        [FIXField("603", EFieldOption.Optional)]
        public string LegSecurityIDSource
        {
            get
            {
                return this.GetStringField(603).Value;
            }
            set
            {
                this.AddStringField(603, value);
            }
        }

        [FIXField("604", EFieldOption.Optional)]
        public int NoLegSecurityAltID
        {
            get
            {
                return this.GetIntField(604).Value;
            }
            set
            {
                this.AddIntField(604, value);
            }
        }

        [FIXField("607", EFieldOption.Optional)]
        public int LegProduct
        {
            get
            {
                return this.GetIntField(607).Value;
            }
            set
            {
                this.AddIntField(607, value);
            }
        }

        [FIXField("608", EFieldOption.Optional)]
        public string LegCFICode
        {
            get
            {
                return this.GetStringField(608).Value;
            }
            set
            {
                this.AddStringField(608, value);
            }
        }

        [FIXField("609", EFieldOption.Optional)]
        public string LegSecurityType
        {
            get
            {
                return this.GetStringField(609).Value;
            }
            set
            {
                this.AddStringField(609, value);
            }
        }

        [FIXField("764", EFieldOption.Optional)]
        public string LegSecuritySubType
        {
            get
            {
                return this.GetStringField(764).Value;
            }
            set
            {
                this.AddStringField(764, value);
            }
        }

        [FIXField("610", EFieldOption.Optional)]
        public string LegMaturityMonthYear
        {
            get
            {
                return this.GetStringField(610).Value;
            }
            set
            {
                this.AddStringField(610, value);
            }
        }

        [FIXField("611", EFieldOption.Optional)]
        public DateTime LegMaturityDate
        {
            get
            {
                return this.GetDateTimeField(611).Value;
            }
            set
            {
                this.AddDateTimeField(611, value);
            }
        }

        [FIXField("248", EFieldOption.Optional)]
        public DateTime LegCouponPaymentDate
        {
            get
            {
                return this.GetDateTimeField(248).Value;
            }
            set
            {
                this.AddDateTimeField(248, value);
            }
        }

        [FIXField("249", EFieldOption.Optional)]
        public DateTime LegIssueDate
        {
            get
            {
                return this.GetDateTimeField(249).Value;
            }
            set
            {
                this.AddDateTimeField(249, value);
            }
        }

        [FIXField("250", EFieldOption.Optional)]
        public int LegRepoCollateralSecurityType
        {
            get
            {
                return this.GetIntField(250).Value;
            }
            set
            {
                this.AddIntField(250, value);
            }
        }

        [FIXField("251", EFieldOption.Optional)]
        public int LegRepurchaseTerm
        {
            get
            {
                return this.GetIntField(251).Value;
            }
            set
            {
                this.AddIntField(251, value);
            }
        }

        [FIXField("252", EFieldOption.Optional)]
        public double LegRepurchaseRate
        {
            get
            {
                return this.GetDoubleField(252).Value;
            }
            set
            {
                this.AddDoubleField(252, value);
            }
        }

        [FIXField("253", EFieldOption.Optional)]
        public double LegFactor
        {
            get
            {
                return this.GetDoubleField(253).Value;
            }
            set
            {
                this.AddDoubleField(253, value);
            }
        }

        [FIXField("257", EFieldOption.Optional)]
        public string LegCreditRating
        {
            get
            {
                return this.GetStringField(257).Value;
            }
            set
            {
                this.AddStringField(257, value);
            }
        }

        [FIXField("599", EFieldOption.Optional)]
        public string LegInstrRegistry
        {
            get
            {
                return this.GetStringField(599).Value;
            }
            set
            {
                this.AddStringField(599, value);
            }
        }

        [FIXField("596", EFieldOption.Optional)]
        public string LegCountryOfIssue
        {
            get
            {
                return this.GetStringField(596).Value;
            }
            set
            {
                this.AddStringField(596, value);
            }
        }

        [FIXField("597", EFieldOption.Optional)]
        public string LegStateOrProvinceOfIssue
        {
            get
            {
                return this.GetStringField(597).Value;
            }
            set
            {
                this.AddStringField(597, value);
            }
        }

        [FIXField("598", EFieldOption.Optional)]
        public string LegLocaleOfIssue
        {
            get
            {
                return this.GetStringField(598).Value;
            }
            set
            {
                this.AddStringField(598, value);
            }
        }

        [FIXField("254", EFieldOption.Optional)]
        public DateTime LegRedemptionDate
        {
            get
            {
                return this.GetDateTimeField(254).Value;
            }
            set
            {
                this.AddDateTimeField(254, value);
            }
        }

        [FIXField("612", EFieldOption.Optional)]
        public double LegStrikePrice
        {
            get
            {
                return this.GetDoubleField(612).Value;
            }
            set
            {
                this.AddDoubleField(612, value);
            }
        }

        [FIXField("942", EFieldOption.Optional)]
        public double LegStrikeCurrency
        {
            get
            {
                return this.GetDoubleField(942).Value;
            }
            set
            {
                this.AddDoubleField(942, value);
            }
        }

        [FIXField("613", EFieldOption.Optional)]
        public char LegOptAttribute
        {
            get
            {
                return this.GetCharField(613).Value;
            }
            set
            {
                this.AddCharField(613, value);
            }
        }

        [FIXField("614", EFieldOption.Optional)]
        public double LegContractMultiplier
        {
            get
            {
                return this.GetDoubleField(614).Value;
            }
            set
            {
                this.AddDoubleField(614, value);
            }
        }

        [FIXField("615", EFieldOption.Optional)]
        public double LegCouponRate
        {
            get
            {
                return this.GetDoubleField(615).Value;
            }
            set
            {
                this.AddDoubleField(615, value);
            }
        }

        [FIXField("616", EFieldOption.Optional)]
        public string LegSecurityExchange
        {
            get
            {
                return this.GetStringField(616).Value;
            }
            set
            {
                this.AddStringField(616, value);
            }
        }

        [FIXField("617", EFieldOption.Optional)]
        public string LegIssuer
        {
            get
            {
                return this.GetStringField(617).Value;
            }
            set
            {
                this.AddStringField(617, value);
            }
        }

        [FIXField("618", EFieldOption.Optional)]
        public int EncodedLegIssuerLen
        {
            get
            {
                return this.GetIntField(618).Value;
            }
            set
            {
                this.AddIntField(618, value);
            }
        }

        [FIXField("619", EFieldOption.Optional)]
        public string EncodedLegIssuer
        {
            get
            {
                return this.GetStringField(619).Value;
            }
            set
            {
                this.AddStringField(619, value);
            }
        }

        [FIXField("620", EFieldOption.Optional)]
        public string LegSecurityDesc
        {
            get
            {
                return this.GetStringField(620).Value;
            }
            set
            {
                this.AddStringField(620, value);
            }
        }

        [FIXField("621", EFieldOption.Optional)]
        public int EncodedLegSecurityDescLen
        {
            get
            {
                return this.GetIntField(621).Value;
            }
            set
            {
                this.AddIntField(621, value);
            }
        }

        [FIXField("622", EFieldOption.Optional)]
        public string EncodedLegSecurityDesc
        {
            get
            {
                return this.GetStringField(622).Value;
            }
            set
            {
                this.AddStringField(622, value);
            }
        }

        [FIXField("623", EFieldOption.Optional)]
        public double LegRatioQty
        {
            get
            {
                return this.GetDoubleField(623).Value;
            }
            set
            {
                this.AddDoubleField(623, value);
            }
        }

        [FIXField("624", EFieldOption.Optional)]
        public char LegSide
        {
            get
            {
                return this.GetCharField(624).Value;
            }
            set
            {
                this.AddCharField(624, value);
            }
        }

        [FIXField("556", EFieldOption.Optional)]
        public double LegCurrency
        {
            get
            {
                return this.GetDoubleField(556).Value;
            }
            set
            {
                this.AddDoubleField(556, value);
            }
        }

        [FIXField("740", EFieldOption.Optional)]
        public string LegPool
        {
            get
            {
                return this.GetStringField(740).Value;
            }
            set
            {
                this.AddStringField(740, value);
            }
        }

        [FIXField("739", EFieldOption.Optional)]
        public DateTime LegDatedDate
        {
            get
            {
                return this.GetDateTimeField(739).Value;
            }
            set
            {
                this.AddDateTimeField(739, value);
            }
        }

        [FIXField("955", EFieldOption.Optional)]
        public string LegContractSettlMonth
        {
            get
            {
                return this.GetStringField(955).Value;
            }
            set
            {
                this.AddStringField(955, value);
            }
        }

        [FIXField("956", EFieldOption.Optional)]
        public DateTime LegInterestAccrualDate
        {
            get
            {
                return this.GetDateTimeField(956).Value;
            }
            set
            {
                this.AddDateTimeField(956, value);
            }
        }

        public FIXInstrumentLeg() : base()
        {
            this.KFDYFq9ju9 = new ArrayList();
        }

        public FIXLegSecurityAltIDGroup GetLegSecurityAltIDGroup(int i)
        {
            if (i < this.NoLegSecurityAltID)
                return (FIXLegSecurityAltIDGroup)this.KFDYFq9ju9[i];
            else
                return (FIXLegSecurityAltIDGroup)null;
        }

        public void AddGroup(FIXLegSecurityAltIDGroup group)
        {
            this.KFDYFq9ju9.Add(group);
            ++this.NoLegSecurityAltID;
        }
    }
}
