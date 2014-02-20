namespace FreeQuant.FIX
{
    public class NewOrderSingle : FIXNewOrderSingle
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

        public new FaMethod FaMethod
        {
            get
            {
                return FIXFaMethod.FromFIX(base.FaMethod);
            }
            set
            {
                base.FaMethod = FIXFaMethod.ToFIX(value);
            }
        }
    }
}
