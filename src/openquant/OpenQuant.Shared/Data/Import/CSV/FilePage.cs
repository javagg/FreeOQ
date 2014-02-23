// Type: OpenQuant.Shared.Data.Import.CSV.FilePage
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.CSV
{
  internal class FilePage : WizardPage
  {
    private Panel panel1;
    private Button btnAddFile;
    private Button btnAddDirectory;
    private Button btnRemove;
    private Label label1;
    private ListBox ltbFiles;
    private HelpProvider helpProvider;
        private IContainer components = null;

    public override bool CanBack
    {
      get
      {
        return false;
      }
    }

    public override bool CanNext
    {
      get
      {
        return this.ltbFiles.Items.Count > 0;
      }
    }

    public override string Title
    {
      get
      {
        return "Select File(s) to Import";
      }
    }

    public FilePage()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panel1 = new Panel();
      this.label1 = new Label();
      this.btnRemove = new Button();
      this.btnAddDirectory = new Button();
      this.btnAddFile = new Button();
      this.ltbFiles = new ListBox();
      this.helpProvider = new HelpProvider();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Controls.Add((Control) this.btnRemove);
      this.panel1.Controls.Add((Control) this.btnAddDirectory);
      this.panel1.Controls.Add((Control) this.btnAddFile);
      this.panel1.Dock = DockStyle.Right;
      this.panel1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.panel1.Location = new Point(368, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(112, 312);
      this.panel1.TabIndex = 0;
      this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.label1.Location = new Point(8, 200);
      this.label1.Name = "label1";
      this.label1.Size = new Size(96, 80);
      this.label1.TabIndex = 3;
      this.label1.Text = "Note:\nIf you select more than one file make sure that all files have the same format!";
      this.helpProvider.SetHelpString((Control) this.btnRemove, "Remove selected file(s) from the list");
      this.btnRemove.Location = new Point(8, 96);
      this.btnRemove.Name = "btnRemove";
      this.helpProvider.SetShowHelp((Control) this.btnRemove, true);
      this.btnRemove.Size = new Size(96, 24);
      this.btnRemove.TabIndex = 2;
      this.btnRemove.Text = "Remove";
      this.btnRemove.Click += new EventHandler(this.btnRemove_Click);
      this.helpProvider.SetHelpString((Control) this.btnAddDirectory, "Add a directory with CSV or text files(s).\nOnly files with .csv or .txt extension will be added.");
      this.btnAddDirectory.Location = new Point(8, 48);
      this.btnAddDirectory.Name = "btnAddDirectory";
      this.helpProvider.SetShowHelp((Control) this.btnAddDirectory, true);
      this.btnAddDirectory.Size = new Size(96, 24);
      this.btnAddDirectory.TabIndex = 1;
      this.btnAddDirectory.Text = "Add Directory";
      this.btnAddDirectory.Click += new EventHandler(this.btnAddDirectory_Click);
      this.helpProvider.SetHelpString((Control) this.btnAddFile, "Add CSV or text file(s) to the list");
      this.btnAddFile.Location = new Point(8, 16);
      this.btnAddFile.Name = "btnAddFile";
      this.helpProvider.SetShowHelp((Control) this.btnAddFile, true);
      this.btnAddFile.Size = new Size(96, 24);
      this.btnAddFile.TabIndex = 0;
      this.btnAddFile.Text = "Add File";
      this.btnAddFile.Click += new EventHandler(this.btnAddFile_Click);
      this.ltbFiles.Dock = DockStyle.Fill;
      this.helpProvider.SetHelpString((Control) this.ltbFiles, "List of the files to import.");
      this.ltbFiles.Location = new Point(0, 0);
      this.ltbFiles.Name = "ltbFiles";
      this.ltbFiles.SelectionMode = SelectionMode.MultiExtended;
      this.helpProvider.SetShowHelp((Control) this.ltbFiles, true);
      this.ltbFiles.Size = new Size(368, 303);
      this.ltbFiles.Sorted = true;
      this.ltbFiles.TabIndex = 1;
      this.Controls.Add((Control) this.ltbFiles);
      this.Controls.Add((Control) this.panel1);
      this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Name = "FilePage";
      this.helpProvider.SetShowHelp((Control) this, false);
      this.Size = new Size(480, 312);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void btnAddFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Title = "Select File(s) to Import";
      openFileDialog.Multiselect = true;
      openFileDialog.CheckFileExists = true;
      openFileDialog.Filter = "CSV files(*.csv;*.txt)|*.csv;*.txt|All files|*.*";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        this.Cursor = Cursors.WaitCursor;
        foreach (string filename in openFileDialog.FileNames)
          this.AddFile(filename);
        this.Cursor = Cursors.Default;
        this.EmitButtonEnabledChanged();
      }
      openFileDialog.Dispose();
    }

    private void btnAddDirectory_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.ShowNewFolderButton = false;
      folderBrowserDialog.Description = "Select directory with CSV or text files.";
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        this.Cursor = Cursors.WaitCursor;
        DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
        foreach (FileSystemInfo fileSystemInfo in directoryInfo.GetFiles("*.csv"))
          this.AddFile(fileSystemInfo.FullName);
        foreach (FileSystemInfo fileSystemInfo in directoryInfo.GetFiles("*.txt"))
          this.AddFile(fileSystemInfo.FullName);
        this.Cursor = Cursors.Default;
        this.EmitButtonEnabledChanged();
      }
      folderBrowserDialog.Dispose();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      foreach (string str in new ArrayList((ICollection) this.ltbFiles.SelectedItems))
        this.ltbFiles.Items.Remove((object) str);
      this.EmitButtonEnabledChanged();
    }

    private void AddFile(string filename)
    {
      bool flag = false;
      foreach (string str in this.ltbFiles.Items)
      {
        if (str.ToUpper() == filename.ToUpper())
        {
          flag = true;
          break;
        }
      }
      if (flag)
        return;
      this.ltbFiles.Items.Add((object) filename);
    }

    public override void BeforeNext()
    {
      int count = this.ltbFiles.Items.Count;
      FileInfo[] fileInfoArray = new FileInfo[count];
      for (int index = 0; index < count; ++index)
        fileInfoArray[index] = new FileInfo(this.ltbFiles.Items[index] as string);
      this.settings.Files = fileInfoArray;
    }
  }
}
