using FreeQuant.FIX;
using System;

namespace FreeQuant.Execution
{
  public interface IOrderServer
  {
    void Open(Type connectionType, string connectionString);

    OrderList Load();

    void AddOrder(IOrder order);

    void AddReport(IOrder order, FIXExecutionReport report);

    void Remove(IOrder order);

    void Close();
  }
}
