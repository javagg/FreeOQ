using System;
using System.Collections;

namespace FreeQuant.FIX
{
	public class FIXTradeCaptureReport : FIXMessage
	{
		private ArrayList f7ZAC6g4DL;
		private ArrayList CTDA21AVEd;
		private ArrayList wCLAcaZ2RA;
		private ArrayList hwZAzM4ODk;
		private ArrayList kel8SHGHm3;
		private ArrayList VL78UVrp9E;
		private ArrayList TYQ8ARIL1M;
		private ArrayList OQ788ftQSH;
		private ArrayList zgq8ZloVJX;

		[FIXField("144", EFieldOption.Optional)]
		public string OnBehalfOfLocationID
		{
			get
			{
				return this.GetStringField(144).Value;
			}
			set
			{
				this.AddStringField(144, value);
			}
		}

		[FIXField("9", EFieldOption.Required)]
		public int BodyLength
		{
			get
			{
				return this.GetIntField(9).Value;
			}
			set
			{
				this.AddIntField(9, value);
			}
		}

		[FIXField("35", EFieldOption.Required)]
		public string MsgType
		{
			get
			{
				return this.GetStringField(35).Value;
			}
			set
			{
				this.AddStringField(35, value);
			}
		}

		[FIXField("49", EFieldOption.Required)]
		public string SenderCompID
		{
			get
			{
				return this.GetStringField(49).Value;
			}
			set
			{
				this.AddStringField(49, value);
			}
		}

		[FIXField("56", EFieldOption.Required)]
		public string TargetCompID
		{
			get
			{
				return this.GetStringField(56).Value;
			}
			set
			{
				this.AddStringField(56, value);
			}
		}

		[FIXField("115", EFieldOption.Optional)]
		public string OnBehalfOfCompID
		{
			get
			{
				return this.GetStringField(115).Value;
			}
			set
			{
				this.AddStringField(115, value);
			}
		}

		[FIXField("128", EFieldOption.Optional)]
		public string DeliverToCompID
		{
			get
			{
				return this.GetStringField(128).Value;
			}
			set
			{
				this.AddStringField(128, value);
			}
		}

		[FIXField("90", EFieldOption.Optional)]
		public int SecureDataLen
		{
			get
			{
				return this.GetIntField(90).Value;
			}
			set
			{
				this.AddIntField(90, value);
			}
		}

		[FIXField("91", EFieldOption.Optional)]
		public string SecureData
		{
			get
			{
				return this.GetStringField(91).Value;
			}
			set
			{
				this.AddStringField(91, value);
			}
		}

		[FIXField("34", EFieldOption.Required)]
		public int MsgSeqNum
		{
			get
			{
				return this.GetIntField(34).Value;
			}
			set
			{
				this.AddIntField(34, value);
			}
		}

		[FIXField("50", EFieldOption.Optional)]
		public string SenderSubID
		{
			get
			{
				return this.GetStringField(50).Value;
			}
			set
			{
				this.AddStringField(50, value);
			}
		}

		[FIXField("142", EFieldOption.Optional)]
		public string SenderLocationID
		{
			get
			{
				return this.GetStringField(142).Value;
			}
			set
			{
				this.AddStringField(142, value);
			}
		}

		[FIXField("57", EFieldOption.Optional)]
		public string TargetSubID
		{
			get
			{
				return this.GetStringField(57).Value;
			}
			set
			{
				this.AddStringField(57, value);
			}
		}

		[FIXField("8", EFieldOption.Required)]
		public string BeginString
		{
			get
			{
				return this.GetStringField(8).Value;
			}
			set
			{
				this.AddStringField(8, value);
			}
		}

		[FIXField("116", EFieldOption.Optional)]
		public string OnBehalfOfSubID
		{
			get
			{
				return this.GetStringField(116).Value;
			}
			set
			{
				this.AddStringField(116, value);
			}
		}

		[FIXField("129", EFieldOption.Optional)]
		public string DeliverToSubID
		{
			get
			{
				return this.GetStringField(129).Value;
			}
			set
			{
				this.AddStringField(129, value);
			}
		}

		[FIXField("145", EFieldOption.Optional)]
		public string DeliverToLocationID
		{
			get
			{
				return this.GetStringField(145).Value;
			}
			set
			{
				this.AddStringField(145, value);
			}
		}

		[FIXField("43", EFieldOption.Optional)]
		public bool PossDupFlag
		{
			get
			{
				return this.GetBoolField(43).Value;
			}
			set
			{
				this.AddBoolField(43, value);
			}
		}

		[FIXField("97", EFieldOption.Optional)]
		public bool PossResend
		{
			get
			{
				return this.GetBoolField(97).Value;
			}
			set
			{
				this.AddBoolField(97, value);
			}
		}

		[FIXField("52", EFieldOption.Optional)]
		public DateTime SendingTime
		{
			get
			{
				return this.GetDateTimeField(52).Value;
			}
			set
			{
				this.AddDateTimeField(52, value);
			}
		}

