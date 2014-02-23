using System;

namespace FreeQuant.QuantRouterLib
{
    public class ConnectionEventArgs : EventArgs
    {
        public IConnection Connection { get; private set; }

        public ConnectionEventArgs(IConnection connection)
        {
            this.Connection = connection;
        }
    }
}
