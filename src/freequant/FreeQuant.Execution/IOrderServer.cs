// Type: SmartQuant.Execution.IOrderServer
// Assembly: SmartQuant.Execution, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: 444CC37E-F17B-4ED8-9FD1-FAF0B8C26A05
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Execution.dll

using SmartQuant.FIX;
using System;

namespace SmartQuant.Execution
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
