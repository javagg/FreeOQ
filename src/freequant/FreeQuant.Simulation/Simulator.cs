using FreeQuant;
using FreeQuant.Data;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Threading;

namespace FreeQuant.Simulation
{
	public class Simulator
	{
		private const SimulationMode PTdKfaGms = SimulationMode.MaxSpeed;
		private const double MjsDRJHuZ = 1.0;
		private const int syfqDTS2Z = 0;
		private const bool pytML48KK = false;
		private SimulationMode simulationMode;
		private double speedMultiplier;
		private Thread xgAzWSrde;
		private bool SmCegm8IIv;
		private bool paused;
		private int step;
		private ArrayList fP9emgbM6c;
		private MemorySeries<SimpleDataObject> XyXefUib4X;
		//    [Editor(typeof (PRLCX7SYLpbDaACt7D), typeof (UITypeEditor))]
		public DataSeriesList InputSeries { get; private set; }

		public IntervalList Intervals { get; private set; }

		[DefaultValue(SimulationMode.MaxSpeed)]
		public SimulationMode SimulationMode
		{
			get
			{
				return this.simulationMode; 
			}
			set
			{
				lock (this)
				{
					if (this.CurrentState != SimulatorState.Stopped)
						throw new InvalidOperationException();
					this.simulationMode = value;
				}
			}
		}

		[DefaultValue(1.0)]
		public double SpeedMultiplier
		{
			get
			{
				return this.speedMultiplier; 
			}
			set
			{
				lock (this)
				{
					if (this.CurrentState == SimulatorState.Running)
						throw new InvalidOperationException("InvalidOperation");
					if (value <= 0.0)
						throw new ArgumentException("InvalidOperation");
					this.speedMultiplier = value;
				}
			}
		}

		[DefaultValue(0)]
		public int Step
		{
			get
			{
				return this.step; 
			}
			set
			{
				lock (this)
				{
					if (this.CurrentState == SimulatorState.Running)
						throw new InvalidOperationException("InvalidOperation");
					if (value < 0)
						throw new ArgumentException("");
					this.step = value;
				}
			}
		}

		[Browsable(false)]
		public bool StepEnabled { get; private set; }

		[Browsable(false)]
		public int ObjectsInInterval { get; private set; }

		[Browsable(false)]
		public SimulatorState CurrentState { get; private set; }

		[DefaultValue(false)]
		public bool UseReversedArray { get; set; }

		public event SeriesObjectEventHandler NewObject;
		public event ExceptionEventHandler Error;
		public event EventHandler EnterSimulation;
		public event EventHandler ExitSimulation;
		public event EventHandler StateChanged;
		public event IntervalEventHandler EnterInterval;
		public event IntervalEventHandler LeaveInterval;

		public Simulator()
		{
			this.Intervals = new IntervalList();
			this.InputSeries = new DataSeriesList();
			this.simulationMode = SimulationMode.MaxSpeed;
			this.speedMultiplier = 1.0;
			this.SmCegm8IIv = false;
			this.paused = false;
			this.step = 0;
			this.StepEnabled = false;
			this.ObjectsInInterval = 0;
			this.CurrentState = SimulatorState.Stopped;
			this.XyXefUib4X = new MemorySeries<SimpleDataObject>("what");
			this.UseReversedArray = false;
		}

		internal void nNp9oHTwk(SimpleDataObject dataObject)
		{
			this.XyXefUib4X.Add(dataObject.DateTime, dataObject);
			if (this.XyXefUib4X.Count == 1)
			{
				MML451mtycDm65B2By l451mtycDm65B2By = new MML451mtycDm65B2By();
				l451mtycDm65B2By.series = this.XyXefUib4X;
				l451mtycDm65B2By.data = this.XyXefUib4X[0] as IDataObject;
				l451mtycDm65B2By.cx20cOlf0 = 1;
				l451mtycDm65B2By.YJQP0P9Gt = 0;
				if (this.fP9emgbM6c != null)
					this.mTh23qh0l(this.fP9emgbM6c, l451mtycDm65B2By);
			}
			++this.ObjectsInInterval;
		}