		[FIXField("122", EFieldOption.Optional)]
		public DateTime OrigSendingTime
		{
			get
			{
				return this.GetDateTimeField(122).Value;
			}
			set
			{
				this.AddDateTimeField(122, value);
			}
		}

		[FIXField("212", EFieldOption.Optional)]
		public int XmlDataLen
		{
			get
			{
				return this.GetIntField(212).Value;
			}
			set
			{
				this.AddIntField(212, value);
			}
		}

		[FIXField("213", EFieldOption.Optional)]
		public string XmlData
		{
			get
			{
				return this.GetStringField(213).Value;
			}
			set
			{
				this.AddStringField(213, value);
			}
		}

		[FIXField("347", EFieldOption.Optional)]
		public string MessageEncoding
		{
			get
			{
				return this.GetStringField(347).Value;
			}
			set
			{
				this.AddStringField(347, value);
			}
		}

		[FIXField("369", EFieldOption.Optional)]
		public int LastMsgSeqNumProcessed
		{
			get
			{
				return this.GetIntField(369).Value;
			}
			set
			{
				this.AddIntField(369, value);
			}
		}

		[FIXField("627", EFieldOption.Optional)]
		public int NoHops
		{
			get
			{
				return this.GetIntField(627).Value;
			}
			set
			{
				this.AddIntField(627, value);
			}
		}

		[FIXField("143", EFieldOption.Optional)]
		public string TargetLocationID
		{
			get
			{
				return this.GetStringField(143).Value;
			}
			set
			{
				this.AddStringField(143, value);
			}
		}

		[FIXField("571", EFieldOption.Required)]
		public string TradeReportID
		{
			get
			{
				return this.GetStringField(571).Value;
			}
			set
			{
				this.AddStringField(571, value);
			}
		}

		[FIXField("487", EFieldOption.Optional)]
		public int TradeReportTransType
		{
			get
			{
				return this.GetIntField(487).Value;
			}
			set
			{
				this.AddIntField(487, value);
			}
		}

		[FIXField("856", EFieldOption.Optional)]
		public int TradeReportType
		{
			get
			{
				return this.GetIntField(856).Value;
			}
			set
			{
				this.AddIntField(856, value);
			}
		}

		[FIXField("568", EFieldOption.Optional)]
		public string TradeRequestID
		{
			get
			{
				return this.GetStringField(568).Value;
			}
			set
			{
				this.AddStringField(568, value);
			}
		}

		[FIXField("828", EFieldOption.Optional)]
		public int TrdType
		{
			get
			{
				return this.GetIntField(828).Value;
			}
			set
			{
				this.AddIntField(828, value);
			}
		}

		[FIXField("829", EFieldOption.Optional)]
		public int TrdSubType
		{
			get
			{
				return this.GetIntField(829).Value;
			}
			set
			{
				this.AddIntField(829, value);
			}
		}

		[FIXField("855", EFieldOption.Optional)]
		public int SecondaryTrdType
		{
			get
			{
				return this.GetIntField(855).Value;
			}
			set
			{
				this.AddIntField(855, value);
			}
		}

		[FIXField("830", EFieldOption.Optional)]
		public string TransferReason
		{
			get
			{
				return this.GetStringField(830).Value;
			}
			set
			{
				this.AddStringField(830, value);
			}
		}

		[FIXField("150", EFieldOption.Optional)]
		public char ExecType
		{
			get
			{
				return this.GetCharField(150).Value;
			}
			set
			{
				this.AddCharField(150, value);
			}
		}

		[FIXField("748", EFieldOption.Optional)]
		public int TotNumTradeReports
		{
			get
			{
				return this.GetIntField(748).Value;
			}
			set
			{
				this.AddIntField(748, value);
			}
		}

		[FIXField("912", EFieldOption.Optional)]
		public bool LastRptRequested
		{
			get
			{
				return this.GetBoolField(912).Value;
			}
			set
			{
				this.AddBoolField(912, value);
			}
		}

		[FIXField("325", EFieldOption.Optional)]
		public bool UnsolicitedIndicator
		{
			get
			{
				return this.GetBoolField(325).Value;
			}
			set
			{
				this.AddBoolField(325, value);
			}
		}

		[FIXField("263", EFieldOption.Optional)]
		public char SubscriptionRequestType
		{
			get
			{
				return this.GetCharField(263).Value;
			}
			set
			{
				this.AddCharField(263, value);
			}
		}

		[FIXField("572", EFieldOption.Optional)]
		public string TradeReportRefID
		{
			get
			{
				return this.GetStringField(572).Value;
			}
			set
			{
				this.AddStringField(572, value);
			}
		}

		[FIXField("881", EFieldOption.Optional)]
		public string SecondaryTradeReportRefID
		{
			get
			{
				return this.GetStringField(881).Value;
			}
			set
			{
				this.AddStringField(881, value);
			}
		}

