using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;

namespace FreeQuant.Indicators
{
	[Serializable]
	public class SMA : Indicator
	{
		protected int fLength = 14;
		protected BarData fOption;

		[Description("")]
		[Category("Parameters")]
		[IndicatorParameter(1)]
		public BarData Option
		{
			get
			{
				return this.fOption;
			}
			set
			{
				this.fOption = value;
				this.Init();
			}
		}

		[Description("")]
		[IndicatorParameter(0)]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return this.fLength;
			}
			set
			{
				this.fLength = value;
				this.Init();
			}
		}

		public SMA() : base()
		{
			this.Init();
		}

		public SMA(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		public SMA(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			this.Color = color;
		}

		public SMA(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle)
			: base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			this.Color = color;
			this.DrawStyle = drawStyle;
		}

		public SMA(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		public SMA(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			this.Color = color;
			this.Init();
		}

		protected override void Init()
		{
			this.Name = "SMA" + this.fLength;
			this.Title = "SMA";
			this.fType = EIndicatorType.Price;
			this.Clear();
			this.fCalculate = true;
			if (this.fInput == null)
				return;
			if (this.fInput is BarSeries)
				this.Name = "SMA" + this.fLength + this.fOption;
			if (TimeSeries.fNameOption != ENameOption.Long)
				return;
			this.Name = this.fInput.Name + this.Name;
		}

		protected override void Calculate(int index)
		{
			double data = double.NaN;
			if (index >= this.fLength - 1 + this.fInput.FirstIndex)
			{
				data = 0.0;
//				int num = Indicator.SyncIndex ? 1 : 0;
				if (index == this.fLength - 1 + this.fInput.FirstIndex)
				{
					for (int i = index; i >= index - this.fLength + 1; --i)
					{
						data += this.fInput[i, this.fOption] / (double)this.fLength;
					}
				}
				else
				{
					data = this[this.fInput.GetDateTime(index - 1)] + (this.fInput[index, this.fOption] - this.fInput[index - this.fLength, this.fOption]) / (double)this.fLength;
				}
			}
			this.Add(this.fInput.GetDateTime(index), data);
		}

		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			if (index < length - 1 + input.FirstIndex) return double.NaN;

			double num = 0.0;
			for (int i = index; i >= index - length + 1; --i)
			{
				num += input[i, option];
			}
			return num / (double)length;
		}

		public static double Value(DoubleSeries input, int index, int length)
		{
			return SMA.Value(input, index, length, BarData.Close);
		}

		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (!this.Monitored) return;

			int index = this.fInput.GetIndex(EventArgs.DateTime);
			if (index == -1) return;

			for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + this.fLength - 1); ++i)
				this.Calculate(i);
		}
	}
}
