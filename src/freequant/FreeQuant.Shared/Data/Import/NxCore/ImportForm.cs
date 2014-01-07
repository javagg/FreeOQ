// Type: SmartQuant.Shared.Data.Import.NxCore.ImportForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using Dt5bTRSnuL0UjZKwy9;
using SmartQuant.Instruments;
using SmartQuant.Shared.Data.Import.TAQ;
using sXnbXNj4xHlKa3OJTR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.NxCore
{
  public class ImportForm : Form
  {
    private IContainer XD0lPImiDh;
    private OpenFileDialog uhKlAN5aBq;
    private Label IetlBUW7N9;
    private TextBox tNdlcY1w5F;
    private Button UjylzWkFD7;
    private GroupBox Dm4uexypxU;
    private ListView MwAuh5Hmhf;
    private ImageList EgmusG0JbL;
    private Button e0RuYH6OK8;
    private CheckBox K09ux0qrhj;
    private CheckBox UBnuDmvwe3;
    private Button WQru1JypuY;
    private Button FMgudgYTMG;
    private DateTimePicker AEhuF8T0eS;
    private DateTimePicker QGIubfItBY;

    private Instrument[] Instruments
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        List<Instrument> list = new List<Instrument>();
        foreach (OIOM0PUor5jNmryAqh oioM0Puor5jNmryAqh in this.MwAuh5Hmhf.Items)
          list.Add(oioM0Puor5jNmryAqh.eaEHGJbiC9());
        return list.ToArray();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.MwAuh5Hmhf.BeginUpdate();
        this.MwAuh5Hmhf.Items.Clear();
        if (value != null)
        {
          foreach (Instrument instrument in value)
            this.MwAuh5Hmhf.Items.Add((ListViewItem) new OIOM0PUor5jNmryAqh(instrument));
        }
        this.MwAuh5Hmhf.EndUpdate();
      }
    }

    private bool Trades
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.K09ux0qrhj.Checked;
      }
    }

    private bool Quotes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.UBnuDmvwe3.Checked;
      }
    }

    private TimeSpan? BeginTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.AEhuF8T0eS.Checked)
          return new TimeSpan?(this.AEhuF8T0eS.Value.TimeOfDay);
        else
          return new TimeSpan?();
      }
    }

    private TimeSpan? EndTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.QGIubfItBY.Checked)
          return new TimeSpan?(this.QGIubfItBY.Value.TimeOfDay);
        else
          return new TimeSpan?();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImportForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dipl2K2wUp();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.XD0lPImiDh != null)
        this.XD0lPImiDh.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dipl2K2wUp()
    {
      this.XD0lPImiDh = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ImportForm));
      this.uhKlAN5aBq = new OpenFileDialog();
      this.IetlBUW7N9 = new Label();
      this.tNdlcY1w5F = new TextBox();
      this.UjylzWkFD7 = new Button();
      this.Dm4uexypxU = new GroupBox();
      this.MwAuh5Hmhf = new ListView();
      this.EgmusG0JbL = new ImageList(this.XD0lPImiDh);
      this.e0RuYH6OK8 = new Button();
      this.K09ux0qrhj = new CheckBox();
      this.UBnuDmvwe3 = new CheckBox();
      this.WQru1JypuY = new Button();
      this.FMgudgYTMG = new Button();
      this.AEhuF8T0eS = new DateTimePicker();
      this.QGIubfItBY = new DateTimePicker();
      this.Dm4uexypxU.SuspendLayout();
      this.SuspendLayout();
      this.uhKlAN5aBq.Filter = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22074);
      this.IetlBUW7N9.Location = new Point(16, 16);
      this.IetlBUW7N9.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22124);
      this.IetlBUW7N9.Size = new Size(53, 20);
      this.IetlBUW7N9.TabIndex = 0;
      this.IetlBUW7N9.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22140);
      this.IetlBUW7N9.TextAlign = ContentAlignment.MiddleLeft;
      this.tNdlcY1w5F.Location = new Point(75, 16);
      this.tNdlcY1w5F.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22162);
      this.tNdlcY1w5F.ReadOnly = true;
      this.tNdlcY1w5F.Size = new Size(335, 20);
      this.tNdlcY1w5F.TabIndex = 1;
      this.UjylzWkFD7.Location = new Point(430, 16);
      this.UjylzWkFD7.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22188);
      this.UjylzWkFD7.Size = new Size(37, 20);
      this.UjylzWkFD7.TabIndex = 2;
      this.UjylzWkFD7.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22226);
      this.UjylzWkFD7.UseVisualStyleBackColor = true;
      this.UjylzWkFD7.Click += new EventHandler(this.wUylXOJcxR);
      this.Dm4uexypxU.Controls.Add((Control) this.MwAuh5Hmhf);
      this.Dm4uexypxU.Location = new Point(20, 64);
      this.Dm4uexypxU.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22236);
      this.Dm4uexypxU.Size = new Size(388, 203);
      this.Dm4uexypxU.TabIndex = 3;
      this.Dm4uexypxU.TabStop = false;
      this.Dm4uexypxU.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22258);
      this.MwAuh5Hmhf.Dock = DockStyle.Fill;
      this.MwAuh5Hmhf.HideSelection = false;
      this.MwAuh5Hmhf.Location = new Point(3, 16);
      this.MwAuh5Hmhf.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22284);
      this.MwAuh5Hmhf.ShowGroups = false;
      this.MwAuh5Hmhf.Size = new Size(382, 184);
      this.MwAuh5Hmhf.SmallImageList = this.EgmusG0JbL;
      this.MwAuh5Hmhf.Sorting = SortOrder.Ascending;
      this.MwAuh5Hmhf.TabIndex = 0;
      this.MwAuh5Hmhf.UseCompatibleStateImageBehavior = false;
      this.MwAuh5Hmhf.View = View.List;
      this.EgmusG0JbL.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(22316));
      this.EgmusG0JbL.TransparentColor = Color.Transparent;
      this.EgmusG0JbL.Images.SetKeyName(0, RNaihRhYEl0wUmAftnB.aYu7exFQKN(22372));
      this.e0RuYH6OK8.Location = new Point(420, 72);
      this.e0RuYH6OK8.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22404);
      this.e0RuYH6OK8.Size = new Size(64, 22);
      this.e0RuYH6OK8.TabIndex = 4;
      this.e0RuYH6OK8.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22448);
      this.e0RuYH6OK8.UseVisualStyleBackColor = true;
      this.e0RuYH6OK8.Click += new EventHandler(this.h3xlKqnKa1);
      this.K09ux0qrhj.Checked = true;
      this.K09ux0qrhj.CheckState = CheckState.Checked;
      this.K09ux0qrhj.Location = new Point(24, 284);
      this.K09ux0qrhj.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22470);
      this.K09ux0qrhj.Size = new Size(71, 20);
      this.K09ux0qrhj.TabIndex = 5;
      this.K09ux0qrhj.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22492);
      this.K09ux0qrhj.UseVisualStyleBackColor = true;
      this.UBnuDmvwe3.Checked = true;
      this.UBnuDmvwe3.CheckState = CheckState.Checked;
      this.UBnuDmvwe3.Location = new Point(24, 310);
      this.UBnuDmvwe3.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22508);
      this.UBnuDmvwe3.Size = new Size(71, 20);
      this.UBnuDmvwe3.TabIndex = 6;
      this.UBnuDmvwe3.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22530);
      this.UBnuDmvwe3.UseVisualStyleBackColor = true;
      this.WQru1JypuY.Location = new Point(301, 405);
      this.WQru1JypuY.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22546);
      this.WQru1JypuY.Size = new Size(80, 24);
      this.WQru1JypuY.TabIndex = 7;
      this.WQru1JypuY.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22566);
      this.WQru1JypuY.UseVisualStyleBackColor = true;
      this.WQru1JypuY.Click += new EventHandler(this.MtJlmlxoUO);
      this.FMgudgYTMG.DialogResult = DialogResult.Cancel;
      this.FMgudgYTMG.Location = new Point(387, 405);
      this.FMgudgYTMG.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22580);
      this.FMgudgYTMG.Size = new Size(80, 24);
      this.FMgudgYTMG.TabIndex = 8;
      this.FMgudgYTMG.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22602);
      this.FMgudgYTMG.UseVisualStyleBackColor = true;
      this.AEhuF8T0eS.CustomFormat = "";
      this.AEhuF8T0eS.Format = DateTimePickerFormat.Time;
      this.AEhuF8T0eS.Location = new Point(22, 340);
      this.AEhuF8T0eS.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22618);
      this.AEhuF8T0eS.ShowCheckBox = true;
      this.AEhuF8T0eS.ShowUpDown = true;
      this.AEhuF8T0eS.Size = new Size(101, 20);
      this.AEhuF8T0eS.TabIndex = 9;
      this.AEhuF8T0eS.Value = new DateTime(2012, 7, 15, 9, 30, 0, 0);
      this.QGIubfItBY.Format = DateTimePickerFormat.Time;
      this.QGIubfItBY.Location = new Point(22, 366);
      this.QGIubfItBY.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22638);
      this.QGIubfItBY.ShowCheckBox = true;
      this.QGIubfItBY.ShowUpDown = true;
      this.QGIubfItBY.Size = new Size(101, 20);
      this.QGIubfItBY.TabIndex = 10;
      this.QGIubfItBY.Value = new DateTime(2012, 7, 15, 16, 0, 0, 0);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.FMgudgYTMG;
      this.ClientSize = new Size(497, 445);
      this.Controls.Add((Control) this.QGIubfItBY);
      this.Controls.Add((Control) this.AEhuF8T0eS);
      this.Controls.Add((Control) this.FMgudgYTMG);
      this.Controls.Add((Control) this.WQru1JypuY);
      this.Controls.Add((Control) this.UBnuDmvwe3);
      this.Controls.Add((Control) this.K09ux0qrhj);
      this.Controls.Add((Control) this.e0RuYH6OK8);
      this.Controls.Add((Control) this.Dm4uexypxU);
      this.Controls.Add((Control) this.UjylzWkFD7);
      this.Controls.Add((Control) this.tNdlcY1w5F);
      this.Controls.Add((Control) this.IetlBUW7N9);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22654);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22678);
      this.Dm4uexypxU.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string JFUlwHBGvB()
    {
      return this.tNdlcY1w5F.Text.Trim();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void mKBl0vrbrZ(string value)
    {
      this.tNdlcY1w5F.Text = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wUylXOJcxR([In] object obj0, [In] EventArgs obj1)
    {
      this.uhKlAN5aBq.FileName = this.JFUlwHBGvB();
      if (this.uhKlAN5aBq.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      this.mKBl0vrbrZ(this.uhKlAN5aBq.FileName);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void h3xlKqnKa1([In] object obj0, [In] EventArgs obj1)
    {
      List<string> list1 = new List<string>();
      foreach (Instrument instrument in this.Instruments)
        list1.Add(instrument.Symbol);
      BrowseSymbolForm browseSymbolForm = new BrowseSymbolForm();
      browseSymbolForm.SelectedSymbols = list1.ToArray();
      if (browseSymbolForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        List<Instrument> list2 = new List<Instrument>();
        foreach (string index in browseSymbolForm.SelectedSymbols)
          list2.Add(InstrumentManager.Instruments[index]);
        this.Instruments = list2.ToArray();
      }
      browseSymbolForm.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MtJlmlxoUO([In] object obj0, [In] EventArgs obj1)
    {
      List<string> list = new List<string>();
      if (string.IsNullOrWhiteSpace(this.JFUlwHBGvB()))
        list.Add(RNaihRhYEl0wUmAftnB.aYu7exFQKN(22734));
      if (this.Instruments.Length == 0)
        list.Add(RNaihRhYEl0wUmAftnB.aYu7exFQKN(22790));
      if (!this.Trades && !this.Quotes)
        list.Add(RNaihRhYEl0wUmAftnB.aYu7exFQKN(22852));
      if (list.Count > 0)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, string.Join(Environment.NewLine, (IEnumerable<string>) list), RNaihRhYEl0wUmAftnB.aYu7exFQKN(22932), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        I20N1OILPyx1QZSVBi i20N1OilPyx1QzsvBi = new I20N1OILPyx1QZSVBi();
        i20N1OilPyx1QzsvBi.tp5bpkPf71(this.JFUlwHBGvB(), this.Instruments, this.Trades, this.Quotes, this.BeginTime, this.EndTime);
        int num2 = (int) i20N1OilPyx1QzsvBi.ShowDialog((IWin32Window) this);
        i20N1OilPyx1QzsvBi.Dispose();
        this.Close();
      }
    }
  }
}
