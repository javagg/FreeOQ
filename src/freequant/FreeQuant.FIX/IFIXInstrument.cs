// Type: SmartQuant.FIX.IFIXInstrument
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using System;

namespace SmartQuant.FIX
{
  public interface IFIXInstrument
  {
    int Id { get; set; }

    [FIXField("55", EFieldOption.Optional)]
    string Symbol { get; set; }

    [FIXField("65", EFieldOption.Optional)]
    string SymbolSfx { get; set; }

    [FIXField("48", EFieldOption.Optional)]
    string SecurityID { get; set; }

    [FIXField("22", EFieldOption.Optional)]
    string SecurityIDSource { get; set; }

    [FIXField("454", EFieldOption.Optional)]
    int NoSecurityAltID { get; }

    [FIXField("460", EFieldOption.Optional)]
    int Product { get; set; }

    [FIXField("461", EFieldOption.Optional)]
    string CFICode { get; set; }

    [FIXField("167", EFieldOption.Optional)]
    string SecurityType { get; set; }

    [FIXField("762", EFieldOption.Optional)]
    string SecuritySubType { get; set; }

    [FIXField("200", EFieldOption.Optional)]
    string MaturityMonthYear { get; set; }

    [FIXField("205", EFieldOption.Optional)]
    string MaturityDay { get; set; }

    [FIXField("541", EFieldOption.Optional)]
    DateTime MaturityDate { get; set; }

    [FIXField("201", EFieldOption.Optional)]
    int PutOrCall { get; set; }

    [FIXField("224", EFieldOption.Optional)]
    DateTime CouponPaymentDate { get; set; }

    [FIXField("225", EFieldOption.Optional)]
    DateTime IssueDate { get; set; }

    [FIXField("239", EFieldOption.Optional)]
    int RepoCollateralSecurityType { get; set; }

    [FIXField("226", EFieldOption.Optional)]
    int RepurchaseTerm { get; set; }

    [FIXField("227", EFieldOption.Optional)]
    double RepurchaseRate { get; set; }

    [FIXField("228", EFieldOption.Optional)]
    double Factor { get; set; }

    [FIXField("255", EFieldOption.Optional)]
    string CreditRating { get; set; }

    [FIXField("543", EFieldOption.Optional)]
    string InstrRegistry { get; set; }

    [FIXField("470", EFieldOption.Optional)]
    string CountryOfIssue { get; set; }

    [FIXField("471", EFieldOption.Optional)]
    string StateOrProvinceOfIssue { get; set; }

    [FIXField("472", EFieldOption.Optional)]
    string LocaleOfIssue { get; set; }

    [FIXField("240", EFieldOption.Optional)]
    DateTime RedemptionDate { get; set; }

    [FIXField("202", EFieldOption.Optional)]
    double StrikePrice { get; set; }

    [FIXField("947", EFieldOption.Optional)]
    string StrikeCurrency { get; set; }

    [FIXField("206", EFieldOption.Optional)]
    char OptAttribute { get; set; }

    [FIXField("231", EFieldOption.Optional)]
    double ContractMultiplier { get; set; }

    [FIXField("223", EFieldOption.Optional)]
    double CouponRate { get; set; }

    [FIXField("207", EFieldOption.Optional)]
    string SecurityExchange { get; set; }

    [FIXField("106", EFieldOption.Optional)]
    string Issuer { get; set; }

    [FIXField("348", EFieldOption.Optional)]
    int EncodedIssuerLen { get; set; }

    [FIXField("349", EFieldOption.Optional)]
    string EncodedIssuer { get; set; }

    [FIXField("107", EFieldOption.Optional)]
    string SecurityDesc { get; set; }

    [FIXField("350", EFieldOption.Optional)]
    int EncodedSecurityDescLen { get; set; }

    [FIXField("351", EFieldOption.Optional)]
    string EncodedSecurityDesc { get; set; }

    [FIXField("691", EFieldOption.Optional)]
    string Pool { get; set; }

    [FIXField("667", EFieldOption.Optional)]
    string ContractSettlMonth { get; set; }

    [FIXField("875", EFieldOption.Optional)]
    int CPProgram { get; set; }

    [FIXField("876", EFieldOption.Optional)]
    string CPRegType { get; set; }

    [FIXField("864", EFieldOption.Optional)]
    int NoEvents { get; set; }

    [FIXField("873", EFieldOption.Optional)]
    DateTime DatedDate { get; set; }

    [FIXField("874", EFieldOption.Optional)]
    DateTime InterestAccrualDate { get; set; }

    bool ContainsField(int tag);

    FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i);

    void AddGroup(FIXSecurityAltIDGroup group);

    FIXEventsGroup GetEventsGroup(int i);

    void AddGroup(FIXEventsGroup group);
  }
}
