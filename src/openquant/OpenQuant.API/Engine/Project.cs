using OpenQuant.API;
using System.Collections.Generic;

namespace OpenQuant.API.Engine
{
  public class Project
  {
    private Statistics statistics;

    public string Name { get; private set; }

    public ParameterSet Parameters { get; private set; }

    public bool ReportEnabled { get; set; }

    public bool Enabled { get; set; }

    public Portfolio Portfolio { get; private set; }

    public Performance Performance { get; private set; }

    public Statistics Statistics
    {
      get
      {
        if (this.statistics != null)
          return this.statistics;
        this.statistics = new Statistics(this.Portfolio.portfolio);
        return this.statistics;
      }
    }

    public InstrumentList Instruments { get; private set; }

    private Project()
    {
      this.Instruments = new InstrumentList();
    }

    private void Init(string name, Portfolio portfolio, bool reportEnabled, List<Parameter> parameters)
    {
      this.Name = name;
      this.Portfolio = portfolio;
      this.Performance = new Performance(portfolio);
      this.ReportEnabled = reportEnabled;
      this.Parameters = new ParameterSet(parameters);
    }

    public void AddInstrument(string symbol)
    {
      this.Instruments.Add(symbol);
    }

    public void AddInstrument(Instrument instrument)
    {
      this.Instruments.Add(instrument);
    }

    public void RemoveInstrument(string symbol)
    {
      this.Instruments.Remove(symbol);
    }

    public void RemoveInstrument(Instrument instrument)
    {
      this.Instruments.Remove(instrument);
    }

    public void ClearInstruments()
    {
      this.Instruments.Clear();
    }

    internal void OnStart()
    {
      if (this.statistics == null)
        return;
      this.statistics.IsCalculated = false;
    }
  }
}
