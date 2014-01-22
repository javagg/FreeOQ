using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class ExecutionReport : FIXExecutionReport
  {
    [Category("Attributes")]
    public Side Side
    {
       get
      {
        return FIXSide.FromFIX(base.Side);
      }
       set
      {
        base.Side = FIXSide.ToFIX(value);
      }
    }

    [Category("Attributes")]
    public OrdType OrdType
    {
       get
      {
        return FIXOrdType.FromFIX(base.OrdType);
      }
       set
      {
        base.OrdType = FIXOrdType.ToFIX(value);
      }
    }

    [Category("Attributes")]
    public OrdStatus OrdStatus
    {
       get
      {
        return FIXOrdStatus.FromFIX(base.OrdStatus);
      }
       set
      {
        base.OrdStatus = FIXOrdStatus.ToFIX(value);
      }
    }

    [Category("Attributes")]
    public TimeInForce TimeInForce
    {
       get
      {
        return FIXTimeInForce.FromFIX(base.TimeInForce);
      }
       set
      {
        base.TimeInForce = FIXTimeInForce.ToFIX(value);
      }
    }

    [Category("Attributes")]
    public ExecTransType ExecTransType
    {
       get
      {
        return FIXExecTransType.FromFIX(base.ExecTransType);
      }
       set
      {
        base.ExecTransType = FIXExecTransType.ToFIX(value);
      }
    }

    [Category("Attributes")]
    public ExecType ExecType
    {
       get
      {
        return FIXExecType.FromFIX(base.ExecType);
      }
       set
      {
        base.ExecType = FIXExecType.ToFIX(value);
      }
    }

    [Category("Commission")]
    public CommType CommType
    {
       get
      {
        return FIXCommType.FromFIX(base.CommType);
      }
       set
      {
        base.CommType = FIXCommType.ToFIX(value);
      }
    }

  }
}
