using FreeQuant;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using FreeQuant.Services;
using FreeQuant.Xml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Simulation
{
  public class SimulationExecutionService : ServiceBase, IExecutionService, IMarketService, IService
  {
    private const string CDaeUACt7D = "Information";
    private const string U60eNamwck = "Status";
    private const string ndTeZAipqv = "Settings";
    private const string Yooe821q6y = "simulator.execution.xml";
    private OrderEntryList RfIejmtUHA;
    private List<OrderEntry> yQseuHHKll;

    [Category("Settings")]
    public OrderEntryList Entries
    {
       get
      {
        return this.RfIejmtUHA;
      }
    }

    [Category("Information")]
    public override byte Id
    {
       get
      {
        return (byte) 1;
      }
    }

    [Category("Information")]
    public override string Name
    {
       get
      {
				return "Name";
      }
    }

    [Category("Information")]
    public override string Description
    {
       get
      {
				return "simut.Description";
      }
    }

    [Category("Status")]
    public override ServiceStatus Status
    {
       get
      {
        return base.Status;
      }
    }

    public event FIXNewOrderSingleEventHandler NewOrderSingle;

    public event FIXOrderCancelRequestEventHandler OrderCancelRequest;

    public event FIXOrderCancelReplaceRequestEventHandler OrderCancelReplaceRequest;

    public event FIXLogonEventHandler Logon;

    public event FIXLogoutEventHandler Logout;

    
		public SimulationExecutionService() : base()
    {

      this.RfIejmtUHA = new OrderEntryList();
      this.yQseuHHKll = new List<OrderEntry>();
      this.zpaevs5ZvV();
      ServiceManager.Add((IService) this);
      ServiceManager.ExecutionSimulator = (IExecutionService) this;
    }

    
    public override void Start()
    {
      if (this.status != ServiceStatus.Stopped)
        return;
      Simulator simulator = ((SimulationDataProvider) ProviderManager.MarketDataSimulator).Simulator;
      simulator.StateChanged += new EventHandler(this.dXSeJAw0dn);
      simulator.NewObject += new SeriesObjectEventHandler(this.To9e7FASSf);
      this.SetServiceStatus(ServiceStatus.Started);
    }

    
    public override void Stop()
    {
      if (this.status != ServiceStatus.Started)
        return;
      Simulator simulator = ((SimulationDataProvider) ProviderManager.MarketDataSimulator).Simulator;
      simulator.StateChanged -= new EventHandler(this.dXSeJAw0dn);
      simulator.NewObject -= new SeriesObjectEventHandler(this.To9e7FASSf);
      this.SetServiceStatus(ServiceStatus.Stopped);
    }

    
    public void Send(FIXExecutionReport message)
    {
    }

    
    public void Send(FIXOrderCancelReject message)
    {
			throw new Exception("Send Exception");
    }

    
    public void Send(FIXLogon message)
    {
			throw new Exception("Send Exception");
    }

    
    public void Send(FIXLogout message)
    {
			throw new Exception("Send Exception");
    }

    
    private void dXSeJAw0dn([In] object obj0, [In] EventArgs obj1)
    {
      switch (((SimulationDataProvider) ProviderManager.MarketDataSimulator).Simulator.CurrentState)
      {
        case SimulatorState.Stopped:
          this.yQseuHHKll.Clear();
          break;
        case SimulatorState.Running:
          this.yQseuHHKll.Clear();
          IEnumerator enumerator = this.RfIejmtUHA.GetEnumerator();
          try
          {
            while (enumerator.MoveNext())
            {
              OrderEntry orderEntry = (OrderEntry) enumerator.Current;
              if (orderEntry.Enabled)
                this.yQseuHHKll.Add(orderEntry);
            }
            break;
          }
          finally
          {
            IDisposable disposable = enumerator as IDisposable;
            if (disposable != null)
              disposable.Dispose();
          }
      }
    }

    
    private void To9e7FASSf([In] SeriesObjectEventArgs obj0)
    {
      while (this.yQseuHHKll.Count > 0)
      {
        OrderEntry orderEntry = this.yQseuHHKll[0];
        if (!(orderEntry.DateTime <= obj0.Object.DateTime))
          break;
        this.yQseuHHKll.RemoveAt(0);
        this.j7FeG7ltt3(orderEntry);
      }
    }

    
    private void j7FeG7ltt3([In] OrderEntry obj0)
    {
      SingleOrder singleOrder = new SingleOrder();
      singleOrder.TransactTime = Clock.Now;
      singleOrder.Instrument = obj0.Instrument;
      singleOrder.Side = obj0.Side;
      singleOrder.OrdType = obj0.OrdType;
      singleOrder.Price = obj0.Price;
      singleOrder.StopPx = obj0.StopPx;
      singleOrder.OrderQty = obj0.OrderQty;
      singleOrder.Text = obj0.Text;
//      if (this.VOQeTqxjH5 == null)
//        return;
//      this.VOQeTqxjH5((object) this, new FIXNewOrderSingleEventArgs((FIXNewOrderSingle) singleOrder));
    }

    
    internal void vSoeaZ8DfK()
    {
//      jHlkoKNvYKqUEkgu3D hlkoKnvYkqUekgu3D = new jHlkoKNvYKqUEkgu3D();
//      foreach (OrderEntry orderEntry in this.RfIejmtUHA)
//        hlkoKnvYkqUekgu3D.CP4y1KPBFu().umBU4R1dm(orderEntry);
//      hlkoKnvYkqUekgu3D.Save(this.jLCe4X7YLp());
    }

    
    private void zpaevs5ZvV()
    {
//      string str = this.jLCe4X7YLp();
//      if (!File.Exists(str))
//        return;
//      jHlkoKNvYKqUEkgu3D hlkoKnvYkqUekgu3D = new jHlkoKNvYKqUEkgu3D();
//      hlkoKnvYkqUekgu3D.Load(str);
//      foreach (xsRJHu8Z4yfDTS2Z7y rjHu8Z4yfDtS2Z7y in (ListXmlNode<xsRJHu8Z4yfDTS2Z7y>) hlkoKnvYkqUekgu3D.CP4y1KPBFu())
//        this.RfIejmtUHA.Add(new OrderEntry()
//        {
//          Enabled = rjHu8Z4yfDtS2Z7y.BP8yYcQUn3(),
//          DateTime = rjHu8Z4yfDtS2Z7y.DateTime.Value,
//          Instrument = InstrumentManager.Instruments[rjHu8Z4yfDtS2Z7y.XVXyIVKEAZ().Value],
//          Side = rjHu8Z4yfDtS2Z7y.Side.Value,
//          OrdType = rjHu8Z4yfDtS2Z7y.OrdType.Value,
//          Price = rjHu8Z4yfDtS2Z7y.Price.Value,
//          StopPx = rjHu8Z4yfDtS2Z7y.StopPx.Value,
//          OrderQty = rjHu8Z4yfDtS2Z7y.OrderQty.Value,
//          Text = rjHu8Z4yfDtS2Z7y.Text.Value
//        });
    }

    
    private string jLCe4X7YLp()
    {
			return string.Format("", Framework.Installation.IniDir.FullName, "");
    }
  }
}
