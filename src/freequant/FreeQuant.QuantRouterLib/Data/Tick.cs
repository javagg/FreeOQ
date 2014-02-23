using System;

namespace FreeQuant.QuantRouterLib.Data
{
    public class Tick
    {
        public int RequestId { get; set; }

        public int SourceId { get; set; }

        public TickType TickType { get; set; }

        public DateTime DateTime { get; set; }

        public double Price { get; set; }

        public int Size { get; set; }
    }
}
