namespace OpenQuant.API
{
  public enum OrderStatus
  {
    PendingNew,
    New,
    PartiallyFilled,
    Filled,
    PendingCancel,
    Cancelled,
    Expired,
    PendingReplace,
    Replaced,
    Rejected
  }
}
