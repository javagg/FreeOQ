using System;
using FreeQuant.FIX;

namespace FreeQuant.Execution
{
    class OrderFileServer : IOrderServer
    {
        public OrderFileServer()
        {
        }

        public void Open(Type connectionType, string connectionString)
        {

        }

        public OrderList Load()
        {
            return new OrderList();
        }

        public void AddOrder(IOrder order)
        {

        }

        public void AddReport(IOrder order, FIXExecutionReport report)
        {

        }

        public void Remove(IOrder order)
        {

        }

        public void Close()
        {

        }
    }
}

