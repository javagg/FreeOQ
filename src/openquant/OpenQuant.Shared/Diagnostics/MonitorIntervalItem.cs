using System;

namespace OpenQuant.Shared.Diagnostics
{
	internal class MonitorIntervalItem
	{
		private TimeSpan value;

		private MonitorIntervalItem(TimeSpan value)
		{
			this.value = value;
		}

		public static implicit operator TimeSpan(MonitorIntervalItem item)
		{
			return item.value;
		}

		public static explicit operator MonitorIntervalItem(TimeSpan value)
		{
			return new MonitorIntervalItem(value);
		}

		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (obj is MonitorIntervalItem)
				return this.value.Equals(((MonitorIntervalItem)obj).value);
			else
				return base.Equals(obj);
		}

		public override string ToString()
		{
			return this.value.ToString(this.value.Hours <= 0 ? "m\\ \\m\\i\\n" : "h\\ \\h\\o\\u\\r");
		}
	}
}
