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
		private OrderEntryList entries;
		private List<OrderEntry> orders;

		[Category("Settings")]
		public OrderEntryList Entries
		{
			get
			{
				return this.entries;  
			}
		}

		[Category("Information")]
		public override byte Id
		{
			get
			{
				return 1;
			}
		}

		[Category("Information")]
		public override string Name
		{
			get
			{
				return "SimulationExecutionService";
			}
		}

		[Category("Information")]
		public override string Description
		{
			get
			{
				return "SimulationExecutionService";
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
			this.entries = new OrderEntryList();
			this.orders = new List<OrderEntry>();
			this.zpaevs5ZvV();
			ServiceManager.Add(this);
			ServiceManager.ExecutionSimulator = this;
		}

		public override void Start()
		{
			if (this.status != ServiceStatus.Stopped)
				return;
			Simulator simulator = ((SimulationDataProvider)ProviderManager.MarketDataSimulator).Simulator;
			simulator.StateChanged += new EventHandler(this.OnStateChanged);
			simulator.NewObject += new SeriesObjectEventHandler(this.OnNewObject);
			this.SetServiceStatus(ServiceStatus.Started);
		}

		public override void Stop()
		{
			if (this.status != ServiceStatus.Started)
				return;
			Simulator simulator = ((SimulationDataProvider)ProviderManager.MarketDataSimulator).Simulator;
			simulator.StateChanged -= new EventHandler(this.OnStateChanged);
			simulator.NewObject -= new SeriesObjectEventHandler(this.OnNewObject);
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

		private void OnStateChanged(object sender, EventArgs e)
		{
			switch (((SimulationDataProvider)ProviderManager.MarketDataSimulator).Simulator.CurrentState)
			{
				case SimulatorState.Stopped:
					this.orders.Clear();
					break;
				case SimulatorState.Running:
					this.orders.Clear();
					IEnumerator enumerator = this.entries.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							OrderEntry orderEntry = (OrderEntry)enumerator.Current;
							if (orderEntry.Enabled)
								this.orders.Add(orderEntry);
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

		private void OnNewObject(SeriesObjectEventArgs e)
		{
			while (this.orders.Count > 0)
			{
				OrderEntry orderEntry = this.orders[0];
				if (!(orderEntry.DateTime <= e.Object.DateTime))
					break;
				this.orders.RemoveAt(0);
				this.j7FeG7ltt3(orderEntry);
			}
		}

		private void j7FeG7ltt3(OrderEntry entry)
		{
			SingleOrder order = new SingleOrder();
			order.TransactTime = DateTime.Now;
			order.Instrument = entry.Instrument;
			order.Side = entry.Side;
			order.OrdType = entry.OrdType;
			order.Price = entry.Price;
			order.StopPx = entry.StopPx;
			order.OrderQty = entry.OrderQty;
			order.Text = entry.Text;
      if (this.NewOrderSingle != null)
      	this.NewOrderSingle(this, new FIXNewOrderSingleEventArgs(order));
		}

		internal void vSoeaZ8DfK()
		{
//      jHlkoKNvYKqUEkgu3D hlkoKnvYkqUekgu3D = new jHlkoKNvYKqUEkgu3D();
//      foreach (OrderEntry orderEntry in this.entries)
//        hlkoKnvYkqUekgu3D.CP4y1KPBFu().umBU4R1dm(orderEntry);
//      hlkoKnvYkqUekgu3D.Save(this.GetFilename());
		}

		private void zpaevs5ZvV()
		{
			string filename  = this.GetFilename();
      if (!File.Exists(filename))
        return;
//      jHlkoKNvYKqUEkgu3D hlkoKnvYkqUekgu3D = new jHlkoKNvYKqUEkgu3D();
//      hlkoKnvYkqUekgu3D.Load(filename);
//      foreach (xsRJHu8Z4yfDTS2Z7y rjHu8Z4yfDtS2Z7y in (ListXmlNode<xsRJHu8Z4yfDTS2Z7y>) hlkoKnvYkqUekgu3D.CP4y1KPBFu())
//        this.entries.Add(new OrderEntry()
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

		private string GetFilename()
		{
			return string.Format("", Framework.Installation.IniDir.FullName, "");
		}

//		class jHlkoKNvYKqUEkgu3D : XmlDocumentBase
//		{
//			public jHlkoKNvYKqUEkgu3D() : base("fdsdfs")
//			{
//			}
//
//			public CQ1dxnlDDAKFTe3Lrk CP4y1KPBFu()
//			{
//				return this.GetChildNode<CQ1dxnlDDAKFTe3Lrk>();
//			}
//		}
	}
}
