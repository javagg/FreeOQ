using OpenQuant.Shared;
using OpenQuant.Shared.Indicators;
//using OpenQuant.Shared.Properties;
using FreeQuant.FinChart;
using FreeQuant.Indicators;
using FreeQuant.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace OpenQuant.Shared.Charting
{
	partial class Chart
	{
		private IContainer components;
		

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			this.ActionType = ChartActionType.None;
			this.AllowDrop = true;
			this.Name = "Chart";
		//	this.PrimitiveDeleteImage = (Image)Resources.delete;
		//	this.PrimitivePropertiesImage = (Image)Resources.properties;
			this.Size = new Size(579, 256);
            this.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.ResumeLayout(false);
		}
	}
}
