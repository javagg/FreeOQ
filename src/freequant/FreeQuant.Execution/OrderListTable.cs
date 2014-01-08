using RZ1j9O1DCcsDf19ge6;
using FreeQuant.FIX;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Execution
{
  public class OrderListTable : InstrumentOrderListTable
  {
    private Hashtable DX1Eba8GVl;

    public InstrumentOrderListTable this[IFIXInstrument instrument]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        InstrumentOrderListTable instrumentOrderListTable = this.DX1Eba8GVl[(object) instrument] as InstrumentOrderListTable;
        if (instrumentOrderListTable == null)
        {
          instrumentOrderListTable = new InstrumentOrderListTable();
          this.DX1Eba8GVl.Add((object) instrument, (object) instrumentOrderListTable);
        }
        return instrumentOrderListTable;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderListTable()
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.DX1Eba8GVl = new Hashtable();
    }

    public override void Clear()
    {
      base.Clear();
      this.DX1Eba8GVl.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Add(SingleOrder order)
    {
      base.Add(order);
      this[(IFIXInstrument) order.Instrument].Add(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Remove(SingleOrder order)
    {
      base.Remove(order);
      this[(IFIXInstrument) order.Instrument].Remove(order);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Update(SingleOrder order)
    {
      base.Update(order);
      this[(IFIXInstrument) order.Instrument].Update(order);
    }
  }
}
