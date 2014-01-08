namespace FreeQuant.FIX
{
  public enum MDReqRejReason
  {
    UnknownSymbol,
    DuplicateMDReqID,
    InsufficientBandwidth,
    InsufficientPermissions,
    UnsupportedSubscriptionRequestType,
    UnsupportedMarketDepth,
    UnsupportedMDUpdateType,
    UnsupportedAggregatedBook,
    UnsupportedMDEntryType,
    UnsupportedTradingSessionID,
    UnsupportedScope,
    UnsupportedOpenCloseSettleFlag,
    UnsupportedMDImplicitDelete,
  }
}
