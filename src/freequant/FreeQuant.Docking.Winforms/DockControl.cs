//using System;
//using System.ComponentModel;
//using System.ComponentModel.Design;
//using TD.SandDock;

using System.ComponentModel;
namespace FreeQuant.Docking.WinForms
{
  [Designer("TD.SandDock.Design.UserDockControlDesigner, SandDock.Design, Version=1.0.0.1, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c3", typeof (System.ComponentModel.Design.IDesigner))]
  [Designer("TD.SandDock.Design.UserDockControlDocumentDesigner, SandDock.Design, Version=1.0.0.1, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c3", typeof (System.ComponentModel.Design.IRootDesigner))]
  public class DockControl : TD.SandDock.DockControl
  {
    private const TD.SandDock.ContainerDockLocation DEFAULT_DOCK_LOCATION = TD.SandDock.ContainerDockLocation.Left;
    private const bool DEFAULT_SHOW_FLOATING = false;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public object Key { get; private set; }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public DockControlSettings Settings { get; private set; }

    [DefaultValue(TD.SandDock.DockControlCloseAction.Dispose)]
    public override TD.SandDock.DockControlCloseAction CloseAction
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
    [DefaultValue(TD.SandDock.ContainerDockLocation.Left)]
    public TD.SandDock.ContainerDockLocation DefaultDockLocation { get; set; }

    [DefaultValue(false)]
    [Category("Docking")]
    public bool ShowFloating { get; set; }

    protected DockControl()
    {
      this.CloseAction = TD.SandDock.DockControlCloseAction.Dispose;
      this.DefaultDockLocation = TD.SandDock.ContainerDockLocation.Left;
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
      base.Open(TD.SandDock.WindowOpenMethod.OnScreenActivate);
    }

    protected void InvokeAction(System.Action action)
    {
      if (this.InvokeRequired)
        this.Invoke(action);
      else
        action();
    }
  }
}