		public void Start(bool wait)
		{
			lock (this)
			{
				if (this.CurrentState != SimulatorState.Stopped)
					throw new InvalidOperationException("invalid");
				this.StepEnabled = false;
				this.SmCegm8IIv = true;
				this.xgAzWSrde = new Thread(new ThreadStart(this.mSHpPJSw9));
				this.xgAzWSrde.Name = "dgdfdsf";
				this.xgAzWSrde.Start();
			}
			if (!wait)
				return;
			this.xgAzWSrde.Join();
		}

		public void Start()
		{
			this.Start(false);
		}

		public void Stop(bool wait)
		{
			lock (this)
			{
				if (this.CurrentState != SimulatorState.Running)
				{
					if (this.CurrentState != SimulatorState.Paused)
						goto label_8;
				}
				this.SmCegm8IIv = false;
				this.paused = false;
			}
			label_8:
			if (!wait)
				return;
			while (this.CurrentState != SimulatorState.Stopped)
				Thread.Sleep(1);
		}

		public void Stop()
		{
			this.Stop(true);
		}

		public void Pause()
		{
			lock (this)
			{
				if (this.CurrentState != SimulatorState.Running)
					throw new InvalidOperationException("InvalidOperation");
				this.paused = true;
			}
		}

		public void Continue()
		{
			lock (this)
			{
				if (this.CurrentState != SimulatorState.Paused)
					throw new InvalidOperationException("InvalidOperation");
				this.StepEnabled = false;
				this.paused = false;
			}
		}

		public void DoStep(bool wait)
		{
			lock (this)
			{
				if (this.CurrentState == SimulatorState.Running)
					throw new InvalidOperationException();
				this.StepEnabled = true;
				switch (this.CurrentState)
				{
					case SimulatorState.Stopped:
						this.SmCegm8IIv = true;
						this.xgAzWSrde = new Thread(new ThreadStart(this.mSHpPJSw9));
						this.xgAzWSrde.Name = "fsdf";
						this.xgAzWSrde.Start();
						break;
					case SimulatorState.Paused:
						this.paused = false;
						break;
					default:
						throw new ApplicationException("SimulatorState.ffdfds");
				}
			}
			if (!wait)
				return;
			while (this.CurrentState != SimulatorState.Paused)
				Thread.Sleep(1);
		}

		public void DoStep()
		{
			this.DoStep(true);
		}

