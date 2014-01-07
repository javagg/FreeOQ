// Type: OpenQuant.Projects.UI.Items.StrategyNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Projects;
using SmartQuant.Instruments;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Items
{
  internal class StrategyNode : ObjectNode
  {
    private StrategyProject strategyProject;
    private StrategySettings strategySettings;
    private InstrumentListNode instrumentListNode;
    private CodeNode codeNode;
    private ContextMenuStrip ctxInstrumentList;
    private ContextMenuStrip ctxCode;
    private ContextMenuStrip ctxInstrument;

    internal InstrumentListNode InstrumentListNode
    {
      get
      {
        return this.instrumentListNode;
      }
    }

    internal CodeNode CodeNode
    {
      get
      {
        return this.codeNode;
      }
    }

    internal StrategyProject StrategyProject
    {
      get
      {
        return this.strategyProject;
      }
    }

    internal StrategySettings StrategySettings
    {
      get
      {
        return this.strategySettings;
      }
    }

    public override object Object
    {
      get
      {
        return (object) new StrategySettingsTypeDescriptor(this.strategySettings);
      }
    }

    public StrategyNode(StrategyProject strategyProject, ContextMenuStrip ctxInstrumentList, ContextMenuStrip ctxCode, ContextMenuStrip ctxInstrument)
      : base(strategyProject.Name, 0)
    {
      this.strategyProject = strategyProject;
      this.strategySettings = strategyProject.StrategySettings;
      this.instrumentListNode = new InstrumentListNode();
      this.codeNode = new CodeNode(strategyProject.CodeLang, this.strategySettings);
      this.Nodes.Add((TreeNode) this.instrumentListNode);
      this.Nodes.Add((TreeNode) this.codeNode);
      this.SetMenus(ctxInstrumentList, ctxCode, ctxInstrument);
      foreach (Instrument instrument in (IEnumerable) this.strategySettings.Instruments)
        this.AddInstrument(instrument);
      this.UpdateImage();
      this.Connect();
    }

    public void SetMenus(ContextMenuStrip ctxInstrumentList, ContextMenuStrip ctxCode, ContextMenuStrip ctxInstrument)
    {
      this.ctxInstrumentList = ctxInstrumentList;
      this.ctxCode = ctxCode;
      this.ctxInstrument = ctxInstrument;
      this.instrumentListNode.ContextMenuStrip = ctxInstrumentList;
      this.codeNode.ContextMenuStrip = ctxCode;
    }

    private void Connect()
    {
      this.strategySettings.Instruments.Added += new OpenQuantListEventHandler<Instrument>(this.Instruments_Added);
      this.strategySettings.Instruments.Removed += new OpenQuantListEventHandler<Instrument>(this.Instruments_Removed);
      this.strategySettings.Instruments.Cleared += new EventHandler(this.Instruments_Cleared);
    }

    public void Disconnect()
    {
      if (this.strategySettings == null)
        return;
      this.strategySettings.Instruments.Added -= new OpenQuantListEventHandler<Instrument>(this.Instruments_Added);
      this.strategySettings.Instruments.Removed -= new OpenQuantListEventHandler<Instrument>(this.Instruments_Removed);
      this.strategySettings.Instruments.Cleared -= new EventHandler(this.Instruments_Cleared);
    }

    private void AddInstrument(Instrument instrument)
    {
      InstrumentNode instrumentNode = new InstrumentNode(instrument);
      instrumentNode.ContextMenuStrip = this.ctxInstrument;
      this.instrumentListNode.Nodes.Add((TreeNode) instrumentNode);
    }

    private void Instruments_Added(object sender, OpenQuantListEventArgs<Instrument> args)
    {
      this.AddInstrument(args.Object);
    }

    private void Instruments_Removed(object sender, OpenQuantListEventArgs<Instrument> args)
    {
      foreach (InstrumentNode instrumentNode in this.instrumentListNode.Nodes)
      {
        if (instrumentNode.Instrument == args.Object)
        {
          instrumentNode.Remove();
          break;
        }
      }
    }

    private void Instruments_Cleared(object sender, EventArgs e)
    {
      this.instrumentListNode.Nodes.Clear();
    }

    public new void UpdateImage()
    {
      if (this.strategyProject.Enabled)
      {
        this.SelectedImageIndex = this.ImageIndex = 0;
        this.ForeColor = Color.Black;
      }
      else
      {
        this.SelectedImageIndex = this.ImageIndex = 12;
        this.ForeColor = SystemColors.GrayText;
      }
    }
  }
}
