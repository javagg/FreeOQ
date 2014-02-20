namespace FreeQuant.FIX
{
    public class MarketDataRequestReject : FIXMarketDataRequestReject
    {
        public new MDReqRejReason MDReqRejReason
        {
            get
            {
                return FIXMDReqRejReason.FromFIX(base.MDReqRejReason);
            }
            set
            {
                base.MDReqRejReason = FIXMDReqRejReason.ToFIX(value);
            }
        }
    }
}
