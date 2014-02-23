using OpenQuant.Shared.Properties;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.Providers
{
  public class ProviderErrorListWindow : FreeQuant.Docking.WinForms.DockControl
  {
    private IContainer components;
    private ListView ltvErrors;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ContextMenuStrip ctxErrors;
    private ToolStripMenuItem ctxErrors_Details;
    private ImageList imgErrors;

    public ProviderErrorListWindow()
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
            this.components = new System.ComponentModel.Container();
            this.ltvErrors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxErrors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxErrors_Details = new System.Windows.Forms.ToolStripMenuItem();
            this.imgErrors = new System.Windows.Forms.ImageList(this.components);
            this.ctxErrors.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltvErrors
            // 
            this.ltvErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ltvErrors.ContextMenuStrip = this.ctxErrors;
            this.ltvErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltvErrors.FullRowSelect = true;
            this.ltvErrors.GridLines = true;
            this.ltvErrors.HideSelection = false;
            this.ltvErrors.Location = new System.Drawing.Point(0, 0);
            this.ltvErrors.MultiSelect = false;
            this.ltvErrors.Name = "ltvErrors";
            this.ltvErrors.ShowGroups = false;
            this.ltvErrors.ShowItemToolTips = true;
            this.ltvErrors.Size = new System.Drawing.Size(585, 167);
            this.ltvErrors.SmallImageList = this.imgErrors;
            this.ltvErrors.TabIndex = 0;
            this.ltvErrors.UseCompatibleStateImageBehavior = false;
            this.ltvErrors.View = System.Windows.Forms.View.Details;
            this.ltvErrors.DoubleClick += new System.EventHandler(this.ltvErrors_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DateTime";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Provider";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Code";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Message";
            this.columnHeader5.Width = 233;
            // 
            // ctxErrors
            // 
            this.ctxErrors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxErrors_Details});
            this.ctxErrors.Name = "ctxErrors";
            this.ctxErrors.Size = new System.Drawing.Size(166, 26);
            this.ctxErrors.Opening += new System.ComponentModel.CancelEventHandler(this.ctxErrors_Opening);
            // 
            // ctxErrors_Details
            // 
            this.ctxErrors_Details.Name = "ctxErrors_Details";
            this.ctxErrors_Details.Size = new System.Drawing.Size(165, 22);
            this.ctxErrors_Details.Text = "View Error Details";
            this.ctxErrors_Details.Click += new System.EventHandler(this.ctxErrors_Details_Click);
            // 
            // imgErrors
            // 
            this.imgErrors.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgErrors.ImageSize = new System.Drawing.Size(16, 16);
            this.imgErrors.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ProviderErrorListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ltvErrors);
            this.DefaultDockLocation = TD.SandDock.ContainerDockLocation.Bottom;
            this.Name = "ProviderErrorListWindow";
            this.Size = new System.Drawing.Size(585, 167);
            this.TabImage = global::OpenQuant.Shared.Properties.Resources.provider_errors;
            this.Text = "Provider Errors";
            this.ctxErrors.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    protected override void OnInit()
    {
      this.ltvErrors.BeginUpdate();
      IEnumerator enumerator = ProviderManager.Errors.GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
          this.AddError((ProviderError) enumerator.Current);
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
      this.ltvErrors.EndUpdate();
      // ISSUE: method pointer
			ProviderManager.Error += new ProviderErrorEventHandler(this.ProviderManager_Error);
    }

    protected override void OnClosing(DockControlClosingEventArgs e)
    {
      // ISSUE: method pointer
			ProviderManager.Error -= new ProviderErrorEventHandler(this.ProviderManager_Error);
      base.OnClosing(e);
    }

    private void ProviderManager_Error(ProviderErrorEventArgs args)
    {
      if (this.InvokeRequired)
      {
        // ISSUE: method pointer
        this.BeginInvoke((Delegate) new ProviderErrorEventHandler( this.ProviderManager_Error), new object[1]
        {
          args
        });
      }
      else
        this.AddError(args.Error);
    }

    private void AddError(ProviderError error)
    {
      this.ltvErrors.Items.Insert(0, (ListViewItem) new ProviderErrorViewItem(error));
    }

    private void ctxErrors_Opening(object sender, CancelEventArgs e)
    {
      this.ctxErrors_Details.Enabled = this.ltvErrors.SelectedItems.Count == 1;
    }

    private void ctxErrors_Details_Click(object sender, EventArgs e)
    {
      this.ViewErrorDetails((this.ltvErrors.SelectedItems[0] as ProviderErrorViewItem).Error);
    }

    private void ltvErrors_DoubleClick(object sender, EventArgs e)
    {
      this.ViewErrorDetails((this.ltvErrors.SelectedItems[0] as ProviderErrorViewItem).Error);
    }

    private void ViewErrorDetails(ProviderError error)
    {
      ProviderErrorDetailsForm errorDetailsForm = new ProviderErrorDetailsForm();
      errorDetailsForm.SetCurrentError(error);
      int num = (int) errorDetailsForm.ShowDialog((IWin32Window) this);
      errorDetailsForm.Dispose();
    }
  }
}
