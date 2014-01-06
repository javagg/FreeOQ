// Type: SmartQuant.Simulation.Simulator
// Assembly: SmartQuant.Simulation, Version=1.0.5036.28353, Culture=neutral, PublicKeyToken=null
// MVID: 7CFB1E94-1672-436F-90C9-C8B7893A5618
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Simulation.dll

using BFSBNbfWKGFb0pdAay;
using CJ5Xsgeg9JvhJUnvO3D;
using H7D5tvkZLfPgVqfACu;
using Ro5JtCVLApA6K9JGvl;
using SmartQuant;
using SmartQuant.Data;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using U60amwwckldTAipqvQ;
using Vjo3XOFRwWR4QLTss0;
using XyXUib14XX95SH8tl8;
using Y9kGLiKILMabFE38T3;

namespace SmartQuant.Simulation
{
  public class Simulator
  {
    private const SimulationMode PTdKfaGms = SimulationMode.MaxSpeed;
    private const double MjsDRJHuZ = 1.0;
    private const int syfqDTS2Z = 0;
    private const bool pytML48KK = false;
    private IntervalList LolsiRoHZ;
    private DataSeriesList cFYtsryqR;
    private SimulationMode ol1x6bFGT;
    private double TKMQHcsRY;
    private Thread xgAzWSrde;
    private bool SmCegm8IIv;
    private bool XU2eebyGW1;
    private SimulatorState tgyeyXh6Qg;
    private int fZHe0WhGKR;
    private bool PUJePgWmBA;
    private int cm5eFlJEeX;
    private ArrayList fP9emgbM6c;
    private MemorySeries<sTqplWAhZEpULyK2Wh> XyXefUib4X;

