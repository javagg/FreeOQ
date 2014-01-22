using FreeQuant.FIX;
using System.Collections;

namespace FreeQuant.Execution
{
  public class OrderListTable : InstrumentOrderListTable
  {
    private Hashtable DX1Eba8GVl;

    public InstrumentOrderListTable this[IFIXInstrument instrument]
    {
       get
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

    
		public OrderListTable():base()
    {
      this.DX1Eba8GVl = new Hashtable();
    }

    public override void Clear()
    {
      base.Clear();
      this.DX1Eba8GVl.Clear();
    }

    
    public override void Add(SingleOrder order)
    {
      base.Add(order);
      this[(IFIXInstrument) order.Instrument].Add(order);
    }

    
    public override void Remove(SingleOrder order)
    {
      base.Remove(order);
      this[(IFIXInstrument) order.Instrument].Remove(order);
    }

    
    public override void Update(SingleOrder order)
    {
      base.Update(order);
      this[(IFIXInstrument) order.Instrument].Update(order);
    }
  }
}