		[FIXField("818", EFieldOption.Optional)]
		public string SecondaryTradeReportID
		{
			get
			{
				return this.GetStringField(818).Value;
			}
			set
			{
				this.AddStringField(818, value);
			}
		}

		[FIXField("820", EFieldOption.Optional)]
		public string TradeLinkID
		{
			get
			{
				return this.GetStringField(820).Value;
			}
			set
			{
				this.AddStringField(820, value);
			}
		}

		[FIXField("880", EFieldOption.Optional)]
		public string TrdMatchID
		{
			get
			{
				return this.GetStringField(880).Value;
			}
			set
			{
				this.AddStringField(880, value);
			}
		}

		[FIXField("17", EFieldOption.Optional)]
		public string ExecID
		{
			get
			{
				return this.GetStringField(17).Value;
			}
			set
			{
				this.AddStringField(17, value);
			}
		}

		[FIXField("39", EFieldOption.Optional)]
		public char OrdStatus
		{
			get
			{
				return this.GetCharField(39).Value;
			}
			set
			{
				this.AddCharField(39, value);
			}
		}

		[FIXField("527", EFieldOption.Optional)]
		public string SecondaryExecID
		{
			get
			{
				return this.GetStringField(527).Value;
			}
			set
			{
				this.AddStringField(527, value);
			}
		}

		[FIXField("378", EFieldOption.Optional)]
		public int ExecRestatementReason
		{
			get
			{
				return this.GetIntField(378).Value;
			}
			set
			{
				this.AddIntField(378, value);
			}
		}

		[FIXField("570", EFieldOption.Required)]
		public bool PreviouslyReported
		{
			get
			{
				return this.GetBoolField(570).Value;
			}
			set
			{
				this.AddBoolField(570, value);
			}
		}

		[FIXField("423", EFieldOption.Optional)]
		public int PriceType
		{
			get
			{
				return this.GetIntField(423).Value;
			}
			set
			{
				this.AddIntField(423, value);
			}
		}

		[FIXField("55", EFieldOption.Optional)]
		public string Symbol
		{
			get
			{
				return this.GetStringField(55).Value;
			}
			set
			{
				this.AddStringField(55, value);
			}
		}

		[FIXField("65", EFieldOption.Optional)]
		public string SymbolSfx
		{
			get
			{
				return this.GetStringField(65).Value;
			}
			set
			{
				this.AddStringField(65, value);
			}
		}

		[FIXField("48", EFieldOption.Optional)]
		public string SecurityID
		{
			get
			{
				return this.GetStringField(48).Value;
			}
			set
			{
				this.AddStringField(48, value);
			}
		}

		[FIXField("22", EFieldOption.Optional)]
		public string SecurityIDSource
		{
			get
			{
				return this.GetStringField(22).Value;
			}
			set
			{
				this.AddStringField(22, value);
			}
		}

		[FIXField("454", EFieldOption.Optional)]
		public int NoSecurityAltID
		{
			get
			{
				return this.GetIntField(454).Value;
			}
			set
			{
				this.AddIntField(454, value);
			}
		}

		[FIXField("460", EFieldOption.Optional)]
		public int Product
		{
			get
			{
				return this.GetIntField(460).Value;
			}
			set
			{
				this.AddIntField(460, value);
			}
		}

		[FIXField("461", EFieldOption.Optional)]
		public string CFICode
		{
			get
			{
				return this.GetStringField(461).Value;
			}
			set
			{
				this.AddStringField(461, value);
			}
		}

		[FIXField("167", EFieldOption.Optional)]
		public string SecurityType
		{
			get
			{
				return this.GetStringField(167).Value;
			}
			set
			{
				this.AddStringField(167, value);
			}
		}

		[FIXField("762", EFieldOption.Optional)]
		public string SecuritySubType
		{
			get
			{
				return this.GetStringField(762).Value;
			}
			set
			{
				this.AddStringField(762, value);
			}
		}

		[FIXField("200", EFieldOption.Optional)]
		public string MaturityMonthYear
		{
			get
			{
				return this.GetStringField(200).Value;
			}
			set
			{
				this.AddStringField(200, value);
			}
		}

		[FIXField("541", EFieldOption.Optional)]
		public DateTime MaturityDate
		{
			get
			{
				return this.GetDateTimeField(541).Value;
			}
			set
			{
				this.AddDateTimeField(541, value);
			}
		}

		[FIXField("224", EFieldOption.Optional)]
		public DateTime CouponPaymentDate
		{
			get
			{
				return this.GetDateTimeField(224).Value;
			}
			set
			{
				this.AddDateTimeField(224, value);
			}
		}

		[FIXField("225", EFieldOption.Optional)]
		public DateTime IssueDate
		{
			get
			{
				return this.GetDateTimeField(225).Value;
			}
			set
			{
				this.AddDateTimeField(225, value);
			}
		}

