// Type: SmartQuant.Shared.Data.Management.QuantServer.ReindexForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using g5IScUuFJ30mW5dqjB;
using MV9df4cVbsoyuY2s64;
using SmartQuant.File;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Management.QuantServer
{
  public class ReindexForm : Form
  {
    private Button HimdqM5nu;
    private Container qOBFkXLZY;
    private Button jnybZNrmt;
    private Label hhdVO8DlX;
    private ComboBox EErRQuytI;
    private ProgressBar XRGH5FVeB;
    private Label ux5kvnAq7;
    private DataFile eNxl3I1Gv;
    private FileSeries imLuYujEd;
    private Label mmigbHbRS;
    private Label zQZM8guLs;
    private lpL9Isl4DQaI6uT8WE on0Jc8iW0;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReindexForm(DataFile file, FileSeries series)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.RwqhYw1ax();
      this.eNxl3I1Gv = file;
      this.imLuYujEd = series;
      if (series == null)
        this.mmigbHbRS.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(0);
      else
        this.mmigbHbRS.Text = series.Name;
      this.EErRQuytI.Items.Add((object) new UCyttABvG4oj9bO5jJ(SmartQuant.File.Indexing.Indexer.None));
      this.EErRQuytI.Items.Add((object) new UCyttABvG4oj9bO5jJ(SmartQuant.File.Indexing.Indexer.Daily));
      this.EErRQuytI.Items.Add((object) new UCyttABvG4oj9bO5jJ(SmartQuant.File.Indexing.Indexer.Monthly));
      if (series == null)
      {
        this.EErRQuytI.SelectedIndex = 0;
      }
      else
      {
        bool flag = false;
        for (int index = 0; index < this.EErRQuytI.Items.Count; ++index)
        {
          if ((this.EErRQuytI.Items[index] as UCyttABvG4oj9bO5jJ).Indexer == series.Indexer)
          {
            this.EErRQuytI.SelectedIndex = index;
            flag = true;
            break;
          }
        }
        if (!flag)
          throw new ArgumentException(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24) + series.Name, RNaihRhYEl0wUmAftnB.aYu7exFQKN(82));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.qOBFkXLZY != null)
        this.qOBFkXLZY.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RwqhYw1ax()
    {
      this.jnybZNrmt = new Button();
      this.HimdqM5nu = new Button();
      this.mmigbHbRS = new Label();
      this.hhdVO8DlX = new Label();
      this.EErRQuytI = new ComboBox();
      this.XRGH5FVeB = new ProgressBar();
      this.ux5kvnAq7 = new Label();
      this.zQZM8guLs = new Label();
      this.SuspendLayout();
      this.jnybZNrmt.Location = new Point(160, 144);
      this.jnybZNrmt.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(100);
      this.jnybZNrmt.Size = new Size(80, 24);
      this.jnybZNrmt.TabIndex = 0;
      this.jnybZNrmt.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(126);
      this.jnybZNrmt.Click += new EventHandler(this.TIOYRtEDU);
      this.HimdqM5nu.DialogResult = DialogResult.Cancel;
      this.HimdqM5nu.Location = new Point(256, 144);
      this.HimdqM5nu.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(146);
      this.HimdqM5nu.Size = new Size(80, 24);
      this.HimdqM5nu.TabIndex = 1;
      this.HimdqM5nu.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(166);
      this.mmigbHbRS.Location = new Point(72, 16);
      this.mmigbHbRS.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(180);
      this.mmigbHbRS.Size = new Size(264, 16);
      this.mmigbHbRS.TabIndex = 2;
      this.mmigbHbRS.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(202);
      this.mmigbHbRS.TextAlign = ContentAlignment.MiddleLeft;
      this.hhdVO8DlX.Font = new Font(RNaihRhYEl0wUmAftnB.aYu7exFQKN(218), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.hhdVO8DlX.Location = new Point(16, 48);
      this.hhdVO8DlX.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(262);
      this.hhdVO8DlX.Size = new Size(48, 16);
      this.hhdVO8DlX.TabIndex = 3;
      this.hhdVO8DlX.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(278);
      this.hhdVO8DlX.TextAlign = ContentAlignment.MiddleLeft;
      this.EErRQuytI.DropDownStyle = ComboBoxStyle.DropDownList;
      this.EErRQuytI.Location = new Point(72, 48);
      this.EErRQuytI.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(296);
      this.EErRQuytI.Size = new Size(96, 21);
      this.EErRQuytI.TabIndex = 5;
      this.XRGH5FVeB.Location = new Point(16, 112);
      this.XRGH5FVeB.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(322);
      this.XRGH5FVeB.Size = new Size(320, 20);
      this.XRGH5FVeB.TabIndex = 6;
      this.ux5kvnAq7.Location = new Point(24, 88);
      this.ux5kvnAq7.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(348);
      this.ux5kvnAq7.Size = new Size(304, 16);
      this.ux5kvnAq7.TabIndex = 7;
      this.ux5kvnAq7.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(366);
      this.zQZM8guLs.Font = new Font(RNaihRhYEl0wUmAftnB.aYu7exFQKN(398), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.zQZM8guLs.Location = new Point(16, 16);
      this.zQZM8guLs.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(442);
      this.zQZM8guLs.Size = new Size(40, 16);
      this.zQZM8guLs.TabIndex = 10;
      this.zQZM8guLs.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(458);
      this.zQZM8guLs.TextAlign = ContentAlignment.MiddleLeft;
      this.AcceptButton = (IButtonControl) this.HimdqM5nu;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.HimdqM5nu;
      this.ClientSize = new Size(352, 175);
      this.ControlBox = false;
      this.Controls.Add((Control) this.zQZM8guLs);
      this.Controls.Add((Control) this.ux5kvnAq7);
      this.Controls.Add((Control) this.XRGH5FVeB);
      this.Controls.Add((Control) this.EErRQuytI);
      this.Controls.Add((Control) this.hhdVO8DlX);
      this.Controls.Add((Control) this.mmigbHbRS);
      this.Controls.Add((Control) this.HimdqM5nu);
      this.Controls.Add((Control) this.jnybZNrmt);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(474);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(500);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void mvjsA3kUE([In] bool obj0)
    {
      this.EErRQuytI.Enabled = obj0;
      this.jnybZNrmt.Enabled = obj0;
      this.HimdqM5nu.Enabled = obj0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TIOYRtEDU([In] object obj0, [In] EventArgs obj1)
    {
      this.mvjsA3kUE(false);
      SmartQuant.File.Indexing.Indexer indexer = (this.EErRQuytI.SelectedItem as UCyttABvG4oj9bO5jJ).Indexer;
      ArrayList arrayList;
      if (this.imLuYujEd == null)
      {
        arrayList = new ArrayList((ICollection) this.eNxl3I1Gv.Series);
      }
      else
      {
        arrayList = new ArrayList();
        arrayList.Add((object) this.imLuYujEd);
      }
      this.on0Jc8iW0 = new lpL9Isl4DQaI6uT8WE(arrayList, indexer);
      this.on0Jc8iW0.kkAYLkJfuM += new SeriesEventHandler(this.ecxDwceTM);
      this.on0Jc8iW0.AagYWhqa3v += new SeriesEventHandler(this.U6x1DgFcI);
      this.on0Jc8iW0.hpyYMXXhIG += new EventHandler(this.Ml5xAHNeN);
      new Thread(new ThreadStart(this.on0Jc8iW0.ptsYRv5ig8)).Start();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Ml5xAHNeN([In] object obj0, [In] EventArgs obj1)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new EventHandler(this.Ml5xAHNeN), obj0, (object) obj1);
      }
      else
      {
        this.ux5kvnAq7.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(520);
        this.on0Jc8iW0.kkAYLkJfuM -= new SeriesEventHandler(this.ecxDwceTM);
        this.on0Jc8iW0.AagYWhqa3v -= new SeriesEventHandler(this.U6x1DgFcI);
        this.on0Jc8iW0.hpyYMXXhIG -= new EventHandler(this.Ml5xAHNeN);
        this.on0Jc8iW0 = (lpL9Isl4DQaI6uT8WE) null;
        this.mvjsA3kUE(true);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ecxDwceTM([In] SeriesEventArgs obj0)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new SeriesEventHandler(this.ecxDwceTM), new object[1]
        {
          (object) obj0
        });
      else
        this.ux5kvnAq7.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(532) + obj0.Series.Name;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void U6x1DgFcI([In] SeriesEventArgs obj0)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new SeriesEventHandler(this.U6x1DgFcI), new object[1]
        {
          (object) obj0
        });
      else
        this.XRGH5FVeB.Value = this.on0Jc8iW0.AKdYH0JWrk();
    }
  }
}
