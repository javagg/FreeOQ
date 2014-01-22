using System;

namespace FreeQuant.FIX
{
	public class FIXEventsGroup : FIXGroup
	{
		[FIXField("865", EFieldOption.Optional)]
		public int EventType
		{
			get
			{
				return this.GetIntField(865).Value;
			}
			set
			{
				this.AddIntField(865, value);
			}
		}

		[FIXField("866", EFieldOption.Optional)]
		public DateTime EventDate
		{
			get
			{
				return this.GetDateTimeField(866).Value;
			}
			set
			{
				this.AddDateTimeField(866, value);
			}
		}

		[FIXField("867", EFieldOption.Optional)]
		public double EventPx
		{
			get
			{
				return this.GetDoubleField(867).Value;
			}
			set
			{
				this.AddDoubleField(867, value);
			}
		}

		[FIXField("868", EFieldOption.Optional)]
		public string EventText
		{
			get
			{
				return this.GetStringField(868).Value;
			}
			set
			{
				this.AddStringField(868, value);
			}
		}
	}
}