		[FIXField("239", EFieldOption.Optional)]
		public int RepoCollateralSecurityType
		{
			get
			{
				return this.GetIntField(239).Value;
			}
			set
			{
				this.AddIntField(239, value);
			}
		}

		[FIXField("226", EFieldOption.Optional)]
		public int RepurchaseTerm
		{
			get
			{
				return this.GetIntField(226).Value;
			}
			set
			{
				this.AddIntField(226, value);
			}
		}

		[FIXField("227", EFieldOption.Optional)]
		public double RepurchaseRate
		{
			get
			{
				return this.GetDoubleField(227).Value;
			}
			set
			{
				this.AddDoubleField(227, value);
			}
		}

		[FIXField("228", EFieldOption.Optional)]
		public double Factor
		{
			get
			{
				return this.GetDoubleField(228).Value;
			}
			set
			{
				this.AddDoubleField(228, value);
			}
		}

		[FIXField("255", EFieldOption.Optional)]
		public string CreditRating
		{
			get
			{
				return this.GetStringField((int)byte.MaxValue).Value;
			}
			set
			{
				this.AddStringField((int)byte.MaxValue, value);
			}
		}

		[FIXField("543", EFieldOption.Optional)]
		public string InstrRegistry
		{
			get
			{
				return this.GetStringField(543).Value;
			}
			set
			{
				this.AddStringField(543, value);
			}
		}

		[FIXField("470", EFieldOption.Optional)]
		public string CountryOfIssue
		{
			get
			{
				return this.GetStringField(470).Value;
			}
			set
			{
				this.AddStringField(470, value);
			}
		}

		[FIXField("471", EFieldOption.Optional)]
		public string StateOrProvinceOfIssue
		{
			get
			{
				return this.GetStringField(471).Value;
			}
			set
			{
				this.AddStringField(471, value);
			}
		}

		[FIXField("472", EFieldOption.Optional)]
		public string LocaleOfIssue
		{
			get
			{
				return this.GetStringField(472).Value;
			}
			set
			{
				this.AddStringField(472, value);
			}
		}

		[FIXField("240", EFieldOption.Optional)]
		public DateTime RedemptionDate
		{
			get
			{
				return this.GetDateTimeField(240).Value;
			}
			set
			{
				this.AddDateTimeField(240, value);
			}
		}

		[FIXField("202", EFieldOption.Optional)]
		public double StrikePrice
		{
			get
			{
				return this.GetDoubleField(202).Value;
			}
			set
			{
				this.AddDoubleField(202, value);
			}
		}

		[FIXField("947", EFieldOption.Optional)]
		public double StrikeCurrency
		{
			get
			{
				return this.GetDoubleField(947).Value;
			}
			set
			{
				this.AddDoubleField(947, value);
			}
		}

		[FIXField("206", EFieldOption.Optional)]
		public char OptAttribute
		{
			get
			{
				return this.GetCharField(206).Value;
			}
			set
			{
				this.AddCharField(206, value);
			}
		}

		[FIXField("231", EFieldOption.Optional)]
		public double ContractMultiplier
		{
			get
			{
				return this.GetDoubleField(231).Value;
			}
			set
			{
				this.AddDoubleField(231, value);
			}
		}

		[FIXField("223", EFieldOption.Optional)]
		public double CouponRate
		{
			get
			{
				return this.GetDoubleField(223).Value;
			}
			set
			{
				this.AddDoubleField(223, value);
			}
		}

		[FIXField("207", EFieldOption.Optional)]
		public string SecurityExchange
		{
			get
			{
				return this.GetStringField(207).Value;
			}
			set
			{
				this.AddStringField(207, value);
			}
		}

		[FIXField("106", EFieldOption.Optional)]
		public string Issuer
		{
			get
			{
				return this.GetStringField(106).Value;
			}
			set
			{
				this.AddStringField(106, value);
			}
		}

		[FIXField("348", EFieldOption.Optional)]
		public int EncodedIssuerLen
		{
			get
			{
				return this.GetIntField(348).Value;
			}
			set
			{
				this.AddIntField(348, value);
			}
		}

		[FIXField("349", EFieldOption.Optional)]
		public string EncodedIssuer
		{
			get
			{
				return this.GetStringField(349).Value;
			}
			set
			{
				this.AddStringField(349, value);
			}
		}

		[FIXField("107", EFieldOption.Optional)]
		public string SecurityDesc
		{
			get
			{
				return this.GetStringField(107).Value;
			}
			set
			{
				this.AddStringField(107, value);
			}
		}

		[FIXField("350", EFieldOption.Optional)]
		public int EncodedSecurityDescLen
		{
			get
			{
				return this.GetIntField(350).Value;
			}
			set
			{
				this.AddIntField(350, value);
			}
		}

