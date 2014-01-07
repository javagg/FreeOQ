using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;

namespace FreeQuant.Execution
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