		private void mSHpPJSw9()
		{
			try
			{
				Clock.ClockMode = ClockMode.Simulation;
				if (!this.InputSeries.Contains(this.XyXefUib4X))
					this.InputSeries.Add(this.XyXefUib4X);
				this.CurrentState = SimulatorState.Running;
				this.EmitStateChanged();
				this.EmitEnterSimulation();
				foreach (Interval interval in this.Intervals)
				{
					if (!this.SmCegm8IIv)
						break;
					Clock.SetDateTime(interval.Begin);
					this.EmitEnterInterval(interval);
					this.fP9emgbM6c = this.UseReversedArray ? (ArrayList)new ReversibleArrayList() : new ArrayList();
					this.ObjectsInInterval = 0;
					foreach (IDataSeries dataSeries in new ArrayList(this.InputSeries))
					{
						int index = dataSeries.IndexOf(interval.Begin, SearchOption.Next);
						int num1 = dataSeries.IndexOf(interval.End.AddMilliseconds(1.0), SearchOption.Prev);
						if (index != -1 && index <= num1)
						{
							MML451mtycDm65B2By l451mtycDm65B2By = new MML451mtycDm65B2By();
							l451mtycDm65B2By.series = dataSeries;
							l451mtycDm65B2By.data = dataSeries[index] as IDataObject;
							l451mtycDm65B2By.cx20cOlf0 = index + 1;
							l451mtycDm65B2By.YJQP0P9Gt = num1;
							this.fP9emgbM6c.Add(l451mtycDm65B2By);
							int num2 = l451mtycDm65B2By.data is Bar ? 2 : 1;
							this.ObjectsInInterval += (num1 - index + 1) * num2;
						}
					}
					if (this.fP9emgbM6c.Count > 0)
					{
						this.fP9emgbM6c.Sort();
						DateTime dateTime1 = (this.fP9emgbM6c[0] as MML451mtycDm65B2By).data.DateTime;
						DateTime datetime = this.simulationMode == SimulationMode.MaxSpeed ? interval.End.AddYears(1) : dateTime1;
						DateTime dateTime2 = this.step == 0 ? DateTime.MaxValue : dateTime1.AddSeconds((double)this.step);
						DateTime dateTime3 = DateTime.Now;
						DateTime dateTime4 = datetime;
						while (this.fP9emgbM6c.Count > 0 && this.SmCegm8IIv)
						{
							bool flag;
							do
							{
								if (this.paused)
								{
									this.CurrentState = SimulatorState.Paused;
									this.EmitStateChanged();
									DateTime now1 = DateTime.Now;
									while (this.paused)
										Thread.Sleep(1);
									DateTime now2 = DateTime.Now;
									if (this.SmCegm8IIv)
									{
										if (this.simulationMode == SimulationMode.UserDefinedSpeed)
											dateTime3 = dateTime3.AddTicks(now2.Ticks - now1.Ticks);
										if (this.simulationMode == SimulationMode.MaxSpeed && dateTime2 < Clock.Now)
											dateTime2 = Clock.Now.AddSeconds((double)this.step);
										this.CurrentState = SimulatorState.Running;
										this.EmitStateChanged();
									}
								}
								if (this.SmCegm8IIv)
								{
									flag = false;
									MML451mtycDm65B2By l451mtycDm65B2By = this.fP9emgbM6c[0] as MML451mtycDm65B2By;
									if (this.simulationMode == SimulationMode.UserDefinedSpeed && datetime >= dateTime2 || this.simulationMode == SimulationMode.MaxSpeed && l451mtycDm65B2By.data.DateTime >= dateTime2)
									{
										dateTime2 = dateTime2.AddSeconds((double)this.step);
										if (this.StepEnabled)
										{
											this.paused = true;
											flag = true;
											goto label_40;
										}
									}
									if (datetime >= l451mtycDm65B2By.data.DateTime)
									{
										this.fP9emgbM6c.RemoveAt(0);
										if (l451mtycDm65B2By.data is Bar || l451mtycDm65B2By.data is Oym5lJOEeXmP9gbM6c)
										{
											if (l451mtycDm65B2By is y2ITxtBCMk4LU5vNC2)
											{
												Oym5lJOEeXmP9gbM6c oym5lJoEeXmP9gbM6c = l451mtycDm65B2By.data as Oym5lJOEeXmP9gbM6c;
												y2ITxtBCMk4LU5vNC2 itxtBcMk4Lu5vNc2 = l451mtycDm65B2By as y2ITxtBCMk4LU5vNC2;
												itxtBcMk4Lu5vNc2.bar.High = oym5lJoEeXmP9gbM6c.tY00OUm9S0.High;
												itxtBcMk4Lu5vNc2.bar.Low = oym5lJoEeXmP9gbM6c.tY00OUm9S0.Low;
												itxtBcMk4Lu5vNc2.bar.Close = oym5lJoEeXmP9gbM6c.tY00OUm9S0.Close;
												itxtBcMk4Lu5vNc2.bar.Volume = oym5lJoEeXmP9gbM6c.tY00OUm9S0.Volume;
												itxtBcMk4Lu5vNc2.bar.OpenInt = oym5lJoEeXmP9gbM6c.tY00OUm9S0.OpenInt;
												itxtBcMk4Lu5vNc2.bar.EndTime = oym5lJoEeXmP9gbM6c.tY00OUm9S0.EndTime;
												itxtBcMk4Lu5vNc2.bar.IsComplete = true;
												itxtBcMk4Lu5vNc2.data = (IDataObject)itxtBcMk4Lu5vNc2.bar;
											}
											else
											{
												Bar bar = l451mtycDm65B2By.data as Bar;
												y2ITxtBCMk4LU5vNC2 itxtBcMk4Lu5vNc2 = new y2ITxtBCMk4LU5vNC2();
												itxtBcMk4Lu5vNc2.bar = bar;
												itxtBcMk4Lu5vNc2.series = l451mtycDm65B2By.series;
												itxtBcMk4Lu5vNc2.data = (IDataObject)new Oym5lJOEeXmP9gbM6c(bar);
												itxtBcMk4Lu5vNc2.cx20cOlf0 = 1;
												itxtBcMk4Lu5vNc2.YJQP0P9Gt = 0;
												itxtBcMk4Lu5vNc2.data.DateTime = bar.EndTime;
												this.mTh23qh0l(this.fP9emgbM6c, (MML451mtycDm65B2By)itxtBcMk4Lu5vNc2);
												bar.High = bar.Open;
												bar.Low = bar.Open;
												bar.Close = bar.Open;
												bar.Volume = 0L;
												bar.OpenInt = 0L;
												bar.IsComplete = false;
											}
										}
										this.QYkhWyHA5(l451mtycDm65B2By.series, l451mtycDm65B2By.data);
										if (l451mtycDm65B2By.cx20cOlf0 <= l451mtycDm65B2By.YJQP0P9Gt)
										{
											l451mtycDm65B2By.data = l451mtycDm65B2By.series[l451mtycDm65B2By.cx20cOlf0] as IDataObject;
											++l451mtycDm65B2By.cx20cOlf0;
											this.mTh23qh0l(this.fP9emgbM6c, l451mtycDm65B2By);
										}
										else if (l451mtycDm65B2By.series == this.XyXefUib4X)
											this.XyXefUib4X.Clear();
										flag = this.fP9emgbM6c.Count > 0;
									}
									label_40:
									;
								}
								else
									break;
							}
							while (flag);
							if (this.simulationMode == SimulationMode.UserDefinedSpeed)
							{
								Clock.SetDateTime(datetime);
								Thread.Sleep(1);
								DateTime now = DateTime.Now;
								datetime = dateTime4.Add(new TimeSpan((long)((double)(now - dateTime3).Ticks * this.speedMultiplier)));
							}
						}
					}
					Clock.FireAllReminders();
					this.EmitLeaveInterval(interval);
				}
			}
			finally
			{
				Clock.ClockMode = ClockMode.Realtime;
				this.EmitExitSimulation();
				this.XyXefUib4X.Clear();
				this.CurrentState = SimulatorState.Stopped;
				this.EmitStateChanged();
			}
		}

