using System;

namespace FreeQuant.QuantRouterLib.Data
{
    public class ProviderError
    {
        public byte ProviderId { get; set; }

        public ProviderErrorType ErrorType { get; set; }

        public DateTime DateTime { get; set; }

        public int Id { get; set; }

        public int Code { get; set; }

        public string Description { get; set; }
    }
}
