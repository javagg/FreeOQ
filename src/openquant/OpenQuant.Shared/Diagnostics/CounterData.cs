using System;

namespace OpenQuant.Shared.Diagnostics
{
	class CounterData : ICloneable
	{
		private long value;

		public long Value
		{
			get
			{
				return this.value;
			}
		}

		public CounterData()
		{
			this.Reset();
		}

		public void Increment()
		{
			++this.value;
		}

		public void Reset()
		{
			this.value = 0;
		}

		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}
