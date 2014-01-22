using FreeQuant.FIX;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Simulation
{
  public class CommissionProvider : ICommissionProvider
  {
    protected CommType fCommType;
    protected double fCommission;
    protected double fMinCommission;

    [Category("Parameter")]
    [DefaultValue(0.0)]
    [Description("Commission value (depends on Commission Type)")]
    public virtual double Commission
    {
       get
      {
        return this.fCommission;
      }
       set
      {
        this.fCommission = value;
      }
    }

    [Description("Commission type (FIX definitions : 1 = per unit (implying shares, par, currency, etc) 2 = percentage 3 = absolute (total monetary amount))")]
    [Category("Parameter")]
    [DefaultValue(CommType.PerShare)]
    public virtual CommType CommType
    {
       get
      {
        return this.fCommType;
      }
       set
      {
        this.fCommType = value;
      }
    }

    [DefaultValue(0.0)]
    [Category("Parameter")]
    [Description("Minimal commission, absolute value")]
    public virtual double MinCommission
    {
       get
      {
        return this.fMinCommission;
      }
       set
      {
        this.fMinCommission = value;
      }
    }

    
    public CommissionProvider()
    {
      this.fCommType = CommType.PerShare;
      this.fCommission = 0.0;
      this.fMinCommission = 0.0;
    }

    
    public virtual FIXCommissionData GetCommissionData(FIXExecutionReport report)
    {
      FIXCommissionData fixCommissionData = new FIXCommissionData();
      fixCommissionData.CommType = FIXCommType.ToFIX(this.fCommType);
      fixCommissionData.Commission = this.fCommission;
      if (this.fMinCommission != 0.0)
      {
        double num;
        switch (this.fCommType)
        {
          case CommType.PerShare:
            num = this.fCommission * report.CumQty;
            break;
          case CommType.Percent:
            num = this.fCommission * report.CumQty * report.AvgPx;
            break;
          case CommType.Absolute:
            num = this.fCommission;
            break;
          default:
						throw new NotSupportedException("");
        }
        if (num < this.fMinCommission)
        {
          fixCommissionData.CommType = '3';
          fixCommissionData.Commission = this.fMinCommission;
        }
      }
      return fixCommissionData;
    }

    
    public override string ToString()
    {
			return "CommissionProvider";
    }
  }
}
