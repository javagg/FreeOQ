using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using TD.SandDock;

namespace FreeQuant.Docking.WinForms
{
  [Designer("TD.SandDock.Design.UserDockControlDesigner, SandDock.Design, Version=1.0.0.1, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c3", typeof (IDesigner))]
  [Designer("TD.SandDock.Design.UserDockControlDocumentDesigner, SandDock.Design, Version=1.0.0.1, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c3", typeof (IRootDesigner))]
  public class DockControl : TD.SandDock.DockControl
  {
    private const ContainerDockLocation DEFAULT_DOCK_LOCATION = ContainerDockLocation.Left;
    private const bool DEFAULT_SHOW_FLOATING = false;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public object Key { get; private set; }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public DockControlSettings Settings { get; private set; }

    [DefaultValue(DockControlCloseAction.Dispose)]
    public override DockControlCloseAction CloseAction
    {
      get
      {
        return base.CloseAction;
      }
      set
      {
        base.CloseAction = value;
      }
    }

    [Category("Docking")]
    [DefaultValue(ContainerDockLocation.Left)]
    public ContainerDockLocation DefaultDockLocation { get; set; }

    [DefaultValue(false)]
    [Category("Docking")]
    public bool ShowFloating { get; set; }

    protected DockControl()
    {
      this.CloseAction = DockControlCloseAction.Dispose;
      this.DefaultDockLocation = ContainerDockLocation.Left;
      this.ShowFloating = false;
    }

    internal void Init(object key, DockControlSettings settings)
    {
      this.Key = key;
      this.Settings = settings;
      this.OnInit();
    }

    protected virtual void OnInit()
    {
    }

    public override void Open()
    {
      base.Open(WindowOpenMethod.OnScreenActivate);
    }

    protected void InvokeAction(Action action)
    {
      if (this.InvokeRequired)
        this.Invoke(action);
      else
        action();
    }
  }
}
