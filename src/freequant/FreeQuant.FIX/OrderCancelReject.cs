namespace FreeQuant.FIX
{
    public class OrderCancelReject : FIXOrderCancelReject
    {
        public new OrdStatus OrdStatus
        {
            get
            {
                return FIXOrdStatus.FromFIX(base.OrdStatus);
            }
            set
            {
                base.OrdStatus = FIXOrdStatus.ToFIX(value);
            }
        }

        public new CxlRejResponseTo CxlRejResponseTo
        {
            get
            {
                return FIXCxlRejResponseTo.FromFIX(base.CxlRejResponseTo);
            }
            set
            {
                base.CxlRejResponseTo = FIXCxlRejResponseTo.ToFIX(value);
            }
        }

        public new CxlRejReason CxlRejReason
        {
            get
            {
                return FIXCxlRejReason.FromFIX(base.CxlRejReason);
            }
            set
            {
                base.CxlRejReason = FIXCxlRejReason.ToFIX(value);
            }
        }
    }
}