		[FIXField("351", EFieldOption.Optional)]
		public string EncodedSecurityDesc
		{
			get
			{
				return this.GetStringField(351).Value;
			}
			set
			{
				this.AddStringField(351, value);
			}
		}

		[FIXField("691", EFieldOption.Optional)]
		public string Pool
		{
			get
			{
				return this.GetStringField(691).Value;
			}
			set
			{
				this.AddStringField(691, value);
			}
		}

		[FIXField("667", EFieldOption.Optional)]
		public string ContractSettlMonth
		{
			get
			{
				return this.GetStringField(667).Value;
			}
			set
			{
				this.AddStringField(667, value);
			}
		}

		[FIXField("875", EFieldOption.Optional)]
		public int CPProgram
		{
			get
			{
				return this.GetIntField(875).Value;
			}
			set
			{
				this.AddIntField(875, value);
			}
		}

		[FIXField("876", EFieldOption.Optional)]
		public string CPRegType
		{
			get
			{
				return this.GetStringField(876).Value;
			}
			set
			{
				this.AddStringField(876, value);
			}
		}

		[FIXField("864", EFieldOption.Optional)]
		public int NoEvents
		{
			get
			{
				return this.GetIntField(864).Value;
			}
			set
			{
				this.AddIntField(864, value);
			}
		}

		[FIXField("873", EFieldOption.Optional)]
		public DateTime DatedDate
		{
			get
			{
				return this.GetDateTimeField(873).Value;
			}
			set
			{
				this.AddDateTimeField(873, value);
			}
		}

		[FIXField("874", EFieldOption.Optional)]
		public DateTime InterestAccrualDate
		{
			get
			{
				return this.GetDateTimeField(874).Value;
			}
			set
			{
				this.AddDateTimeField(874, value);
			}
		}

		[FIXField("913", EFieldOption.Optional)]
		public string AgreementDesc
		{
			get
			{
				return this.GetStringField(913).Value;
			}
			set
			{
				this.AddStringField(913, value);
			}
		}

		[FIXField("914", EFieldOption.Optional)]
		public string AgreementID
		{
			get
			{
				return this.GetStringField(914).Value;
			}
			set
			{
				this.AddStringField(914, value);
			}
		}

		[FIXField("915", EFieldOption.Optional)]
		public DateTime AgreementDate
		{
			get
			{
				return this.GetDateTimeField(915).Value;
			}
			set
			{
				this.AddDateTimeField(915, value);
			}
		}

		[FIXField("918", EFieldOption.Optional)]
		public double AgreementCurrency
		{
			get
			{
				return this.GetDoubleField(918).Value;
			}
			set
			{
				this.AddDoubleField(918, value);
			}
		}

		[FIXField("788", EFieldOption.Optional)]
		public int TerminationType
		{
			get
			{
				return this.GetIntField(788).Value;
			}
			set
			{
				this.AddIntField(788, value);
			}
		}

		[FIXField("916", EFieldOption.Optional)]
		public DateTime StartDate
		{
			get
			{
				return this.GetDateTimeField(916).Value;
			}
			set
			{
				this.AddDateTimeField(916, value);
			}
		}

		[FIXField("917", EFieldOption.Optional)]
		public DateTime EndDate
		{
			get
			{
				return this.GetDateTimeField(917).Value;
			}
			set
			{
				this.AddDateTimeField(917, value);
			}
		}

		[FIXField("919", EFieldOption.Optional)]
		public int DeliveryType
		{
			get
			{
				return this.GetIntField(919).Value;
			}
			set
			{
				this.AddIntField(919, value);
			}
		}

		[FIXField("898", EFieldOption.Optional)]
		public double MarginRatio
		{
			get
			{
				return this.GetDoubleField(898).Value;
			}
			set
			{
				this.AddDoubleField(898, value);
			}
		}

		[FIXField("38", EFieldOption.Optional)]
		public double OrderQty
		{
			get
			{
				return this.GetDoubleField(38).Value;
			}
			set
			{
				this.AddDoubleField(38, value);
			}
		}

		[FIXField("152", EFieldOption.Optional)]
		public double CashOrderQty
		{
			get
			{
				return this.GetDoubleField(152).Value;
			}
			set
			{
				this.AddDoubleField(152, value);
			}
		}

		[FIXField("516", EFieldOption.Optional)]
		public double OrderPercent
		{
			get
			{
				return this.GetDoubleField(516).Value;
			}
			set
			{
				this.AddDoubleField(516, value);
			}
		}

		[FIXField("468", EFieldOption.Optional)]
		public char RoundingDirection
		{
			get
			{
				return this.GetCharField(468).Value;
			}
			set
			{
				this.AddCharField(468, value);
			}
		}

		[FIXField("469", EFieldOption.Optional)]
		public double RoundingModulus
		{
			get
			{
				return this.GetDoubleField(469).Value;
			}
			set
			{
				this.AddDoubleField(469, value);
			}
		}

