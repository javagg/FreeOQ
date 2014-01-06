using FreeQuant.FIX;
using System;
using System.ComponentModel;

namespace OpenQuant.API
{
  public class ExecutionReport
  {
    private const string CATEGORY_APPEARANCE = "Appearance";
    private const string CATEGORY_EXECUTION = "Execution";
    internal FIXMessage message;

    [Category("Appearance")]
    public DateTime DateTime
    {
      get
      {
        return this.message.GetDateTimeValue(60);
      }
    }

    public OrderStatus OrderStatus
    {
      get
      {
        return EnumConverter.Convert(FIXOrdStatus.FromFIX(this.message.GetCharValue(39)));
      }
    }

    [Category("Appearance")]
    public double LastQty
    {
      get
      {
        return this.message.GetDoubleValue(32);
      }
    }

    [Category("Appearance")]
    public double CumQty
    {
      get
      {
        return this.message.GetDoubleValue(14);
      }
    }

    [Category("Execution")]
    public double LeavesQty
    {
      get
      {
        return this.message.GetDoubleValue(151);
      }
    }

    [Category("Execution")]
    public double Qty
    {
      get
      {
        return this.message.GetDoubleValue(38);
      }
    }

    [Category("Appearance")]
    public double LastPrice
    {
      get
      {
        return this.message.GetDoubleValue(31);
      }
    }

    [Category("Appearance")]
    public double AvgPrice
    {
      get
      {
        return this.message.GetDoubleValue(6);
      }
    }

    [Category("Appearance")]
    public string Text
    {
      get
      {
        return this.message.GetStringValue(58);
      }
    }

    [Category("Appearance")]
    public double Price
    {
      get
      {
        return this.message.GetDoubleValue(44);
      }
    }

    [Category("Appearance")]
    public double StopPrice
    {
      get
      {
        return this.message.GetDoubleValue(99);
      }
    }

    [Category("Appearance")]
    public TimeInForce TimeInForce
    {
      get
      {
        switch (this.message.GetCharValue(59))
        {
          case '0':
            return TimeInForce.Day;
          case '1':
            return TimeInForce.GTC;
          case '2':
            return TimeInForce.OPG;
          case '3':
            return TimeInForce.IOC;
          case '4':
            return TimeInForce.FOK;
          case '5':
            return TimeInForce.GTX;
          case '6':
            return TimeInForce.GTD;
          case '7':
            return TimeInForce.ATC;
          case 'X':
            return TimeInForce.GFS;
          default:
            return TimeInForce.Day;
        }
      }
    }

    [Category("Appearance")]
    public ExecutionReportType Type
    {
      get
      {
        switch (this.message.GetCharValue(150))
        {
          case '0':
            return ExecutionReportType.New;
          case '1':
            return ExecutionReportType.PartialFill;
          case '2':
            return ExecutionReportType.Fill;
          case '3':
            return ExecutionReportType.DoneForDay;
          case '4':
            return ExecutionReportType.Cancelled;
          case '5':
            return ExecutionReportType.Replace;
          case '6':
            return ExecutionReportType.PendingCancel;
          case '7':
            return ExecutionReportType.Stopped;
          case '8':
            return ExecutionReportType.Rejected;
          case '9':
            return ExecutionReportType.Suspended;
          case 'A':
            return ExecutionReportType.PendingNew;
          case 'B':
            return ExecutionReportType.Calculated;
          case 'C':
            return ExecutionReportType.Expired;
          case 'D':
            return ExecutionReportType.Restarted;
          case 'E':
            return ExecutionReportType.PendingReplace;
          case 'F':
            return ExecutionReportType.Trade;
          case 'G':
            return ExecutionReportType.TradeCorrect;
          case 'H':
            return ExecutionReportType.TradeCancel;
          case 'I':
            return ExecutionReportType.OrderStatus;
          default:
            switch (this.message.GetCharValue(434))
            {
              case '1':
                return ExecutionReportType.CancelReject;
              case '2':
                return ExecutionReportType.ReplaceReject;
              default:
                return ExecutionReportType.Undefined;
            }
        }
      }
    }

    internal ExecutionReport(FIXMessage message)
    {
      this.message = message;
    }
  }
}
