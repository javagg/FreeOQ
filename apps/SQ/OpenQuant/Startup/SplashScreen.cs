// Type: OpenQuant.Startup.SplashScreen
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.API;
using OpenQuant.Shared;
using SmartQuant;
using SmartQuant.Instruments;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace OpenQuant.Startup
{
  internal class SplashScreen : SplashScreen
  {
    private IContainer components;

    public SplashScreen()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ((Control) this).SuspendLayout();
      ((Control) this).ResumeLayout(false);
    }

    protected virtual void OnDoWork(object sender, DoWorkEventArgs e)
    {
      DataInstaller dataInstaller1 = (DataInstaller) new AppDataInstaller();
      dataInstaller1.CheckInstallation();
      if (!dataInstaller1.IsInstalled)
      {
        this.SetProgressText("Installing application data...");
        dataInstaller1.Install();
      }
      DataInstaller dataInstaller2 = (DataInstaller) new SamplesInstaller();
      dataInstaller2.CheckInstallation();
      if (!dataInstaller2.IsInstalled)
      {
        this.SetProgressText("Installing samples...");
        dataInstaller2.Install();
      }
      this.SetProgressText("Initializing SmartQuant Framework...");
      Framework.Init();
      this.SetProgressText("Initializing Data Manager...");
      DataManager.Init();
      this.SetProgressText("Initializing Instrument Manager...");
      InstrumentManager.Init();
      foreach (Portfolio portfolio in PortfolioManager.Portfolios)
        portfolio.Monitored = false;
      Environment.SetEnvironmentVariable("PATH", string.Format("{0};{1}\\", (object) Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Process), (object) Global.Setup.Folders.FrameworkBin.FullName), EnvironmentVariableTarget.Process);
      this.AddPlugin("SmartQuant.QUIK", "SmartQuant.QUIK.QUIKFIX", true);
      this.AddPlugin("SmartQuant.OSL", "SmartQuant.OSL.OSLFIX", true);
      this.AddPlugin("SmartQuant.ID", "SmartQuant.ID.Integral", true);
      this.AddPlugin("SmartQuant.NN", "SmartQuant.NN.Nordnet", true);
      this.RemovePlugin("SmartQuant.OT", "SmartQuant.OT.OpenTick");
      this.RemovePlugin("SmartQuant.OTK", "SmartQuant.OTK.OTK");
      this.RemovePlugin("SmartQuant.DC", "SmartQuant.DC.DataCenter");
      this.AddPlugin("SmartQuant.QB", "SmartQuant.QB.QuantBase", true);
      this.AddPlugin("SmartQuant.QR", "SmartQuant.QR.QuantRouter", true);
      this.AddPlugin("SmartQuant.RTS", "SmartQuant.RTS.Plaza2", false);
      this.AddPlugin("SmartQuant.LS", "SmartQuant.LS.Lightspeed", true);
      this.AddPlugin("SmartQuant.DB", "SmartQuant.DB.DBFIX", true);
      this.SetProgressText("Loading plugins...");
      Framework.LoadPlugins();
      this.SetProgressText("Initializing OpenQuant API...");
      OpenQuant.Init();
      this.SetProgressText("Starting...");
      AssemblyName[] assemblies = GAC.Assemblies;
    }
  }
}