		[FIXField("854", EFieldOption.Optional)]
		public int QtyType
		{
			get
			{
				return this.GetIntField(854).Value;
			}
			set
			{
				this.AddIntField(854, value);
			}
		}

		[FIXField("235", EFieldOption.Optional)]
		public string YieldType
		{
			get
			{
				return this.GetStringField(235).Value;
			}
			set
			{
				this.AddStringField(235, value);
			}
		}

		[FIXField("236", EFieldOption.Optional)]
		public double Yield
		{
			get
			{
				return this.GetDoubleField(236).Value;
			}
			set
			{
				this.AddDoubleField(236, value);
			}
		}

		[FIXField("701", EFieldOption.Optional)]
		public DateTime YieldCalcDate
		{
			get
			{
				return this.GetDateTimeField(701).Value;
			}
			set
			{
				this.AddDateTimeField(701, value);
			}
		}

		[FIXField("696", EFieldOption.Optional)]
		public DateTime YieldRedemptionDate
		{
			get
			{
				return this.GetDateTimeField(696).Value;
			}
			set
			{
				this.AddDateTimeField(696, value);
			}
		}

		[FIXField("697", EFieldOption.Optional)]
		public double YieldRedemptionPrice
		{
			get
			{
				return this.GetDoubleField(697).Value;
			}
			set
			{
				this.AddDoubleField(697, value);
			}
		}

		[FIXField("698", EFieldOption.Optional)]
		public int YieldRedemptionPriceType
		{
			get
			{
				return this.GetIntField(698).Value;
			}
			set
			{
				this.AddIntField(698, value);
			}
		}

		[FIXField("711", EFieldOption.Optional)]
		public int NoUnderlyings
		{
			get
			{
				return this.GetIntField(711).Value;
			}
			set
			{
				this.AddIntField(711, value);
			}
		}

		[FIXField("822", EFieldOption.Optional)]
		public string UnderlyingTradingSessionID
		{
			get
			{
				return this.GetStringField(822).Value;
			}
			set
			{
				this.AddStringField(822, value);
			}
		}

		[FIXField("823", EFieldOption.Optional)]
		public string UnderlyingTradingSessionSubID
		{
			get
			{
				return this.GetStringField(823).Value;
			}
			set
			{
				this.AddStringField(823, value);
			}
		}

		[FIXField("32", EFieldOption.Required)]
		public double LastQty
		{
			get
			{
				return this.GetDoubleField(32).Value;
			}
			set
			{
				this.AddDoubleField(32, value);
			}
		}

		[FIXField("31", EFieldOption.Required)]
		public double LastPx
		{
			get
			{
				return this.GetDoubleField(31).Value;
			}
			set
			{
				this.AddDoubleField(31, value);
			}
		}

		[FIXField("669", EFieldOption.Optional)]
		public double LastParPx
		{
			get
			{
				return this.GetDoubleField(669).Value;
			}
			set
			{
				this.AddDoubleField(669, value);
			}
		}

		[FIXField("194", EFieldOption.Optional)]
		public double LastSpotRate
		{
			get
			{
				return this.GetDoubleField(194).Value;
			}
			set
			{
				this.AddDoubleField(194, value);
			}
		}

		[FIXField("195", EFieldOption.Optional)]
		public double LastForwardPoints
		{
			get
			{
				return this.GetDoubleField(195).Value;
			}
			set
			{
				this.AddDoubleField(195, value);
			}
		}

		[FIXField("30", EFieldOption.Optional)]
		public string LastMkt
		{
			get
			{
				return this.GetStringField(30).Value;
			}
			set
			{
				this.AddStringField(30, value);
			}
		}

		[FIXField("75", EFieldOption.Required)]
		public DateTime TradeDate
		{
			get
			{
				return this.GetDateTimeField(75).Value;
			}
			set
			{
				this.AddDateTimeField(75, value);
			}
		}

		[FIXField("715", EFieldOption.Optional)]
		public DateTime ClearingBusinessDate
		{
			get
			{
				return this.GetDateTimeField(715).Value;
			}
			set
			{
				this.AddDateTimeField(715, value);
			}
		}

		[FIXField("6", EFieldOption.Optional)]
		public double AvgPx
		{
			get
			{
				return this.GetDoubleField(6).Value;
			}
			set
			{
				this.AddDoubleField(6, value);
			}
		}

		[FIXField("218", EFieldOption.Optional)]
		public double Spread
		{
			get
			{
				return this.GetDoubleField(218).Value;
			}
			set
			{
				this.AddDoubleField(218, value);
			}
		}

		[FIXField("220", EFieldOption.Optional)]
		public double BenchmarkCurveCurrency
		{
			get
			{
				return this.GetDoubleField(220).Value;
			}
			set
			{
				this.AddDoubleField(220, value);
			}
		}

