using System;

namespace FreeQuant.QuantRouterLib.Data
{
    public class HeartbeatEventArgs : EventArgs
    {
        public Heartbeat Heartbeat { get; private set; }

        public HeartbeatEventArgs(Heartbeat heartbeat)
        {
            this.Heartbeat = heartbeat;
        }
    }
}
