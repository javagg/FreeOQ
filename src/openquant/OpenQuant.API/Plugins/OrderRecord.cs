using FreeQuant.Execution;
using FreeQuant.FIX;

namespace OpenQuant.API.Plugins
{
  internal class OrderRecord
  {
    private SingleOrder order;
    private double avgPx;
    private int leavesQty;
    private int cumQty;

    public SingleOrder Order
    {
      get
      {
        return this.order;
      }
    }

    public double AvgPx
    {
      get
      {
        return this.avgPx;
      }
    }

    public int LeavesQty
    {
      get
      {
        return this.leavesQty;
      }
      internal set
      {
        this.leavesQty = value;
      }
    }

    public int CumQty
    {
      get
      {
        return this.cumQty;
      }
    }

    public OrderRecord(SingleOrder order)
    {
      this.order = order;
      this.avgPx = 0.0;
      this.leavesQty = (int) ((FIXNewOrderSingle) order).OrderQty;
      this.cumQty = 0;
    }

    public void AddFill(double lastPx, int lastQty)
    {
      this.avgPx = (this.avgPx * (double) this.cumQty + lastPx * (double) lastQty) / (double) (this.cumQty + lastQty);
      this.leavesQty -= lastQty;
      this.cumQty += lastQty;
    }
  }
}
