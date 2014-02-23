using System;

namespace FreeQuant.QuantRouterLib.Data
{
    public class ProviderErrorEventArgs : EventArgs
    {
        public ProviderError Error { get; private set; }

        public ProviderErrorEventArgs(ProviderError error)
        {
            this.Error = error;
        }
    }
}
