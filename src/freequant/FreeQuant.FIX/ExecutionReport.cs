using System.ComponentModel;

namespace FreeQuant.FIX
{
	public class ExecutionReport : FIXExecutionReport
	{
		[Category("Attributes")]
		new public Side Side
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
		new public OrdType OrdType
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
		new public OrdStatus OrdStatus
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
		new public TimeInForce TimeInForce
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
		new public ExecTransType ExecTransType
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
		new public ExecType ExecType
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
		new public CommType CommType
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
