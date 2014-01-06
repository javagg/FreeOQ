namespace OpenQuant.API
{
  public enum ExecutionReportType
  {
    Undefined,
    New,
    PartialFill,
    Fill,
    DoneForDay,
    Cancelled,
    Replace,
    PendingCancel,
    Stopped,
    Rejected,
    Suspended,
    PendingNew,
    Calculated,
    Expired,
    Restarted,
    PendingReplace,
    Trade,
    TradeCorrect,
    TradeCancel,
    OrderStatus,
    CancelReject,
    ReplaceReject,
  }
}
