using System;

namespace FreeQuant.QuantRouterLib.Data
{
    [Flags]
    public enum TickType : byte
    {
        Unknown = 0,
        Bid = 1,
        Ask = 2,
        Trade = 4,
        Level2 = 8,
    }
}
