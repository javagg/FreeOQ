using CJ5Xsgeg9JvhJUnvO3D;
using FreeQuant.FIX;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Y9kGLiKILMabFE38T3;

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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fCommission;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fCommission = value;
      }
    }

    [Description("Commission type (FIX definitions : 1 = per unit (implying shares, par, currency, etc) 2 = percentage 3 = absolute (total monetary amount))")]
    [Category("Parameter")]
    [DefaultValue(CommType.PerShare)]
    public virtual CommType CommType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fCommType;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fCommType = value;
      }
    }

    [DefaultValue(0.0)]
    [Category("Parameter")]
    [Description("Minimal commission, absolute value")]
    public virtual double MinCommission
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMinCommission;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMinCommission = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CommissionProvider()
    {
      eekpcgzPjZLOyP2Ysv.eyppkuTzDkifX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fCommType = CommType.PerShare;
      this.fCommission = 0.0;
      this.fMinCommission = 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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
            throw new NotSupportedException(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(2332) + (object) this.fCommType);
        }
        if (num < this.fMinCommission)
        {
          fixCommissionData.CommType = '3';
          fixCommissionData.Commission = this.fMinCommission;
        }
      }
      return fixCommissionData;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return v6F3C32VVUpp2OYb5n.VVyFVqM4b6(2406);
    }
  }
}
