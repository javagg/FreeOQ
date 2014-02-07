using FreeQuant.Data;
using FreeQuant.Instruments;
using System.Collections.Generic;

namespace FreeQuant.Trading
{
	public class BarSliceManager
	{
		private Dictionary<long, BarSlice> data;

		public int InstrumentsCount { get; set; }

		public BarSliceManager()
		{
			this.data = new Dictionary<long, BarSlice>();
		}

		internal void Clear()
		{
			this.data.Clear();
		}

		internal void Add(Instrument instrument, Bar bar)
		{
			BarSlice barSlice = null;
			if (!this.data.TryGetValue(bar.Size, out barSlice))
			{
				barSlice = new BarSlice(this.InstrumentsCount);
				this.data.Add(bar.Size, barSlice);
			}
			barSlice.Add(instrument, bar);
		}

		internal BarSlice GetBarSlice(long barSize)
		{
			BarSlice barSlice = null;
			this.data.TryGetValue(barSize, out barSlice);
			return barSlice;
		}
	}
}
