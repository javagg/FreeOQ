// Type: SmartQuant.Shared.Data.Import.CSV.FilePage
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class FilePage : WizardPage
  {
    private Panel IfTbnbg6I5;
    private Button Ha6b7bJF4K;
    private Button gvAbLb1UVn;
    private Button iEsbiAM9DG;
    private Label eZLb9xLHWl;
    private ListBox G4ub3JWut8;
    private HelpProvider rHWbWes7HL;
    private IContainer LmhbTKqRDr;

    public override bool CanBack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return false;
      }
    }

    public override bool CanNext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.G4ub3JWut8.Items.Count > 0;
      }
    }

    public override string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return RNaihRhYEl0wUmAftnB.aYu7exFQKN(13794);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FilePage()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.ndXblQIBcx();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.LmhbTKqRDr != null)
        this.LmhbTKqRDr.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ndXblQIBcx()
    {
      this.IfTbnbg6I5 = new Panel();
      this.eZLb9xLHWl = new Label();
      this.iEsbiAM9DG = new Button();
      this.gvAbLb1UVn = new Button();
      this.Ha6b7bJF4K = new Button();
      this.G4ub3JWut8 = new ListBox();
      this.rHWbWes7HL = new HelpProvider();
      this.IfTbnbg6I5.SuspendLayout();
      this.SuspendLayout();
      this.IfTbnbg6I5.Controls.Add((Control) this.eZLb9xLHWl);
      this.IfTbnbg6I5.Controls.Add((Control) this.iEsbiAM9DG);
      this.IfTbnbg6I5.Controls.Add((Control) this.gvAbLb1UVn);
      this.IfTbnbg6I5.Controls.Add((Control) this.Ha6b7bJF4K);
      this.IfTbnbg6I5.Dock = DockStyle.Right;
      this.IfTbnbg6I5.Font = new Font(RNaihRhYEl0wUmAftnB.aYu7exFQKN(12598), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.IfTbnbg6I5.Location = new Point(368, 0);
      this.IfTbnbg6I5.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12642);
      this.IfTbnbg6I5.Size = new Size(112, 312);
      this.IfTbnbg6I5.TabIndex = 0;
      this.eZLb9xLHWl.Font = new Font(RNaihRhYEl0wUmAftnB.aYu7exFQKN(12658), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.eZLb9xLHWl.Location = new Point(8, 200);
      this.eZLb9xLHWl.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12702);
      this.eZLb9xLHWl.Size = new Size(96, 80);
      this.eZLb9xLHWl.TabIndex = 3;
      this.eZLb9xLHWl.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12718);
      this.rHWbWes7HL.SetHelpString((Control) this.iEsbiAM9DG, RNaihRhYEl0wUmAftnB.aYu7exFQKN(12892));
      this.iEsbiAM9DG.Location = new Point(8, 96);
      this.iEsbiAM9DG.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12970);
      this.rHWbWes7HL.SetShowHelp((Control) this.iEsbiAM9DG, true);
      this.iEsbiAM9DG.Size = new Size(96, 24);
      this.iEsbiAM9DG.TabIndex = 2;
      this.iEsbiAM9DG.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12992);
      this.iEsbiAM9DG.Click += new EventHandler(this.CkRbMSckLj);
      this.rHWbWes7HL.SetHelpString((Control) this.gvAbLb1UVn, RNaihRhYEl0wUmAftnB.aYu7exFQKN(13008));
      this.gvAbLb1UVn.Location = new Point(8, 48);
      this.gvAbLb1UVn.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13204);
      this.rHWbWes7HL.SetShowHelp((Control) this.gvAbLb1UVn, true);
      this.gvAbLb1UVn.Size = new Size(96, 24);
      this.gvAbLb1UVn.TabIndex = 1;
      this.gvAbLb1UVn.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13238);
      this.gvAbLb1UVn.Click += new EventHandler(this.VxvbgfoUJ4);
      this.rHWbWes7HL.SetHelpString((Control) this.Ha6b7bJF4K, RNaihRhYEl0wUmAftnB.aYu7exFQKN(13268));
      this.Ha6b7bJF4K.Location = new Point(8, 16);
      this.Ha6b7bJF4K.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13342);
      this.rHWbWes7HL.SetShowHelp((Control) this.Ha6b7bJF4K, true);
      this.Ha6b7bJF4K.Size = new Size(96, 24);
      this.Ha6b7bJF4K.TabIndex = 0;
      this.Ha6b7bJF4K.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13366);
      this.Ha6b7bJF4K.Click += new EventHandler(this.o8ybuhaZoE);
      this.G4ub3JWut8.Dock = DockStyle.Fill;
      this.rHWbWes7HL.SetHelpString((Control) this.G4ub3JWut8, RNaihRhYEl0wUmAftnB.aYu7exFQKN(13386));
      this.G4ub3JWut8.Location = new Point(0, 0);
      this.G4ub3JWut8.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13446);
      this.G4ub3JWut8.SelectionMode = SelectionMode.MultiExtended;
      this.rHWbWes7HL.SetShowHelp((Control) this.G4ub3JWut8, true);
      this.G4ub3JWut8.Size = new Size(368, 303);
      this.G4ub3JWut8.Sorted = true;
      this.G4ub3JWut8.TabIndex = 1;
      this.Controls.Add((Control) this.G4ub3JWut8);
      this.Controls.Add((Control) this.IfTbnbg6I5);
      this.Font = new Font(RNaihRhYEl0wUmAftnB.aYu7exFQKN(13466), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13510);
      this.rHWbWes7HL.SetShowHelp((Control) this, false);
      this.Size = new Size(480, 312);
      this.IfTbnbg6I5.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void o8ybuhaZoE([In] object obj0, [In] EventArgs obj1)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Title = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13530);
      openFileDialog.Multiselect = true;
      openFileDialog.CheckFileExists = true;
      openFileDialog.Filter = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13582);
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        this.Cursor = Cursors.WaitCursor;
        foreach (string str in openFileDialog.FileNames)
          this.OW1bJyr3Em(str);
        this.Cursor = Cursors.Default;
        this.EmitButtonEnabledChanged();
      }
      openFileDialog.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VxvbgfoUJ4([In] object obj0, [In] EventArgs obj1)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.ShowNewFolderButton = false;
      folderBrowserDialog.Description = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13682);
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        this.Cursor = Cursors.WaitCursor;
        DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
        foreach (FileSystemInfo fileSystemInfo in directoryInfo.GetFiles(RNaihRhYEl0wUmAftnB.aYu7exFQKN(13766)))
          this.OW1bJyr3Em(fileSystemInfo.FullName);
        foreach (FileSystemInfo fileSystemInfo in directoryInfo.GetFiles(RNaihRhYEl0wUmAftnB.aYu7exFQKN(13780)))
          this.OW1bJyr3Em(fileSystemInfo.FullName);
        this.Cursor = Cursors.Default;
        this.EmitButtonEnabledChanged();
      }
      folderBrowserDialog.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CkRbMSckLj([In] object obj0, [In] EventArgs obj1)
    {
      foreach (string str in new ArrayList((ICollection) this.G4ub3JWut8.SelectedItems))
        this.G4ub3JWut8.Items.Remove((object) str);
      this.EmitButtonEnabledChanged();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OW1bJyr3Em([In] string obj0)
    {
      bool flag = false;
      foreach (string str in this.G4ub3JWut8.Items)
      {
        if (str.ToUpper() == obj0.ToUpper())
        {
          flag = true;
          break;
        }
      }
      if (flag)
        return;
      this.G4ub3JWut8.Items.Add((object) obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void BeforeNext()
    {
      int count = this.G4ub3JWut8.Items.Count;
      FileInfo[] fileInfoArray = new FileInfo[count];
      for (int index = 0; index < count; ++index)
        fileInfoArray[index] = new FileInfo(this.G4ub3JWut8.Items[index] as string);
      this.settings.Files = fileInfoArray;
    }
  }
}
