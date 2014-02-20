using FreeQuant.FIX;

namespace FreeQuant.Instruments
{
    class RequestItem
    {
        private FIXMarketDataRequest request;
        private int id;

        internal RequestItem(FIXMarketDataRequest request)
        {
            this.request = request;
            this.id = 0;
        }

        
        
        internal FIXMarketDataRequest GetFIXMarketDataRequest()
        {
            return this.request;
        }

        
        
        internal int GetRequestId()
        {
            return this.id;
        }

        
        
        internal void SetRequestId(int id)
        {
            this.id = id;
        }
    }
}
