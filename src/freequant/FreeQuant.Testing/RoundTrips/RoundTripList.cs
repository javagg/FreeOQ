// Type: SmartQuant.Testing.RoundTrips.RoundTripList
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using SmartQuant.Instruments;
using SmartQuant.Testing;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Testing.RoundTrips
{
  public class RoundTripList : IEnumerable
  {
    protected ArrayList list;
    protected OpenRoundTripList openRoundTrips;
    protected LiveTester tester;
    protected int lastNotUpdatedIndex;
    protected DateTime lastOpenRoundTripDate;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.list.Count + this.openRoundTrips.Count;
      }
    }

    public RoundTrip this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (index < this.list.Count)
          return this.list[index] as RoundTrip;
        if (index < this.Count)
          return this.openRoundTrips[index - this.list.Count];
        else
          return (RoundTrip) null;
      }
    }

    public event RoundTripListEventHandler Updated;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RoundTripList(LiveTester tester)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.tester = tester;
      this.lastNotUpdatedIndex = -1;
      this.lastOpenRoundTripDate = DateTime.MaxValue;
      this.Connect();
      this.list = new ArrayList();
      this.openRoundTrips = new OpenRoundTripList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) new RoundTripListEnumerator(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Connect()
    {
      this.tester.Osxy2s5d69 += new TesterEventHandler(this.BK4yT8IfHC);
      this.tester.RoundTripsFinished += new TesterEventHandler(this.kOWyDvDJH4);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Disconnect()
    {
      this.tester.Osxy2s5d69 -= new TesterEventHandler(this.BK4yT8IfHC);
      this.tester.RoundTripsFinished -= new TesterEventHandler(this.kOWyDvDJH4);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetClosedRoundTripIndex(RoundTrip roundTrip)
    {
      return this.list.IndexOf((object) roundTrip);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CountOfClosedRoundTrips()
    {
      return this.list.Count;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.list.Clear();
      foreach (RoundTrip roundTrip in this.openRoundTrips)
        roundTrip.Cancel();
      this.openRoundTrips.Clear();
      this.lastNotUpdatedIndex = -1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOpenRoundTrip(RoundTrip openRoundTrip)
    {
      this.openRoundTrips.Add(openRoundTrip);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRoundTripOpen(RoundTrip roundTrip)
    {
      return this.openRoundTrips.Contains(roundTrip);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RoundTripArray GetRoundTrips(Instrument instrument)
    {
      ArrayList array = new ArrayList();
      foreach (RoundTrip roundTrip in this.list)
      {
        if (roundTrip.Instrument == instrument)
          array.Add((object) roundTrip);
      }
      if (this.openRoundTrips.Contains(instrument))
        array.Add((object) this.openRoundTrips[instrument]);
      return new RoundTripArray(array);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RoundTripArray GetRoundTrips(InstrumentList instrumentList)
    {
      ArrayList array = new ArrayList();
      foreach (RoundTrip roundTrip in this.list)
      {
        if (instrumentList.Contains(roundTrip.Instrument))
          array.Add((object) roundTrip);
      }
      foreach (RoundTrip roundTrip in this.openRoundTrips)
      {
        if (instrumentList.Contains(roundTrip.Instrument))
          array.Add((object) roundTrip);
      }
      return new RoundTripArray(array);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateOpenRoundTrips()
    {
      foreach (RoundTrip roundTrip in this.openRoundTrips)
        roundTrip.Update();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CloseOpenRoundTrip(Instrument instrument, double exitPrice, DateTime exitDate)
    {
      RoundTrip roundTrip = this.openRoundTrips[instrument];
      if (roundTrip == null)
        return;
      this.openRoundTrips.Remove(instrument);
      roundTrip.Close(exitDate);
      this.list.Add((object) roundTrip);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RoundTrip GetOpenRoundTrip(Instrument instrument)
    {
      if (this.openRoundTrips.Contains(instrument))
        return this.openRoundTrips[instrument];
      else
        return (RoundTrip) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RoundTripArray GetOpenRoundTrips(InstrumentList instrumentList)
    {
      ArrayList array = new ArrayList();
      foreach (RoundTrip roundTrip in this.openRoundTrips)
      {
        if (instrumentList.Contains(roundTrip.Instrument))
          array.Add((object) roundTrip);
      }
      return new RoundTripArray(array);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OpenRoundTripList GetOpenRoundTrips()
    {
      return this.openRoundTrips;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JN2yhT4OtC([In] int obj0)
    {
      if (this.w05yMKQ0Al == null)
        return;
      this.w05yMKQ0Al(new RoundTripListEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BK4yT8IfHC([In] LiveTester obj0)
    {
      if (this.list.Count > 0 || this.openRoundTrips.Count > 0)
      {
        int index = this.list.Count - 1;
        while (index >= 0 && this.lastOpenRoundTripDate <= (this.list[index] as RoundTrip).ExitDateTime)
          --index;
        this.lastOpenRoundTripDate = this.openRoundTrips.Count <= 0 ? DateTime.MaxValue : this.openRoundTrips[0].ExitDateTime;
        this.lastNotUpdatedIndex = index;
      }
      else
        this.lastNotUpdatedIndex = -1;
      this.JN2yhT4OtC(this.lastNotUpdatedIndex);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void kOWyDvDJH4([In] LiveTester obj0)
    {
      foreach (RoundTrip roundTrip in this.openRoundTrips)
        roundTrip.Cancel();
    }
  }
}