		[FIXField("221", EFieldOption.Optional)]
		public string BenchmarkCurveName
		{
			get
			{
				return this.GetStringField(221).Value;
			}
			set
			{
				this.AddStringField(221, value);
			}
		}

		[FIXField("222", EFieldOption.Optional)]
		public string BenchmarkCurvePoint
		{
			get
			{
				return this.GetStringField(222).Value;
			}
			set
			{
				this.AddStringField(222, value);
			}
		}

		[FIXField("662", EFieldOption.Optional)]
		public double BenchmarkPrice
		{
			get
			{
				return this.GetDoubleField(662).Value;
			}
			set
			{
				this.AddDoubleField(662, value);
			}
		}

		[FIXField("663", EFieldOption.Optional)]
		public int BenchmarkPriceType
		{
			get
			{
				return this.GetIntField(663).Value;
			}
			set
			{
				this.AddIntField(663, value);
			}
		}

		[FIXField("699", EFieldOption.Optional)]
		public string BenchmarkSecurityID
		{
			get
			{
				return this.GetStringField(699).Value;
			}
			set
			{
				this.AddStringField(699, value);
			}
		}

		[FIXField("761", EFieldOption.Optional)]
		public string BenchmarkSecurityIDSource
		{
			get
			{
				return this.GetStringField(761).Value;
			}
			set
			{
				this.AddStringField(761, value);
			}
		}

		[FIXField("819", EFieldOption.Optional)]
		public int AvgPxIndicator
		{
			get
			{
				return this.GetIntField(819).Value;
			}
			set
			{
				this.AddIntField(819, value);
			}
		}

		[FIXField("753", EFieldOption.Optional)]
		public int NoPosAmt
		{
			get
			{
				return this.GetIntField(753).Value;
			}
			set
			{
				this.AddIntField(753, value);
			}
		}

		[FIXField("442", EFieldOption.Optional)]
		public char MultiLegReportingType
		{
			get
			{
				return this.GetCharField(442).Value;
			}
			set
			{
				this.AddCharField(442, value);
			}
		}

		[FIXField("824", EFieldOption.Optional)]
		public string TradeLegRefID
		{
			get
			{
				return this.GetStringField(824).Value;
			}
			set
			{
				this.AddStringField(824, value);
			}
		}

		[FIXField("555", EFieldOption.Optional)]
		public int NoLegs
		{
			get
			{
				return this.GetIntField(555).Value;
			}
			set
			{
				this.AddIntField(555, value);
			}
		}

		[FIXField("60", EFieldOption.Required)]
		public DateTime TransactTime
		{
			get
			{
				return this.GetDateTimeField(60).Value;
			}
			set
			{
				this.AddDateTimeField(60, value);
			}
		}

		[FIXField("768", EFieldOption.Optional)]
		public int NoTrdRegTimestamps
		{
			get
			{
				return this.GetIntField(768).Value;
			}
			set
			{
				this.AddIntField(768, value);
			}
		}

		[FIXField("63", EFieldOption.Optional)]
		public char SettlType
		{
			get
			{
				return this.GetCharField(63).Value;
			}
			set
			{
				this.AddCharField(63, value);
			}
		}

		[FIXField("64", EFieldOption.Optional)]
		public DateTime SettlDate
		{
			get
			{
				return this.GetDateTimeField(64).Value;
			}
			set
			{
				this.AddDateTimeField(64, value);
			}
		}

		[FIXField("573", EFieldOption.Optional)]
		public char MatchStatus
		{
			get
			{
				return this.GetCharField(573).Value;
			}
			set
			{
				this.AddCharField(573, value);
			}
		}

		[FIXField("574", EFieldOption.Optional)]
		public string MatchType
		{
			get
			{
				return this.GetStringField(574).Value;
			}
			set
			{
				this.AddStringField(574, value);
			}
		}

		[FIXField("552", EFieldOption.Required)]
		public int NoSides
		{
			get
			{
				return this.GetIntField(552).Value;
			}
			set
			{
				this.AddIntField(552, value);
			}
		}

		[FIXField("797", EFieldOption.Optional)]
		public bool CopyMsgIndicator
		{
			get
			{
				return this.GetBoolField(797).Value;
			}
			set
			{
				this.AddBoolField(797, value);
			}
		}

		[FIXField("852", EFieldOption.Optional)]
		public bool PublishTrdIndicator
		{
			get
			{
				return this.GetBoolField(852).Value;
			}
			set
			{
				this.AddBoolField(852, value);
			}
		}

		[FIXField("853", EFieldOption.Optional)]
		public int ShortSaleReason
		{
			get
			{
				return this.GetIntField(853).Value;
			}
			set
			{
				this.AddIntField(853, value);
			}
		}

		[FIXField("10", EFieldOption.Required)]
		public string CheckSum
		{
			get
			{
				return this.GetStringField(10).Value;
			}
			set
			{
				this.AddStringField(10, value);
			}
		}

