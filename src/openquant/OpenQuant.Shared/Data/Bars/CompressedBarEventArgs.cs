using FreeQuant.Data;
using System;

namespace OpenQuant.Shared.Data.Bars
{
	class CompressedBarEventArgs : EventArgs
	{
		public Bar Bar { get; private set; }

		public CompressedBarEventArgs(Bar bar)
		{
			this.Bar = bar;
		}
	}
}
