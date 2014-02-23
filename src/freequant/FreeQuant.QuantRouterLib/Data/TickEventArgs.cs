using System;

namespace FreeQuant.QuantRouterLib.Data
{
    public class TickEventArgs : EventArgs
    {
        public Tick Tick { get; private set; }

        public TickEventArgs(Tick tick)
        {
            this.Tick = tick;
        }
    }
}
