using System;

namespace FreeQuant.QuantRouterLib.Data
{
    [Flags]
    public enum ProviderErrorType : byte
    {
        Error = 0,
        Warning = 1,
        Information = 2,
    }
}
