namespace FreeQuant.FIX
{
    public class Reject : FIXReject
    {
        public new SessionRejectReason SessionRejectReason
        {
            get
            {
                return FIXSessionRejectReason.FromFIX(base.SessionRejectReason);
            }
            set
            {
                base.SessionRejectReason = FIXSessionRejectReason.ToFIX(value);
            }
        }
    }
}
