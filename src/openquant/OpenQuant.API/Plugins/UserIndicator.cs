using OpenQuant.API;
using FreeQuant.Indicators;
using FreeQuant.Series;
using System;
using System.ComponentModel;

namespace OpenQuant.API.Plugins
{
	///<summary>
	///  A user defined indicator
	///</summary>
	public class UserIndicator : Indicator
	{
		private ISeries input;
		private FreeQuant.Series.TimeSeries series;
		private bool isInitialized;

		public ISeries Input { get	{ return this.input;	} }

		[Browsable(false)]
		public new string Name
		{
			get
			{
				this.Init();
				return ((FreeQuant.Series.TimeSeries)this.indicator).Name;
			}
			set
			{
				this.Init();
				((FreeQuant.Series.TimeSeries)this.indicator).Name = value;
			}
		}

		public override double this[int index]
		{
			get
			{
				this.Init();
				return base[index];
			}
		}

		public override double this [DateTime dateTime]
		{
			get
			{
				this.Init();
				return base[dateTime];
			}
		}

		[Browsable(false)]
		public override int Count
		{
			get
			{
				this.Init();
				return base.Count;
			}
		}

		public override double this [Bar bar]
		{
			get
			{
				this.Init();
				return base[bar];
			}
		}

		[Browsable(false)]
		public override double Last
		{
			get
			{
				this.Init();
				return base.Last;
			}
		}

		[Browsable(false)]
		public override DateTime FirstDateTime
		{
			get
			{
				this.Init();
				return base.FirstDateTime;
			}
		}

		[Browsable(false)]
		public override DateTime LastDateTime
		{
			get
			{
				this.Init();
				return base.LastDateTime;
			}
		}

		public override double this [DateTime dateTime, BarData barData]
		{
			get
			{
				this.Init();
				return base[dateTime, barData];
			}
		}

		public override double this [int index, BarData barData]
		{
			get
			{
				this.Init();
				return base[index, barData];
			}
		}


		///<summary>
		///  Initializes a new instance of the UserIndicator class
		///</summary>
		public UserIndicator(ISeries input)
		{
			this.input = input;
			if (input is TimeSeries)
				this.series = (FreeQuant.Series.TimeSeries)(input as TimeSeries).series;
			if (input is BarSeries)
				this.series = (FreeQuant.Series.TimeSeries)(input as BarSeries).series;
			if (input is Indicator)
				this.series = (FreeQuant.Series.TimeSeries)(input as Indicator).indicator;
			this.indicator = new FreeQuant.Indicators.Indicator(this.series);
		}

		///<summary>
		///  Initializes user indicator
		///</summary>
		public void Init()
		{
			if (this.isInitialized)
				return;
			this.series.ItemAdded += new ItemAddedEventHandler(this.OnInputItemAdded);
			for (int index = 0; index < this.series.Count; ++index)
			{
				double num = this.Calculate(index);
				if (!double.IsNaN(num))
					((DoubleSeries)this.indicator).Add(this.series.GetDateTime(index), num);
			}
			this.isInitialized = true;
		}

		///<summary>
		///  Do the Calculation work
		///</summary>
		public virtual double Calculate(int index)
		{
			return double.NaN;
		}

		private void OnInputItemAdded(object sender, DateTimeEventArgs args)
		{
			double num = this.Calculate(this.series.GetIndex(args.DateTime));
			if (double.IsNaN(num))
				return;
			((DoubleSeries)this.indicator).Add(args.DateTime, num);
		}

		public override double Ago(int n)
		{
			this.Init();
			return base.Ago(n);
		}

		public override bool Contains(DateTime dateTime)
		{
			this.Init();
			return base.Contains(dateTime);
		}

		public override bool Contains(Bar bar)
		{
			this.Init();
			return base.Contains(bar);
		}

		public override bool CrossesBelow(BarSeries series, Bar bar)
		{
			this.Init();
			return base.CrossesBelow(series, bar);
		}

		public override bool CrossesAbove(BarSeries series, Bar bar)
		{
			this.Init();
			return base.CrossesAbove(series, bar);
		}

		public override bool CrossesBelow(Indicator indicator, Bar bar)
		{
			this.Init();
			return base.CrossesBelow(indicator, bar);
		}

		public override bool CrossesAbove(Indicator indicator, Bar bar)
		{
			this.Init();
			return base.CrossesAbove(indicator, bar);
		}

		public override Cross Crosses(Indicator indicator, Bar bar)
		{
			this.Init();
			return base.Crosses(indicator, bar);
		}

		public override Cross Crosses(BarSeries series, Bar bar)
		{
			this.Init();
			return base.Crosses(series, bar);
		}

		public override DateTime GetDateTime(int index)
		{
			this.Init();
			return base.GetDateTime(index);
		}
	}
}