    [Editor(typeof (PRLCX7SYLpbDaACt7D), typeof (UITypeEditor))]
    public DataSeriesList InputSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.cFYtsryqR;
      }
    }

    public IntervalList Intervals
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LolsiRoHZ;
      }
    }

    [DefaultValue(SimulationMode.MaxSpeed)]
    public SimulationMode SimulationMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ol1x6bFGT;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        lock (this)
        {
          if (this.tgyeyXh6Qg != SimulatorState.Stopped)
            throw new InvalidOperationException(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(668));
          this.ol1x6bFGT = value;
        }
      }
    }

    [DefaultValue(1.0)]
    public double SpeedMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.TKMQHcsRY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        lock (this)
        {
          if (this.tgyeyXh6Qg == SimulatorState.Running)
            throw new InvalidOperationException(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(786));
          if (value <= 0.0)
            throw new ArgumentException(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(920));
          this.TKMQHcsRY = value;
        }
      }
    }

    [DefaultValue(0)]
    public int Step
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fZHe0WhGKR;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        lock (this)
        {
          if (this.tgyeyXh6Qg == SimulatorState.Running)
            throw new InvalidOperationException(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(1004));
          if (value < 0)
            throw new ArgumentException(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(1108));
          this.fZHe0WhGKR = value;
        }
      }
    }

    [Browsable(false)]
    public bool StepEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PUJePgWmBA;
      }
    }

    [Browsable(false)]
    public int ObjectsInInterval
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.cm5eFlJEeX;
      }
    }

    [Browsable(false)]
    public SimulatorState CurrentState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.tgyeyXh6Qg;
      }
    }

    [DefaultValue(false)]
    public bool UseReversedArray { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public event SeriesObjectEventHandler NewObject;

    public event ExceptionEventHandler Error;

    public event EventHandler EnterSimulation;

    public event EventHandler ExitSimulation;

    public event EventHandler StateChanged;

    public event IntervalEventHandler EnterInterval;

    public event IntervalEventHandler LeaveInterval;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Simulator()
    {
      eekpcgzPjZLOyP2Ysv.eyppkuTzDkifX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.LolsiRoHZ = new IntervalList();
      this.cFYtsryqR = new DataSeriesList();
      this.ol1x6bFGT = SimulationMode.MaxSpeed;
      this.TKMQHcsRY = 1.0;
      this.SmCegm8IIv = false;
      this.XU2eebyGW1 = false;
      this.fZHe0WhGKR = 0;
      this.PUJePgWmBA = false;
      this.cm5eFlJEeX = 0;
      this.tgyeyXh6Qg = SimulatorState.Stopped;
      this.XyXefUib4X = new MemorySeries<sTqplWAhZEpULyK2Wh>(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(640));
      this.UseReversedArray = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void nNp9oHTwk([In] sTqplWAhZEpULyK2Wh obj0)
    {
      this.XyXefUib4X.Add(obj0.DateTime, (object) obj0);
      if (this.XyXefUib4X.Count == 1)
      {
        MML451mtycDm65B2By l451mtycDm65B2By = new MML451mtycDm65B2By();
        l451mtycDm65B2By.wu1e2esBL = (IDataSeries) this.XyXefUib4X;
        l451mtycDm65B2By.pX5yZopy1 = this.XyXefUib4X[0] as IDataObject;
        l451mtycDm65B2By.cx20cOlf0 = 1;
        l451mtycDm65B2By.YJQP0P9Gt = 0;
        if (this.fP9emgbM6c != null)
          this.mTh23qh0l(this.fP9emgbM6c, l451mtycDm65B2By);
      }
      ++this.cm5eFlJEeX;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start(bool wait)
    {
      lock (this)
      {
        if (this.tgyeyXh6Qg != SimulatorState.Stopped)
          throw new InvalidOperationException(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(1198));
        this.PUJePgWmBA = false;
        this.SmCegm8IIv = true;
        this.xgAzWSrde = new Thread(new ThreadStart(this.mSHpPJSw9));
        this.xgAzWSrde.Name = v6F3C32VVUpp2OYb5n.VVyFVqM4b6(1266);
        this.xgAzWSrde.Start();
      }
      if (!wait)
        return;
      this.xgAzWSrde.Join();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start()
    {
      this.Start(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop(bool wait)
    {
      lock (this)
      {
        if (this.tgyeyXh6Qg != SimulatorState.Running)
        {
          if (this.tgyeyXh6Qg != SimulatorState.Paused)
            goto label_8;
        }
        this.SmCegm8IIv = false;
        this.XU2eebyGW1 = false;
      }
label_8:
      if (!wait)
        return;
      while (this.tgyeyXh6Qg != SimulatorState.Stopped)
        Thread.Sleep(1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop()
    {
      this.Stop(true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Pause()
    {
      lock (this)
      {
        if (this.tgyeyXh6Qg != SimulatorState.Running)
          throw new InvalidOperationException(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(1288));
        this.XU2eebyGW1 = true;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Continue()
    {
      lock (this)
      {
        if (this.tgyeyXh6Qg != SimulatorState.Paused)
          throw new InvalidOperationException(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(1388));
        this.PUJePgWmBA = false;
        this.XU2eebyGW1 = false;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoStep(bool wait)
    {
      lock (this)
      {
        if (this.tgyeyXh6Qg == SimulatorState.Running)
          throw new InvalidOperationException(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(1492));
        this.PUJePgWmBA = true;
        switch (this.tgyeyXh6Qg)
        {
          case SimulatorState.Stopped:
            this.SmCegm8IIv = true;
            this.xgAzWSrde = new Thread(new ThreadStart(this.mSHpPJSw9));
            this.xgAzWSrde.Name = v6F3C32VVUpp2OYb5n.VVyFVqM4b6(1616);
            this.xgAzWSrde.Start();
            break;
          case SimulatorState.Paused:
            this.XU2eebyGW1 = false;
            break;
          default:
            throw new ApplicationException(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(1638));
        }
      }
      if (!wait)
        return;
      while (this.tgyeyXh6Qg != SimulatorState.Paused)
        Thread.Sleep(1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoStep()
    {
      this.DoStep(true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void mSHpPJSw9()
    {
      try
      {
        Clock.ClockMode = ClockMode.Simulation;
        if (!this.cFYtsryqR.Contains((IDataSeries) this.XyXefUib4X))
          this.cFYtsryqR.Add((IDataSeries) this.XyXefUib4X);
        this.tgyeyXh6Qg = SimulatorState.Running;
        this.hf5VfXWgR();
        this.rLLiAbbhr();
        foreach (Interval interval in this.LolsiRoHZ)
        {
          if (!this.SmCegm8IIv)
            break;
          Clock.SetDateTime(interval.Begin);
          this.ElknoKvYK(interval);
          this.fP9emgbM6c = this.UseReversedArray ? (ArrayList) new S3F1ehPCfoua4Nmsp3() : new ArrayList();
          this.cm5eFlJEeX = 0;
          foreach (IDataSeries dataSeries in new ArrayList((ICollection) this.cFYtsryqR))
          {
            int index = dataSeries.IndexOf(interval.Begin, SearchOption.Next);
            int num1 = dataSeries.IndexOf(interval.End.AddMilliseconds(1.0), SearchOption.Prev);
            if (index != -1 && index <= num1)
            {
              MML451mtycDm65B2By l451mtycDm65B2By = new MML451mtycDm65B2By();
              l451mtycDm65B2By.wu1e2esBL = dataSeries;
              l451mtycDm65B2By.pX5yZopy1 = dataSeries[index] as IDataObject;
              l451mtycDm65B2By.cx20cOlf0 = index + 1;
              l451mtycDm65B2By.YJQP0P9Gt = num1;
              this.fP9emgbM6c.Add((object) l451mtycDm65B2By);
              int num2 = l451mtycDm65B2By.pX5yZopy1 is Bar ? 2 : 1;
              this.cm5eFlJEeX += (num1 - index + 1) * num2;
            }
          }
          if (this.fP9emgbM6c.Count > 0)
          {
            this.fP9emgbM6c.Sort();
            DateTime dateTime1 = (this.fP9emgbM6c[0] as MML451mtycDm65B2By).pX5yZopy1.DateTime;
            DateTime datetime = this.ol1x6bFGT == SimulationMode.MaxSpeed ? interval.End.AddYears(1) : dateTime1;
            DateTime dateTime2 = this.fZHe0WhGKR == 0 ? DateTime.MaxValue : dateTime1.AddSeconds((double) this.fZHe0WhGKR);
            DateTime dateTime3 = DateTime.Now;
            DateTime dateTime4 = datetime;
            while (this.fP9emgbM6c.Count > 0 && this.SmCegm8IIv)
            {
              bool flag;
              do
              {
                if (this.XU2eebyGW1)
                {
                  this.tgyeyXh6Qg = SimulatorState.Paused;
                  this.hf5VfXWgR();
                  DateTime now1 = DateTime.Now;
                  while (this.XU2eebyGW1)
                    Thread.Sleep(1);
                  DateTime now2 = DateTime.Now;
                  if (this.SmCegm8IIv)
                  {
                    if (this.ol1x6bFGT == SimulationMode.UserDefinedSpeed)
                      dateTime3 = dateTime3.AddTicks(now2.Ticks - now1.Ticks);
                    if (this.ol1x6bFGT == SimulationMode.MaxSpeed && dateTime2 < Clock.Now)
                      dateTime2 = Clock.Now.AddSeconds((double) this.fZHe0WhGKR);
                    this.tgyeyXh6Qg = SimulatorState.Running;
                    this.hf5VfXWgR();
                  }
                }
                if (this.SmCegm8IIv)
                {
                  flag = false;
                  MML451mtycDm65B2By l451mtycDm65B2By = this.fP9emgbM6c[0] as MML451mtycDm65B2By;
                  if (this.ol1x6bFGT == SimulationMode.UserDefinedSpeed && datetime >= dateTime2 || this.ol1x6bFGT == SimulationMode.MaxSpeed && l451mtycDm65B2By.pX5yZopy1.DateTime >= dateTime2)
                  {
                    dateTime2 = dateTime2.AddSeconds((double) this.fZHe0WhGKR);
                    if (this.PUJePgWmBA)
                    {
                      this.XU2eebyGW1 = true;
                      flag = true;
                      goto label_40;
                    }
                  }
                  if (datetime >= l451mtycDm65B2By.pX5yZopy1.DateTime)
                  {
                    this.fP9emgbM6c.RemoveAt(0);
                    if (l451mtycDm65B2By.pX5yZopy1 is Bar || l451mtycDm65B2By.pX5yZopy1 is Oym5lJOEeXmP9gbM6c)
                    {
                      if (l451mtycDm65B2By is y2ITxtBCMk4LU5vNC2)
                      {
                        Oym5lJOEeXmP9gbM6c oym5lJoEeXmP9gbM6c = l451mtycDm65B2By.pX5yZopy1 as Oym5lJOEeXmP9gbM6c;
                        y2ITxtBCMk4LU5vNC2 itxtBcMk4Lu5vNc2 = l451mtycDm65B2By as y2ITxtBCMk4LU5vNC2;
                        itxtBcMk4Lu5vNc2.mJqFwxGQh.High = oym5lJoEeXmP9gbM6c.tY00OUm9S0.High;
                        itxtBcMk4Lu5vNc2.mJqFwxGQh.Low = oym5lJoEeXmP9gbM6c.tY00OUm9S0.Low;
                        itxtBcMk4Lu5vNc2.mJqFwxGQh.Close = oym5lJoEeXmP9gbM6c.tY00OUm9S0.Close;
                        itxtBcMk4Lu5vNc2.mJqFwxGQh.Volume = oym5lJoEeXmP9gbM6c.tY00OUm9S0.Volume;
                        itxtBcMk4Lu5vNc2.mJqFwxGQh.OpenInt = oym5lJoEeXmP9gbM6c.tY00OUm9S0.OpenInt;
                        itxtBcMk4Lu5vNc2.mJqFwxGQh.EndTime = oym5lJoEeXmP9gbM6c.tY00OUm9S0.EndTime;
                        itxtBcMk4Lu5vNc2.mJqFwxGQh.IsComplete = true;
                        itxtBcMk4Lu5vNc2.pX5yZopy1 = (IDataObject) itxtBcMk4Lu5vNc2.mJqFwxGQh;
                      }
                      else
                      {
                        Bar bar = l451mtycDm65B2By.pX5yZopy1 as Bar;
                        y2ITxtBCMk4LU5vNC2 itxtBcMk4Lu5vNc2 = new y2ITxtBCMk4LU5vNC2();
                        itxtBcMk4Lu5vNc2.mJqFwxGQh = bar;
                        itxtBcMk4Lu5vNc2.wu1e2esBL = l451mtycDm65B2By.wu1e2esBL;
                        itxtBcMk4Lu5vNc2.pX5yZopy1 = (IDataObject) new Oym5lJOEeXmP9gbM6c(bar);
                        itxtBcMk4Lu5vNc2.cx20cOlf0 = 1;
                        itxtBcMk4Lu5vNc2.YJQP0P9Gt = 0;
                        itxtBcMk4Lu5vNc2.pX5yZopy1.DateTime = bar.EndTime;
                        this.mTh23qh0l(this.fP9emgbM6c, (MML451mtycDm65B2By) itxtBcMk4Lu5vNc2);
                        bar.High = bar.Open;
                        bar.Low = bar.Open;
                        bar.Close = bar.Open;
                        bar.Volume = 0L;
                        bar.OpenInt = 0L;
                        bar.IsComplete = false;
                      }
                    }
                    this.QYkhWyHA5(l451mtycDm65B2By.wu1e2esBL, l451mtycDm65B2By.pX5yZopy1);
                    if (l451mtycDm65B2By.cx20cOlf0 <= l451mtycDm65B2By.YJQP0P9Gt)
                    {
                      l451mtycDm65B2By.pX5yZopy1 = l451mtycDm65B2By.wu1e2esBL[l451mtycDm65B2By.cx20cOlf0] as IDataObject;
                      ++l451mtycDm65B2By.cx20cOlf0;
                      this.mTh23qh0l(this.fP9emgbM6c, l451mtycDm65B2By);
                    }
                    else if (l451mtycDm65B2By.wu1e2esBL == this.XyXefUib4X)
                      this.XyXefUib4X.Clear();
                    flag = this.fP9emgbM6c.Count > 0;
                  }
label_40:;
                }
                else
                  break;
              }
              while (flag);
              if (this.ol1x6bFGT == SimulationMode.UserDefinedSpeed)
              {
                Clock.SetDateTime(datetime);
                Thread.Sleep(1);
                DateTime now = DateTime.Now;
                datetime = dateTime4.Add(new TimeSpan((long) ((double) (now - dateTime3).Ticks * this.TKMQHcsRY)));
              }
            }
          }
          Clock.FireAllReminders();
          this.UUE3kgu3D(interval);
        }
      }
      finally
      {
        Clock.ClockMode = ClockMode.Realtime;
        this.ol8AIbxcY();
        this.XyXefUib4X.Clear();
        this.tgyeyXh6Qg = SimulatorState.Stopped;
        this.hf5VfXWgR();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return ((object) this.tgyeyXh6Qg).ToString();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QYkhWyHA5([In] IDataSeries obj0, [In] IDataObject obj1)
    {
      DateTime datetime;
      if (obj1 is Bar)
      {
        Bar bar = obj1 as Bar;
        datetime = bar.IsComplete ? bar.EndTime : bar.BeginTime;
      }
      else
        datetime = obj1.DateTime;
      Clock.SetDateTime(datetime);
      if (this.G95eBSH8tl == null)
        return;
      this.G95eBSH8tl(new SeriesObjectEventArgs(obj0, obj1));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Gig53kIhY([In] Exception obj0)
    {
      if (this.wpUekP9S03 == null)
        return;
      this.wpUekP9S03(new ExceptionEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void rLLiAbbhr()
    {
      if (this.NfOermJB3T == null)
        return;
      this.NfOermJB3T((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ol8AIbxcY()
    {
      if (this.VwGeRWW4sM == null)
        return;
      this.VwGeRWW4sM((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void hf5VfXWgR()
    {
      if (this.jRNeEKl06h == null)
        return;
      this.jRNeEKl06h((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ElknoKvYK([In] Interval obj0)
    {
      if (this.OL1eL4gWeW == null)
        return;
      this.OL1eL4gWeW(new IntervalEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UUE3kgu3D([In] Interval obj0)
    {
      if (this.LGge6Y7IAm == null)
        return;
      this.LGge6Y7IAm(new IntervalEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void mTh23qh0l([In] ArrayList obj0, [In] MML451mtycDm65B2By obj1)
    {
      if (obj0.Count == 0)
      {
        obj0.Add((object) obj1);
      }
      else
      {
        bool flag = obj1 is y2ITxtBCMk4LU5vNC2;
        int num1 = obj1.CompareTo(obj0[0]);
        if (num1 < 0 || num1 == 0 && flag)
        {
          obj0.Insert(0, (object) obj1);
        }
        else
        {
          int num2 = obj1.CompareTo(obj0[obj0.Count - 1]);
          if (num2 > 0 || num2 == 0 && !flag)
          {
            obj0.Add((object) obj1);
          }
          else
          {
            DateTime dateTime1 = obj1.pX5yZopy1.DateTime;
            int num3 = 0;
            int num4 = obj0.Count - 1;
            int index;
            while (true)
            {
              DateTime dateTime2;
              do
              {
                index = (num4 + num3) / 2;
                dateTime2 = (obj0[index] as MML451mtycDm65B2By).pX5yZopy1.DateTime;
                DateTime dateTime3 = (obj0[index + 1] as MML451mtycDm65B2By).pX5yZopy1.DateTime;
                if (flag)
                {
                  if (!(dateTime2 < dateTime1) || !(dateTime1 <= dateTime3))
                  {
                    if (dateTime1 > dateTime3)
                      num3 = index + 1;
                    else if (dateTime1 <= dateTime2)
                      num4 = index;
                  }
                  else
                    goto label_18;
                }
                else if (!(dateTime2 <= dateTime1) || !(dateTime1 < dateTime3))
                {
                  if (dateTime1 >= dateTime3)
                    num3 = index + 1;
                }
                else
                  goto label_18;
              }
              while (!(dateTime1 < dateTime2));
              num4 = index;
            }
label_18:
            obj0.Insert(index + 1, (object) obj1);
          }
        }
      }
    }
  }
}
