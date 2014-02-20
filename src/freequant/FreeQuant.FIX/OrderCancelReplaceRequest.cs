namespace FreeQuant.FIX
{
    public class OrderCancelReplaceRequest : FIXOrderCancelReplaceRequest
    {
        public new Side Side
        {
            get
            {
                return FIXSide.FromFIX(base.Side);
            }
            set
            {
                base.Side = FIXSide.ToFIX(value);
            }
        }

        public new OrdType OrdType
        {
            get
            {
                return FIXOrdType.FromFIX(base.OrdType);
            }
            set
            {
                base.OrdType = FIXOrdType.ToFIX(value);
            }
        }

        public new TimeInForce TimeInForce
        {
            get
            {
                return FIXTimeInForce.FromFIX(base.TimeInForce);
            }
            set
            {
                base.TimeInForce = FIXTimeInForce.ToFIX(value);
            }
        }
    }
}
