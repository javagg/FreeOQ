namespace FreeQuant.FIX
{
  public enum PosReqResult
  {
    ValidRequest,
    InvalidOrUnsupportedRequest,
    NoPositionsFound,
    NotAuthorized,
    RequestForPositionNotSupported,
    Other,
  }
}
