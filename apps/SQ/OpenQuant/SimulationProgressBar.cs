// Type: OpenQuant.SimulationProgressBar
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Providers;
using SmartQuant.Simulation;
using System;
using System.Windows.Forms;

namespace OpenQuant
{
  internal class SimulationProgressBar
  {
    private const int MAX_VALUE = 100;
    private ProgressBar progressBar;
    private int prevValue;
    private Simulator simulator;

    public SimulationProgressBar(ProgressBar progressBar)
    {
      this.progressBar = progressBar;
      this.progressBar.Maximum = 100;
      this.simulator = (ProviderManager.MarketDataSimulator as SimulationDataProvider).Simulator;
      this.simulator.EnterInterval += new IntervalEventHandler(this.simulator_EnterInterval);
      this.simulator.LeaveInterval += new IntervalEventHandler(this.simulator_LeaveInterval);
      this.simulator.NewObject += new SeriesObjectEventHandler(this.simulator_NewObject);
    }

    private void simulator_EnterInterval(IntervalEventArgs args)
    {
      this.progressBar.Invoke((Delegate) (() =>
      {
        this.progressBar.Value = 1;
        this.prevValue = 1;
      }));
    }

    private void simulator_LeaveInterval(IntervalEventArgs args)
    {
      this.progressBar.Invoke((Delegate) (() => this.progressBar.Value = 0));
    }

    private void simulator_NewObject(SeriesObjectEventArgs args)
    {
      int progress = this.prevValue * 100 / this.simulator.ObjectsInInterval;
      if (progress > this.progressBar.Value)
        this.progressBar.Invoke((Delegate) (() => this.progressBar.Value = progress));
      ++this.prevValue;
    }
  }
}
