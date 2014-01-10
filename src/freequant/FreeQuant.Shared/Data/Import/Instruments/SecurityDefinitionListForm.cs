using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.Shared.Data.Import.Instruments
{
  public class SecurityDefinitionListForm : Form
  {
    private IInstrumentProvider ElZM5QiWFt;
    private int xohMqXQHT2;
    private int jrLMCKlI4f;
    private SortOrder vgmM2PPFGO;
    private ListView Av6MXcQF5Z;
    private ColumnHeader C8TMKjxKFi;
    private ColumnHeader at2MmLNNGX;
    private ColumnHeader rNbMwDoQn6;
    private ColumnHeader N0CM0T9XnG;
    private ColumnHeader rKeMpUYAWr;
    private Button lfWMNN8JAI;
    private Button tb9MtLweak;
    private Button BhfME7Z5lF;
    private Button YeIMQ4QjwU;
    private ComboBox YqjMvRa8WX;
    private TextBox mM8Mo52OWa;
    private TextBox pcQMPgbCUZ;
    private Button eC5MALHhWM;
    private GroupBox aVBMBfOuv6;
    private ProgressBar jdxMcrTVkr;
    private CheckBox wIGMz4YMIr;
    private CheckBox C7NJeK5mMK;
    private CheckBox cr5JhTbkcv;
    private ContextMenuStrip ib8Js0VYqq;
    private ToolStripMenuItem uZlJY1Si6F;
    private IContainer ayuJxBtOSb;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SecurityDefinitionListForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      this.jrLMCKlI4f = -1;
      this.vgmM2PPFGO = SortOrder.Ascending;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.WlUM34Ql6m();
      this.ElZM5QiWFt = (IInstrumentProvider) null;
      this.YqjMvRa8WX.BeginUpdate();
      this.YqjMvRa8WX.Items.Clear();
      foreach (string str in this.gPmM8MoN0I())
        this.YqjMvRa8WX.Items.Add((object) new xtIARG15FVeBWx5vnA(str));
      this.YqjMvRa8WX.SelectedIndex = 0;
      this.YqjMvRa8WX.EndUpdate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.ayuJxBtOSb != null)
        this.ayuJxBtOSb.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WlUM34Ql6m()
    {
      this.ayuJxBtOSb = (IContainer) new Container();
      this.Av6MXcQF5Z = new ListView();
      this.C8TMKjxKFi = new ColumnHeader();
      this.at2MmLNNGX = new ColumnHeader();
      this.rNbMwDoQn6 = new ColumnHeader();
      this.N0CM0T9XnG = new ColumnHeader();
      this.rKeMpUYAWr = new ColumnHeader();
      this.lfWMNN8JAI = new Button();
      this.tb9MtLweak = new Button();
      this.BhfME7Z5lF = new Button();
      this.YeIMQ4QjwU = new Button();
      this.aVBMBfOuv6 = new GroupBox();
      this.cr5JhTbkcv = new CheckBox();
      this.C7NJeK5mMK = new CheckBox();
      this.wIGMz4YMIr = new CheckBox();
      this.eC5MALHhWM = new Button();
      this.pcQMPgbCUZ = new TextBox();
      this.mM8Mo52OWa = new TextBox();
      this.YqjMvRa8WX = new ComboBox();
      this.jdxMcrTVkr = new ProgressBar();
      this.ib8Js0VYqq = new ContextMenuStrip(this.ayuJxBtOSb);
      this.uZlJY1Si6F = new ToolStripMenuItem();
      this.aVBMBfOuv6.SuspendLayout();
      this.ib8Js0VYqq.SuspendLayout();
      this.SuspendLayout();
      this.Av6MXcQF5Z.CheckBoxes = true;
      this.Av6MXcQF5Z.Columns.AddRange(new ColumnHeader[5]
      {
        this.C8TMKjxKFi,
        this.at2MmLNNGX,
        this.rNbMwDoQn6,
        this.N0CM0T9XnG,
        this.rKeMpUYAWr
      });
      this.Av6MXcQF5Z.ContextMenuStrip = this.ib8Js0VYqq;
      this.Av6MXcQF5Z.FullRowSelect = true;
      this.Av6MXcQF5Z.GridLines = true;
      this.Av6MXcQF5Z.HideSelection = false;
      this.Av6MXcQF5Z.Location = new Point(8, 96);
      this.Av6MXcQF5Z.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31760);
      this.Av6MXcQF5Z.Size = new Size(520, 272);
      this.Av6MXcQF5Z.TabIndex = 0;
      this.Av6MXcQF5Z.UseCompatibleStateImageBehavior = false;
      this.Av6MXcQF5Z.View = View.Details;
      this.Av6MXcQF5Z.ColumnClick += new ColumnClickEventHandler(this.kxQMyQY8Ho);
      this.C8TMKjxKFi.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31792);
      this.C8TMKjxKFi.Width = 95;
      this.at2MmLNNGX.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31808);
      this.at2MmLNNGX.Width = 79;
      this.rNbMwDoQn6.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31838);
      this.rNbMwDoQn6.Width = 165;
      this.N0CM0T9XnG.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31864);
      this.N0CM0T9XnG.Width = 85;
      this.rKeMpUYAWr.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31884);
      this.rKeMpUYAWr.Width = 62;
      this.lfWMNN8JAI.DialogResult = DialogResult.Cancel;
      this.lfWMNN8JAI.Location = new Point(544, 363);
      this.lfWMNN8JAI.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31904);
      this.lfWMNN8JAI.Size = new Size(80, 24);
      this.lfWMNN8JAI.TabIndex = 1;
      this.lfWMNN8JAI.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31924);
      this.tb9MtLweak.Location = new Point(544, 96);
      this.tb9MtLweak.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31938);
      this.tb9MtLweak.Size = new Size(80, 24);
      this.tb9MtLweak.TabIndex = 2;
      this.tb9MtLweak.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31964);
      this.tb9MtLweak.Click += new EventHandler(this.d8YMG6qhxw);
      this.BhfME7Z5lF.Location = new Point(544, 128);
      this.BhfME7Z5lF.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31986);
      this.BhfME7Z5lF.Size = new Size(80, 24);
      this.BhfME7Z5lF.TabIndex = 3;
      this.BhfME7Z5lF.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32016);
      this.BhfME7Z5lF.Click += new EventHandler(this.OjbMZ0ms4h);
      this.YeIMQ4QjwU.Location = new Point(544, 184);
      this.YeIMQ4QjwU.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32042);
      this.YeIMQ4QjwU.Size = new Size(80, 24);
      this.YeIMQ4QjwU.TabIndex = 4;
      this.YeIMQ4QjwU.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32064);
      this.YeIMQ4QjwU.Click += new EventHandler(this.QmHMIFYlFO);
      this.aVBMBfOuv6.Controls.Add((Control) this.cr5JhTbkcv);
      this.aVBMBfOuv6.Controls.Add((Control) this.C7NJeK5mMK);
      this.aVBMBfOuv6.Controls.Add((Control) this.wIGMz4YMIr);
      this.aVBMBfOuv6.Controls.Add((Control) this.eC5MALHhWM);
      this.aVBMBfOuv6.Controls.Add((Control) this.pcQMPgbCUZ);
      this.aVBMBfOuv6.Controls.Add((Control) this.mM8Mo52OWa);
      this.aVBMBfOuv6.Controls.Add((Control) this.YqjMvRa8WX);
      this.aVBMBfOuv6.Location = new Point(8, 8);
      this.aVBMBfOuv6.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32080);
      this.aVBMBfOuv6.Size = new Size(520, 72);
      this.aVBMBfOuv6.TabIndex = 5;
      this.aVBMBfOuv6.TabStop = false;
      this.aVBMBfOuv6.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32104);
      this.cr5JhTbkcv.Location = new Point(272, 24);
      this.cr5JhTbkcv.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32120);
      this.cr5JhTbkcv.Size = new Size(104, 16);
      this.cr5JhTbkcv.TabIndex = 9;
      this.cr5JhTbkcv.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32142);
      this.cr5JhTbkcv.CheckedChanged += new EventHandler(this.dd5MfeTQbS);
      this.C7NJeK5mMK.Location = new Point(144, 24);
      this.C7NJeK5mMK.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32158);
      this.C7NJeK5mMK.Size = new Size(104, 16);
      this.C7NJeK5mMK.TabIndex = 8;
      this.C7NJeK5mMK.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32184);
      this.C7NJeK5mMK.CheckedChanged += new EventHandler(this.pt5MTSZYTJ);
      this.wIGMz4YMIr.Location = new Point(16, 24);
      this.wIGMz4YMIr.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32204);
      this.wIGMz4YMIr.Size = new Size(104, 16);
      this.wIGMz4YMIr.TabIndex = 7;
      this.wIGMz4YMIr.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32238);
      this.wIGMz4YMIr.CheckedChanged += new EventHandler(this.BuHMWHunde);
      this.eC5MALHhWM.Location = new Point(414, 37);
      this.eC5MALHhWM.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32268);
      this.eC5MALHhWM.Size = new Size(80, 24);
      this.eC5MALHhWM.TabIndex = 6;
      this.eC5MALHhWM.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32292);
      this.eC5MALHhWM.Click += new EventHandler(this.QrVMSZjXN0);
      this.pcQMPgbCUZ.Enabled = false;
      this.pcQMPgbCUZ.Location = new Point(272, 40);
      this.pcQMPgbCUZ.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32310);
      this.pcQMPgbCUZ.Size = new Size(112, 20);
      this.pcQMPgbCUZ.TabIndex = 5;
      this.mM8Mo52OWa.Enabled = false;
      this.mM8Mo52OWa.Location = new Point(144, 40);
      this.mM8Mo52OWa.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32332);
      this.mM8Mo52OWa.Size = new Size(112, 20);
      this.mM8Mo52OWa.TabIndex = 3;
      this.YqjMvRa8WX.DropDownStyle = ComboBoxStyle.DropDownList;
      this.YqjMvRa8WX.Enabled = false;
      this.YqjMvRa8WX.Location = new Point(16, 40);
      this.YqjMvRa8WX.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32358);
      this.YqjMvRa8WX.Size = new Size(112, 21);
      this.YqjMvRa8WX.Sorted = true;
      this.YqjMvRa8WX.TabIndex = 1;
      this.jdxMcrTVkr.Location = new Point(8, 374);
      this.jdxMcrTVkr.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32394);
      this.jdxMcrTVkr.Size = new Size(520, 13);
      this.jdxMcrTVkr.Step = 1;
      this.jdxMcrTVkr.TabIndex = 6;
      this.ib8Js0VYqq.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.uZlJY1Si6F
      });
      this.ib8Js0VYqq.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32420);
      this.ib8Js0VYqq.Size = new Size(153, 48);
      this.ib8Js0VYqq.Opening += new CancelEventHandler(this.po9MUQS2Mb);
      this.uZlJY1Si6F.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32452);
      this.uZlJY1Si6F.Size = new Size(152, 22);
      this.uZlJY1Si6F.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32508);
      this.uZlJY1Si6F.Click += new EventHandler(this.vDgMjKwFAQ);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.lfWMNN8JAI;
      this.ClientSize = new Size(634, 398);
      this.Controls.Add((Control) this.jdxMcrTVkr);
      this.Controls.Add((Control) this.aVBMBfOuv6);
      this.Controls.Add((Control) this.YeIMQ4QjwU);
      this.Controls.Add((Control) this.BhfME7Z5lF);
      this.Controls.Add((Control) this.tb9MtLweak);
      this.Controls.Add((Control) this.lfWMNN8JAI);
      this.Controls.Add((Control) this.Av6MXcQF5Z);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32542);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32598);
      this.aVBMBfOuv6.ResumeLayout(false);
      this.aVBMBfOuv6.PerformLayout();
      this.ib8Js0VYqq.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnClosing(CancelEventArgs e)
    {
      this.ElZM5QiWFt.SecurityDefinition -= new SecurityDefinitionEventHandler(this.tXkMObNhAo);
      base.OnClosing(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetProvider(IInstrumentProvider provider)
    {
      this.ElZM5QiWFt = provider;
      provider.SecurityDefinition += new SecurityDefinitionEventHandler(this.tXkMObNhAo);
      SecurityDefinitionListForm definitionListForm = this;
      string str = definitionListForm.Text + RNaihRhYEl0wUmAftnB.aYu7exFQKN(32650) + provider.Name;
      definitionListForm.Text = str;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuHMWHunde([In] object obj0, [In] EventArgs obj1)
    {
      this.YqjMvRa8WX.Enabled = this.wIGMz4YMIr.Checked;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pt5MTSZYTJ([In] object obj0, [In] EventArgs obj1)
    {
      this.mM8Mo52OWa.Enabled = this.C7NJeK5mMK.Checked;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dd5MfeTQbS([In] object obj0, [In] EventArgs obj1)
    {
      this.pcQMPgbCUZ.Enabled = this.cr5JhTbkcv.Checked;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void kxQMyQY8Ho([In] object obj0, [In] ColumnClickEventArgs obj1)
    {
      if (obj1.Column == this.jrLMCKlI4f)
      {
        switch (this.vgmM2PPFGO)
        {
          case SortOrder.Ascending:
            this.vgmM2PPFGO = SortOrder.Descending;
            break;
          case SortOrder.Descending:
            this.vgmM2PPFGO = SortOrder.Ascending;
            break;
        }
      }
      else
        this.jrLMCKlI4f = obj1.Column;
      this.Av6MXcQF5Z.ListViewItemSorter = (IComparer) new CAXVPdE3hIWZDqlM3N(obj1.Column, this.vgmM2PPFGO);
      this.Cursor = Cursors.WaitCursor;
      this.Av6MXcQF5Z.Sort();
      this.Cursor = Cursors.Default;
      this.Av6MXcQF5Z.ListViewItemSorter = (IComparer) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void tXkMObNhAo([In] object obj0, [In] SecurityDefinitionEventArgs obj1)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new SecurityDefinitionEventHandler(this.tXkMObNhAo), obj0, (object) obj1);
      else
        this.NIfMaIjWQ1(obj1.SecurityDefinition);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NIfMaIjWQ1([In] FIXSecurityDefinition obj0)
    {
      if (obj0.SecurityResponseType == 100)
      {
        this.jdxMcrTVkr.Minimum = 0;
        this.jdxMcrTVkr.Maximum = obj0.TotNoRelatedSym;
        this.jdxMcrTVkr.Value = obj0.BodyLength;
        Application.DoEvents();
      }
      else
      {
        ++this.xohMqXQHT2;
        this.jdxMcrTVkr.Maximum = obj0.TotNoRelatedSym;
        this.jdxMcrTVkr.Value = this.xohMqXQHT2;
        if (this.xohMqXQHT2 == obj0.TotNoRelatedSym)
          this.jA3M607Con(true);
        this.Av6MXcQF5Z.Items.Add((ListViewItem) new SecurityDefinitionViewItem(this.DsUMrBufkW(obj0), obj0));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void d8YMG6qhxw([In] object obj0, [In] EventArgs obj1)
    {
      this.lTbM4fPsWk(true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OjbMZ0ms4h([In] object obj0, [In] EventArgs obj1)
    {
      this.lTbM4fPsWk(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void lTbM4fPsWk([In] bool obj0)
    {
      this.Cursor = Cursors.WaitCursor;
      this.Av6MXcQF5Z.BeginUpdate();
      foreach (ListViewItem listViewItem in this.Av6MXcQF5Z.Items)
        listViewItem.Checked = obj0;
      this.Av6MXcQF5Z.EndUpdate();
      this.Cursor = Cursors.Default;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QmHMIFYlFO([In] object obj0, [In] EventArgs obj1)
    {
      this.jA3M607Con(false);
      this.Cursor = Cursors.WaitCursor;
      this.jdxMcrTVkr.Minimum = 0;
      this.jdxMcrTVkr.Value = 0;
      this.jdxMcrTVkr.Maximum = this.Av6MXcQF5Z.CheckedItems.Count;
      int num1 = 0;
      int num2 = 0;
      foreach (SecurityDefinitionViewItem definitionViewItem in this.Av6MXcQF5Z.CheckedItems)
      {
        string symbol = this.DsUMrBufkW(definitionViewItem.SecurityDefinition);
        if (!InstrumentManager.Instruments.Contains(symbol))
        {
          Instrument instrument = new Instrument(symbol, definitionViewItem.SecurityDefinition.SecurityType);
          foreach (FIXField field in definitionViewItem.SecurityDefinition.Fields)
          {
            if (field.Tag != 55 && field.Tag != 167)
              instrument.AddField(field);
          }
          if (!instrument.ContainsField(541))
          {
            DateTime result = DateTime.MinValue;
            string str = instrument.ContainsField(205) ? instrument.MaturityDay : RNaihRhYEl0wUmAftnB.aYu7exFQKN(32660);
            if (str.Length == 1)
              str = RNaihRhYEl0wUmAftnB.aYu7exFQKN(32668) + str;
            if (DateTime.TryParseExact(instrument.MaturityMonthYear + str, RNaihRhYEl0wUmAftnB.aYu7exFQKN(32674), (IFormatProvider) CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
              instrument.MaturityDate = result;
          }
          if ((int) this.ElZM5QiWFt.Id == 10)
          {
            instrument.AddSymbol(definitionViewItem.SecurityDefinition.Symbol, definitionViewItem.SecurityDefinition.SecurityExchange, RNaihRhYEl0wUmAftnB.aYu7exFQKN(32694));
            instrument.AddSymbol(definitionViewItem.SecurityDefinition.Symbol, definitionViewItem.SecurityDefinition.SecurityExchange, RNaihRhYEl0wUmAftnB.aYu7exFQKN(32710));
          }
          if ((int) this.ElZM5QiWFt.Id == 21)
            instrument.AddSymbol(definitionViewItem.SecurityDefinition.SecurityID, definitionViewItem.SecurityDefinition.SecurityExchange, this.ElZM5QiWFt.Name);
          if ((int) this.ElZM5QiWFt.Id == 22)
          {
            instrument.AddSymbol(definitionViewItem.SecurityDefinition.SecurityID, definitionViewItem.SecurityDefinition.SecurityExchange, this.ElZM5QiWFt.Name);
            instrument.RemoveField(48);
          }
          instrument.Save();
          ++num1;
        }
        else
          ++num2;
        ++this.jdxMcrTVkr.Value;
        Application.DoEvents();
      }
      this.jA3M607Con(true);
      this.Cursor = Cursors.Default;
      int num3 = (int) MessageBox.Show(string.Format(RNaihRhYEl0wUmAftnB.aYu7exFQKN(32726) + Environment.NewLine + RNaihRhYEl0wUmAftnB.aYu7exFQKN(32788), (object) num1, (object) num2), RNaihRhYEl0wUmAftnB.aYu7exFQKN(32828), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QrVMSZjXN0([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.ElZM5QiWFt.IsConnected)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, RNaihRhYEl0wUmAftnB.aYu7exFQKN(32842), RNaihRhYEl0wUmAftnB.aYu7exFQKN(32956), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        this.xohMqXQHT2 = 0;
        this.Av6MXcQF5Z.Items.Clear();
        this.jA3M607Con(false);
        Application.DoEvents();
        FIXSecurityDefinitionRequest request = (int) this.ElZM5QiWFt.Id != 19 ? new FIXSecurityDefinitionRequest(string.Format(RNaihRhYEl0wUmAftnB.aYu7exFQKN(32992), (object) DateTime.Now), 3) : new FIXSecurityDefinitionRequest(RNaihRhYEl0wUmAftnB.aYu7exFQKN(32986), 3);
        if (this.wIGMz4YMIr.Checked)
          request.SecurityType = (this.YqjMvRa8WX.SelectedItem as xtIARG15FVeBWx5vnA).HDSsSY5eSi();
        if (this.C7NJeK5mMK.Checked)
          request.SecurityExchange = this.mM8Mo52OWa.Text.Trim();
        if (this.cr5JhTbkcv.Checked)
          request.Symbol = this.pcQMPgbCUZ.Text.Trim();
        this.ElZM5QiWFt.SendSecurityDefinitionRequest(request);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void po9MUQS2Mb([In] object obj0, [In] CancelEventArgs obj1)
    {
      if (this.Av6MXcQF5Z.SelectedItems.Count == 1)
        this.uZlJY1Si6F.Enabled = true;
      else
        this.uZlJY1Si6F.Enabled = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void vDgMjKwFAQ([In] object obj0, [In] EventArgs obj1)
    {
      SecurityDefinitionViewItem definitionViewItem = (SecurityDefinitionViewItem) this.Av6MXcQF5Z.SelectedItems[0];
      DeKaCN7SJePpaLXyx4 kaCn7SjePpaLxyx4 = new DeKaCN7SJePpaLXyx4();
      kaCn7SjePpaLxyx4.CXXdFYqwvc(definitionViewItem.SecurityDefinition);
      int num = (int) kaCn7SjePpaLxyx4.ShowDialog((IWin32Window) this);
      kaCn7SjePpaLxyx4.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void jA3M607Con([In] bool obj0)
    {
      this.aVBMBfOuv6.Enabled = this.Av6MXcQF5Z.Enabled = this.tb9MtLweak.Enabled = this.BhfME7Z5lF.Enabled = this.YeIMQ4QjwU.Enabled = obj0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string DsUMrBufkW([In] FIXSecurityDefinition obj0)
    {
      if ((int) this.ElZM5QiWFt.Id == 10)
      {
        string str = obj0.Symbol;
        if (obj0.SecurityType == RNaihRhYEl0wUmAftnB.aYu7exFQKN(33032) || obj0.SecurityType == RNaihRhYEl0wUmAftnB.aYu7exFQKN(33042) || obj0.SecurityType == RNaihRhYEl0wUmAftnB.aYu7exFQKN(33052))
        {
          if (obj0.ContainsField(200))
          {
            string s = obj0.MaturityMonthYear.Substring(4, 2);
            DateTime dateTime = new DateTime(int.Parse(obj0.MaturityMonthYear.Substring(0, 4), (IFormatProvider) CultureInfo.InvariantCulture), int.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture), 1);
            str = str + RNaihRhYEl0wUmAftnB.aYu7exFQKN(33064) + dateTime.ToString(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33070), (IFormatProvider) CultureInfo.InvariantCulture);
          }
          if (obj0.SecurityType == RNaihRhYEl0wUmAftnB.aYu7exFQKN(33084))
          {
            if (obj0.ContainsField(202))
              str = str + (object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(33094) + (string) (object) obj0.StrikePrice;
            if (obj0.ContainsField(201))
              str = obj0.PutOrCall != 0 ? str + RNaihRhYEl0wUmAftnB.aYu7exFQKN(33108) : str + RNaihRhYEl0wUmAftnB.aYu7exFQKN(33100);
          }
        }
        return str;
      }
      else
      {
        if ((int) this.ElZM5QiWFt.Id != 22)
          return obj0.Symbol;
        string str = obj0.Symbol;
        if (obj0.SecurityType == RNaihRhYEl0wUmAftnB.aYu7exFQKN(33116) || obj0.SecurityType == RNaihRhYEl0wUmAftnB.aYu7exFQKN(33126))
        {
          if (obj0.ContainsField(541))
            str = str + RNaihRhYEl0wUmAftnB.aYu7exFQKN(33136) + obj0.MaturityDate.ToString(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33142), (IFormatProvider) CultureInfo.InvariantCulture);
          if (obj0.SecurityType == RNaihRhYEl0wUmAftnB.aYu7exFQKN(33156))
          {
            if (obj0.ContainsField(202))
              str = str + (object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(33166) + (string) (object) obj0.StrikePrice;
            if (obj0.ContainsField(201))
            {
              switch (obj0.PutOrCall)
              {
                case 0:
                  str = str + RNaihRhYEl0wUmAftnB.aYu7exFQKN(33172);
                  break;
                case 1:
                  str = str + RNaihRhYEl0wUmAftnB.aYu7exFQKN(33180);
                  break;
              }
            }
          }
        }
        return str;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string[] gPmM8MoN0I()
    {
      List<string> list = new List<string>();
      foreach (FieldInfo fieldInfo in typeof (FIXSecurityType).GetFields(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public))
      {
        if (fieldInfo.FieldType == typeof (string))
          list.Add((string) fieldInfo.GetValue((object) null));
      }
      return list.ToArray();
    }
  }
}
