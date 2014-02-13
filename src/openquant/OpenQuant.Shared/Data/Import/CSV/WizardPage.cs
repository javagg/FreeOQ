using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class WizardPage : UserControl
	{
		protected ImportSettings settings;
		protected DirectoryInfo templateDirectory;
		private Container components;

		public virtual bool CanBack
		{
			get
			{
				return true;
			}
		}

		public virtual bool CanNext
		{
			get
			{
				return true;
			}
		}

		public virtual bool CanClose
		{
			get
			{
				return true;
			}
		}

		public virtual string Title
		{
			get
			{
				return "";
			}
		}

		public event EventHandler ButtonEnabledChanged;

		public WizardPage()
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
			this.Name = "WizardPage";
			this.Size = new Size(376, 288);
		}

		public void SetSettings(ImportSettings settings)
		{
			this.settings = settings;
		}

		public void SetTemplateDirectory(DirectoryInfo templateDirectory)
		{
			this.templateDirectory = templateDirectory;
		}

		public virtual void BeforeNext()
		{
		}

		public virtual void BeforeBack()
		{
		}

		public virtual void BeforeLoad()
		{
		}

		public virtual void BeforeClose()
		{
		}

		protected void EmitButtonEnabledChanged()
		{
			if (this.ButtonEnabledChanged == null)
				return;
			this.ButtonEnabledChanged((object)this, EventArgs.Empty);
		}
	}
}