		public override string ToString()
		{
			return ((object)this.CurrentState).ToString();
		}

		private void QYkhWyHA5(IDataSeries series, IDataObject obj)
		{
			DateTime datetime;
			if (obj is Bar)
			{
				Bar bar = obj as Bar;
				datetime = bar.IsComplete ? bar.EndTime : bar.BeginTime;
			}
			else
				datetime = obj.DateTime;
			Clock.SetDateTime(datetime);
			if (this.NewObject != null)
			{
				this.NewObject(new SeriesObjectEventArgs(series, obj));
			}
		}

		private void Gig53kIhY(Exception obj0)
		{
//      if (this.wpUekP9S03 == null)
//        return;
//      this.wpUekP9S03(new ExceptionEventArgs(obj0));
		}

		private void EmitEnterSimulation()
		{
			if (this.EnterSimulation != null)
			{
				this.EnterSimulation(this, EventArgs.Empty);
			}
		}

		private void EmitExitSimulation()
		{
			if (this.ExitSimulation != null)
			{
				this.ExitSimulation(this, EventArgs.Empty);
			}
		}

		private void EmitStateChanged()
		{
			if (this.StateChanged != null)
			{
				this.StateChanged(this, EventArgs.Empty);
			}
		}

		private void EmitEnterInterval(Interval interval)
		{
			if (this.EnterInterval != null)
			{
				this.EnterInterval(new IntervalEventArgs(interval));
			}
		}