		[FIXField("89", EFieldOption.Optional)]
		public string Signature
		{
			get
			{
				return this.GetStringField(89).Value;
			}
			set
			{
				this.AddStringField(89, value);
			}
		}

		[FIXField("93", EFieldOption.Optional)]
		public int SignatureLength
		{
			get
			{
				return this.GetIntField(93).Value;
			}
			set
			{
				this.AddIntField(93, value);
			}
		}

		public FIXTradeCaptureReport() : base()
		{
			this.f7ZAC6g4DL = new ArrayList();
			this.CTDA21AVEd = new ArrayList();
			this.wCLAcaZ2RA = new ArrayList();
			this.hwZAzM4ODk = new ArrayList();
			this.kel8SHGHm3 = new ArrayList();
			this.VL78UVrp9E = new ArrayList();
			this.TYQ8ARIL1M = new ArrayList();
			this.OQ788ftQSH = new ArrayList();
			this.zgq8ZloVJX = new ArrayList();
		}

		public FIXTradeCaptureReport(string TradeReportID, bool PreviouslyReported, double LastQty, double LastPx, DateTime TradeDate, DateTime TransactTime, int NoSides)
    : base()
		{
			this.f7ZAC6g4DL = new ArrayList();
			this.CTDA21AVEd = new ArrayList();
			this.wCLAcaZ2RA = new ArrayList();
			this.hwZAzM4ODk = new ArrayList();
			this.kel8SHGHm3 = new ArrayList();
			this.VL78UVrp9E = new ArrayList();
			this.TYQ8ARIL1M = new ArrayList();
			this.OQ788ftQSH = new ArrayList();
			this.zgq8ZloVJX = new ArrayList();

			this.TradeReportID = TradeReportID;
			this.PreviouslyReported = PreviouslyReported;
			this.LastQty = LastQty;
			this.LastPx = LastPx;
			this.TradeDate = TradeDate;
			this.TransactTime = TransactTime;
			this.NoSides = NoSides;
		}

		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.f7ZAC6g4DL[i];
		}

		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.f7ZAC6g4DL.Add((object)group);
		}

		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
				return (FIXHopsGroup)this.CTDA21AVEd[i];
			else
				return (FIXHopsGroup)null;
		}

		public void AddGroup(FIXHopsGroup group)
		{
			this.CTDA21AVEd.Add((object)group);
			++this.NoHops;
		}

		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
				return (FIXSecurityAltIDGroup)this.wCLAcaZ2RA[i];
			else
				return (FIXSecurityAltIDGroup)null;
		}

		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.wCLAcaZ2RA.Add((object)group);
			++this.NoSecurityAltID;
		}

		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
				return (FIXEventsGroup)this.hwZAzM4ODk[i];
			else
				return (FIXEventsGroup)null;
		}

		public void AddGroup(FIXEventsGroup group)
		{
			this.hwZAzM4ODk.Add((object)group);
			++this.NoEvents;
		}

		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
				return (FIXUnderlyingsGroup)this.kel8SHGHm3[i];
			else
				return (FIXUnderlyingsGroup)null;
		}

		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.kel8SHGHm3.Add((object)group);
			++this.NoUnderlyings;
		}

		public FIXPosAmtGroup GetPosAmtGroup(int i)
		{
			if (i < this.NoPosAmt)
				return (FIXPosAmtGroup)this.VL78UVrp9E[i];
			else
				return (FIXPosAmtGroup)null;
		}

		public void AddGroup(FIXPosAmtGroup group)
		{
			this.VL78UVrp9E.Add((object)group);
			++this.NoPosAmt;
		}

		public FIXLegsGroup GetLegsGroup(int i)
		{
			if (i < this.NoLegs)
				return (FIXLegsGroup)this.TYQ8ARIL1M[i];
			else
				return (FIXLegsGroup)null;
		}

		public void AddGroup(FIXLegsGroup group)
		{
			this.TYQ8ARIL1M.Add((object)group);
			++this.NoLegs;
		}

		public FIXTrdRegTimestampsGroup GetTrdRegTimestampsGroup(int i)
		{
			if (i < this.NoTrdRegTimestamps)
				return (FIXTrdRegTimestampsGroup)this.OQ788ftQSH[i];
			else
				return (FIXTrdRegTimestampsGroup)null;
		}

		public void AddGroup(FIXTrdRegTimestampsGroup group)
		{
			this.OQ788ftQSH.Add((object)group);
			++this.NoTrdRegTimestamps;
		}

		public FIXSidesGroup GetSidesGroup(int i)
		{
			if (i < this.NoSides)
				return (FIXSidesGroup)this.zgq8ZloVJX[i];
			else
				return (FIXSidesGroup)null;
		}

		public void AddGroup(FIXSidesGroup group)
		{
			this.zgq8ZloVJX.Add((object)group);
			++this.NoSides;
		}
	}
}
