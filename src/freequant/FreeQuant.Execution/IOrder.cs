// Type: SmartQuant.Execution.IOrder
// Assembly: SmartQuant.Execution, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: 444CC37E-F17B-4ED8-9FD1-FAF0B8C26A05
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Execution.dll

using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using System;

namespace SmartQuant.Execution
{
  public interface IOrder
  {
    string OrderID { get; }

    string ClOrdID { get; set; }

    int Id { get; set; }

    Instrument Instrument { get; set; }

    IExecutionProvider Provider { get; set; }

    Portfolio Portfolio { get; set; }

    bool Persistent { get; set; }

    ExecutionReportList Reports { get; }

    event EventHandler StatusChanged;

    event ExecutionReportEventHandler ExecutionReport;
  }
}
