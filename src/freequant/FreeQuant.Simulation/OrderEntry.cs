using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;

namespace FreeQuant.Simulation
{
	public class OrderEntry
	{
		public bool Enabled { get; set; }
		public DateTime DateTime { get; set; }
		public Instrument Instrument { get; set; }
		public Side Side { get; set; }
		public OrdType OrdType { get; set; }
		public double Price { get; set; }
		public double StopPx { get; set; }
		public double OrderQty { get; set; }
		public string Text { get; set; }

		public OrderEntry()
		{
		}
	}
}
