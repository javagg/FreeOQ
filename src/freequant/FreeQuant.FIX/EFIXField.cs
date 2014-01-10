namespace FreeQuant.FIX
{
	public sealed class EFIXField
	{
		public const int Account = 1;
		public const int AdvId = 2;
		public const int AdvRefID = 3;
		public const int AdvSide = 4;
		public const int AdvTransType = 5;
		public const int AvgPx = 6;
		public const int BeginSeqNo = 7;
		public const int BeginString = 8;
		public const int BodyLength = 9;
		public const int CheckSum = 10;
		public const int ClOrdID = 11;
		public const int Commission = 12;
		public const int CommType = 13;
		public const int CumQty = 14;
		public const int Currency = 15;
		public const int EndSeqNo = 16;
		public const int ExecID = 17;
		public const int ExecInst = 18;
		public const int ExecRefID = 19;
		public const int ExecTransType = 20;
		public const int HandlInst = 21;
		public const int SecurityIDSource = 22;
		public const int IOIID = 23;
		public const int IOIOthSvc = 24;
		public const int IOIQltyInd = 25;
		public const int IOIRefID = 26;
		public const int IOIQty = 27;
		public const int IOITransType = 28;
		public const int LastCapacity = 29;
		public const int LastMkt = 30;
		public const int LastPx = 31;
		public const int LastQty = 32;
		public const int NoLinesOfText = 33;
		public const int MsgSeqNum = 34;
		public const int MsgType = 35;
		public const int NewSeqNo = 36;
		public const int OrderID = 37;
		public const int OrderQty = 38;
		public const int OrdStatus = 39;
		public const int OrdType = 40;
		public const int OrigClOrdID = 41;
		public const int OrigTime = 42;
		public const int PossDupFlag = 43;
		public const int Price = 44;
		public const int RefSeqNum = 45;
		public const int RelatdSym = 46;
		public const int Rule80A = 47;
		public const int SecurityID = 48;
		public const int SenderCompID = 49;
		public const int SenderSubID = 50;
		public const int SendingDate = 51;
		public const int SendingTime = 52;
		public const int Quantity = 53;
		public const int Side = 54;
		public const int Symbol = 55;
		public const int TargetCompID = 56;
		public const int TargetSubID = 57;
		public const int Text = 58;
		public const int TimeInForce = 59;
		public const int TransactTime = 60;
		public const int Urgency = 61;
		public const int ValidUntilTime = 62;
		public const int SettlType = 63;
		public const int SettlDate = 64;
		public const int SymbolSfx = 65;
		public const int ListID = 66;
		public const int ListSeqNo = 67;
		public const int TotNoOrders = 68;
		public const int ListExecInst = 69;
		public const int AllocID = 70;
		public const int AllocTransType = 71;
		public const int RefAllocID = 72;
		public const int NoOrders = 73;
		public const int AvgPxPrecision = 74;
		public const int TradeDate = 75;
		public const int ExecBroker = 76;
		public const int PositionEffect = 77;
		public const int NoAllocs = 78;
		public const int AllocAccount = 79;
		public const int AllocQty = 80;
		public const int ProcessCode = 81;
		public const int NoRpts = 82;
		public const int RptSeq = 83;
		public const int CxlQty = 84;
		public const int NoDlvyInst = 85;
		public const int DlvyInst = 86;
		public const int AllocStatus = 87;
		public const int AllocRejCode = 88;
		public const int Signature = 89;
		public const int SecureDataLen = 90;
		public const int SecureData = 91;
		public const int BrokerOfCredit = 92;
		public const int SignatureLength = 93;
		public const int EmailType = 94;
		public const int RawDataLength = 95;
		public const int RawData = 96;
		public const int PossResend = 97;
		public const int EncryptMethod = 98;
		public const int StopPx = 99;
		public const int ExDestination = 100;
		public const int CxlRejReason = 102;
		public const int OrdRejReason = 103;
		public const int IOIQualifier = 104;
		public const int WaveNo = 105;
		public const int Issuer = 106;
		public const int SecurityDesc = 107;
		public const int HeartBtInt = 108;
		public const int ClientID = 109;
		public const int MinQty = 110;
		public const int MaxFloor = 111;
		public const int TestReqID = 112;
		public const int ReportToExch = 113;
		public const int LocateReqd = 114;
		public const int OnBehalfOfCompID = 115;
		public const int OnBehalfOfSubID = 116;
		public const int QuoteID = 117;
		public const int NetMoney = 118;
		public const int SettlCurrAmt = 119;
		public const int SettlCurrency = 120;
		public const int ForexReq = 121;
		public const int OrigSendingTime = 122;
		public const int GapFillFlag = 123;
		public const int NoExecs = 124;
		public const int CxlType = 125;
		public const int ExpireTime = 126;
		public const int DKReason = 127;
		public const int DeliverToCompID = 128;
		public const int DeliverToSubID = 129;
		public const int IOINaturalFlag = 130;
		public const int QuoteReqID = 131;
		public const int BidPx = 132;
		public const int OfferPx = 133;
		public const int BidSize = 134;
		public const int OfferSize = 135;
		public const int NoMiscFees = 136;
		public const int MiscFeeAmt = 137;
		public const int MiscFeeCurr = 138;
		public const int MiscFeeType = 139;
		public const int PrevClosePx = 140;
		public const int ResetSeqNumFlag = 141;
		public const int SenderLocationID = 142;
		public const int TargetLocationID = 143;
		public const int OnBehalfOfLocationID = 144;
		public const int DeliverToLocationID = 145;
		public const int NoRelatedSym = 146;
		public const int Subject = 147;
		public const int Headline = 148;
		public const int URLLink = 149;
		public const int ExecType = 150;
		public const int LeavesQty = 151;
		public const int CashOrderQty = 152;
		public const int AllocAvgPx = 153;
		public const int AllocNetMoney = 154;
		public const int SettlCurrFxRate = 155;
		public const int SettlCurrFxRateCalc = 156;
		public const int NumDaysInterest = 157;
		public const int AccruedInterestRate = 158;
		public const int AccruedInterestAmt = 159;
		public const int SettlInstMode = 160;
		public const int AllocText = 161;
		public const int SettlInstID = 162;
		public const int SettlInstTransType = 163;
		public const int EmailThreadID = 164;
		public const int SettlInstSource = 165;
		public const int SettlLocation = 166;
		public const int SecurityType = 167;
		public const int EffectiveTime = 168;
		public const int StandInstDbType = 169;
		public const int StandInstDbName = 170;
		public const int StandInstDbID = 171;
		public const int SettlDeliveryType = 172;
		public const int SettlDepositoryCode = 173;
		public const int SettlBrkrCode = 174;
		public const int SettlInstCode = 175;
		public const int SecuritySettlAgentName = 176;
		public const int SecuritySettlAgentCode = 177;
		public const int SecuritySettlAgentAcctNum = 178;
		public const int SecuritySettlAgentAcctName = 179;
		public const int SecuritySettlAgentContactName = 180;
		public const int SecuritySettlAgentContactPhone = 181;
		public const int CashSettlAgentName = 182;
		public const int CashSettlAgentCode = 183;
		public const int CashSettlAgentAcctNum = 184;
		public const int CashSettlAgentAcctName = 185;
		public const int CashSettlAgentContactName = 186;
		public const int CashSettlAgentContactPhone = 187;
		public const int BidSpotRate = 188;
		public const int BidForwardPoints = 189;
		public const int OfferSpotRate = 190;
		public const int OfferForwardPoints = 191;
		public const int OrderQty2 = 192;
		public const int SettlDate2 = 193;
		public const int LastSpotRate = 194;
		public const int LastForwardPoints = 195;
		public const int AllocLinkID = 196;
		public const int AllocLinkType = 197;
		public const int SecondaryOrderID = 198;
		public const int NoIOIQualifiers = 199;
		public const int MaturityMonthYear = 200;
		public const int PutOrCall = 201;
		public const int StrikePrice = 202;
		public const int CoveredOrUncovered = 203;
		public const int CustomerOrFirm = 204;
		public const int MaturityDay = 205;
		public const int OptAttribute = 206;
		public const int SecurityExchange = 207;
		public const int NotifyBrokerOfCredit = 208;
		public const int AllocHandlInst = 209;
		public const int MaxShow = 210;
		public const int PegOffsetValue = 211;
		public const int XmlDataLen = 212;
		public const int XmlData = 213;
		public const int SettlInstRefID = 214;
		public const int NoRoutingIDs = 215;
		public const int RoutingType = 216;
		public const int RoutingID = 217;
		public const int Spread = 218;
		public const int Benchmark = 219;
		public const int BenchmarkCurveCurrency = 220;
		public const int BenchmarkCurveName = 221;
		public const int BenchmarkCurvePoint = 222;
		public const int CouponRate = 223;
		public const int CouponPaymentDate = 224;
		public const int IssueDate = 225;
		public const int RepurchaseTerm = 226;
		public const int RepurchaseRate = 227;
		public const int Factor = 228;
		public const int TradeOriginationDate = 229;
		public const int ExDate = 230;
		public const int ContractMultiplier = 231;
		public const int NoStipulations = 232;
		public const int StipulationType = 233;
		public const int StipulationValue = 234;
		public const int YieldType = 235;
		public const int Yield = 236;
		public const int TotalTakedown = 237;
		public const int Concession = 238;
		public const int RepoCollateralSecurityType = 239;
		public const int RedemptionDate = 240;
		public const int UnderlyingCouponPaymentDate = 241;
		public const int UnderlyingIssueDate = 242;
		public const int UnderlyingRepoCollateralSecurityType = 243;
		public const int UnderlyingRepurchaseTerm = 244;
		public const int UnderlyingRepurchaseRate = 245;
		public const int UnderlyingFactor = 246;
		public const int UnderlyingRedemptionDate = 247;
		public const int LegCouponPaymentDate = 248;
		public const int LegIssueDate = 249;
		public const int LegRepoCollateralSecurityType = 250;
		public const int LegRepurchaseTerm = 251;
		public const int LegRepurchaseRate = 252;
		public const int LegFactor = 253;
		public const int LegRedemptionDate = 254;
		public const int CreditRating = 255;
		public const int UnderlyingCreditRating = 256;
		public const int LegCreditRating = 257;
		public const int TradedFlatSwitch = 258;
		public const int BasisFeatureDate = 259;
		public const int BasisFeaturePrice = 260;
		public const int Reserved = 261;
		public const int MDReqID = 262;
		public const int SubscriptionRequestType = 263;
		public const int MarketDepth = 264;
		public const int MDUpdateType = 265;
		public const int AggregatedBook = 266;
		public const int NoMDEntryTypes = 267;
		public const int NoMDEntries = 268;
		public const int MDEntryType = 269;
		public const int MDEntryPx = 270;
		public const int MDEntrySize = 271;
		public const int MDEntryDate = 272;
		public const int MDEntryTime = 273;
		public const int TickDirection = 274;
		public const int MDMkt = 275;
		public const int QuoteCondition = 276;
		public const int TradeCondition = 277;
		public const int MDEntryID = 278;
		public const int MDUpdateAction = 279;
		public const int MDEntryRefID = 280;
		public const int MDReqRejReason = 281;
		public const int MDEntryOriginator = 282;
		public const int LocationID = 283;
		public const int DeskID = 284;
		public const int DeleteReason = 285;
		public const int OpenCloseSettlFlag = 286;
		public const int SellerDays = 287;
		public const int MDEntryBuyer = 288;
		public const int MDEntrySeller = 289;
		public const int MDEntryPositionNo = 290;
		public const int FinancialStatus = 291;
		public const int CorporateAction = 292;
		public const int DefBidSize = 293;
		public const int DefOfferSize = 294;
		public const int NoQuoteEntries = 295;
		public const int NoQuoteSets = 296;
		public const int QuoteStatus = 297;
		public const int QuoteCancelType = 298;
		public const int QuoteEntryID = 299;
		public const int QuoteRejectReason = 300;
		public const int QuoteResponseLevel = 301;
		public const int QuoteSetID = 302;
		public const int QuoteRequestType = 303;
		public const int TotNoQuoteEntries = 304;
		public const int UnderlyingSecurityIDSource = 305;
		public const int UnderlyingIssuer = 306;
		public const int UnderlyingSecurityDesc = 307;
		public const int UnderlyingSecurityExchange = 308;
		public const int UnderlyingSecurityID = 309;
		public const int UnderlyingSecurityType = 310;
		public const int UnderlyingSymbol = 311;
		public const int UnderlyingSymbolSfx = 312;
		public const int UnderlyingMaturityMonthYear = 313;
		public const int UnderlyingMaturityDay = 314;
		public const int UnderlyingPutOrCall = 315;
		public const int UnderlyingStrikePrice = 316;
		public const int UnderlyingOptAttribute = 317;
		public const int UnderlyingCurrency = 318;
		public const int RatioQty = 319;
		public const int SecurityReqID = 320;
		public const int SecurityRequestType = 321;
		public const int SecurityResponseID = 322;
		public const int SecurityResponseType = 323;
		public const int SecurityStatusReqID = 324;
		public const int UnsolicitedIndicator = 325;
		public const int SecurityTradingStatus = 326;
		public const int HaltReason = 327;
		public const int InViewOfCommon = 328;
		public const int DueToRelated = 329;
		public const int BuyVolume = 330;
		public const int SellVolume = 331;
		public const int HighPx = 332;
		public const int LowPx = 333;
		public const int Adjustment = 334;
		public const int TradSesReqID = 335;
		public const int TradingSessionID = 336;
		public const int ContraTrader = 337;
		public const int TradSesMethod = 338;
		public const int TradSesMode = 339;
		public const int TradSesStatus = 340;
		public const int TradSesStartTime = 341;
		public const int TradSesOpenTime = 342;
		public const int TradSesPreCloseTime = 343;
		public const int TradSesCloseTime = 344;
		public const int TradSesEndTime = 345;
		public const int NumberOfOrders = 346;
		public const int MessageEncoding = 347;
		public const int EncodedIssuerLen = 348;
		public const int EncodedIssuer = 349;
		public const int EncodedSecurityDescLen = 350;
		public const int EncodedSecurityDesc = 351;
		public const int EncodedListExecInstLen = 352;
		public const int EncodedListExecInst = 353;
		public const int EncodedTextLen = 354;
		public const int EncodedText = 355;
		public const int EncodedSubjectLen = 356;
		public const int EncodedSubject = 357;
		public const int EncodedHeadlineLen = 358;
		public const int EncodedHeadline = 359;
		public const int EncodedAllocTextLen = 360;
		public const int EncodedAllocText = 361;
		public const int EncodedUnderlyingIssuerLen = 362;
		public const int EncodedUnderlyingIssuer = 363;
		public const int EncodedUnderlyingSecurityDescLen = 364;
		public const int EncodedUnderlyingSecurityDesc = 365;
		public const int AllocPrice = 366;
		public const int QuoteSetValidUntilTime = 367;
		public const int QuoteEntryRejectReason = 368;
		public const int LastMsgSeqNumProcessed = 369;
		public const int OnBehalfOfSendingTime = 370;
		public const int RefTagID = 371;
		public const int RefMsgType = 372;
		public const int SessionRejectReason = 373;
		public const int BidRequestTransType = 374;
		public const int ContraBroker = 375;
		public const int ComplianceID = 376;
		public const int SolicitedFlag = 377;
		public const int ExecRestatementReason = 378;
		public const int BusinessRejectRefID = 379;
		public const int BusinessRejectReason = 380;
		public const int GrossTradeAmt = 381;
		public const int NoContraBrokers = 382;
		public const int MaxMessageSize = 383;
		public const int NoMsgTypes = 384;
		public const int MsgDirection = 385;
		public const int NoTradingSessions = 386;
		public const int TotalVolumeTraded = 387;
		public const int DiscretionInst = 388;
		public const int DiscretionOffsetValue = 389;
		public const int BidID = 390;
		public const int ClientBidID = 391;
		public const int ListName = 392;
		public const int TotNoRelatedSym = 393;
		public const int BidType = 394;
		public const int NumTickets = 395;
		public const int SideValue1 = 396;
		public const int SideValue2 = 397;
		public const int NoBidDescriptors = 398;
		public const int BidDescriptorType = 399;
		public const int BidDescriptor = 400;
		public const int SideValueInd = 401;
		public const int LiquidityPctLow = 402;
		public const int LiquidityPctHigh = 403;
		public const int LiquidityValue = 404;
		public const int EFPTrackingError = 405;
		public const int FairValue = 406;
		public const int OutsideIndexPct = 407;
		public const int ValueOfFutures = 408;
		public const int LiquidityIndType = 409;
		public const int WtAverageLiquidity = 410;
		public const int ExchangeForPhysical = 411;
		public const int OutMainCntryUIndex = 412;
		public const int CrossPercent = 413;
		public const int ProgRptReqs = 414;
		public const int ProgPeriodInterval = 415;
		public const int IncTaxInd = 416;
		public const int NumBidders = 417;
		public const int BidTradeType = 418;
		public const int BasisPxType = 419;
		public const int NoBidComponents = 420;
		public const int Country = 421;
		public const int TotNoStrikes = 422;
		public const int PriceType = 423;
		public const int DayOrderQty = 424;
		public const int DayCumQty = 425;
		public const int DayAvgPx = 426;
		public const int GTBookingInst = 427;
		public const int NoStrikes = 428;
		public const int ListStatusType = 429;
		public const int NetGrossInd = 430;
		public const int ListOrderStatus = 431;
		public const int ExpireDate = 432;
		public const int ListExecInstType = 433;
		public const int CxlRejResponseTo = 434;
		public const int UnderlyingCouponRate = 435;
		public const int UnderlyingContractMultiplier = 436;
		public const int ContraTradeQty = 437;
		public const int ContraTradeTime = 438;
		public const int ClearingFirm = 439;
		public const int ClearingAccount = 440;
		public const int LiquidityNumSecurities = 441;
		public const int MultiLegReportingType = 442;
		public const int StrikeTime = 443;
		public const int ListStatusText = 444;
		public const int EncodedListStatusTextLen = 445;
		public const int EncodedListStatusText = 446;
		public const int PartyIDSource = 447;
		public const int PartyID = 448;
		public const int TotalVolumeTradedDate = 449;
		public const int TotalVolumeTradedTime = 450;
		public const int NetChgPrevDay = 451;
		public const int PartyRole = 452;
		public const int NoPartyIDs = 453;
		public const int NoSecurityAltID = 454;
		public const int SecurityAltID = 455;
		public const int SecurityAltIDSource = 456;
		public const int NoUnderlyingSecurityAltID = 457;
		public const int UnderlyingSecurityAltID = 458;
		public const int UnderlyingSecurityAltIDSource = 459;
		public const int Product = 460;
		public const int CFICode = 461;
		public const int UnderlyingProduct = 462;
		public const int UnderlyingCFICode = 463;
		public const int TestMessageIndicator = 464;
		public const int QuantityType = 465;
		public const int BookingRefID = 466;
		public const int IndividualAllocID = 467;
		public const int RoundingDirection = 468;
		public const int RoundingModulus = 469;
		public const int CountryOfIssue = 470;
		public const int StateOrProvinceOfIssue = 471;
		public const int LocaleOfIssue = 472;
		public const int NoRegistDtls = 473;
		public const int MailingDtls = 474;
		public const int InvestorCountryOfResidence = 475;
		public const int PaymentRef = 476;
		public const int DistribPaymentMethod = 477;
		public const int CashDistribCurr = 478;
		public const int CommCurrency = 479;
		public const int CancellationRights = 480;
		public const int MoneyLaunderingStatus = 481;
		public const int MailingInst = 482;
		public const int TransBkdTime = 483;
		public const int ExecPriceType = 484;
		public const int ExecPriceAdjustment = 485;
		public const int DateOfBirth = 486;
		public const int TradeReportTransType = 487;
		public const int CardHolderName = 488;
		public const int CardNumber = 489;
		public const int CardExpDate = 490;
		public const int CardIssNum = 491;
		public const int PaymentMethod = 492;
		public const int RegistAcctType = 493;
		public const int Designation = 494;
		public const int TaxAdvantageType = 495;
		public const int RegistRejReasonText = 496;
		public const int FundRenewWaiv = 497;
		public const int CashDistribAgentName = 498;
		public const int CashDistribAgentCode = 499;
		public const int CashDistribAgentAcctNumber = 500;
		public const int CashDistribPayRef = 501;
		public const int CashDistribAgentAcctName = 502;
		public const int CardStartDate = 503;
		public const int PaymentDate = 504;
		public const int PaymentRemitterID = 505;
		public const int RegistStatus = 506;
		public const int RegistRejReasonCode = 507;
		public const int RegistRefID = 508;
		public const int RegistDtls = 509;
		public const int NoDistribInsts = 510;
		public const int RegistEmail = 511;
		public const int DistribPercentage = 512;
		public const int RegistID = 513;
		public const int RegistTransType = 514;
		public const int ExecValuationPoint = 515;
		public const int OrderPercent = 516;
		public const int OwnershipType = 517;
		public const int NoContAmts = 518;
		public const int ContAmtType = 519;
		public const int ContAmtValue = 520;
		public const int ContAmtCurr = 521;
		public const int OwnerType = 522;
		public const int PartySubID = 523;
		public const int NestedPartyID = 524;
		public const int NestedPartyIDSource = 525;
		public const int SecondaryClOrdID = 526;
		public const int SecondaryExecID = 527;
		public const int OrderCapacity = 528;
		public const int OrderRestrictions = 529;
		public const int MassCancelRequestType = 530;
		public const int MassCancelResponse = 531;
		public const int MassCancelRejectReason = 532;
		public const int TotalAffectedOrders = 533;
		public const int NoAffectedOrders = 534;
		public const int AffectedOrderID = 535;
		public const int AffectedSecondaryOrderID = 536;
		public const int QuoteType = 537;
		public const int NestedPartyRole = 538;
		public const int NoNestedPartyIDs = 539;
		public const int TotalAccruedInterestAmt = 540;
		public const int MaturityDate = 541;
		public const int UnderlyingMaturityDate = 542;
		public const int InstrRegistry = 543;
		public const int CashMargin = 544;
		public const int NestedPartySubID = 545;
		public const int Scope = 546;
		public const int MDImplicitDelete = 547;
		public const int CrossID = 548;
		public const int CrossType = 549;
		public const int CrossPrioritization = 550;
		public const int OrigCrossID = 551;
		public const int NoSides = 552;
		public const int Username = 553;
		public const int Password = 554;
		public const int NoLegs = 555;
		public const int LegCurrency = 556;
		public const int TotNoSecurityTypes = 557;
		public const int NoSecurityTypes = 558;
		public const int SecurityListRequestType = 559;
		public const int SecurityRequestResult = 560;
		public const int RoundLot = 561;
		public const int MinTradeVol = 562;
		public const int MultiLegRptTypeReq = 563;
		public const int LegPositionEffect = 564;
		public const int LegCoveredOrUncovered = 565;
		public const int LegPrice = 566;
		public const int TradSesStatusRejReason = 567;
		public const int TradeRequestID = 568;
		public const int TradeRequestType = 569;
		public const int PreviouslyReported = 570;
		public const int TradeReportID = 571;
		public const int TradeReportRefID = 572;
		public const int MatchStatus = 573;
		public const int MatchType = 574;
		public const int OddLot = 575;
		public const int NoClearingInstructions = 576;
		public const int ClearingInstruction = 577;
		public const int TradeInputSource = 578;
		public const int TradeInputDevice = 579;
		public const int NoDates = 580;
		public const int AccountType = 581;
		public const int CustOrderCapacity = 582;
		public const int ClOrdLinkID = 583;
		public const int MassStatusReqID = 584;
		public const int MassStatusReqType = 585;
		public const int OrigOrdModTime = 586;
		public const int LegSettlType = 587;
		public const int LegSettlDate = 588;
		public const int DayBookingInst = 589;
		public const int BookingUnit = 590;
		public const int PreallocMethod = 591;
		public const int UnderlyingCountryOfIssue = 592;
		public const int UnderlyingStateOrProvinceOfIssue = 593;
		public const int UnderlyingLocaleOfIssue = 594;
		public const int UnderlyingInstrRegistry = 595;
		public const int LegCountryOfIssue = 596;
		public const int LegStateOrProvinceOfIssue = 597;
		public const int LegLocaleOfIssue = 598;
		public const int LegInstrRegistry = 599;
		public const int LegSymbol = 600;
		public const int LegSymbolSfx = 601;
		public const int LegSecurityID = 602;
		public const int LegSecurityIDSource = 603;
		public const int NoLegSecurityAltID = 604;
		public const int LegSecurityAltID = 605;
		public const int LegSecurityAltIDSource = 606;
		public const int LegProduct = 607;
		public const int LegCFICode = 608;
		public const int LegSecurityType = 609;
		public const int LegMaturityMonthYear = 610;
		public const int LegMaturityDate = 611;
		public const int LegStrikePrice = 612;
		public const int LegOptAttribute = 613;
		public const int LegContractMultiplier = 614;
		public const int LegCouponRate = 615;
		public const int LegSecurityExchange = 616;
		public const int LegIssuer = 617;
		public const int EncodedLegIssuerLen = 618;
		public const int EncodedLegIssuer = 619;
		public const int LegSecurityDesc = 620;
		public const int EncodedLegSecurityDescLen = 621;
		public const int EncodedLegSecurityDesc = 622;
		public const int LegRatioQty = 623;
		public const int LegSide = 624;
		public const int TradingSessionSubID = 625;
		public const int AllocType = 626;
		public const int NoHops = 627;
		public const int HopCompID = 628;
		public const int HopSendingTime = 629;
		public const int HopRefID = 630;
		public const int MidPx = 631;
		public const int BidYield = 632;
		public const int MidYield = 633;
		public const int OfferYield = 634;
		public const int ClearingFeeIndicator = 635;
		public const int WorkingIndicator = 636;
		public const int LegLastPx = 637;
		public const int PriorityIndicator = 638;
		public const int PriceImprovement = 639;
		public const int Price2 = 640;
		public const int LastForwardPoints2 = 641;
		public const int BidForwardPoints2 = 642;
		public const int OfferForwardPoints2 = 643;
		public const int RFQReqID = 644;
		public const int MktBidPx = 645;
		public const int MktOfferPx = 646;
		public const int MinBidSize = 647;
		public const int MinOfferSize = 648;
		public const int QuoteStatusReqID = 649;
		public const int LegalConfirm = 650;
		public const int UnderlyingLastPx = 651;
		public const int UnderlyingLastQty = 652;
		public const int SecDefStatus = 653;
		public const int LegRefID = 654;
		public const int ContraLegRefID = 655;
		public const int SettlCurrBidFxRate = 656;
		public const int SettlCurrOfferFxRate = 657;
		public const int QuoteRequestRejectReason = 658;
		public const int SideComplianceID = 659;
		public const int AcctIDSource = 660;
		public const int AllocAcctIDSource = 661;
		public const int BenchmarkPrice = 662;
		public const int BenchmarkPriceType = 663;
		public const int ConfirmID = 664;
		public const int ConfirmStatus = 665;
		public const int ConfirmTransType = 666;
		public const int ContractSettlMonth = 667;
		public const int DeliveryForm = 668;
		public const int LastParPx = 669;
		public const int NoLegAllocs = 670;
		public const int LegAllocAccount = 671;
		public const int LegIndividualAllocID = 672;
		public const int LegAllocQty = 673;
		public const int LegAllocAcctIDSource = 674;
		public const int LegSettlCurrency = 675;
		public const int LegBenchmarkCurveCurrency = 676;
		public const int LegBenchmarkCurveName = 677;
		public const int LegBenchmarkCurvePoint = 678;
		public const int LegBenchmarkPrice = 679;
		public const int LegBenchmarkPriceType = 680;
		public const int LegBidPx = 681;
		public const int LegIOIQty = 682;
		public const int NoLegStipulations = 683;
		public const int LegOfferPx = 684;
		public const int LegOrderQty = 685;
		public const int LegPriceType = 686;
		public const int LegQty = 687;
		public const int LegStipulationType = 688;
		public const int LegStipulationValue = 689;
		public const int LegSwapType = 690;
		public const int Pool = 691;
		public const int QuotePriceType = 692;
		public const int QuoteRespID = 693;
		public const int QuoteRespType = 694;
		public const int QuoteQualifier = 695;
		public const int YieldRedemptionDate = 696;
		public const int YieldRedemptionPrice = 697;
		public const int YieldRedemptionPriceType = 698;
		public const int BenchmarkSecurityID = 699;
		public const int ReversalIndicator = 700;
		public const int YieldCalcDate = 701;
		public const int NoPositions = 702;
		public const int PosType = 703;
		public const int LongQty = 704;
		public const int ShortQty = 705;
		public const int PosQtyStatus = 706;
		public const int PosAmtType = 707;
		public const int PosAmt = 708;
		public const int PosTransType = 709;
		public const int PosReqID = 710;
		public const int NoUnderlyings = 711;
		public const int PosMaintAction = 712;
		public const int OrigPosReqRefID = 713;
		public const int PosMaintRptRefID = 714;
		public const int ClearingBusinessDate = 715;
		public const int SettlSessID = 716;
		public const int SettlSessSubID = 717;
		public const int AdjustmentType = 718;
		public const int ContraryInstructionIndicator = 719;
		public const int PriorSpreadIndicator = 720;
		public const int PosMaintRptID = 721;
		public const int PosMaintStatus = 722;
		public const int PosMaintResult = 723;
		public const int PosReqType = 724;
		public const int ResponseTransportType = 725;
		public const int ResponseDestination = 726;
		public const int TotalNumPosReports = 727;
		public const int PosReqResult = 728;
		public const int PosReqStatus = 729;
		public const int SettlPrice = 730;
		public const int SettlPriceType = 731;
		public const int UnderlyingSettlPrice = 732;
		public const int UnderlyingSettlPriceType = 733;
		public const int PriorSettlPrice = 734;
		public const int NoQuoteQualifiers = 735;
		public const int AllocSettlCurrency = 736;
		public const int AllocSettlCurrAmt = 737;
		public const int InterestAtMaturity = 738;
		public const int LegDatedDate = 739;
		public const int LegPool = 740;
		public const int AllocInterestAtMaturity = 741;
		public const int AllocAccruedInterestAmt = 742;
		public const int DeliveryDate = 743;
		public const int AssignmentMethod = 744;
		public const int AssignmentUnit = 745;
		public const int OpenInterest = 746;
		public const int ExerciseMethod = 747;
		public const int TotNumTradeReports = 748;
		public const int TradeRequestResult = 749;
		public const int TradeRequestStatus = 750;
		public const int TradeReportRejectReason = 751;
		public const int SideMultiLegReportingType = 752;
		public const int NoPosAmt = 753;
		public const int AutoAcceptIndicator = 754;
		public const int AllocReportID = 755;
		public const int NoNested2PartyIDs = 756;
		public const int Nested2PartyID = 757;
		public const int Nested2PartyIDSource = 758;
		public const int Nested2PartyRole = 759;
		public const int Nested2PartySubID = 760;
		public const int BenchmarkSecurityIDSource = 761;
		public const int SecuritySubType = 762;
		public const int UnderlyingSecuritySubType = 763;
		public const int LegSecuritySubType = 764;
		public const int AllowableOneSidednessPct = 765;
		public const int AllowableOneSidednessValue = 766;
		public const int AllowableOneSidednessCurr = 767;
		public const int NoTrdRegTimestamps = 768;
		public const int TrdRegTimestamp = 769;
		public const int TrdRegTimestampType = 770;
		public const int TrdRegTimestampOrigin = 771;
		public const int ConfirmRefID = 772;
		public const int ConfirmType = 773;
		public const int ConfirmRejReason = 774;
		public const int BookingType = 775;
		public const int IndividualAllocRejCode = 776;
		public const int SettlInstMsgID = 777;
		public const int NoSettlInst = 778;
		public const int LastUpdateTime = 779;
		public const int AllocSettlInstType = 780;
		public const int NoSettlPartyIDs = 781;
		public const int SettlPartyID = 782;
		public const int SettlPartyIDSource = 783;
		public const int SettlPartyRole = 784;
		public const int SettlPartySubID = 785;
		public const int SettlPartySubIDType = 786;
		public const int DlvyInstType = 787;
		public const int TerminationType = 788;
		public const int NextExpectedMsgSeqNum = 789;
		public const int OrdStatusReqID = 790;
		public const int SettlInstReqID = 791;
		public const int SettlInstReqRejCode = 792;
		public const int SecondaryAllocID = 793;
		public const int AllocReportType = 794;
		public const int AllocReportRefID = 795;
		public const int AllocCancReplaceReason = 796;
		public const int CopyMsgIndicator = 797;
		public const int AllocAccountType = 798;
		public const int OrderAvgPx = 799;
		public const int OrderBookingQty = 800;
		public const int NoSettlPartySubIDs = 801;
		public const int NoPartySubIDs = 802;
		public const int PartySubIDType = 803;
		public const int NoNestedPartySubIDs = 804;
		public const int NestedPartySubIDType = 805;
		public const int NoNested2PartySubIDs = 806;
		public const int Nested2PartySubIDType = 807;
		public const int AllocIntermedReqType = 808;
		public const int NoUsernames = 809;
		public const int UnderlyingPx = 810;
		public const int PriceDelta = 811;
		public const int ApplQueueMax = 812;
		public const int ApplQueueDepth = 813;
		public const int ApplQueueResolution = 814;
		public const int ApplQueueAction = 815;
		public const int NoAltMDSource = 816;
		public const int AltMDSourceID = 817;
		public const int SecondaryTradeReportID = 818;
		public const int AvgPxIndicator = 819;
		public const int TradeLinkID = 820;
		public const int OrderInputDevice = 821;
		public const int UnderlyingTradingSessionID = 822;
		public const int UnderlyingTradingSessionSubID = 823;
		public const int TradeLegRefID = 824;
		public const int ExchangeRule = 825;
		public const int TradeAllocIndicator = 826;
		public const int ExpirationCycle = 827;
		public const int TrdType = 828;
		public const int TrdSubType = 829;
		public const int TransferReason = 830;
		public const int AsgnReqID = 831;
		public const int TotNumAssignmentReports = 832;
		public const int AsgnRptID = 833;
		public const int ThresholdAmount = 834;
		public const int PegMoveType = 835;
		public const int PegOffsetType = 836;
		public const int PegLimitType = 837;
		public const int PegRoundDirection = 838;
		public const int PeggedPrice = 839;
		public const int PegScope = 840;
		public const int DiscretionMoveType = 841;
		public const int DiscretionOffsetType = 842;
		public const int DiscretionLimitType = 843;
		public const int DiscretionRoundDirection = 844;
		public const int DiscretionPrice = 845;
		public const int DiscretionScope = 846;
		public const int TargetStrategy = 847;
		public const int TargetStrategyParameters = 848;
		public const int ParticipationRate = 849;
		public const int TargetStrategyPerformance = 850;
		public const int LastLiquidityInd = 851;
		public const int PublishTrdIndicator = 852;
		public const int ShortSaleReason = 853;
		public const int QtyType = 854;
		public const int SecondaryTrdType = 855;
		public const int TradeReportType = 856;
		public const int AllocNoOrdersType = 857;
		public const int SharedCommission = 858;
		public const int ConfirmReqID = 859;
		public const int AvgParPx = 860;
		public const int ReportedPx = 861;
		public const int NoCapacities = 862;
		public const int OrderCapacityQty = 863;
		public const int NoEvents = 864;
		public const int EventType = 865;
		public const int EventDate = 866;
		public const int EventPx = 867;
		public const int EventText = 868;
		public const int PctAtRisk = 869;
		public const int NoInstrAttrib = 870;
		public const int InstrAttribType = 871;
		public const int InstrAttribValue = 872;
		public const int DatedDate = 873;
		public const int InterestAccrualDate = 874;
		public const int CPProgram = 875;
		public const int CPRegType = 876;
		public const int UnderlyingCPProgram = 877;
		public const int UnderlyingCPRegType = 878;
		public const int UnderlyingQty = 879;
		public const int TrdMatchID = 880;
		public const int SecondaryTradeReportRefID = 881;
		public const int UnderlyingDirtyPrice = 882;
		public const int UnderlyingEndPrice = 883;
		public const int UnderlyingStartValue = 884;
		public const int UnderlyingCurrentValue = 885;
		public const int UnderlyingEndValue = 886;
		public const int NoUnderlyingStips = 887;
		public const int UnderlyingStipType = 888;
		public const int UnderlyingStipValue = 889;
		public const int MaturityNetMoney = 890;
		public const int MiscFeeBasis = 891;
		public const int TotNoAllocs = 892;
		public const int LastFragment = 893;
		public const int CollReqID = 894;
		public const int CollAsgnReason = 895;
		public const int CollInquiryQualifier = 896;
		public const int NoTrades = 897;
		public const int MarginRatio = 898;
		public const int MarginExcess = 899;
		public const int TotalNetValue = 900;
		public const int CashOutstanding = 901;
		public const int CollAsgnID = 902;
		public const int CollAsgnTransType = 903;
		public const int CollRespID = 904;
		public const int CollAsgnRespType = 905;
		public const int CollAsgnRejectReason = 906;
		public const int CollAsgnRefID = 907;
		public const int CollRptID = 908;
		public const int CollInquiryID = 909;
		public const int CollStatus = 910;
		public const int TotNumReports = 911;
		public const int LastRptRequested = 912;
		public const int AgreementDesc = 913;
		public const int AgreementID = 914;
		public const int AgreementDate = 915;
		public const int StartDate = 916;
		public const int EndDate = 917;
		public const int AgreementCurrency = 918;
		public const int DeliveryType = 919;
		public const int EndAccruedInterestAmt = 920;
		public const int StartCash = 921;
		public const int EndCash = 922;
		public const int UserRequestID = 923;
		public const int UserRequestType = 924;
		public const int NewPassword = 925;
		public const int UserStatus = 926;
		public const int UserStatusText = 927;
		public const int StatusValue = 928;
		public const int StatusText = 929;
		public const int RefCompID = 930;
		public const int RefSubID = 931;
		public const int NetworkResponseID = 932;
		public const int NetworkRequestID = 933;
		public const int LastNetworkResponseID = 934;
		public const int NetworkRequestType = 935;
		public const int NoCompIDs = 936;
		public const int NetworkStatusResponseType = 937;
		public const int NoCollInquiryQualifier = 938;
		public const int TrdRptStatus = 939;
		public const int AffirmStatus = 940;
		public const int UnderlyingStrikeCurrency = 941;
		public const int LegStrikeCurrency = 942;
		public const int TimeBracket = 943;
		public const int CollAction = 944;
		public const int CollInquiryStatus = 945;
		public const int CollInquiryResult = 946;
		public const int StrikeCurrency = 947;
		public const int NoNested3PartyIDs = 948;
		public const int Nested3PartyID = 949;
		public const int Nested3PartyIDSource = 950;
		public const int Nested3PartyRole = 951;
		public const int NoNested3PartySubIDs = 952;
		public const int Nested3PartySubID = 953;
		public const int Nested3PartySubIDType = 954;
		public const int LegContractSettlMonth = 955;
		public const int LegInterestAccrualDate = 956;
		public const int NoStrategyParameters = 957;
		public const int StrategyParameterName = 958;
		public const int StrategyParameterType = 959;
		public const int StrategyParameterValue = 960;
		public const int HostCrossID = 961;
		public const int SideTimeInForce = 962;
		public const int MDReportID = 963;
		public const int SecurityReportID = 964;
		public const int SecurityStatus = 965;
		public const int SettleOnOpenFlag = 966;
		public const int StrikeMultiplier = 967;
		public const int StrikeValue = 968;
		public const int MinPriceIncrement = 969;
		public const int PositionLimit = 970;
		public const int NTPositionLimit = 971;
		public const int UnderlyingAllocationPercent = 972;
		public const int UnderlyingCashAmount = 973;
		public const int UnderlyingCashType = 974;
		public const int UnderlyingSettlementType = 975;
		public const int QuantityDate = 976;
		public const int ContIntRptID = 977;
		public const int LateIndicator = 978;
		public const int InputSource = 979;
		public const int SecurityUpdateAction = 980;
		public const int NoExpiration = 981;
		public const int ExpirationQtyType = 982;
		public const int ExpQty = 983;
		public const int NoUnderlyingAmounts = 984;
		public const int UnderlyingPayAmount = 985;
		public const int UnderlyingCollectAmount = 986;
		public const int UnderlyingSettlementDate = 987;
		public const int UnderlyingSettlementStatus = 988;
		public const int SecondaryIndividualAllocID = 989;
		public const int LegReportID = 990;
		public const int RndPx = 991;
		public const int IndividualAllocType = 992;
		public const int AllocCustomerCapacity = 993;
		public const int TierCode = 994;
		public const int UnitOfMeasure = 996;
		public const int TimeUnit = 997;
		public const int UnderlyingUnitOfMeasure = 998;
		public const int LegUnitOfMeasure = 999;
		public const int UnderlyingTimeUnit = 1000;
		public const int LegTimeUnit = 1001;
		public const int AllocMethod = 1002;
		public const int TradeID = 1003;
		public const int SideTradeReportID = 1005;
		public const int SideFillStationCd = 1006;
		public const int SideReasonCd = 1007;
		public const int SideTrdSubTyp = 1008;
		public const int SideLastQty = 1009;
		public const int MessageEventSource = 1011;
		public const int SideTrdRegTimestamp = 1012;
		public const int SideTrdRegTimestampType = 1013;
		public const int SideTrdRegTimestampSrc = 1014;
		public const int AsOfIndicator = 1015;
		public const int NoSideTrdRegTS = 1016;
		public const int LegOptionRatio = 1017;
		public const int NoInstrumentParties = 1018;
		public const int InstrumentPartyID = 1019;
		public const int TradeVolume = 1020;
		public const int MDBookType = 1021;
		public const int MDFeedType = 1022;
		public const int MDPriceLevel = 1023;
		public const int MDOriginType = 1024;
		public const int FirstPx = 1025;
		public const int MDEntrySpotRate = 1026;
		public const int MDEntryForwardPoints = 1027;
		public const int ManualOrderIndicator = 1028;
		public const int CustDirectedOrder = 1029;
		public const int ReceivedDeptID = 1030;
		public const int CustOrderHandlingInst = 1031;
		public const int OrderHandlingInstSource = 1032;
		public const int DeskType = 1033;
		public const int DeskTypeSource = 1034;
		public const int DeskOrderHandlingInst = 1035;
		public const int ExecAckStatus = 1036;
		public const int UnderlyingDeliveryAmount = 1037;
		public const int UnderlyingCapValue = 1038;
		public const int UnderlyingSettlMethod = 1039;
		public const int SecondaryTradeID = 1040;
		public const int FirmTradeID = 1041;
		public const int SecondaryFirmTradeID = 1042;
		public const int CollApplType = 1043;
		public const int UnderlyingAdjustedQuantity = 1044;
		public const int UnderlyingFXRate = 1045;
		public const int UnderlyingFXRateCalc = 1046;
		public const int AllocPositionEffect = 1047;
		public const int DealingCapacity = 1048;
		public const int InstrmtAssignmentMethod = 1049;
		public const int InstrumentPartyIDSource = 1050;
		public const int InstrumentPartyRole = 1051;
		public const int NoInstrumentPartySubIDs = 1052;
		public const int InstrumentPartySubID = 1053;
		public const int InstrumentPartySubIDType = 1054;
		public const int PositionCurrency = 1055;
		public const int CalculatedCcyLastQty = 1056;
		public const int AggressorIndicator = 1057;
		public const int NoUndlyInstrumentParties = 1058;
		public const int UnderlyingInstrumentPartyID = 1059;
		public const int UnderlyingInstrumentPartyIDSource = 1060;
		public const int UnderlyingInstrumentPartyRole = 1061;
		public const int NoUndlyInstrumentPartySubIDs = 1062;
		public const int UnderlyingInstrumentPartySubID = 1063;
		public const int UnderlyingInstrumentPartySubIDType = 1064;
		public const int BidSwapPoints = 1065;
		public const int OfferSwapPoints = 1066;
		public const int LegBidForwardPoints = 1067;
		public const int LegOfferForwardPoints = 1068;
		public const int SwapPoints = 1069;
		public const int MDQuoteType = 1070;
		public const int LastSwapPoints = 1071;
		public const int SideGrossTradeAmt = 1072;
		public const int LegLastForwardPoints = 1073;
		public const int LegCalculatedCcyLastQty = 1074;
		public const int LegGrossTradeAmt = 1075;
		public const int MaturityTime = 1079;
		public const int RefOrderID = 1080;
		public const int RefOrderIDSource = 1081;
		public const int SecondaryDisplayQty = 1082;
		public const int DisplayWhen = 1083;
		public const int DisplayMethod = 1084;
		public const int DisplayLowQty = 1085;
		public const int DisplayHighQty = 1086;
		public const int DisplayMinIncr = 1087;
		public const int RefreshQty = 1088;
		public const int MatchIncrement = 1089;
		public const int MaxPriceLevels = 1090;
		public const int PreTradeAnonymity = 1091;
		public const int PriceProtectionScope = 1092;
		public const int LotType = 1093;
		public const int PegPriceType = 1094;
		public const int PeggedRefPrice = 1095;
		public const int PegSecurityIDSource = 1096;
		public const int PegSecurityID = 1097;
		public const int PegSymbol = 1098;
		public const int PegSecurityDesc = 1099;
		public const int TriggerType = 1100;
		public const int TriggerAction = 1101;
		public const int TriggerPrice = 1102;
		public const int TriggerSymbol = 1103;
		public const int TriggerSecurityID = 1104;
		public const int TriggerSecurityIDSource = 1105;
		public const int TriggerSecurityDesc = 1106;
		public const int TriggerPriceType = 1107;
		public const int TriggerPriceTypeScope = 1108;
		public const int TriggerPriceDirection = 1109;
		public const int TriggerNewPrice = 1110;
		public const int TriggerOrderType = 1111;
		public const int TriggerNewQty = 1112;
		public const int TriggerTradingSessionID = 1113;
		public const int TriggerTradingSessionSubID = 1114;
		public const int OrderCategory = 1115;
		public const int NoRootPartyIDs = 1116;
		public const int RootPartyID = 1117;
		public const int RootPartyIDSource = 1118;
		public const int RootPartyRole = 1119;
		public const int NoRootPartySubIDs = 1120;
		public const int RootPartySubID = 1121;
		public const int RootPartySubIDType = 1122;
		public const int TradeHandlingInstr = 1123;
		public const int OrigTradeHandlingInstr = 1124;
		public const int OrigTradeDate = 1125;
		public const int OrigTradeID = 1126;
		public const int OrigSecondaryTradeID = 1127;
		public const int ApplVerID = 1128;
		public const int CstmApplVerID = 1129;
		public const int RefApplVerID = 1130;
		public const int RefCstmApplVerID = 1131;
		public const int TZTransactTime = 1132;
		public const int ExDestinationIDSource = 1133;
		public const int ReportedPxDiff = 1134;
		public const int RptSys = 1135;
		public const int AllocClearingFeeIndicator = 1136;
		public const int DefaultApplVerID = 1137;
		public const int DisplayQty = 1138;
		public const int ExchangeSpecialInstructions = 1139;
		public const int MaxTradeVol = 1140;
		public const int NoMDFeedTypes = 1141;
		public const int MatchAlgorithm = 1142;
		public const int MaxPriceVariation = 1143;
		public const int ImpliedMarketIndicator = 1144;
		public const int EventTime = 1145;
		public const int MinPriceIncrementAmount = 1146;
		public const int UnitOfMeasureQty = 1147;
		public const int LowLimitPrice = 1148;
		public const int HighLimitPrice = 1149;
		public const int TradingReferencePrice = 1150;
		public const int SecurityGroup = 1151;
		public const int LegNumber = 1152;
		public const int SettlementCycleNo = 1153;
		public const int SideCurrency = 1154;
		public const int SideSettlCurrency = 1155;
		public const int ApplExtID = 1156;
		public const int CcyAmt = 1157;
		public const int NoSettlDetails = 1158;
		public const int SettlObligMode = 1159;
		public const int SettlObligMsgID = 1160;
		public const int SettlObligID = 1161;
		public const int SettlObligTransType = 1162;
		public const int SettlObligRefID = 1163;
		public const int SettlObligSource = 1164;
		public const int NoSettlOblig = 1165;
		public const int QuoteMsgID = 1166;
		public const int QuoteEntryStatus = 1167;
		public const int TotNoCxldQuotes = 1168;
		public const int TotNoAccQuotes = 1169;
		public const int TotNoRejQuotes = 1170;
		public const int PrivateQuote = 1171;
		public const int RespondentType = 1172;
		public const int MDSubBookType = 1173;
		public const int SecurityTradingEvent = 1174;
		public const int NoStatsIndicators = 1175;
		public const int StatsType = 1176;
		public const int NoOfSecSizes = 1177;
		public const int MDSecSizeType = 1178;
		public const int MDSecSize = 1179;
		public const int ApplID = 1180;
		public const int ApplSeqNum = 1181;
		public const int ApplBegSeqNum = 1182;
		public const int ApplEndSeqNum = 1183;
		public const int SecurityXMLLen = 1184;
		public const int SecurityXML = 1185;
		public const int SecurityXMLSchema = 1186;
		public const int RefreshIndicator = 1187;
		public const int Volatility = 1188;
		public const int TimeToExpiration = 1189;
		public const int RiskFreeRate = 1190;
		public const int PriceUnitOfMeasure = 1191;
		public const int PriceUnitOfMeasureQty = 1192;
		public const int SettlMethod = 1193;
		public const int ExerciseStyle = 1194;
		public const int OptPayoutAmount = 1195;
		public const int PriceQuoteMethod = 1196;
		public const int ValuationMethod = 1197;
		public const int ListMethod = 1198;
		public const int CapPrice = 1199;
		public const int FloorPrice = 1200;
		public const int NoStrikeRules = 1201;
		public const int StartStrikePxRange = 1202;
		public const int EndStrikePxRange = 1203;
		public const int StrikeIncrement = 1204;
		public const int NoTickRules = 1205;
		public const int StartTickPriceRange = 1206;
		public const int EndTickPriceRange = 1207;
		public const int TickIncrement = 1208;
		public const int TickRuleType = 1209;
		public const int NestedInstrAttribType = 1210;
		public const int NestedInstrAttribValue = 1211;
		public const int LegMaturityTime = 1212;
		public const int UnderlyingMaturityTime = 1213;
		public const int DerivativeSymbol = 1214;
		public const int DerivativeSymbolSfx = 1215;
		public const int DerivativeSecurityID = 1216;
		public const int DerivativeSecurityIDSource = 1217;
		public const int NoDerivativeSecurityAltID = 1218;
		public const int DerivativeSecurityAltID = 1219;
		public const int DerivativeSecurityAltIDSource = 1220;
		public const int SecondaryLowLimitPrice = 1221;
		public const int MaturityRuleID = 1222;
		public const int StrikeRuleID = 1223;
		public const int LegUnitOfMeasureQty = 1224;
		public const int DerivativeOptPayAmount = 1225;
		public const int EndMaturityMonthYear = 1226;
		public const int ProductComplex = 1227;
		public const int DerivativeProductComplex = 1228;
		public const int MaturityMonthYearIncrement = 1229;
		public const int SecondaryHighLimitPrice = 1230;
		public const int MinLotSize = 1231;
		public const int NoExecInstRules = 1232;
		public const int NoLotTypeRules = 1234;
		public const int NoMatchRules = 1235;
		public const int NoMaturityRules = 1236;
		public const int NoOrdTypeRules = 1237;
		public const int NoTimeInForceRules = 1239;
		public const int SecondaryTradingReferencePrice = 1240;
		public const int StartMaturityMonthYear = 1241;
		public const int FlexProductEligibilityIndicator = 1242;
		public const int DerivFlexProductEligibilityIndicator = 1243;
		public const int FlexibleIndicator = 1244;
		public const int TradingCurrency = 1245;
		public const int DerivativeProduct = 1246;
		public const int DerivativeSecurityGroup = 1247;
		public const int DerivativeCFICode = 1248;
		public const int DerivativeSecurityType = 1249;
		public const int DerivativeSecuritySubType = 1250;
		public const int DerivativeMaturityMonthYear = 1251;
		public const int DerivativeMaturityDate = 1252;
		public const int DerivativeMaturityTime = 1253;
		public const int DerivativeSettleOnOpenFlag = 1254;
		public const int DerivativeInstrmtAssignmentMethod = 1255;
		public const int DerivativeSecurityStatus = 1256;
		public const int DerivativeInstrRegistry = 1257;
		public const int DerivativeCountryOfIssue = 1258;
		public const int DerivativeStateOrProvinceOfIssue = 1259;
		public const int DerivativeLocaleOfIssue = 1260;
		public const int DerivativeStrikePrice = 1261;
		public const int DerivativeStrikeCurrency = 1262;
		public const int DerivativeStrikeMultiplier = 1263;
		public const int DerivativeStrikeValue = 1264;
		public const int DerivativeOptAttribute = 1265;
		public const int DerivativeContractMultiplier = 1266;
		public const int DerivativeMinPriceIncrement = 1267;
		public const int DerivativeMinPriceIncrementAmount = 1268;
		public const int DerivativeUnitOfMeasure = 1269;
		public const int DerivativeUnitOfMeasureQty = 1270;
		public const int DerivativeTimeUnit = 1271;
		public const int DerivativeSecurityExchange = 1272;
		public const int DerivativePositionLimit = 1273;
		public const int DerivativeNTPositionLimit = 1274;
		public const int DerivativeIssuer = 1275;
		public const int DerivativeIssueDate = 1276;
		public const int DerivativeEncodedIssuerLen = 1277;
		public const int DerivativeEncodedIssuer = 1278;
		public const int DerivativeSecurityDesc = 1279;
		public const int DerivativeEncodedSecurityDescLen = 1280;
		public const int DerivativeEncodedSecurityDesc = 1281;
		public const int DerivativeSecurityXMLLen = 1282;
		public const int DerivativeSecurityXML = 1283;
		public const int DerivativeSecurityXMLSchema = 1284;
		public const int DerivativeContractSettlMonth = 1285;
		public const int NoDerivativeEvents = 1286;
		public const int DerivativeEventType = 1287;
		public const int DerivativeEventDate = 1288;
		public const int DerivativeEventTime = 1289;
		public const int DerivativeEventPx = 1290;
		public const int DerivativeEventText = 1291;
		public const int NoDerivativeInstrumentParties = 1292;
		public const int DerivativeInstrumentPartyID = 1293;
		public const int DerivativeInstrumentPartyIDSource = 1294;
		public const int DerivativeInstrumentPartyRole = 1295;
		public const int NoDerivativeInstrumentPartySubIDs = 1296;
		public const int DerivativeInstrumentPartySubID = 1297;
		public const int DerivativeInstrumentPartySubIDType = 1298;
		public const int DerivativeExerciseStyle = 1299;
		public const int MarketSegmentID = 1300;
		public const int MarketID = 1301;
		public const int MaturityMonthYearIncrementUnits = 1302;
		public const int MaturityMonthYearFormat = 1303;
		public const int StrikeExerciseStyle = 1304;
		public const int SecondaryPriceLimitType = 1305;
		public const int PriceLimitType = 1306;
		public const int DerivativeSecurityListRequestType = 1307;
		public const int ExecInstValue = 1308;
		public const int NoTradingSessionRules = 1309;
		public const int NoMarketSegments = 1310;
		public const int NoDerivativeInstrAttrib = 1311;
		public const int NoNestedInstrAttrib = 1312;
		public const int DerivativeInstrAttribType = 1313;
		public const int DerivativeInstrAttribValue = 1314;
		public const int DerivativePriceUnitOfMeasure = 1315;
		public const int DerivativePriceUnitOfMeasureQty = 1316;
		public const int DerivativeSettlMethod = 1317;
		public const int DerivativePriceQuoteMethod = 1318;
		public const int DerivativeValuationMethod = 1319;
		public const int DerivativeListMethod = 1320;
		public const int DerivativeCapPrice = 1321;
		public const int DerivativeFloorPrice = 1322;
		public const int DerivativePutOrCall = 1323;
		public const int ListUpdateAction = 1324;
		public const int ParentMktSegmID = 1325;
		public const int TradingSessionDesc = 1326;
		public const int TradSesUpdateAction = 1327;
		public const int RejectText = 1328;
		public const int FeeMultiplier = 1329;
		public const int UnderlyingLegSymbol = 1330;
		public const int UnderlyingLegSymbolSfx = 1331;
		public const int UnderlyingLegSecurityID = 1332;
		public const int UnderlyingLegSecurityIDSource = 1333;
		public const int NoUnderlyingLegSecurityAltID = 1334;
		public const int UnderlyingLegSecurityAltID = 1335;
		public const int UnderlyingLegSecurityAltIDSource = 1336;
		public const int UnderlyingLegSecurityType = 1337;
		public const int UnderlyingLegSecuritySubType = 1338;
		public const int UnderlyingLegMaturityMonthYear = 1339;
		public const int UnderlyingLegStrikePrice = 1340;
		public const int UnderlyingLegSecurityExchange = 1341;
		public const int NoOfLegUnderlyings = 1342;
		public const int UnderlyingLegPutOrCall = 1343;
		public const int UnderlyingLegCFICode = 1344;
		public const int UnderlyingLegMaturityDate = 1345;
		public const int ApplReqID = 1346;
		public const int ApplReqType = 1347;
		public const int ApplResponseType = 1348;
		public const int ApplTotalMessageCount = 1349;
		public const int ApplLastSeqNum = 1350;
		public const int NoApplIDs = 1351;
		public const int ApplResendFlag = 1352;
		public const int ApplResponseID = 1353;
		public const int ApplResponseError = 1354;
		public const int RefApplID = 1355;
		public const int ApplReportID = 1356;
		public const int RefApplLastSeqNum = 1357;
		public const int LegPutOrCall = 1358;
		public const int EncodedSymbolLen = 1359;
		public const int EncodedSymbol = 1360;
		public const int TotNoFills = 1361;
		public const int NoFills = 1362;
		public const int FillExecID = 1363;
		public const int FillPx = 1364;
		public const int FillQty = 1365;
		public const int LegAllocID = 1366;
		public const int LegAllocSettlCurrency = 1367;
		public const int TradSesEvent = 1368;
		public const int MassActionReportID = 1369;
		public const int NoNotAffectedOrders = 1370;
		public const int NotAffectedOrderID = 1371;
		public const int NotAffOrigClOrdID = 1372;
		public const int MassActionType = 1373;
		public const int MassActionScope = 1374;
		public const int MassActionResponse = 1375;
		public const int MassActionRejectReason = 1376;
		public const int MultilegModel = 1377;
		public const int MultilegPriceMethod = 1378;
		public const int LegVolatility = 1379;
		public const int DividendYield = 1380;
		public const int LegDividendYield = 1381;
		public const int CurrencyRatio = 1382;
		public const int LegCurrencyRatio = 1383;
		public const int LegExecInst = 1384;
		public const int ContingencyType = 1385;
		public const int ListRejectReason = 1386;
		public const int NoTrdRepIndicators = 1387;
		public const int TrdRepPartyRole = 1388;
		public const int TrdRepIndicator = 1389;
		public const int TradePublishIndicator = 1390;
		public const int UnderlyingLegOptAttribute = 1391;
		public const int UnderlyingLegSecurityDesc = 1392;
		public const int MarketReqID = 1393;
		public const int MarketReportID = 1394;
		public const int MarketUpdateAction = 1395;
		public const int MarketSegmentDesc = 1396;
		public const int EncodedMktSegmDescLen = 1397;
		public const int EncodedMktSegmDesc = 1398;
		public const int ApplNewSeqNum = 1399;
		public const int EncryptedPasswordMethod = 1400;
		public const int EncryptedPasswordLen = 1401;
		public const int EncryptedPassword = 1402;
		public const int EncryptedNewPasswordLen = 1403;
		public const int EncryptedNewPassword = 1404;
		public const int UnderlyingLegMaturityTime = 1405;
		public const int RefApplExtID = 1406;
		public const int DefaultApplExtID = 1407;
		public const int DefaultCstmApplVerID = 1408;
		public const int SessionStatus = 1409;
		public const int DefaultVerIndicator = 1410;
		public const int Nested4PartySubIDType = 1411;
		public const int Nested4PartySubID = 1412;
		public const int NoNested4PartySubIDs = 1413;
		public const int NoNested4PartyIDs = 1414;
		public const int Nested4PartyID = 1415;
		public const int Nested4PartyIDSource = 1416;
		public const int Nested4PartyRole = 1417;
		public const int LegLastQty = 1418;
		public const int UnderlyingExerciseStyle = 1419;
		public const int LegExerciseStyle = 1420;
		public const int LegPriceUnitOfMeasure = 1421;
		public const int LegPriceUnitOfMeasureQty = 1422;
		public const int UnderlyingUnitOfMeasureQty = 1423;
		public const int UnderlyingPriceUnitOfMeasure = 1424;
		public const int UnderlyingPriceUnitOfMeasureQty = 1425;
		public const int ApplReportType = 1426;
		public const int SideExecID = 1427;
		public const int OrderDelay = 1428;
		public const int OrderDelayUnit = 1429;
		public const int VenueType = 1430;
		public const int RefOrdIDReason = 1431;
		public const int OrigCustOrderCapacity = 1432;
		public const int RefApplReqID = 1433;
		public const int ModelType = 1434;
		public const int ContractMultiplierUnit = 1435;
		public const int LegContractMultiplierUnit = 1436;
		public const int UnderlyingContractMultiplierUnit = 1437;
		public const int DerivativeContractMultiplierUnit = 1438;
		public const int FlowScheduleType = 1439;
		public const int LegFlowScheduleType = 1440;
		public const int UnderlyingFlowScheduleType = 1441;
		public const int DerivativeFlowScheduleType = 1442;
		public const int FillLiquidityInd = 1443;
		public const int SideLiquidityInd = 1444;
		public const int NoRateSources = 1445;
		public const int RateSource = 1446;
		public const int RateSourceType = 1447;
		public const int ReferencePage = 1448;
		public const int RestructuringType = 1449;
		public const int Seniority = 1450;
		public const int NotionalPercentageOutstanding = 1451;
		public const int OriginalNotionalPercentageOutstanding = 1452;
		public const int UnderlyingRestructuringType = 1453;
		public const int UnderlyingSeniority = 1454;
		public const int UnderlyingNotionalPercentageOutstanding = 1455;
		public const int UnderlyingOriginalNotionalPercentageOutstanding = 1456;
		public const int AttachmentPoint = 1457;
		public const int DetachmentPoint = 1458;
		public const int UnderlyingAttachmentPoint = 1459;
		public const int UnderlyingDetachmentPoint = 1460;
		public const int NoTargetPartyIDs = 1461;
		public const int TargetPartyID = 1462;
		public const int TargetPartyIDSource = 1463;
		public const int TargetPartyRole = 1464;
		public const int SecurityListID = 1465;
		public const int SecurityListRefID = 1466;
		public const int SecurityListDesc = 1467;
		public const int EncodedSecurityListDescLen = 1468;
		public const int EncodedSecurityListDesc = 1469;
		public const int SecurityListType = 1470;
		public const int SecurityListTypeSource = 1471;
		public const int NewsID = 1472;
		public const int NewsCategory = 1473;
		public const int LanguageCode = 1474;
		public const int NoNewsRefIDs = 1475;
		public const int NewsRefID = 1476;
		public const int NewsRefType = 1477;
		public const int StrikePriceDeterminationMethod = 1478;
		public const int StrikePriceBoundaryMethod = 1479;
		public const int StrikePriceBoundaryPrecision = 1480;
		public const int UnderlyingPriceDeterminationMethod = 1481;
		public const int OptPayoutType = 1482;
		public const int NoComplexEvents = 1483;
		public const int ComplexEventType = 1484;
		public const int ComplexOptPayoutAmount = 1485;
		public const int ComplexEventPrice = 1486;
		public const int ComplexEventPriceBoundaryMethod = 1487;
		public const int ComplexEventPriceBoundaryPrecision = 1488;
		public const int ComplexEventPriceTimeType = 1489;
		public const int ComplexEventCondition = 1490;
		public const int NoComplexEventDates = 1491;
		public const int ComplexEventStartDate = 1492;
		public const int ComplexEventEndDate = 1493;
		public const int NoComplexEventTimes = 1494;
		public const int ComplexEventStartTime = 1495;
		public const int ComplexEventEndTime = 1496;
		public const int StreamAsgnReqID = 1497;
		public const int StreamAsgnReqType = 1498;
		public const int NoAsgnReqs = 1499;
		public const int MDStreamID = 1500;
		public const int StreamAsgnRptID = 1501;
		public const int StreamAsgnRejReason = 1502;
		public const int StreamAsgnAckType = 1503;
		public const int RelSymTransactTime = 1504;
		public const int PartyDetailsListRequestID = 1505;
		public const int NoPartyListResponseTypes = 1506;
		public const int PartyListResponseType = 1507;
		public const int NoRequestedPartyRoles = 1508;
		public const int RequestedPartyRole = 1509;
		public const int PartyDetailsListReportID = 1510;
		public const int PartyDetailsRequestResult = 1511;
		public const int TotNoPartyList = 1512;
		public const int NoPartyList = 1513;
		public const int NoPartyRelationships = 1514;
		public const int PartyRelationship = 1515;
		public const int NoPartyAltIDs = 1516;
		public const int PartyAltID = 1517;
		public const int PartyAltIDSource = 1518;
		public const int NoPartyAltSubIDs = 1519;
		public const int PartyAltSubID = 1520;
		public const int PartyAltSubIDType = 1521;
		public const int NoContextPartyIDs = 1522;
		public const int ContextPartyID = 1523;
		public const int ContextPartyIDSource = 1524;
		public const int ContextPartyRole = 1525;
		public const int NoContextPartySubIDs = 1526;
		public const int ContextPartySubID = 1527;
		public const int ContextPartySubIDType = 1528;
		public const int NoRiskLimits = 1529;
		public const int RiskLimitType = 1530;
		public const int RiskLimitAmount = 1531;
		public const int RiskLimitCurrency = 1532;
		public const int RiskLimitPlatform = 1533;
		public const int NoRiskInstruments = 1534;
		public const int RiskInstrumentOperator = 1535;
		public const int RiskSymbol = 1536;
		public const int RiskSymbolSfx = 1537;
		public const int RiskSecurityID = 1538;
		public const int RiskSecurityIDSource = 1539;
		public const int NoRiskSecurityAltID = 1540;
		public const int RiskSecurityAltID = 1541;
		public const int RiskSecurityAltIDSource = 1542;
		public const int RiskProduct = 1543;
		public const int RiskProductComplex = 1544;
		public const int RiskSecurityGroup = 1545;
		public const int RiskCFICode = 1546;
		public const int RiskSecurityType = 1547;
		public const int RiskSecuritySubType = 1548;
		public const int RiskMaturityMonthYear = 1549;
		public const int RiskMaturityTime = 1550;
		public const int RiskRestructuringType = 1551;
		public const int RiskSeniority = 1552;
		public const int RiskPutOrCall = 1553;
		public const int RiskFlexibleIndicator = 1554;
		public const int RiskCouponRate = 1555;
		public const int RiskSecurityDesc = 1556;
		public const int RiskInstrumentSettlType = 1557;
		public const int RiskInstrumentMultiplier = 1558;
		public const int NoRiskWarningLevels = 1559;
		public const int RiskWarningLevelPercent = 1560;
		public const int RiskWarningLevelName = 1561;
		public const int NoRelatedPartyIDs = 1562;
		public const int RelatedPartyID = 1563;
		public const int RelatedPartyIDSource = 1564;
		public const int RelatedPartyRole = 1565;
		public const int NoRelatedPartySubIDs = 1566;
		public const int RelatedPartySubID = 1567;
		public const int RelatedPartySubIDType = 1568;
		public const int NoRelatedPartyAltIDs = 1569;
		public const int RelatedPartyAltID = 1570;
		public const int RelatedPartyAltIDSource = 1571;
		public const int NoRelatedPartyAltSubIDs = 1572;
		public const int RelatedPartyAltSubID = 1573;
		public const int RelatedPartyAltSubIDType = 1574;
		public const int NoRelatedContextPartyIDs = 1575;
		public const int RelatedContextPartyID = 1576;
		public const int RelatedContextPartyIDSource = 1577;
		public const int RelatedContextPartyRole = 1578;
		public const int NoRelatedContextPartySubIDs = 1579;
		public const int RelatedContextPartySubID = 1580;
		public const int RelatedContextPartySubIDType = 1581;
		public const int NoRelationshipRiskLimits = 1582;
		public const int RelationshipRiskLimitType = 1583;
		public const int RelationshipRiskLimitAmount = 1584;
		public const int RelationshipRiskLimitCurrency = 1585;
		public const int RelationshipRiskLimitPlatform = 1586;
		public const int NoRelationshipRiskInstruments = 1587;
		public const int RelationshipRiskInstrumentOperator = 1588;
		public const int RelationshipRiskSymbol = 1589;
		public const int RelationshipRiskSymbolSfx = 1590;
		public const int RelationshipRiskSecurityID = 1591;
		public const int RelationshipRiskSecurityIDSource = 1592;
		public const int NoRelationshipRiskSecurityAltID = 1593;
		public const int RelationshipRiskSecurityAltID = 1594;
		public const int RelationshipRiskSecurityAltIDSource = 1595;
		public const int RelationshipRiskProduct = 1596;
		public const int RelationshipRiskProductComplex = 1597;
		public const int RelationshipRiskSecurityGroup = 1598;
		public const int RelationshipRiskCFICode = 1599;
		public const int RelationshipRiskSecurityType = 1600;
		public const int RelationshipRiskSecuritySubType = 1601;
		public const int RelationshipRiskMaturityMonthYear = 1602;
		public const int RelationshipRiskMaturityTime = 1603;
		public const int RelationshipRiskRestructuringType = 1604;
		public const int RelationshipRiskSeniority = 1605;
		public const int RelationshipRiskPutOrCall = 1606;
		public const int RelationshipRiskFlexibleIndicator = 1607;
		public const int RelationshipRiskCouponRate = 1608;
		public const int RelationshipRiskSecurityExchange = 1609;
		public const int RelationshipRiskSecurityDesc = 1610;
		public const int RelationshipRiskInstrumentSettlType = 1611;
		public const int RelationshipRiskInstrumentMultiplier = 1612;
		public const int NoRelationshipRiskWarningLevels = 1613;
		public const int RelationshipRiskWarningLevelPercent = 1614;
		public const int RelationshipRiskWarningLevelName = 1615;
		public const int RiskSecurityExchange = 1616;
		public const int StreamAsgnType = 1617;
		public const int RelationshipRiskEncodedSecurityDescLen = 1618;
		public const int RelationshipRiskEncodedSecurityDesc = 1619;
		public const int RiskEncodedSecurityDescLen = 1620;
		public const int RiskEncodedSecurityDesc = 1621;
		public const int IndustryCode = 10100;
		public const int IndustrySector = 10101;
		public const int IndustryGroup = 10102;
		public const int IndustrySubGroup = 10103;
		public const int CorporateActionType = 10200;
		public const int DeclaredDate = 10201;
		public const int RecordDate = 10202;
		public const int PayDate = 10203;
		public const int DividendType = 10204;
		public const int SplitType = 10205;
		public const int RightsIssueType = 10206;
		public const int NetAmount = 10207;
		public const int GrossAmount = 10208;
		public const int Ratio = 10209;
		public const int Percent = 10210;
		public const int AdjustmentFactor = 10211;
		public const int EarningsPerShare = 10300;
		public const int BookValuePerShare = 10301;
		public const int CashPerShare = 10302;
		public const int RevenuePerShare = 10303;
		public const int DebtPerShare = 10304;
		public const int CashFlowPerShare = 10305;
		public const int InterestPaymentPerShare = 10306;
		public const int Strategy = 11100;
		public const int StrategyComponent = 11101;
		public const int StrategyPrice = 11102;
		public const int StrategyFill = 11103;
		public const int StrategyMode = 11104;
		public const int ForceMarketOrder = 11200;
		public const int FillOnBarMode = 11201;
		public const int TickSize = 10400;
		public const int PriceDisplay = 11105;
		public const int OCAGroup = 10500;
		public const int SecurityAltExchange = 12100;
		public const int Margin = 10600;
		public const int Hidden = 10700;
		public const int TrailingAmt = 10701;
		public const int DisplaySize = 10702;
		public const int FaMethod = 10710;
		public const int FaGroup = 10711;
		public const int FaProfile = 10712;
		public const int FaPercentage = 10713;
		public const int OrderRef = 10714;
		public const int ExpireSeconds = 7558;
		public const int TTManualOrderIndicator = 11028;
		public const int FFT2 = 16102;
		public const int FFT3 = 16103;
		public const int OrderOriginationID = 16142;
		public const int TTAccountType = 18205;
		public const int ClientOrderRefID = 10800;
		public const int Route = 10900;
		public const int TradeVolumeDelay = 11000;

		public static string ToString(int tag)
		{
			switch (tag)
			{
				case 16102:
					return "FFT2";
				case 16103:
					return "FFT3";
				case 16142:
					return "OrderOriginationID";
				case 18205:
					return "TTAccountType";
				case 11200:
					return "ForceMarketOrder";
				case 11201:
					return "FillOnBarMode";
				case 12100:
					return "SecurityAltExchange";
				case 11028:
					return "TTManualOrderIndicator";
				case 11100:
					return "Strategy";
				case 11101:
					return "StrategyComponent";
				case 11102:
					return "StrategyPrice";
				case 11103:
					return "StrategyFill";
				case 11104:
					return "StrategyMode";
				case 11105:
					return "PriceDisplay";
				case 10900:
					return "Route";
				case 11000:
					return "TradeVolumeDelay";
				case 10500:
					return "OCAGroup";
				case 10600:
					return "Margin";
				case 10700:
					return "Hidden";
				case 10701:
					return "TrailingAmt";
				case 10702:
					return "DisplaySize";
				case 10710:
					return "FaMethod";
				case 10711:
					return "FaGroup";
				case 10712:
					return "FaProfile";
				case 10713:
					return "FaPercentage";
				case 10714:
					return "OrderRef";
				case 10300:
					return "EarningsPerShare";
				case 10301:
					return "BookValuePerShare";
				case 10302:
					return "CashPerShare";
				case 10303:
					return "RevenuePerShare";
				case 10304:
					return "DebtPerShare";
				case 10305:
					return "CashFlowPerShare";
				case 10306:
					return "InterestPaymentPerShare";
				case 10400:
					return "TickSize";
				case 10100:
					return "IndustryCode";
				case 10101:
					return "IndustrySector";
				case 10102:
					return "IndustryGroup";
				case 10103:
					return "IndustrySubGroup";
				case 10200:
					return "CorporateActionType";
				case 10201:
					return "DeclaredDate";
				case 10202:
					return "RecordDate";
				case 10203:
					return "PayDate";
				case 10204:
					return "DividendType";
				case 10205:
					return "SplitType";
				case 10206:
					return "RightsIssueType";
				case 10207:
					return "NetAmount";
				case 10208:
					return "GrossAmount";
				case 10209:
					return "Ratio";
				case 10210:
					return "Percent";
				case 10211:
					return "AdjustmentFactor";
				case  1:
					return "Account";
				case  2:
					return "AdvId";
				case  3:
					return "AdvRefID";
				case  4:
					return "AdvSide";
				case  5:
					return "AdvTransType";
				case  6:
					return "AvgPx";
				case  7:
					return "BeginSeqNo";
				case  8:
					return "BeginString";
				case  9:
					return "BodyLength";
				case  10:
					return "CheckSum";
				case  11:
					return "ClOrdID";
				case  12:
					return "Commission";
				case  13:
					return "CommType";
				case  14:
					return "CumQty";
				case  15:
					return "Currency";
				case  16:
					return "EndSeqNo";
				case  17:
					return "ExecID";
				case  18:
					return "ExecInst";
				case  19:
					return "ExecRefID";
				case  20:
					return "ExecTransType";
				case  21:
					return "HandlInst";
				case  22:
					return "SecurityIDSource";
				case  23:
					return "IOIID";
				case  24:
					return "IOIOthSvc";
				case  25:
					return "IOIQltyInd";
				case  26:
					return "IOIRefID";
				case  27:
					return "IOIQty";
				case  28:
					return "IOITransType";
				case  29:
					return "LastCapacity";
				case  30:
					return "LastMkt";
				case  31:
					return "LastPx";
				case  32:
					return "LastQty";
				case  33:
					return "NoLinesOfText";
				case  34:
					return "MsgSeqNum";
				case  35:
					return "MsgType";
				case  36:
					return "NewSeqNo";
				case  37:
					return "OrderID";
				case  38:
					return "OrderQty";
				case  39:
					return "OrdStatus";
				case  40:
					return "OrdType";
				case  41:
					return "OrigClOrdID";
				case  42:
					return "OrigTime";
				case  43:
					return "PossDupFlag";
				case  44:
					return "Price";
				case  45:
					return "RefSeqNum";
				case  46:
					return "RelatdSym";
				case  47:
					return "Rule80A";
				case  48:
					return "SecurityID";
				case  49:
					return "SenderCompID";
				case  50:
					return "SenderSubID";
				case  51:
					return "SendingDate";
				case  52:
					return "SendingTime";
				case  53:
					return "Quantity";
				case  54:
					return "Side";
				case  55:
					return "Symbol";
				case  56:
					return "TargetCompID";
				case  57:
					return "TargetSubID";
				case  58:
					return "Text";
				case  59:
					return "TimeInForce";
				case  60:
					return "TransactTime";
				case  61:
					return "Urgency";
				case  62:
					return "ValidUntilTime";
				case  63:
					return "SettlType";
				case  64:
					return "SettlDate";
				case  65:
					return "SymbolSfx";
				case  66:
					return "ListID";
				case  67:
					return "ListSeqNo";
				case  68:
					return "TotNoOrders";
				case  69:
					return "ListExecInst";
				case  70:
					return "AllocID";
				case  71:
					return "AllocTransType";
				case  72:
					return "RefAllocID";
				case  73:
					return "NoOrders";
				case  74:
					return "AvgPxPrecision";
				case  75:
					return "TradeDate";
				case  76:
					return "ExecBroker";
				case  77:
					return "PositionEffect";
				case  78:
					return "NoAllocs";
				case  79:
					return "AllocAccount";
				case  80:
					return "AllocQty";
				case  81:
					return "ProcessCode";
				case  82:
					return "NoRpts";
				case  83:
					return "RptSeq";
				case  84:
					return "CxlQty";
				case  85:
					return "NoDlvyInst";
				case  86:
					return "DlvyInst";
				case  87:
					return "AllocStatus";
				case  88:
					return "AllocRejCode";
				case  89:
					return "Signature";
				case  90:
					return "SecureDataLen";
				case  91:
					return "SecureData";
				case  92:
					return "BrokerOfCredit";
				case  93:
					return "SignatureLength";
				case  94:
					return "EmailType";
				case  95:
					return "RawDataLength";
				case  96:
					return "RawData";
				case  97:
					return "PossResend";
				case  98:
					return "EncryptMethod";
				case  99:
					return "StopPx";
				case  100:
					return "ExDestination";
				case  102:
					return "CxlRejReason";
				case  103:
					return "OrdRejReason";
				case  104:
					return "IOIQualifier";
				case  105:
					return "WaveNo";
				case  106:
					return "Issuer";
				case  107:
					return "SecurityDesc";
				case  108:
					return "HeartBtInt";
				case  109:
					return "ClientID";
				case  110:
					return "MinQty";
				case  111:
					return "MaxFloor";
				case  112:
					return "TestReqID";
				case  113:
					return "ReportToExch";
				case  114:
					return "LocateReqd";
				case  115:
					return "OnBehalfOfCompID";
				case  116:
					return "OnBehalfOfSubID";
				case  117:
					return "QuoteID";
				case  118:
					return "NetMoney";
				case  119:
					return "SettlCurrAmt";
				case  120:
					return "SettlCurrency";
				case  121:
					return "ForexReq";
				case  122:
					return "OrigSendingTime";
				case  123:
					return "GapFillFlag";
				case  124:
					return "NoExecs";
				case  125:
					return "CxlType";
				case  126:
					return "ExpireTime";
				case  127:
					return "DKReason";
				case  128:
					return "DeliverToCompID";
				case  129:
					return "DeliverToSubID";
				case  130:
					return "IOINaturalFlag";
				case  131:
					return "QuoteReqID";
				case  132:
					return "BidPx";
				case  133:
					return "OfferPx";
				case  134:
					return "BidSize";
				case  135:
					return "OfferSize";
				case  136:
					return "NoMiscFees";
				case  137:
					return "MiscFeeAmt";
				case  138:
					return "MiscFeeCurr";
				case  139:
					return "MiscFeeType";
				case  140:
					return "PrevClosePx";
				case  141:
					return "ResetSeqNumFlag";
				case  142:
					return "SenderLocationID";
				case  143:
					return "TargetLocationID";
				case  144:
					return "OnBehalfOfLocationID";
				case  145:
					return "DeliverToLocationID";
				case  146:
					return "NoRelatedSym";
				case  147:
					return "Subject";
				case  148:
					return "Headline";
				case  149:
					return "URLLink";
				case  150:
					return "ExecType";
				case  151:
					return "LeavesQty";
				case  152:
					return "CashOrderQty";
				case  153:
					return "AllocAvgPx";
				case  154:
					return "AllocNetMoney";
				case  155:
					return "SettlCurrFxRate";
				case  156:
					return "SettlCurrFxRateCalc";
				case  157:
					return "NumDaysInterest";
				case  158:
					return "AccruedInterestRate";
				case  159:
					return "AccruedInterestAmt";
				case  160:
					return "SettlInstMode";
				case  161:
					return "AllocText";
				case  162:
					return "SettlInstID";
				case  163:
					return "SettlInstTransType";
				case  164:
					return "EmailThreadID";
				case  165:
					return "SettlInstSource";
				case  166:
					return "SettlLocation";
				case  167:
					return "SecurityType";
				case  168:
					return "EffectiveTime";
				case  169:
					return "StandInstDbType";
				case  170:
					return "StandInstDbName";
				case  171:
					return "StandInstDbID";
				case  172:
					return "SettlDeliveryType";
				case  173:
					return "SettlDepositoryCode ";
				case  174:
					return "SettlBrkrCode ";
				case  175:
					return "SettlInstCode ";
				case  176:
					return "SecuritySettlAgentName";
				case  177:
					return "SecuritySettlAgentCode";
				case  178:
					return "SecuritySettlAgentAcctNum";
				case  179:
					return "SecuritySettlAgentAcctName";
				case  180:
					return "SecuritySettlAgentContactName";
				case  181:
					return "SecuritySettlAgentContactPhone";
				case  182:
					return "CashSettlAgentName";
				case  183:
					return "CashSettlAgentCode";
				case  184:
					return "CashSettlAgentAcctNum";
				case  185:
					return "CashSettlAgentAcctName";
				case  186:
					return "CashSettlAgentContactName";
				case  187:
					return "CashSettlAgentContactPhone";
				case  188:
					return "BidSpotRate";
				case  189:
					return "BidForwardPoints";
				case  190:
					return "OfferSpotRate";
				case  191:
					return "OfferForwardPoints";
				case  192:
					return "OrderQty2";
				case  193:
					return "SettlDate2";
				case  194:
					return "LastSpotRate";
				case  195:
					return "LastForwardPoints";
				case  196:
					return "AllocLinkID";
				case  197:
					return "AllocLinkType";
				case  198:
					return "SecondaryOrderID";
				case  199:
					return "NoIOIQualifiers";
				case  200:
					return "MaturityMonthYear";
				case  201:
					return "PutOrCall";
				case  202:
					return "StrikePrice";
				case  203:
					return "CoveredOrUncovered";
				case  204:
					return "CustomerOrFirm";
				case  205:
					return "MaturityDay";
				case  206:
					return "OptAttribute";
				case  207:
					return "SecurityExchange";
				case  208:
					return "NotifyBrokerOfCredit";
				case  209:
					return "AllocHandlInst";
				case  210:
					return "MaxShow";
				case  211:
					return "PegOffsetValue";
				case  212:
					return "XmlDataLen";
				case  213:
					return "XmlData";
				case  214:
					return "SettlInstRefID";
				case  215:
					return "NoRoutingIDs";
				case  216:
					return "RoutingType";
				case  217:
					return "RoutingID";
				case  218:
					return "Spread";
				case  219:
					return "Benchmark";
				case  220:
					return "BenchmarkCurveCurrency";
				case  221:
					return "BenchmarkCurveName";
				case  222:
					return "BenchmarkCurvePoint";
				case  223:
					return "CouponRate";
				case  224:
					return "CouponPaymentDate";
				case  225:
					return "IssueDate";
				case  226:
					return "RepurchaseTerm";
				case  227:
					return "RepurchaseRate";
				case  228:
					return "Factor";
				case  229:
					return "TradeOriginationDate";
				case  230:
					return "ExDate";
				case  231:
					return "ContractMultiplier";
				case  232:
					return "NoStipulations";
				case  233:
					return "StipulationType";
				case  234:
					return "StipulationValue";
				case  235:
					return "YieldType";
				case  236:
					return "Yield";
				case  237:
					return "TotalTakedown";
				case  238:
					return "Concession";
				case  239:
					return "RepoCollateralSecurityType";
				case  240:
					return "RedemptionDate";
				case  241:
					return "UnderlyingCouponPaymentDate";
				case  242:
					return "UnderlyingIssueDate";
				case  243:
					return "UnderlyingRepoCollateralSecurityType";
				case  244:
					return "UnderlyingRepurchaseTerm";
				case  245:
					return "UnderlyingRepurchaseRate";
				case  246:
					return "UnderlyingFactor";
				case  247:
					return "UnderlyingRedemptionDate";
				case  248:
					return "LegCouponPaymentDate";
				case  249:
					return "LegIssueDate";
				case  250:
					return "LegRepoCollateralSecurityType";
				case  251:
					return "LegRepurchaseTerm";
				case  252:
					return "LegRepurchaseRate";
				case  253:
					return "LegFactor";
				case  254:
					return "LegRedemptionDate";
				case  255:
					return "CreditRating";
				case  256:
					return "UnderlyingCreditRating";
				case  257:
					return "LegCreditRating";
				case  258:
					return "TradedFlatSwitch";
				case  259:
					return "BasisFeatureDate";
				case  260:
					return "BasisFeaturePrice";
				case  261:
					return "Reserved";
				case  262:
					return "MDReqID";
				case  263:
					return "SubscriptionRequestType";
				case  264:
					return "MarketDepth";
				case  265:
					return "MDUpdateType";
				case  266:
					return "AggregatedBook";
				case  267:
					return "NoMDEntryTypes";
				case  268:
					return "NoMDEntries";
				case  269:
					return "MDEntryType";
				case  270:
					return "MDEntryPx";
				case  271:
					return "MDEntrySize";
				case  272:
					return "MDEntryDate";
				case  273:
					return "MDEntryTime";
				case  274:
					return "TickDirection";
				case  275:
					return "MDMkt";
				case  276:
					return "QuoteCondition";
				case  277:
					return "TradeCondition";
				case  278:
					return "MDEntryID";
				case  279:
					return "MDUpdateAction";
				case  280:
					return "MDEntryRefID";
				case  281:
					return "MDReqRejReason";
				case  282:
					return "MDEntryOriginator";
				case  283:
					return "LocationID";
				case  284:
					return "DeskID";
				case  285:
					return "DeleteReason";
				case  286:
					return "OpenCloseSettlFlag";
				case  287:
					return "SellerDays";
				case  288:
					return "MDEntryBuyer";
				case  289:
					return "MDEntrySeller";
				case  290:
					return "MDEntryPositionNo";
				case  291:
					return "FinancialStatus";
				case  292:
					return "CorporateAction";
				case  293:
					return "DefBidSize";
				case  294:
					return "DefOfferSize";
				case  295:
					return "NoQuoteEntries";
				case  296:
					return "NoQuoteSets";
				case  297:
					return "QuoteStatus";
				case  298:
					return "QuoteCancelType";
				case  299:
					return "QuoteEntryID";
				case  300:
					return "QuoteRejectReason";
				case  301:
					return "QuoteResponseLevel";
				case  302:
					return "QuoteSetID";
				case  303:
					return "QuoteRequestType";
				case  304:
					return "TotNoQuoteEntries";
				case  305:
					return "UnderlyingSecurityIDSource";
				case  306:
					return "UnderlyingIssuer";
				case  307:
					return "UnderlyingSecurityDesc";
				case  308:
					return "UnderlyingSecurityExchange";
				case  309:
					return "UnderlyingSecurityID";
				case  310:
					return "UnderlyingSecurityType";
				case  311:
					return "UnderlyingSymbol";
				case  312:
					return "UnderlyingSymbolSfx";
				case  313:
					return "UnderlyingMaturityMonthYear";
				case  314:
					return "UnderlyingMaturityDay";
				case  315:
					return "UnderlyingPutOrCall";
				case  316:
					return "UnderlyingStrikePrice";
				case  317:
					return "UnderlyingOptAttribute";
				case  318:
					return "UnderlyingCurrency";
				case  319:
					return "RatioQty";
				case  320:
					return "SecurityReqID";
				case  321:
					return "SecurityRequestType";
				case  322:
					return "SecurityResponseID";
				case  323:
					return "SecurityResponseType";
				case  324:
					return "SecurityStatusReqID";
				case  325:
					return "UnsolicitedIndicator";
				case  326:
					return "SecurityTradingStatus";
				case  327:
					return "HaltReason";
				case  328:
					return "InViewOfCommon";
				case  329:
					return "DueToRelated";
				case  330:
					return "BuyVolume";
				case  331:
					return "SellVolume";
				case  332:
					return "HighPx";
				case  333:
					return "LowPx";
				case  334:
					return "Adjustment";
				case  335:
					return "TradSesReqID";
				case  336:
					return "TradingSessionID";
				case  337:
					return "ContraTrader";
				case  338:
					return "TradSesMethod";
				case  339:
					return "TradSesMode";
				case  340:
					return "TradSesStatus";
				case  341:
					return "TradSesStartTime";
				case  342:
					return "TradSesOpenTime";
				case  343:
					return "TradSesPreCloseTime";
				case  344:
					return "TradSesCloseTime";
				case  345:
					return "TradSesEndTime";
				case  346:
					return "NumberOfOrders";
				case  347:
					return "MessageEncoding";
				case  348:
					return "EncodedIssuerLen";
				case  349:
					return "EncodedIssuer";
				case  350:
					return "EncodedSecurityDescLen";
				case  351:
					return "EncodedSecurityDesc";
				case  352:
					return "EncodedListExecInstLen";
				case  353:
					return "EncodedListExecInst";
				case  354:
					return "EncodedTextLen";
				case  355:
					return "EncodedText";
				case  356:
					return "EncodedSubjectLen";
				case  357:
					return "EncodedSubject";
				case  358:
					return "EncodedHeadlineLen";
				case  359:
					return "EncodedHeadline";
				case  360:
					return "EncodedAllocTextLen";
				case  361:
					return "EncodedAllocText";
				case  362:
					return "EncodedUnderlyingIssuerLen";
				case  363:
					return "EncodedUnderlyingIssuer";
				case  364:
					return "EncodedUnderlyingSecurityDescLen";
				case  365:
					return "EncodedUnderlyingSecurityDesc";
				case  366:
					return "AllocPrice";
				case  367:
					return "QuoteSetValidUntilTime";
				case  368:
					return "QuoteEntryRejectReason";
				case  369:
					return "LastMsgSeqNumProcessed";
				case  370:
					return "OnBehalfOfSendingTime";
				case  371:
					return "RefTagID";
				case  372:
					return "RefMsgType";
				case  373:
					return "SessionRejectReason";
				case  374:
					return "BidRequestTransType";
				case  375:
					return "ContraBroker";
				case  376:
					return "ComplianceID";
				case  377:
					return "SolicitedFlag";
				case  378:
					return "ExecRestatementReason";
				case  379:
					return "BusinessRejectRefID";
				case  380:
					return "BusinessRejectReason";
				case  381:
					return "GrossTradeAmt";
				case  382:
					return "NoContraBrokers";
				case  383:
					return "MaxMessageSize";
				case  384:
					return "NoMsgTypes";
				case  385:
					return "MsgDirection";
				case  386:
					return "NoTradingSessions";
				case  387:
					return "TotalVolumeTraded";
				case  388:
					return "DiscretionInst";
				case  389:
					return "DiscretionOffsetValue";
				case  390:
					return "BidID";
				case  391:
					return "ClientBidID";
				case  392:
					return "ListName";
				case  393:
					return "TotNoRelatedSym";
				case  394:
					return "BidType";
				case  395:
					return "NumTickets";
				case  396:
					return "SideValue1";
				case  397:
					return "SideValue2";
				case  398:
					return "NoBidDescriptors";
				case  399:
					return "BidDescriptorType";
				case  400:
					return "BidDescriptor";
				case  401:
					return "SideValueInd";
				case  402:
					return "LiquidityPctLow";
				case  403:
					return "LiquidityPctHigh";
				case  404:
					return "LiquidityValue";
				case  405:
					return "EFPTrackingError";
				case  406:
					return "FairValue";
				case  407:
					return "OutsideIndexPct";
				case  408:
					return "ValueOfFutures";
				case  409:
					return "LiquidityIndType";
				case  410:
					return "WtAverageLiquidity";
				case  411:
					return "ExchangeForPhysical";
				case  412:
					return "OutMainCntryUIndex";
				case  413:
					return "CrossPercent";
				case  414:
					return "ProgRptReqs";
				case  415:
					return "ProgPeriodInterval";
				case  416:
					return "IncTaxInd";
				case  417:
					return "NumBidders";
				case  418:
					return "BidTradeType";
				case  419:
					return "BasisPxType";
				case  420:
					return "NoBidComponents";
				case  421:
					return "Country";
				case  422:
					return "TotNoStrikes";
				case  423:
					return "PriceType";
				case  424:
					return "DayOrderQty";
				case  425:
					return "DayCumQty";
				case  426:
					return "DayAvgPx";
				case  427:
					return "GTBookingInst";
				case  428:
					return "NoStrikes";
				case  429:
					return "ListStatusType";
				case  430:
					return "NetGrossInd";
				case  431:
					return "ListOrderStatus";
				case  432:
					return "ExpireDate";
				case  433:
					return "ListExecInstType";
				case  434:
					return "CxlRejResponseTo";
				case  435:
					return "UnderlyingCouponRate";
				case  436:
					return "UnderlyingContractMultiplier";
				case  437:
					return "ContraTradeQty";
				case  438:
					return "ContraTradeTime";
				case  439:
					return "ClearingFirm";
				case  440:
					return "ClearingAccount";
				case  441:
					return "LiquidityNumSecurities";
				case  442:
					return "MultiLegReportingType";
				case  443:
					return "StrikeTime";
				case  444:
					return "ListStatusText";
				case  445:
					return "EncodedListStatusTextLen";
				case  446:
					return "EncodedListStatusText";
				case  447:
					return "PartyIDSource";
				case  448:
					return "PartyID";
				case  449:
					return "TotalVolumeTradedDate";
				case  450:
					return "TotalVolumeTradedTime";
				case  451:
					return "NetChgPrevDay";
				case  452:
					return "PartyRole";
				case  453:
					return "NoPartyIDs";
				case  454:
					return "NoSecurityAltID";
				case  455:
					return "SecurityAltID";
				case  456:
					return "SecurityAltIDSource";
				case  457:
					return "NoUnderlyingSecurityAltID";
				case  458:
					return "UnderlyingSecurityAltID";
				case  459:
					return "UnderlyingSecurityAltIDSource";
				case  460:
					return "Product";
				case  461:
					return "CFICode";
				case  462:
					return "UnderlyingProduct";
				case  463:
					return "UnderlyingCFICode";
				case  464:
					return "TestMessageIndicator";
				case  465:
					return "QuantityType";
				case  466:
					return "BookingRefID";
				case  467:
					return "IndividualAllocID";
				case  468:
					return "RoundingDirection";
				case  469:
					return "RoundingModulus";
				case  470:
					return "CountryOfIssue";
				case  471:
					return "StateOrProvinceOfIssue";
				case  472:
					return "LocaleOfIssue";
				case  473:
					return "NoRegistDtls";
				case  474:
					return "MailingDtls";
				case  475:
					return "InvestorCountryOfResidence";
				case  476:
					return "PaymentRef";
				case  477:
					return "DistribPaymentMethod";
				case  478:
					return "CashDistribCurr";
				case  479:
					return "CommCurrency";
				case  480:
					return "CancellationRights";
				case  481:
					return "MoneyLaunderingStatus";
				case  482:
					return "MailingInst";
				case  483:
					return "TransBkdTime";
				case  484:
					return "ExecPriceType";
				case  485:
					return "ExecPriceAdjustment";
				case  486:
					return "DateOfBirth";
				case  487:
					return "TradeReportTransType";
				case  488:
					return "CardHolderName";
				case  489:
					return "CardNumber";
				case  490:
					return "CardExpDate";
				case  491:
					return "CardIssNum";
				case  492:
					return "PaymentMethod";
				case  493:
					return "RegistAcctType";
				case  494:
					return "Designation";
				case  495:
					return "TaxAdvantageType";
				case  496:
					return "RegistRejReasonText";
				case  497:
					return "FundRenewWaiv";
				case  498:
					return "CashDistribAgentName";
				case  499:
					return "CashDistribAgentCode";
				case  500:
					return "CashDistribAgentAcctNumber";
				case  501:
					return "CashDistribPayRef";
				case  502:
					return "CashDistribAgentAcctName";
				case  503:
					return "CardStartDate";
				case  504:
					return "PaymentDate";
				case  505:
					return "PaymentRemitterID";
				case  506:
					return "RegistStatus";
				case  507:
					return "RegistRejReasonCode";
				case  508:
					return "RegistRefID";
				case  509:
					return "RegistDtls";
				case  510:
					return "NoDistribInsts";
				case  511:
					return "RegistEmail";
				case  512:
					return "DistribPercentage";
				case  513:
					return "RegistID";
				case  514:
					return "RegistTransType";
				case  515:
					return "ExecValuationPoint";
				case  516:
					return "OrderPercent";
				case  517:
					return "OwnershipType";
				case  518:
					return "NoContAmts";
				case  519:
					return "ContAmtType";
				case  520:
					return "ContAmtValue";
				case  521:
					return "ContAmtCurr";
				case  522:
					return "OwnerType";
				case  523:
					return "PartySubID";
				case  524:
					return "NestedPartyID";
				case  525:
					return "NestedPartyIDSource";
				case  526:
					return "SecondaryClOrdID";
				case  527:
					return "SecondaryExecID";
				case  528:
					return "OrderCapacity";
				case  529:
					return "OrderRestrictions";
				case  530:
					return "MassCancelRequestType";
				case  531:
					return "MassCancelResponse";
				case  532:
					return "MassCancelRejectReason";
				case  533:
					return "TotalAffectedOrders";
				case  534:
					return "NoAffectedOrders";
				case  535:
					return "AffectedOrderID";
				case  536:
					return "AffectedSecondaryOrderID";
				case  537:
					return "QuoteType";
				case  538:
					return "NestedPartyRole";
				case  539:
					return "NoNestedPartyIDs";
				case  540:
					return "TotalAccruedInterestAmt";
				case  541:
					return "MaturityDate";
				case  542:
					return "UnderlyingMaturityDate";
				case  543:
					return "InstrRegistry";
				case  544:
					return "CashMargin";
				case  545:
					return "NestedPartySubID";
				case  546:
					return "Scope";
				case  547:
					return "MDImplicitDelete";
				case  548:
					return "CrossID";
				case  549:
					return "CrossType";
				case  550:
					return "CrossPrioritization";
				case  551:
					return "OrigCrossID";
				case  552:
					return "NoSides";
				case  553:
					return "Username";
				case  554:
					return "Password";
				case  555:
					return "NoLegs";
				case  556:
					return "LegCurrency";
				case  557:
					return "TotNoSecurityTypes";
				case  558:
					return "NoSecurityTypes";
				case  559:
					return "SecurityListRequestType";
				case  560:
					return "SecurityRequestResult";
				case  561:
					return "RoundLot";
				case  562:
					return "MinTradeVol";
				case  563:
					return "MultiLegRptTypeReq";
				case  564:
					return "LegPositionEffect";
				case  565:
					return "LegCoveredOrUncovered";
				case  566:
					return "LegPrice";
				case  567:
					return "TradSesStatusRejReason";
				case  568:
					return "TradeRequestID";
				case  569:
					return "TradeRequestType";
				case  570:
					return "PreviouslyReported";
				case  571:
					return "TradeReportID";
				case  572:
					return "TradeReportRefID";
				case  573:
					return "MatchStatus";
				case  574:
					return "MatchType";
				case  575:
					return "OddLot";
				case  576:
					return "NoClearingInstructions";
				case  577:
					return "ClearingInstruction";
				case  578:
					return "TradeInputSource";
				case  579:
					return "TradeInputDevice";
				case  580:
					return "NoDates";
				case  581:
					return "AccountType";
				case  582:
					return "CustOrderCapacity";
				case  583:
					return "ClOrdLinkID";
				case  584:
					return "MassStatusReqID";
				case  585:
					return "MassStatusReqType";
				case  586:
					return "OrigOrdModTime";
				case  587:
					return "LegSettlType";
				case  588:
					return "LegSettlDate";
				case  589:
					return "DayBookingInst";
				case  590:
					return "BookingUnit";
				case  591:
					return "PreallocMethod";
				case  592:
					return "UnderlyingCountryOfIssue";
				case  593:
					return "UnderlyingStateOrProvinceOfIssue";
				case  594:
					return "UnderlyingLocaleOfIssue";
				case  595:
					return "UnderlyingInstrRegistry";
				case  596:
					return "LegCountryOfIssue";
				case  597:
					return "LegStateOrProvinceOfIssue";
				case  598:
					return "LegLocaleOfIssue";
				case  599:
					return "LegInstrRegistry";
				case  600:
					return "LegSymbol";
				case  601:
					return "LegSymbolSfx";
				case  602:
					return "LegSecurityID";
				case  603:
					return "LegSecurityIDSource";
				case  604:
					return "NoLegSecurityAltID";
				case  605:
					return "LegSecurityAltID";
				case  606:
					return "LegSecurityAltIDSource";
				case  607:
					return "LegProduct";
				case  608:
					return "LegCFICode";
				case  609:
					return "LegSecurityType";
				case  610:
					return "LegMaturityMonthYear";
				case  611:
					return "LegMaturityDate";
				case  612:
					return "LegStrikePrice";
				case  613:
					return "LegOptAttribute";
				case  614:
					return "LegContractMultiplier";
				case  615:
					return "LegCouponRate";
				case  616:
					return "LegSecurityExchange";
				case  617:
					return "LegIssuer";
				case  618:
					return "EncodedLegIssuerLen";
				case  619:
					return "EncodedLegIssuer";
				case  620:
					return "LegSecurityDesc";
				case  621:
					return "EncodedLegSecurityDescLen";
				case  622:
					return "EncodedLegSecurityDesc";
				case  623:
					return "LegRatioQty";
				case  624:
					return "LegSide";
				case  625:
					return "TradingSessionSubID";
				case  626:
					return "AllocType";
				case  627:
					return "NoHops";
				case  628:
					return "HopCompID";
				case  629:
					return "HopSendingTime";
				case  630:
					return "HopRefID";
				case  631:
					return "MidPx";
				case  632:
					return "BidYield";
				case  633:
					return "MidYield";
				case  634:
					return "OfferYield";
				case  635:
					return "ClearingFeeIndicator";
				case  636:
					return "WorkingIndicator";
				case  637:
					return "LegLastPx";
				case  638:
					return "PriorityIndicator";
				case  639:
					return "PriceImprovement";
				case  640:
					return "Price2";
				case  641:
					return "LastForwardPoints2";
				case  642:
					return "BidForwardPoints2";
				case  643:
					return "OfferForwardPoints2";
				case  644:
					return "RFQReqID";
				case  645:
					return "MktBidPx";
				case  646:
					return "MktOfferPx";
				case  647:
					return "MinBidSize";
				case  648:
					return "MinOfferSize";
				case  649:
					return "QuoteStatusReqID";
				case  650:
					return "LegalConfirm";
				case  651:
					return "UnderlyingLastPx";
				case  652:
					return "UnderlyingLastQty";
				case  653:
					return "SecDefStatus";
				case  654:
					return "LegRefID";
				case  655:
					return "ContraLegRefID";
				case  656:
					return "SettlCurrBidFxRate";
				case  657:
					return "SettlCurrOfferFxRate";
				case  658:
					return "QuoteRequestRejectReason";
				case  659:
					return "SideComplianceID";
				case  660:
					return "AcctIDSource";
				case  661:
					return "AllocAcctIDSource";
				case  662:
					return "BenchmarkPrice";
				case  663:
					return "BenchmarkPriceType";
				case  664:
					return "ConfirmID";
				case  665:
					return "ConfirmStatus";
				case  666:
					return "ConfirmTransType";
				case  667:
					return "ContractSettlMonth";
				case  668:
					return "DeliveryForm";
				case  669:
					return "LastParPx";
				case  670:
					return "NoLegAllocs";
				case  671:
					return "LegAllocAccount";
				case  672:
					return "LegIndividualAllocID";
				case  673:
					return "LegAllocQty";
				case  674:
					return "LegAllocAcctIDSource";
				case  675:
					return "LegSettlCurrency";
				case  676:
					return "LegBenchmarkCurveCurrency";
				case  677:
					return "LegBenchmarkCurveName";
				case  678:
					return "LegBenchmarkCurvePoint";
				case  679:
					return "LegBenchmarkPrice";
				case  680:
					return "LegBenchmarkPriceType";
				case  681:
					return "LegBidPx";
				case  682:
					return "LegIOIQty";
				case  683:
					return "NoLegStipulations";
				case  684:
					return "LegOfferPx";
				case  685:
					return "LegOrderQty";
				case  686:
					return "LegPriceType";
				case  687:
					return "LegQty";
				case  688:
					return "LegStipulationType";
				case  689:
					return "LegStipulationValue";
				case  690:
					return "LegSwapType";
				case  691:
					return "Pool";
				case  692:
					return "QuotePriceType";
				case  693:
					return "QuoteRespID";
				case  694:
					return "QuoteRespType";
				case  695:
					return "QuoteQualifier";
				case  696:
					return "YieldRedemptionDate";
				case  697:
					return "YieldRedemptionPrice";
				case  698:
					return "YieldRedemptionPriceType";
				case  699:
					return "BenchmarkSecurityID";
				case  700:
					return "ReversalIndicator";
				case  701:
					return "YieldCalcDate";
				case  702:
					return "NoPositions";
				case  703:
					return "PosType";
				case  704:
					return "LongQty";
				case  705:
					return "ShortQty";
				case  706:
					return "PosQtyStatus";
				case  707:
					return "PosAmtType";
				case  708:
					return "PosAmt";
				case  709:
					return "PosTransType";
				case  710:
					return "PosReqID";
				case  711:
					return "NoUnderlyings";
				case  712:
					return "PosMaintAction";
				case  713:
					return "OrigPosReqRefID";
				case  714:
					return "PosMaintRptRefID";
				case  715:
					return "ClearingBusinessDate";
				case  716:
					return "SettlSessID";
				case  717:
					return "SettlSessSubID";
				case  718:
					return "AdjustmentType";
				case  719:
					return "ContraryInstructionIndicator";
				case  720:
					return "PriorSpreadIndicator";
				case  721:
					return "PosMaintRptID";
				case  722:
					return "PosMaintStatus";
				case  723:
					return "PosMaintResult";
				case  724:
					return "PosReqType";
				case  725:
					return "ResponseTransportType";
				case  726:
					return "ResponseDestination";
				case  727:
					return "TotalNumPosReports";
				case  728:
					return "PosReqResult";
				case  729:
					return "PosReqStatus";
				case  730:
					return "SettlPrice";
				case  731:
					return "SettlPriceType";
				case  732:
					return "UnderlyingSettlPrice";
				case  733:
					return "UnderlyingSettlPriceType";
				case  734:
					return "PriorSettlPrice";
				case  735:
					return "NoQuoteQualifiers";
				case  736:
					return "AllocSettlCurrency";
				case  737:
					return "AllocSettlCurrAmt";
				case  738:
					return "InterestAtMaturity";
				case  739:
					return "LegDatedDate";
				case  740:
					return "LegPool";
				case  741:
					return "AllocInterestAtMaturity";
				case  742:
					return "AllocAccruedInterestAmt";
				case  743:
					return "DeliveryDate";
				case  744:
					return "AssignmentMethod";
				case  745:
					return "AssignmentUnit";
				case  746:
					return "OpenInterest";
				case  747:
					return "ExerciseMethod";
				case  748:
					return "TotNumTradeReports";
				case  749:
					return "TradeRequestResult";
				case  750:
					return "TradeRequestStatus";
				case  751:
					return "TradeReportRejectReason";
				case  752:
					return "SideMultiLegReportingType";
				case  753:
					return "NoPosAmt";
				case  754:
					return "AutoAcceptIndicator";
				case  755:
					return "AllocReportID";
				case  756:
					return "NoNested2PartyIDs";
				case  757:
					return "Nested2PartyID";
				case  758:
					return "Nested2PartyIDSource";
				case  759:
					return "Nested2PartyRole";
				case  760:
					return "Nested2PartySubID";
				case  761:
					return "BenchmarkSecurityIDSource";
				case  762:
					return "SecuritySubType";
				case  763:
					return "UnderlyingSecuritySubType";
				case  764:
					return "LegSecuritySubType";
				case  765:
					return "AllowableOneSidednessPct";
				case  766:
					return "AllowableOneSidednessValue";
				case  767:
					return "AllowableOneSidednessCurr";
				case  768:
					return "NoTrdRegTimestamps";
				case  769:
					return "TrdRegTimestamp";
				case  770:
					return "TrdRegTimestampType";
				case  771:
					return "TrdRegTimestampOrigin";
				case  772:
					return "ConfirmRefID";
				case  773:
					return "ConfirmType";
				case  774:
					return "ConfirmRejReason";
				case  775:
					return "BookingType";
				case  776:
					return "IndividualAllocRejCode";
				case  777:
					return "SettlInstMsgID";
				case  778:
					return "NoSettlInst";
				case  779:
					return "LastUpdateTime";
				case  780:
					return "AllocSettlInstType";
				case  781:
					return "NoSettlPartyIDs";
				case  782:
					return "SettlPartyID";
				case  783:
					return "SettlPartyIDSource";
				case  784:
					return "SettlPartyRole";
				case  785:
					return "SettlPartySubID";
				case  786:
					return "SettlPartySubIDType";
				case  787:
					return "DlvyInstType";
				case  788:
					return "TerminationType";
				case  789:
					return "NextExpectedMsgSeqNum";
				case  790:
					return "OrdStatusReqID";
				case  791:
					return "SettlInstReqID";
				case  792:
					return "SettlInstReqRejCode";
				case  793:
					return "SecondaryAllocID";
				case  794:
					return "AllocReportType";
				case  795:
					return "AllocReportRefID";
				case  796:
					return "AllocCancReplaceReason";
				case  797:
					return "CopyMsgIndicator";
				case  798:
					return "AllocAccountType";
				case  799:
					return "OrderAvgPx";
				case  800:
					return "OrderBookingQty";
				case  801:
					return "NoSettlPartySubIDs";
				case  802:
					return "NoPartySubIDs";
				case  803:
					return "PartySubIDType";
				case  804:
					return "NoNestedPartySubIDs";
				case  805:
					return "NestedPartySubIDType";
				case  806:
					return "NoNested2PartySubIDs";
				case  807:
					return "Nested2PartySubIDType";
				case  808:
					return "AllocIntermedReqType";
				case  809:
					return "NoUsernames";
				case  810:
					return "UnderlyingPx";
				case  811:
					return "PriceDelta";
				case  812:
					return "ApplQueueMax";
				case  813:
					return "ApplQueueDepth";
				case  814:
					return "ApplQueueResolution";
				case  815:
					return "ApplQueueAction";
				case  816:
					return "NoAltMDSource";
				case  817:
					return "AltMDSourceID";
				case  818:
					return "SecondaryTradeReportID";
				case  819:
					return "AvgPxIndicator";
				case  820:
					return "TradeLinkID";
				case  821:
					return "OrderInputDevice";
				case  822:
					return "UnderlyingTradingSessionID";
				case  823:
					return "UnderlyingTradingSessionSubID";
				case  824:
					return "TradeLegRefID";
				case  825:
					return "ExchangeRule";
				case  826:
					return "TradeAllocIndicator";
				case  827:
					return "ExpirationCycle";
				case  828:
					return "TrdType";
				case  829:
					return "TrdSubType";
				case  830:
					return "TransferReason";
				case  831:
					return "AsgnReqID";
				case  832:
					return "TotNumAssignmentReports";
				case  833:
					return "AsgnRptID";
				case  834:
					return "ThresholdAmount";
				case  835:
					return "PegMoveType";
				case  836:
					return "PegOffsetType";
				case  837:
					return "PegLimitType";
				case  838:
					return "PegRoundDirection";
				case  839:
					return "PeggedPrice";
				case  840:
					return "PegScope";
				case  841:
					return "DiscretionMoveType";
				case  842:
					return "DiscretionOffsetType";
				case  843:
					return "DiscretionLimitType";
				case  844:
					return "DiscretionRoundDirection";
				case  845:
					return "DiscretionPrice";
				case  846:
					return "DiscretionScope";
				case  847:
					return "TargetStrategy";
				case  848:
					return "TargetStrategyParameters";
				case  849:
					return "ParticipationRate";
				case  850:
					return "TargetStrategyPerformance";
				case  851:
					return "LastLiquidityInd";
				case  852:
					return "PublishTrdIndicator";
				case  853:
					return "ShortSaleReason";
				case  854:
					return "QtyType";
				case  855:
					return "SecondaryTrdType";
				case  856:
					return "TradeReportType";
				case  857:
					return "AllocNoOrdersType";
				case  858:
					return "SharedCommission";
				case  859:
					return "ConfirmReqID";
				case  860:
					return "AvgParPx";
				case  861:
					return "ReportedPx";
				case  862:
					return "NoCapacities";
				case  863:
					return "OrderCapacityQty";
				case  864:
					return "NoEvents";
				case  865:
					return "EventType";
				case  866:
					return "EventDate";
				case  867:
					return "EventPx";
				case  868:
					return "EventText";
				case  869:
					return "PctAtRisk";
				case  870:
					return "NoInstrAttrib";
				case  871:
					return "InstrAttribType";
				case  872:
					return "InstrAttribValue";
				case  873:
					return "DatedDate";
				case  874:
					return "InterestAccrualDate";
				case  875:
					return "CPProgram";
				case  876:
					return "CPRegType";
				case  877:
					return "UnderlyingCPProgram";
				case  878:
					return "UnderlyingCPRegType";
				case  879:
					return "UnderlyingQty";
				case  880:
					return "TrdMatchID";
				case  881:
					return "SecondaryTradeReportRefID";
				case  882:
					return "UnderlyingDirtyPrice";
				case  883:
					return "UnderlyingEndPrice";
				case  884:
					return "UnderlyingStartValue";
				case  885:
					return "UnderlyingCurrentValue";
				case  886:
					return "UnderlyingEndValue";
				case  887:
					return "NoUnderlyingStips";
				case  888:
					return "UnderlyingStipType";
				case  889:
					return "UnderlyingStipValue";
				case  890:
					return "MaturityNetMoney";
				case  891:
					return "MiscFeeBasis";
				case  892:
					return "TotNoAllocs";
				case  893:
					return "LastFragment";
				case  894:
					return "CollReqID";
				case  895:
					return "CollAsgnReason";
				case  896:
					return "CollInquiryQualifier";
				case  897:
					return "NoTrades";
				case  898:
					return "MarginRatio";
				case  899:
					return "MarginExcess";
				case  900:
					return "TotalNetValue";
				case  901:
					return "CashOutstanding";
				case  902:
					return "CollAsgnID";
				case  903:
					return "CollAsgnTransType";
				case  904:
					return "CollRespID";
				case  905:
					return "CollAsgnRespType";
				case  906:
					return "CollAsgnRejectReason";
				case  907:
					return "CollAsgnRefID";
				case  908:
					return "CollRptID";
				case  909:
					return "CollInquiryID";
				case  910:
					return "CollStatus";
				case  911:
					return "TotNumReports";
				case  912:
					return "LastRptRequested";
				case  913:
					return "AgreementDesc";
				case  914:
					return "AgreementID";
				case  915:
					return "AgreementDate";
				case  916:
					return "StartDate";
				case  917:
					return "EndDate";
				case  918:
					return "AgreementCurrency";
				case  919:
					return "DeliveryType";
				case  920:
					return "EndAccruedInterestAmt";
				case  921:
					return "StartCash";
				case  922:
					return "EndCash";
				case  923:
					return "UserRequestID";
				case  924:
					return "UserRequestType";
				case  925:
					return "NewPassword";
				case  926:
					return "UserStatus";
				case  927:
					return "UserStatusText";
				case  928:
					return "StatusValue";
				case  929:
					return "StatusText";
				case  930:
					return "RefCompID";
				case  931:
					return "RefSubID";
				case  932:
					return "NetworkResponseID";
				case  933:
					return "NetworkRequestID";
				case  934:
					return "LastNetworkResponseID";
				case  935:
					return "NetworkRequestType";
				case  936:
					return "NoCompIDs";
				case  937:
					return "NetworkStatusResponseType";
				case  938:
					return "NoCollInquiryQualifier";
				case  939:
					return "TrdRptStatus";
				case  940:
					return "AffirmStatus";
				case  941:
					return "UnderlyingStrikeCurrency";
				case  942:
					return "LegStrikeCurrency";
				case  943:
					return "TimeBracket";
				case  944:
					return "CollAction";
				case  945:
					return "CollInquiryStatus";
				case  946:
					return "CollInquiryResult";
				case  947:
					return "StrikeCurrency";
				case  948:
					return "NoNested3PartyIDs";
				case  949:
					return "Nested3PartyID";
				case  950:
					return "Nested3PartyIDSource";
				case  951:
					return "Nested3PartyRole";
				case  952:
					return "NoNested3PartySubIDs";
				case  953:
					return "Nested3PartySubID";
				case  954:
					return "Nested3PartySubIDType";
				case  955:
					return "LegContractSettlMonth";
				case  956:
					return "LegInterestAccrualDate";
				case  957:
					return "NoStrategyParameters";
				case  958:
					return "StrategyParameterName";
				case  959:
					return "StrategyParameterType";
				case  960:
					return "StrategyParameterValue";
				case  961:
					return "HostCrossID";
				case  962:
					return "SideTimeInForce";
				case  963:
					return "MDReportID";
				case  964:
					return "SecurityReportID";
				case  965:
					return "SecurityStatus";
				case  966:
					return "SettleOnOpenFlag";
				case  967:
					return "StrikeMultiplier";
				case  968:
					return "StrikeValue";
				case  969:
					return "MinPriceIncrement";
				case  970:
					return "PositionLimit";
				case  971:
					return "NTPositionLimit";
				case  972:
					return "UnderlyingAllocationPercent";
				case  973:
					return "UnderlyingCashAmount";
				case  974:
					return "UnderlyingCashType";
				case  975:
					return "UnderlyingSettlementType";
				case  976:
					return "QuantityDate";
				case  977:
					return "ContIntRptID";
				case  978:
					return "LateIndicator";
				case  979:
					return "InputSource";
				case  980:
					return "SecurityUpdateAction";
				case  981:
					return "NoExpiration";
				case  982:
					return "ExpirationQtyType";
				case  983:
					return "ExpQty";
				case  984:
					return "NoUnderlyingAmounts";
				case  985:
					return "UnderlyingPayAmount";
				case  986:
					return "UnderlyingCollectAmount";
				case  987:
					return "UnderlyingSettlementDate";
				case  988:
					return "UnderlyingSettlementStatus";
				case  989:
					return "SecondaryIndividualAllocID";
				case  990:
					return "LegReportID";
				case  991:
					return "RndPx";
				case  992:
					return "IndividualAllocType";
				case  993:
					return "AllocCustomerCapacity";
				case  994:
					return "TierCode";
				case  996:
					return "UnitOfMeasure";
				case  997:
					return "TimeUnit";
				case  998:
					return "UnderlyingUnitOfMeasure";
				case  999:
					return "LegUnitOfMeasure";
				case  1000:
					return "UnderlyingTimeUnit";
				case  1001:
					return "LegTimeUnit";
				case  1002:
					return "AllocMethod";
				case  1003:
					return "TradeID";
				case  1005:
					return "SideTradeReportID";
				case  1006:
					return "SideFillStationCd";
				case  1007:
					return "SideReasonCd";
				case  1008:
					return "SideTrdSubTyp";
				case  1009:
					return "SideLastQty";
				case  1011:
					return "MessageEventSource";
				case  1012:
					return "SideTrdRegTimestamp";
				case  1013:
					return "SideTrdRegTimestampType";
				case  1014:
					return "SideTrdRegTimestampSrc";
				case  1015:
					return "AsOfIndicator";
				case  1016:
					return "NoSideTrdRegTS";
				case  1017:
					return "LegOptionRatio";
				case  1018:
					return "NoInstrumentParties";
				case  1019:
					return "InstrumentPartyID";
				case  1020:
					return "TradeVolume";
				case  1021:
					return "MDBookType";
				case  1022:
					return "MDFeedType";
				case  1023:
					return "MDPriceLevel";
				case  1024:
					return "MDOriginType";
				case  1025:
					return "FirstPx";
				case  1026:
					return "MDEntrySpotRate";
				case  1027:
					return "MDEntryForwardPoints";
				case  1028:
					return "ManualOrderIndicator";
				case  1029:
					return "CustDirectedOrder";
				case  1030:
					return "ReceivedDeptID";
				case  1031:
					return "CustOrderHandlingInst";
				case  1032:
					return "OrderHandlingInstSource";
				case  1033:
					return "DeskType";
				case  1034:
					return "DeskTypeSource";
				case  1035:
					return "DeskOrderHandlingInst";
				case  1036:
					return "ExecAckStatus";
				case  1037:
					return "UnderlyingDeliveryAmount";
				case  1038:
					return "UnderlyingCapValue";
				case  1039:
					return "UnderlyingSettlMethod";
				case  1040:
					return "SecondaryTradeID";
				case  1041:
					return "FirmTradeID";
				case  1042:
					return "SecondaryFirmTradeID";
				case  1043:
					return "CollApplType";
				case  1044:
					return "UnderlyingAdjustedQuantity";
				case  1045:
					return "UnderlyingFXRate";
				case  1046:
					return "UnderlyingFXRateCalc";
				case  1047:
					return "AllocPositionEffect";
				case  1048:
					return "DealingCapacity";
				case  1049:
					return "InstrmtAssignmentMethod";
				case  1050:
					return "InstrumentPartyIDSource";
				case  1051:
					return "InstrumentPartyRole";
				case  1052:
					return "NoInstrumentPartySubIDs";
				case  1053:
					return "InstrumentPartySubID";
				case  1054:
					return "InstrumentPartySubIDType";
				case  1055:
					return "PositionCurrency";
				case  1056:
					return "CalculatedCcyLastQty";
				case  1057:
					return "AggressorIndicator";
				case  1058:
					return "NoUndlyInstrumentParties";
				case  1059:
					return "UnderlyingInstrumentPartyID";
				case  1060:
					return "UnderlyingInstrumentPartyIDSource";
				case  1061:
					return "UnderlyingInstrumentPartyRole";
				case  1062:
					return "NoUndlyInstrumentPartySubIDs";
				case  1063:
					return "UnderlyingInstrumentPartySubID";
				case  1064:
					return "UnderlyingInstrumentPartySubIDType";
				case  1065:
					return "BidSwapPoints";
				case  1066:
					return "OfferSwapPoints";
				case  1067:
					return "LegBidForwardPoints";
				case  1068:
					return "LegOfferForwardPoints";
				case  1069:
					return "SwapPoints";
				case  1070:
					return "MDQuoteType";
				case  1071:
					return "LastSwapPoints";
				case  1072:
					return "SideGrossTradeAmt";
				case  1073:
					return "LegLastForwardPoints";
				case  1074:
					return "LegCalculatedCcyLastQty";
				case  1075:
					return "LegGrossTradeAmt";
				case  1079:
					return "MaturityTime";
				case  1080:
					return "RefOrderID";
				case  1081:
					return "RefOrderIDSource";
				case  1082:
					return "SecondaryDisplayQty";
				case  1083:
					return "DisplayWhen";
				case  1084:
					return "DisplayMethod";
				case  1085:
					return "DisplayLowQty";
				case  1086:
					return "DisplayHighQty";
				case  1087:
					return "DisplayMinIncr";
				case  1088:
					return "RefreshQty";
				case  1089:
					return "MatchIncrement";
				case  1090:
					return "MaxPriceLevels";
				case  1091:
					return "PreTradeAnonymity";
				case  1092:
					return "PriceProtectionScope";
				case  1093:
					return "LotType";
				case  1094:
					return "PegPriceType";
				case  1095:
					return "PeggedRefPrice";
				case  1096:
					return "PegSecurityIDSource";
				case  1097:
					return "PegSecurityID";
				case  1098:
					return "PegSymbol";
				case  1099:
					return "PegSecurityDesc";
				case  1100:
					return "TriggerType";
				case  1101:
					return "TriggerAction";
				case  1102:
					return "TriggerPrice";
				case  1103:
					return "TriggerSymbol";
				case  1104:
					return "TriggerSecurityID";
				case  1105:
					return "TriggerSecurityIDSource";
				case  1106:
					return "TriggerSecurityDesc";
				case  1107:
					return "TriggerPriceType";
				case  1108:
					return "TriggerPriceTypeScope";
				case  1109:
					return "TriggerPriceDirection";
				case  1110:
					return "TriggerNewPrice";
				case  1111:
					return "TriggerOrderType";
				case  1112:
					return "TriggerNewQty";
				case  1113:
					return "TriggerTradingSessionID";
				case  1114:
					return "TriggerTradingSessionSubID";
				case  1115:
					return "OrderCategory";
				case  1116:
					return "NoRootPartyIDs";
				case  1117:
					return "RootPartyID";
				case  1118:
					return "RootPartyIDSource";
				case  1119:
					return "RootPartyRole";
				case  1120:
					return "NoRootPartySubIDs";
				case  1121:
					return "RootPartySubID";
				case  1122:
					return "RootPartySubIDType";
				case  1123:
					return "TradeHandlingInstr";
				case  1124:
					return "OrigTradeHandlingInstr";
				case  1125:
					return "OrigTradeDate";
				case  1126:
					return "OrigTradeID";
				case  1127:
					return "OrigSecondaryTradeID";
				case  1128:
					return "ApplVerID";
				case  1129:
					return "CstmApplVerID";
				case  1130:
					return "RefApplVerID";
				case  1131:
					return "RefCstmApplVerID";
				case  1132:
					return "TZTransactTime";
				case  1133:
					return "ExDestinationIDSource";
				case  1134:
					return "ReportedPxDiff";
				case  1135:
					return "RptSys";
				case  1136:
					return "AllocClearingFeeIndicator";
				case  1137:
					return "DefaultApplVerID";
				case  1138:
					return "DisplayQty";
				case  1139:
					return "ExchangeSpecialInstructions";
				case  1140:
					return "MaxTradeVol";
				case  1141:
					return "NoMDFeedTypes";
				case  1142:
					return "MatchAlgorithm";
				case  1143:
					return "MaxPriceVariation";
				case  1144:
					return "ImpliedMarketIndicator";
				case  1145:
					return "EventTime";
				case  1146:
					return "MinPriceIncrementAmount";
				case  1147:
					return "UnitOfMeasureQty";
				case  1148:
					return "LowLimitPrice";
				case  1149:
					return "HighLimitPrice";
				case  1150:
					return "TradingReferencePrice";
				case  1151:
					return "SecurityGroup";
				case  1152:
					return "LegNumber";
				case  1153:
					return "SettlementCycleNo";
				case  1154:
					return "SideCurrency";
				case  1155:
					return "SideSettlCurrency";
				case  1156:
					return "ApplExtID";
				case  1157:
					return "CcyAmt";
				case  1158:
					return "NoSettlDetails";
				case  1159:
					return "SettlObligMode";
				case  1160:
					return "SettlObligMsgID";
				case  1161:
					return "SettlObligID";
				case  1162:
					return "SettlObligTransType";
				case  1163:
					return "SettlObligRefID";
				case  1164:
					return "SettlObligSource";
				case  1165:
					return "NoSettlOblig";
				case  1166:
					return "QuoteMsgID";
				case  1167:
					return "QuoteEntryStatus";
				case  1168:
					return "TotNoCxldQuotes";
				case  1169:
					return "TotNoAccQuotes";
				case  1170:
					return "TotNoRejQuotes";
				case  1171:
					return "PrivateQuote";
				case  1172:
					return "RespondentType";
				case  1173:
					return "MDSubBookType";
				case  1174:
					return "SecurityTradingEvent";
				case  1175:
					return "NoStatsIndicators";
				case  1176:
					return "StatsType";
				case  1177:
					return "NoOfSecSizes";
				case  1178:
					return "MDSecSizeType";
				case  1179:
					return "MDSecSize";
				case  1180:
					return "ApplID";
				case  1181:
					return "ApplSeqNum";
				case  1182:
					return "ApplBegSeqNum";
				case  1183:
					return "ApplEndSeqNum";
				case  1184:
					return "SecurityXMLLen";
				case  1185:
					return "SecurityXML";
				case  1186:
					return "SecurityXMLSchema";
				case  1187:
					return "RefreshIndicator";
				case  1188:
					return "Volatility";
				case  1189:
					return "TimeToExpiration";
				case  1190:
					return "RiskFreeRate";
				case  1191:
					return "PriceUnitOfMeasure";
				case  1192:
					return "PriceUnitOfMeasureQty";
				case  1193:
					return "SettlMethod";
				case  1194:
					return "ExerciseStyle";
				case  1195:
					return "OptPayoutAmount";
				case  1196:
					return "PriceQuoteMethod";
				case  1197:
					return "ValuationMethod";
				case  1198:
					return "ListMethod";
				case  1199:
					return "CapPrice";
				case  1200:
					return "FloorPrice";
				case  1201:
					return "NoStrikeRules";
				case  1202:
					return "StartStrikePxRange";
				case  1203:
					return "EndStrikePxRange";
				case  1204:
					return "StrikeIncrement";
				case  1205:
					return "NoTickRules";
				case  1206:
					return "StartTickPriceRange";
				case  1207:
					return "EndTickPriceRange";
				case  1208:
					return "TickIncrement";
				case  1209:
					return "TickRuleType";
				case  1210:
					return "NestedInstrAttribType";
				case  1211:
					return "NestedInstrAttribValue";
				case  1212:
					return "LegMaturityTime";
				case  1213:
					return "UnderlyingMaturityTime";
				case  1214:
					return "DerivativeSymbol";
				case  1215:
					return "DerivativeSymbolSfx";
				case  1216:
					return "DerivativeSecurityID";
				case  1217:
					return "DerivativeSecurityIDSource";
				case  1218:
					return "NoDerivativeSecurityAltID";
				case  1219:
					return "DerivativeSecurityAltID";
				case  1220:
					return "DerivativeSecurityAltIDSource";
				case  1221:
					return "SecondaryLowLimitPrice";
				case  1222:
					return "MaturityRuleID";
				case  1223:
					return "StrikeRuleID";
				case  1224:
					return "LegUnitOfMeasureQty";
				case  1225:
					return "DerivativeOptPayAmount";
				case  1226:
					return "EndMaturityMonthYear";
				case  1227:
					return "ProductComplex";
				case  1228:
					return "DerivativeProductComplex";
				case  1229:
					return "MaturityMonthYearIncrement";
				case  1230:
					return "SecondaryHighLimitPrice";
				case  1231:
					return "MinLotSize";
				case  1232:
					return "NoExecInstRules";
				case  1234:
					return "NoLotTypeRules";
				case  1235:
					return "NoMatchRules";
				case  1236:
					return "NoMaturityRules";
				case  1237:
					return "NoOrdTypeRules";
				case  1239:
					return "NoTimeInForceRules";
				case  1240:
					return "SecondaryTradingReferencePrice";
				case  1241:
					return "StartMaturityMonthYear";
				case  1242:
					return "FlexProductEligibilityIndicator";
				case  1243:
					return "DerivFlexProductEligibilityIndicator";
				case  1244:
					return "FlexibleIndicator";
				case  1245:
					return "TradingCurrency";
				case  1246:
					return "DerivativeProduct";
				case  1247:
					return "DerivativeSecurityGroup";
				case  1248:
					return "DerivativeCFICode";
				case  1249:
					return "DerivativeSecurityType";
				case  1250:
					return "DerivativeSecuritySubType";
				case  1251:
					return "DerivativeMaturityMonthYear";
				case  1252:
					return "DerivativeMaturityDate";
				case  1253:
					return "DerivativeMaturityTime";
				case  1254:
					return "DerivativeSettleOnOpenFlag";
				case  1255:
					return "DerivativeInstrmtAssignmentMethod";
				case  1256:
					return "DerivativeSecurityStatus";
				case  1257:
					return "DerivativeInstrRegistry";
				case  1258:
					return "DerivativeCountryOfIssue";
				case  1259:
					return "DerivativeStateOrProvinceOfIssue";
				case  1260:
					return "DerivativeLocaleOfIssue";
				case  1261:
					return "DerivativeStrikePrice";
				case  1262:
					return "DerivativeStrikeCurrency";
				case  1263:
					return "DerivativeStrikeMultiplier";
				case  1264:
					return "DerivativeStrikeValue";
				case  1265:
					return "DerivativeOptAttribute";
				case  1266:
					return "DerivativeContractMultiplier";
				case  1267:
					return "DerivativeMinPriceIncrement";
				case  1268:
					return "DerivativeMinPriceIncrementAmount";
				case  1269:
					return "DerivativeUnitOfMeasure";
				case  1270:
					return "DerivativeUnitOfMeasureQty";
				case  1271:
					return "DerivativeTimeUnit";
				case  1272:
					return "DerivativeSecurityExchange";
				case  1273:
					return "DerivativePositionLimit";
				case  1274:
					return "DerivativeNTPositionLimit";
				case  1275:
					return "DerivativeIssuer";
				case  1276:
					return "DerivativeIssueDate";
				case  1277:
					return "DerivativeEncodedIssuerLen";
				case  1278:
					return "DerivativeEncodedIssuer";
				case  1279:
					return "DerivativeSecurityDesc";
				case  1280:
					return "DerivativeEncodedSecurityDescLen";
				case  1281:
					return "DerivativeEncodedSecurityDesc";
				case  1282:
					return "DerivativeSecurityXMLLen";
				case  1283:
					return "DerivativeSecurityXML";
				case  1284:
					return "DerivativeSecurityXMLSchema";
				case  1285:
					return "DerivativeContractSettlMonth";
				case  1286:
					return "NoDerivativeEvents";
				case  1287:
					return "DerivativeEventType";
				case  1288:
					return "DerivativeEventDate";
				case  1289:
					return "DerivativeEventTime";
				case  1290:
					return "DerivativeEventPx";
				case  1291:
					return "DerivativeEventText";
				case  1292:
					return "NoDerivativeInstrumentParties";
				case  1293:
					return "DerivativeInstrumentPartyID";
				case  1294:
					return "DerivativeInstrumentPartyIDSource";
				case  1295:
					return "DerivativeInstrumentPartyRole";
				case  1296:
					return "NoDerivativeInstrumentPartySubIDs";
				case  1297:
					return "DerivativeInstrumentPartySubID";
				case  1298:
					return "DerivativeInstrumentPartySubIDType";
				case  1299:
					return "DerivativeExerciseStyle";
				case  1300:
					return "MarketSegmentID";
				case  1301:
					return "MarketID";
				case  1302:
					return "MaturityMonthYearIncrementUnits";
				case  1303:
					return "MaturityMonthYearFormat";
				case  1304:
					return "StrikeExerciseStyle";
				case  1305:
					return "SecondaryPriceLimitType";
				case  1306:
					return "PriceLimitType";
				case  1307:
					return "DerivativeSecurityListRequestType";
				case  1308:
					return "ExecInstValue";
				case  1309:
					return "NoTradingSessionRules";
				case  1310:
					return "NoMarketSegments";
				case  1311:
					return "NoDerivativeInstrAttrib";
				case  1312:
					return "NoNestedInstrAttrib";
				case  1313:
					return "DerivativeInstrAttribType";
				case  1314:
					return "DerivativeInstrAttribValue";
				case  1315:
					return "DerivativePriceUnitOfMeasure";
				case  1316:
					return "DerivativePriceUnitOfMeasureQty";
				case  1317:
					return "DerivativeSettlMethod";
				case  1318:
					return "DerivativePriceQuoteMethod";
				case  1319:
					return "DerivativeValuationMethod";
				case  1320:
					return "DerivativeListMethod";
				case  1321:
					return "DerivativeCapPrice";
				case  1322:
					return "DerivativeFloorPrice";
				case  1323:
					return "DerivativePutOrCall";
				case  1324:
					return "ListUpdateAction";
				case  1325:
					return "ParentMktSegmID";
				case  1326:
					return "TradingSessionDesc";
				case  1327:
					return "TradSesUpdateAction";
				case  1328:
					return "RejectText";
				case  1329:
					return "FeeMultiplier";
				case  1330:
					return "UnderlyingLegSymbol";
				case  1331:
					return "UnderlyingLegSymbolSfx";
				case  1332:
					return "UnderlyingLegSecurityID";
				case  1333:
					return "UnderlyingLegSecurityIDSource";
				case  1334:
					return "NoUnderlyingLegSecurityAltID";
				case  1335:
					return "UnderlyingLegSecurityAltID";
				case  1336:
					return "UnderlyingLegSecurityAltIDSource";
				case  1337:
					return "UnderlyingLegSecurityType";
				case  1338:
					return "UnderlyingLegSecuritySubType";
				case  1339:
					return "UnderlyingLegMaturityMonthYear";
				case  1340:
					return "UnderlyingLegStrikePrice";
				case  1341:
					return "UnderlyingLegSecurityExchange";
				case  1342:
					return "NoOfLegUnderlyings";
				case  1343:
					return "UnderlyingLegPutOrCall";
				case  1344:
					return "UnderlyingLegCFICode";
				case  1345:
					return "UnderlyingLegMaturityDate";
				case  1346:
					return "ApplReqID";
				case  1347:
					return "ApplReqType";
				case  1348:
					return "ApplResponseType";
				case  1349:
					return "ApplTotalMessageCount";
				case  1350:
					return "ApplLastSeqNum";
				case  1351:
					return "NoApplIDs";
				case  1352:
					return "ApplResendFlag";
				case  1353:
					return "ApplResponseID";
				case  1354:
					return "ApplResponseError";
				case  1355:
					return "RefApplID";
				case  1356:
					return "ApplReportID";
				case  1357:
					return "RefApplLastSeqNum";
				case  1358:
					return "LegPutOrCall";
				case  1359:
					return "EncodedSymbolLen";
				case  1360:
					return "EncodedSymbol";
				case  1361:
					return "TotNoFills";
				case  1362:
					return "NoFills";
				case  1363:
					return "FillExecID";
				case  1364:
					return "FillPx";
				case  1365:
					return "FillQty";
				case  1366:
					return "LegAllocID";
				case  1367:
					return "LegAllocSettlCurrency";
				case  1368:
					return "TradSesEvent";
				case  1369:
					return "MassActionReportID";
				case  1370:
					return "NoNotAffectedOrders";
				case  1371:
					return "NotAffectedOrderID";
				case  1372:
					return "NotAffOrigClOrdID";
				case  1373:
					return "MassActionType";
				case  1374:
					return "MassActionScope";
				case  1375:
					return "MassActionResponse";
				case  1376:
					return "MassActionRejectReason";
				case  1377:
					return "MultilegModel";
				case  1378:
					return "MultilegPriceMethod";
				case  1379:
					return "LegVolatility";
				case  1380:
					return "DividendYield";
				case  1381:
					return "LegDividendYield";
				case  1382:
					return "CurrencyRatio";
				case  1383:
					return "LegCurrencyRatio";
				case  1384:
					return "LegExecInst";
				case  1385:
					return "ContingencyType";
				case  1386:
					return "ListRejectReason";
				case  1387:
					return "NoTrdRepIndicators";
				case  1388:
					return "TrdRepPartyRole";
				case  1389:
					return "TrdRepIndicator";
				case  1390:
					return "TradePublishIndicator";
				case  1391:
					return "UnderlyingLegOptAttribute";
				case  1392:
					return "UnderlyingLegSecurityDesc";
				case  1393:
					return "MarketReqID";
				case  1394:
					return "MarketReportID";
				case  1395:
					return "MarketUpdateAction";
				case  1396:
					return "MarketSegmentDesc";
				case  1397:
					return "EncodedMktSegmDescLen";
				case  1398:
					return "EncodedMktSegmDesc";
				case  1399:
					return "ApplNewSeqNum";
				case  1400:
					return "EncryptedPasswordMethod";
				case  1401:
					return "EncryptedPasswordLen";
				case  1402:
					return "EncryptedPassword";
				case  1403:
					return "EncryptedNewPasswordLen";
				case  1404:
					return "EncryptedNewPassword";
				case  1405:
					return "UnderlyingLegMaturityTime";
				case  1406:
					return "RefApplExtID";
				case  1407:
					return "DefaultApplExtID";
				case  1408:
					return "DefaultCstmApplVerID";
				case  1409:
					return "SessionStatus";
				case  1410:
					return "DefaultVerIndicator";
				case  1411:
					return "Nested4PartySubIDType";
				case  1412:
					return "Nested4PartySubID";
				case  1413:
					return "NoNested4PartySubIDs";
				case  1414:
					return "NoNested4PartyIDs";
				case  1415:
					return "Nested4PartyID";
				case  1416:
					return "Nested4PartyIDSource";
				case  1417:
					return "Nested4PartyRole";
				case  1418:
					return "LegLastQty";
				case  1419:
					return "UnderlyingExerciseStyle";
				case  1420:
					return "LegExerciseStyle";
				case  1421:
					return "LegPriceUnitOfMeasure";
				case  1422:
					return "LegPriceUnitOfMeasureQty";
				case  1423:
					return "UnderlyingUnitOfMeasureQty";
				case  1424:
					return "UnderlyingPriceUnitOfMeasure";
				case  1425:
					return "UnderlyingPriceUnitOfMeasureQty";
				case  1426:
					return "ApplReportType";
				case  1427:
					return "SideExecID";
				case  1428:
					return "OrderDelay";
				case  1429:
					return "OrderDelayUnit";
				case  1430:
					return "VenueType";
				case  1431:
					return "RefOrdIDReason";
				case  1432:
					return "OrigCustOrderCapacity";
				case  1433:
					return "RefApplReqID";
				case  1434:
					return "ModelType";
				case  1435:
					return "ContractMultiplierUnit";
				case  1436:
					return "LegContractMultiplierUnit";
				case  1437:
					return "UnderlyingContractMultiplierUnit";
				case  1438:
					return "DerivativeContractMultiplierUnit";
				case  1439:
					return "FlowScheduleType";
				case  1440:
					return "LegFlowScheduleType";
				case  1441:
					return "UnderlyingFlowScheduleType";
				case  1442:
					return "DerivativeFlowScheduleType";
				case  1443:
					return "FillLiquidityInd";
				case  1444:
					return "SideLiquidityInd";
				case  1445:
					return "NoRateSources";
				case  1446:
					return "RateSource";
				case  1447:
					return "RateSourceType";
				case  1448:
					return "ReferencePage";
				case  1449:
					return "RestructuringType";
				case  1450:
					return "Seniority";
				case  1451:
					return "NotionalPercentageOutstanding";
				case  1452:
					return "OriginalNotionalPercentageOutstanding";
				case  1453:
					return "UnderlyingRestructuringType";
				case  1454:
					return "UnderlyingSeniority";
				case  1455:
					return "UnderlyingNotionalPercentageOutstanding";
				case  1456:
					return "UnderlyingOriginalNotionalPercentageOutstanding";
				case  1457:
					return "AttachmentPoint";
				case  1458:
					return "DetachmentPoint";
				case  1459:
					return "UnderlyingAttachmentPoint";
				case  1460:
					return "UnderlyingDetachmentPoint";
				case  1461:
					return "NoTargetPartyIDs";
				case  1462:
					return "TargetPartyID";
				case  1463:
					return "TargetPartyIDSource";
				case  1464:
					return "TargetPartyRole";
				case  1465:
					return "SecurityListID";
				case  1466:
					return "SecurityListRefID";
				case  1467:
					return "SecurityListDesc";
				case  1468:
					return "EncodedSecurityListDescLen";
				case  1469:
					return "EncodedSecurityListDesc";
				case  1470:
					return "SecurityListType";
				case  1471:
					return "SecurityListTypeSource";
				case  1472:
					return "NewsID";
				case  1473:
					return "NewsCategory";
				case  1474:
					return "LanguageCode";
				case  1475:
					return "NoNewsRefIDs";
				case  1476:
					return "NewsRefID";
				case  1477:
					return "NewsRefType";
				case  1478:
					return "StrikePriceDeterminationMethod";
				case  1479:
					return "StrikePriceBoundaryMethod";
				case  1480:
					return "StrikePriceBoundaryPrecision";
				case  1481:
					return "UnderlyingPriceDeterminationMethod";
				case  1482:
					return "OptPayoutType";
				case  1483:
					return "NoComplexEvents";
				case  1484:
					return "ComplexEventType";
				case  1485:
					return "ComplexOptPayoutAmount";
				case  1486:
					return "ComplexEventPrice";
				case  1487:
					return "ComplexEventPriceBoundaryMethod";
				case  1488:
					return "ComplexEventPriceBoundaryPrecision";
				case  1489:
					return "ComplexEventPriceTimeType";
				case  1490:
					return "ComplexEventCondition";
				case  1491:
					return "NoComplexEventDates";
				case  1492:
					return "ComplexEventStartDate";
				case  1493:
					return "ComplexEventEndDate";
				case  1494:
					return "NoComplexEventTimes";
				case  1495:
					return "ComplexEventStartTime";
				case  1496:
					return "ComplexEventEndTime";
				case  1497:
					return "StreamAsgnReqID";
				case  1498:
					return "StreamAsgnReqType";
				case  1499:
					return "NoAsgnReqs";
				case  1500:
					return "MDStreamID";
				case  1501:
					return "StreamAsgnRptID";
				case  1502:
					return "StreamAsgnRejReason";
				case  1503:
					return "StreamAsgnAckType";
				case  1504:
					return "RelSymTransactTime";
				case  1505:
					return "PartyDetailsListRequestID";
				case  1506:
					return "NoPartyListResponseTypes";
				case  1507:
					return "PartyListResponseType";
				case  1508:
					return "NoRequestedPartyRoles";
				case  1509:
					return "RequestedPartyRole";
				case  1510:
					return "PartyDetailsListReportID";
				case  1511:
					return "PartyDetailsRequestResult";
				case  1512:
					return "TotNoPartyList";
				case  1513:
					return "NoPartyList";
				case  1514:
					return "NoPartyRelationships";
				case  1515:
					return "PartyRelationship";
				case  1516:
					return "NoPartyAltIDs";
				case  1517:
					return "PartyAltID";
				case  1518:
					return "PartyAltIDSource";
				case  1519:
					return "NoPartyAltSubIDs";
				case  1520:
					return "PartyAltSubID";
				case  1521:
					return "PartyAltSubIDType";
				case  1522:
					return "NoContextPartyIDs";
				case  1523:
					return "ContextPartyID";
				case  1524:
					return "ContextPartyIDSource";
				case  1525:
					return "ContextPartyRole";
				case  1526:
					return "NoContextPartySubIDs";
				case  1527:
					return "ContextPartySubID";
				case  1528:
					return "ContextPartySubIDType";
				case  1529:
					return "NoRiskLimits";
				case  1530:
					return "RiskLimitType";
				case  1531:
					return "RiskLimitAmount";
				case  1532:
					return "RiskLimitCurrency";
				case  1533:
					return "RiskLimitPlatform";
				case  1534:
					return "NoRiskInstruments";
				case  1535:
					return "RiskInstrumentOperator";
				case  1536:
					return "RiskSymbol";
				case  1537:
					return "RiskSymbolSfx";
				case  1538:
					return "RiskSecurityID";
				case  1539:
					return "RiskSecurityIDSource";
				case  1540:
					return "NoRiskSecurityAltID";
				case  1541:
					return "RiskSecurityAltID";
				case  1542:
					return "RiskSecurityAltIDSource";
				case  1543:
					return "RiskProduct";
				case  1544:
					return "RiskProductComplex";
				case  1545:
					return "RiskSecurityGroup";
				case  1546:
					return "RiskCFICode";
				case  1547:
					return "RiskSecurityType";
				case  1548:
					return "RiskSecuritySubType";
				case  1549:
					return "RiskMaturityMonthYear";
				case  1550:
					return "RiskMaturityTime";
				case  1551:
					return "RiskRestructuringType";
				case  1552:
					return "RiskSeniority";
				case  1553:
					return "RiskPutOrCall";
				case  1554:
					return "RiskFlexibleIndicator";
				case  1555:
					return "RiskCouponRate";
				case  1556:
					return "RiskSecurityDesc";
				case  1557:
					return "RiskInstrumentSettlType";
				case  1558:
					return "RiskInstrumentMultiplier";
				case  1559:
					return "NoRiskWarningLevels";
				case  1560:
					return "RiskWarningLevelPercent";
				case  1561:
					return "RiskWarningLevelName";
				case  1562:
					return "NoRelatedPartyIDs";
				case  1563:
					return "RelatedPartyID";
				case  1564:
					return "RelatedPartyIDSource";
				case  1565:
					return "RelatedPartyRole";
				case  1566:
					return "NoRelatedPartySubIDs";
				case  1567:
					return "RelatedPartySubID";
				case  1568:
					return "RelatedPartySubIDType";
				case  1569:
					return "NoRelatedPartyAltIDs";
				case  1570:
					return "RelatedPartyAltID";
				case  1571:
					return "RelatedPartyAltIDSource";
				case  1572:
					return "NoRelatedPartyAltSubIDs";
				case  1573:
					return "RelatedPartyAltSubID";
				case  1574:
					return "RelatedPartyAltSubIDType";
				case  1575:
					return "NoRelatedContextPartyIDs";
				case  1576:
					return "RelatedContextPartyID";
				case  1577:
					return "RelatedContextPartyIDSource";
				case  1578:
					return "RelatedContextPartyRole";
				case  1579:
					return "NoRelatedContextPartySubIDs";
				case  1580:
					return "RelatedContextPartySubID";
				case  1581:
					return "RelatedContextPartySubIDType";
				case  1582:
					return "NoRelationshipRiskLimits";
				case  1583:
					return "RelationshipRiskLimitType";
				case  1584:
					return "RelationshipRiskLimitAmount";
				case  1585:
					return "RelationshipRiskLimitCurrency";
				case  1586:
					return "RelationshipRiskLimitPlatform";
				case  1587:
					return "NoRelationshipRiskInstruments";
				case  1588:
					return "RelationshipRiskInstrumentOperator";
				case  1589:
					return "RelationshipRiskSymbol";
				case  1590:
					return "RelationshipRiskSymbolSfx";
				case  1591:
					return "RelationshipRiskSecurityID";
				case  1592:
					return "RelationshipRiskSecurityIDSource";
				case  1593:
					return "NoRelationshipRiskSecurityAltID";
				case  1594:
					return "RelationshipRiskSecurityAltID";
				case  1595:
					return "RelationshipRiskSecurityAltIDSource";
				case  1596:
					return "RelationshipRiskProduct";
				case  1597:
					return "RelationshipRiskProductComplex";
				case  1598:
					return "RelationshipRiskSecurityGroup";
				case  1599:
					return "RelationshipRiskCFICode";
				case  1600:
					return "RelationshipRiskSecurityType";
				case  1601:
					return "RelationshipRiskSecuritySubType";
				case  1602:
					return "RelationshipRiskMaturityMonthYear";
				case  1603:
					return "RelationshipRiskMaturityTime";
				case  1604:
					return "RelationshipRiskRestructuringType";
				case  1605:
					return "RelationshipRiskSeniority";
				case  1606:
					return "RelationshipRiskPutOrCall";
				case  1607:
					return "RelationshipRiskFlexibleIndicator";
				case  1608:
					return "RelationshipRiskCouponRate";
				case  1609:
					return "RelationshipRiskSecurityExchange";
				case  1610:
					return "RelationshipRiskSecurityDesc";
				case  1611:
					return "RelationshipRiskInstrumentSettlType";
				case  1612:
					return "RelationshipRiskInstrumentMultiplier";
				case  1613:
					return "NoRelationshipRiskWarningLevels";
				case  1614:
					return "RelationshipRiskWarningLevelPercent";
				case  1615:
					return "RelationshipRiskWarningLevelName";
				case  1616:
					return "RiskSecurityExchange";
				case  1617:
					return "StreamAsgnType";
				case  1618:
					return "RelationshipRiskEncodedSecurityDescLen";
				case  1619:
					return "RelationshipRiskEncodedSecurityDesc";
				case  1620:
					return "RiskEncodedSecurityDescLen";
				case  1621:
					return "RiskEncodedSecurityDesc";
				case 7558:
					return "ExpireSeconds";
				default:
					return "Not found" + (object)tag;
			}
		}
	}
}
