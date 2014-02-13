using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.Historical
{
	class DownloadViewItem : ListViewItem
	{
		private int count;
		private int total;
		private bool doUpdate;

		public Instrument Instrument { get; private set; }

		public DownloadItemStatus Status { get; set; }

		public string Message { get; set; }

		public int Count
		{
			get
			{
				return this.count;
			}
			set
			{
				this.count = value;
				this.doUpdate = true;
			}
		}

		public int Total
		{
			get
			{
				return this.total;
			}
			set
			{
				this.total = value;
				this.doUpdate = true;
			}
		}

		public DownloadViewItem(Instrument instrument) : base(new string[5])
		{
			this.Instrument = instrument;
			this.Reset();
		}

		public void Reset()
		{
			this.Status = DownloadItemStatus.Pending;
			this.count = 0;
			this.total = 0;
			this.Message = string.Empty;
			this.doUpdate = true;
			this.SubItems[0].Text = this.Instrument.Symbol;
			this.UpdateStatus();
			this.UpdateProgress();
			this.UpdateMessage();
		}

		public void UpdateStatus()
		{
			this.SubItems[1].Text = ((object)this.Status).ToString();
			switch (this.Status)
			{
				case DownloadItemStatus.Pending:
					this.ImageIndex = 0;
					break;
				case DownloadItemStatus.Downloading:
					this.ImageIndex = 1;
					break;
				case DownloadItemStatus.Done:
					this.ImageIndex = 2;
					break;
				case DownloadItemStatus.Error:
					this.ImageIndex = 3;
					break;
				case DownloadItemStatus.Cancelled:
					this.ImageIndex = 4;
					break;
				default:
					throw new ArgumentException(string.Format("Unknown status - {0}", this.Status));
			}
		}

		public void UpdateProgress()
		{
			if (!this.doUpdate)
				return;
			NumberFormatInfo numberFormatInfo = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
			numberFormatInfo.NumberDecimalDigits = 0;
			if (this.count == this.total)
			{
				this.SubItems[2].Text = this.count.ToString("n", (IFormatProvider)numberFormatInfo);
				this.SubItems[3].Text = this.total.ToString("n", (IFormatProvider)numberFormatInfo);
			}
			else
			{
				int num = this.count * 100 / this.total;
				this.SubItems[2].Text = string.Format((IFormatProvider)numberFormatInfo, "{0:n} ({1}%)", new object[2]
				{
					(object)this.count,
					(object)num
				});
				this.SubItems[3].Text = this.total.ToString("n", (IFormatProvider)numberFormatInfo);
			}
			this.doUpdate = false;
		}

		public void UpdateMessage()
		{
			this.SubItems[4].Text = this.Message;
		}
	}
}
