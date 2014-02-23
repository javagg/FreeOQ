using System;

namespace FreeQuant.QuantRouterLib.Data
{
    public class SubscriptionStatusEventArgs : EventArgs
    {
        public SubscriptionStatus Status { get; private set; }

        public SubscriptionStatusEventArgs(SubscriptionStatus status)
        {
            this.Status = status;
        }
    }
}