		private void EmitLeaveInterval(Interval interval)
		{
			if (this.LeaveInterval != null)
			{
				this.LeaveInterval(new IntervalEventArgs(interval));
			}
		}

		private void mTh23qh0l(ArrayList obj0, MML451mtycDm65B2By obj1)
		{
			//			if (obj0.Count == 0)
			//			{
			//				obj0.Add((object)obj1);
			//			}
			//			else
			//			{
			//				bool flag = obj1 is y2ITxtBCMk4LU5vNC2;
			//				int num1 = obj1.CompareTo(obj0[0]);
			//				if (num1 < 0 || num1 == 0 && flag)
			//				{
			//					obj0.Insert(0, (object)obj1);
			//				}
			//				else
			//				{
			//					int num2 = obj1.CompareTo(obj0[obj0.Count - 1]);
			//					if (num2 > 0 || num2 == 0 && !flag)
			//					{
			//						obj0.Add((object)obj1);
			//					}
			//					else
			//					{
			//						DateTime dateTime1 = obj1.pX5yZopy1.DateTime;
			//						int num3 = 0;
			//						int num4 = obj0.Count - 1;
			//						int index;
			//						while (true)
			//						{
			//							DateTime dateTime2;
			//							do
			//							{
			//								index = (num4 + num3) / 2;
			//								dateTime2 = (obj0[index] as MML451mtycDm65B2By).pX5yZopy1.DateTime;
			//								DateTime dateTime3 = (obj0[index + 1] as MML451mtycDm65B2By).pX5yZopy1.DateTime;
			//								if (flag)
			//								{
			//									if (!(dateTime2 < dateTime1) || !(dateTime1 <= dateTime3))
			//									{
			//										if (dateTime1 > dateTime3)
			//											num3 = index + 1;
			//										else if (dateTime1 <= dateTime2)
			//											num4 = index;
			//									}
			//									else
			//										goto label_18;
			//								}
			//								else if (!(dateTime2 <= dateTime1) || !(dateTime1 < dateTime3))
			//								{
			//									if (dateTime1 >= dateTime3)
			//										num3 = index + 1;
			//								}
			//								else
			//									goto label_18;
			//							}
			//							while (!(dateTime1 < dateTime2));
			//							num4 = index;
			//						}
			//						label_18:
			//						obj0.Insert(index + 1, (object)obj1);
			//					}
			//				}
			//			}
		}

		class Oym5lJOEeXmP9gbM6c : IDataObject
		{
			internal Bar tY00OUm9S0;
			private DateTime LVK01ArkGI;

			public byte ProviderId
			{
				get
				{
					throw new InvalidOperationException();
				}
				set
				{
					throw new InvalidOperationException();
				}
			}

			public DateTime DateTime
			{
				get
				{
					return this.LVK01ArkGI;
				}
				set
				{
					this.LVK01ArkGI = value;
				}
			}

			internal Oym5lJOEeXmP9gbM6c(Bar obj0)
			{
				this.tY00OUm9S0 = obj0.Clone() as Bar;
			}
		}

		class MML451mtycDm65B2By : IComparable
		{
			internal IDataSeries series;
			internal IDataObject data;
			internal int cx20cOlf0;
			internal int YJQP0P9Gt;

			public virtual int CompareTo(object obj0)
			{
				MML451mtycDm65B2By that = obj0 as MML451mtycDm65B2By;
				if (this.data.DateTime > that.data.DateTime)
					return 1;
				return this.data.DateTime < that.data.DateTime ? -1 : 0;
			}
		}

		class y2ITxtBCMk4LU5vNC2 : MML451mtycDm65B2By
		{
			internal Bar bar;
		}

	}

}
