// Type: SmartQuant.Shared.Data.Management.QuantServer.ObjectViewer
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.Data;
using SmartQuant.File;
using SmartQuant.Shared.Controls;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Management.QuantServer
{
  public class ObjectViewer : Form
  {
    private SeriesViewer Tkgh8MqvJP;
    private Panel xqYh5xq2Vf;
    private Panel KYuhqCuthv;
    private Button lsUhCnqtIx;
    private Container VD0h2rtIQV;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectViewer(FileSeries series)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.agshrsium3();
      this.Tkgh8MqvJP.DataSeries = (IDataSeries) series;
      this.Text = series.Name;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.VD0h2rtIQV != null)
        this.VD0h2rtIQV.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void agshrsium3()
    {
      this.Tkgh8MqvJP = new SeriesViewer();
      this.xqYh5xq2Vf = new Panel();
      this.KYuhqCuthv = new Panel();
      this.lsUhCnqtIx = new Button();
      this.xqYh5xq2Vf.SuspendLayout();
      this.KYuhqCuthv.SuspendLayout();
      this.SuspendLayout();
      this.Tkgh8MqvJP.DataSeries = (IDataSeries) null;
      this.Tkgh8MqvJP.Dock = DockStyle.Fill;
      this.Tkgh8MqvJP.Location = new Point(0, 0);
      this.Tkgh8MqvJP.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2478);
      this.Tkgh8MqvJP.PriceDisplay = (string) null;
      this.Tkgh8MqvJP.Size = new Size(600, 492);
      this.Tkgh8MqvJP.TabIndex = 0;
      this.xqYh5xq2Vf.Controls.Add((Control) this.KYuhqCuthv);
      this.xqYh5xq2Vf.Dock = DockStyle.Bottom;
      this.xqYh5xq2Vf.Location = new Point(0, 492);
      this.xqYh5xq2Vf.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2494);
      this.xqYh5xq2Vf.Size = new Size(600, 28);
      this.xqYh5xq2Vf.TabIndex = 1;
      this.KYuhqCuthv.Controls.Add((Control) this.lsUhCnqtIx);
      this.KYuhqCuthv.Dock = DockStyle.Right;
      this.KYuhqCuthv.Location = new Point(480, 0);
      this.KYuhqCuthv.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2510);
      this.KYuhqCuthv.Size = new Size(120, 28);
      this.KYuhqCuthv.TabIndex = 0;
      this.lsUhCnqtIx.DialogResult = DialogResult.Cancel;
      this.lsUhCnqtIx.Location = new Point(48, 4);
      this.lsUhCnqtIx.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2526);
      this.lsUhCnqtIx.Size = new Size(56, 20);
      this.lsUhCnqtIx.TabIndex = 0;
      this.lsUhCnqtIx.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2546);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.lsUhCnqtIx;
      this.ClientSize = new Size(600, 520);
      this.Controls.Add((Control) this.Tkgh8MqvJP);
      this.Controls.Add((Control) this.xqYh5xq2Vf);
      this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2560);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.xqYh5xq2Vf.ResumeLayout(false);
      this.KYuhqCuthv.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
