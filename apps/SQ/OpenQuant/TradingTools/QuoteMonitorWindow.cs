// Type: OpenQuant.TradingTools.QuoteMonitorWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Config;
using OpenQuant.Shared.TradingTools;
using SmartQuant.Providers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.TradingTools
{
  internal class QuoteMonitorWindow : QuoteMonitorWindow
  {
    private IContainer components;

    public QuoteMonitorWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    protected virtual void OnInit()
    {
      this.UpdateConfiguration();
      Configuration.add_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
      base.OnInit();
    }

    protected virtual void OnClosing(DockControlClosingEventArgs e)
    {
      Configuration.remove_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
      base.OnClosing(e);
    }

    protected virtual void OnNewQuote(object sender, QuoteEventArgs args)
    {
      if (!Global.Flags.UpdateUI)
        return;
      base.OnNewQuote(sender, args);
    }

    protected virtual void OnNewTrade(object sender, TradeEventArgs args)
    {
      if (!Global.Flags.UpdateUI)
        return;
      base.OnNewTrade(sender, args);
    }

    protected virtual void OnNewBar(object sender, BarEventArgs args)
    {
      if (!Global.Flags.UpdateUI)
        return;
      base.OnNewBar(sender, args);
    }

    public virtual void OnElapsed()
    {
      if (!Global.Flags.UpdateUI)
        return;
      base.OnElapsed();
    }

    private void UpdateConfiguration()
    {
      this.Init(Configuration.get_Active().get_MarketDataProvider(), Configuration.get_Active().get_ExecutionProvider(), Configuration.get_Active().get_Portfolio(), Configuration.get_ActiveMode() != 0);
    }

    private void Configuration_ConfigurationModeChanged(object sender, EventArgs e)
    {
      this.UpdateConfiguration();
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
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Name = "QuoteMonitorWindow";
      ((DockControl) this).set_PersistState(true);
      this.set_SendOrdersEnabled(true);
      ((Control) this).ResumeLayout(false);
    }
  }
}
