//using OpenQuant.API;
//using OpenQuant.Shared;
//using OpenQuant.Shared.Charting;
//using OpenQuant.Shared.Data.Management;
//using OpenQuant.Shared.Properties;
//using OpenQuant.Shared.ToolWindows;
//using FreeQuant.FIX;
//using FreeQuant.Instruments;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Windows.Forms;
//using TD.SandDock;
//
//using Instrument = FreeQuant.Instruments.Instrument;
//using InstrumentManager = FreeQuant.Instruments.InstrumentManager;
//using InstrumentList = FreeQuant.Instruments.InstrumentList;
//

namespace OpenQuant.Shared.Instruments
{
    public partial class InstrumentListWindow
    {
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.TreeView trvInstruments;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ImageList images;
        private System.Windows.Forms.ToolStripDropDownButton tsbGroup;
        private System.Windows.Forms.ToolStripMenuItem tsbGroup_None;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsbGroup_ByInstrumentType;
        private System.Windows.Forms.ToolStripMenuItem tsbGroup_Alphabetically;
        private System.Windows.Forms.ContextMenuStrip ctxInstruments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctxInstruments_Properties;
        private System.Windows.Forms.ToolStripMenuItem ctxInstruments_AddNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ctxInstruments_Delete;
        private System.Windows.Forms.ToolStripSeparator tssInstruments_Data;
        private System.Windows.Forms.ToolStripMenuItem tsbGroup_ByExchange;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripMenuItem ctxInstruments_Data;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsbGroup_ByCurrency;
        private System.Windows.Forms.ToolStripMenuItem tsbGroup_ByMaturity;
        private System.Windows.Forms.ToolStripMenuItem tsbGroup_ByGroup;
        private System.Windows.Forms.ToolStripMenuItem tsbGroup_BySector;
        private System.Windows.Forms.ToolStripSeparator tssInstruments_Chart;
        private System.Windows.Forms.ToolStripMenuItem ctxInstruments_Chart;
//        private System.Drawing.Rectangle dragBoxFromMouseDown;
//        private System.Drawing.Point screenOffset;
//        private System.Windows.Forms.Cursor myNoDropCursor;
//        private System.Windows.Forms.Cursor myNormalCursor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstrumentListWindow));
            this.trvInstruments = new System.Windows.Forms.TreeView();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbGroup = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbGroup_Alphabetically = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGroup_ByCurrency = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbGroup_ByExchange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbGroup_ByInstrumentType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbGroup_ByMaturity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbGroup_ByGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbGroup_BySector = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGroup_None = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.ctxInstruments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxInstruments_AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tssInstruments_Chart = new System.Windows.Forms.ToolStripSeparator();
            this.ctxInstruments_Chart = new System.Windows.Forms.ToolStripMenuItem();
            this.tssInstruments_Data = new System.Windows.Forms.ToolStripSeparator();
            this.ctxInstruments_Data = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxInstruments_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxInstruments_Properties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.ctxInstruments.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvInstruments
            // 
            this.trvInstruments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvInstruments.HideSelection = false;
            this.trvInstruments.ImageIndex = 0;
            this.trvInstruments.ImageList = this.images;
            this.trvInstruments.Location = new System.Drawing.Point(0, 25);
            this.trvInstruments.Name = "trvInstruments";
            this.trvInstruments.SelectedImageIndex = 0;
            this.trvInstruments.ShowNodeToolTips = true;
            this.trvInstruments.Size = new System.Drawing.Size(250, 375);
            this.trvInstruments.TabIndex = 0;
            this.trvInstruments.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.trvInstruments_AfterCollapse);
            this.trvInstruments.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvInstruments_AfterExpand);
            this.trvInstruments.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvInstruments_AfterSelect);
            this.trvInstruments.DoubleClick += new System.EventHandler(this.trvInstruments_DoubleClick);
            this.trvInstruments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trvInstruments_KeyDown);
            this.trvInstruments.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvInstruments_MouseDown);
            this.trvInstruments.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trvInstruments_MouseMove);
            this.trvInstruments.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trvInstruments_MouseUp);
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "instrument_plain.png");
                this.images.Images.SetKeyName(1, "VSFolder_closed.png");
                this.images.Images.SetKeyName(2, "VSFolder_open.png");
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGroup,
            this.tsbRefresh});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(250, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbGroup
            // 
            this.tsbGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGroup_Alphabetically,
            this.toolStripSeparator1,
            this.tsbGroup_ByCurrency,
            this.tsbGroup_ByExchange,
            this.tsbGroup_ByInstrumentType,
            this.tsbGroup_ByMaturity,
            this.tsbGroup_ByGroup,
            this.tsbGroup_BySector,
            this.toolStripSeparator5,
            this.tsbGroup_None});
            this.tsbGroup.Image = global::OpenQuant.Shared.Properties.Resources.group;
            this.tsbGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGroup.Name = "tsbGroup";
            this.tsbGroup.Size = new System.Drawing.Size(29, 22);
            this.tsbGroup.ToolTipText = "Group Instruments";
            this.tsbGroup.DropDownOpening += new System.EventHandler(this.tsbGroup_DropDownOpening);
            // 
            // tsbGroup_Alphabetically
            // 
            this.tsbGroup_Alphabetically.Name = "tsbGroup_Alphabetically";
            this.tsbGroup_Alphabetically.Size = new System.Drawing.Size(177, 22);
            this.tsbGroup_Alphabetically.Text = "Alphabetically";
            this.tsbGroup_Alphabetically.Click += new System.EventHandler(this.tsbGroup_Alphabetically_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // tsbGroup_ByCurrency
            // 
            this.tsbGroup_ByCurrency.Name = "tsbGroup_ByCurrency";
            this.tsbGroup_ByCurrency.Size = new System.Drawing.Size(177, 22);
            this.tsbGroup_ByCurrency.Text = "By Currency";
            this.tsbGroup_ByCurrency.Click += new System.EventHandler(this.tsbGroup_ByCurrency_Click);
            // 
            // tsbGroup_ByExchange
            // 
            this.tsbGroup_ByExchange.Name = "tsbGroup_ByExchange";
            this.tsbGroup_ByExchange.Size = new System.Drawing.Size(177, 22);
            this.tsbGroup_ByExchange.Text = "By Exchange";
            this.tsbGroup_ByExchange.Click += new System.EventHandler(this.tsbGroup_ByExchange_Click);
            // 
            // tsbGroup_ByInstrumentType
            // 
            this.tsbGroup_ByInstrumentType.Name = "tsbGroup_ByInstrumentType";
            this.tsbGroup_ByInstrumentType.Size = new System.Drawing.Size(177, 22);
            this.tsbGroup_ByInstrumentType.Text = "By Instrument Type";
            this.tsbGroup_ByInstrumentType.Click += new System.EventHandler(this.tsbGroup_ByInstrumentType_Click);
            // 
            // tsbGroup_ByMaturity
            // 
            this.tsbGroup_ByMaturity.Name = "tsbGroup_ByMaturity";
            this.tsbGroup_ByMaturity.Size = new System.Drawing.Size(177, 22);
            this.tsbGroup_ByMaturity.Text = "By Maturity";
            this.tsbGroup_ByMaturity.Click += new System.EventHandler(this.tsbGroup_ByMaturity_Click);
            // 
            // tsbGroup_ByGroup
            // 
            this.tsbGroup_ByGroup.Name = "tsbGroup_ByGroup";
            this.tsbGroup_ByGroup.Size = new System.Drawing.Size(177, 22);
            this.tsbGroup_ByGroup.Text = "By Industry Group";
            this.tsbGroup_ByGroup.Click += new System.EventHandler(this.tsbGroup_ByGroup_Click);
            // 
            // tsbGroup_BySector
            // 
            this.tsbGroup_BySector.Name = "tsbGroup_BySector";
            this.tsbGroup_BySector.Size = new System.Drawing.Size(177, 22);
            this.tsbGroup_BySector.Text = "By Industry Sector";
            this.tsbGroup_BySector.Click += new System.EventHandler(this.tsbGroup_BySector_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(174, 6);
            // 
            // tsbGroup_None
            // 
            this.tsbGroup_None.Name = "tsbGroup_None";
            this.tsbGroup_None.Size = new System.Drawing.Size(177, 22);
            this.tsbGroup_None.Text = "No Group";
            this.tsbGroup_None.Click += new System.EventHandler(this.tsbGroup_None_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::OpenQuant.Shared.Properties.Resources.refresh;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.ToolTipText = "Refresh Instruments";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // ctxInstruments
            // 
            this.ctxInstruments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxInstruments_AddNew,
            this.tssInstruments_Chart,
            this.ctxInstruments_Chart,
            this.tssInstruments_Data,
            this.ctxInstruments_Data,
            this.toolStripSeparator3,
            this.ctxInstruments_Delete,
            this.toolStripSeparator2,
            this.ctxInstruments_Properties});
            this.ctxInstruments.Name = "ctxInstruments";
            this.ctxInstruments.Size = new System.Drawing.Size(133, 138);
            this.ctxInstruments.Opening += new System.ComponentModel.CancelEventHandler(this.ctxInstruments_Opening);
            // 
            // ctxInstruments_AddNew
            // 
            this.ctxInstruments_AddNew.Image = global::OpenQuant.Shared.Properties.Resources.instrument;
            this.ctxInstruments_AddNew.Name = "ctxInstruments_AddNew";
            this.ctxInstruments_AddNew.Size = new System.Drawing.Size(132, 22);
            this.ctxInstruments_AddNew.Text = "Add New...";
            this.ctxInstruments_AddNew.Click += new System.EventHandler(this.ctxInstruments_AddNew_Click);
            // 
            // tssInstruments_Chart
            // 
            this.tssInstruments_Chart.Name = "tssInstruments_Chart";
            this.tssInstruments_Chart.Size = new System.Drawing.Size(129, 6);
            // 
            // ctxInstruments_Chart
            // 
            this.ctxInstruments_Chart.Image = global::OpenQuant.Shared.Properties.Resources.chart;
            this.ctxInstruments_Chart.Name = "ctxInstruments_Chart";
            this.ctxInstruments_Chart.Size = new System.Drawing.Size(132, 22);
            this.ctxInstruments_Chart.Text = "Chart";
            this.ctxInstruments_Chart.Click += new System.EventHandler(this.ctxInstruments_Chart_Click);
            // 
            // tssInstruments_Data
            // 
            this.tssInstruments_Data.Name = "tssInstruments_Data";
            this.tssInstruments_Data.Size = new System.Drawing.Size(129, 6);
            // 
            // ctxInstruments_Data
            // 
            this.ctxInstruments_Data.Image = global::OpenQuant.Shared.Properties.Resources.data;
            this.ctxInstruments_Data.Name = "ctxInstruments_Data";
            this.ctxInstruments_Data.Size = new System.Drawing.Size(132, 22);
            this.ctxInstruments_Data.Text = "Data";
            this.ctxInstruments_Data.Click += new System.EventHandler(this.ctxInstruments_Data_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(129, 6);
            // 
            // ctxInstruments_Delete
            // 
            this.ctxInstruments_Delete.Image = global::OpenQuant.Shared.Properties.Resources.delete;
            this.ctxInstruments_Delete.Name = "ctxInstruments_Delete";
            this.ctxInstruments_Delete.Size = new System.Drawing.Size(132, 22);
            this.ctxInstruments_Delete.Text = "Delete";
            this.ctxInstruments_Delete.Click += new System.EventHandler(this.ctxInstruments_Delete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(129, 6);
            // 
            // ctxInstruments_Properties
            // 
            this.ctxInstruments_Properties.Image = global::OpenQuant.Shared.Properties.Resources.properties;
            this.ctxInstruments_Properties.Name = "ctxInstruments_Properties";
            this.ctxInstruments_Properties.Size = new System.Drawing.Size(132, 22);
            this.ctxInstruments_Properties.Text = "Properties";
            this.ctxInstruments_Properties.Click += new System.EventHandler(this.ctxInstruments_Properties_Click);
            // 
            // InstrumentListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.ctxInstruments;
            this.Controls.Add(this.trvInstruments);
            this.Controls.Add(this.toolStrip);
            this.Name = "InstrumentListWindow";
            this.TabImage = global::OpenQuant.Shared.Properties.Resources.instrument;
            this.Text = "Instruments";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ctxInstruments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
