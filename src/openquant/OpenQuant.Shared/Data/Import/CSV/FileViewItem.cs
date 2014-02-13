using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class FileViewItem : ListViewItem
	{
		public FileInfo File { get; private set; }

		public FileViewItem(FileInfo file) : base(new string[] { file.Name, "", "" })
		{
			this.File = file;
//			this.SubItems[0].Text = file.Name;
//			this.SubItems[1].Text = "";
//			this.SubItems[2].Text = "";
			this.ImageIndex = -1;
		}

		public void SetFileStatus(FileStatus status)
		{
			switch (status)
			{
				case FileStatus.Waiting:
					this.SetStatus("Waiting", 0);
					break;
				case FileStatus.Importing:
					this.SetStatus("Importing", 1);
					break;
				case FileStatus.Testing:
					this.SetStatus("Testing", 4);
					break;
				case FileStatus.DoneOk:
					this.SetStatus("Done", 2);
					break;
				case FileStatus.DoneError:
					this.SetStatus("Done with errors", 3);
					break;
				case FileStatus.Aborted:
					this.SetStatus("Aborted", 5);
					break;
				default:
					throw new NotSupportedException("Unknown status - " + status.ToString());
			}
		}

		public void SetObjectCount(int count)
		{
			if (count == -1)
			{
				this.SubItems[2].Text = "";
			}
			else
			{
				NumberFormatInfo numberFormatInfo = NumberFormatInfo.CurrentInfo.Clone() as NumberFormatInfo;
				numberFormatInfo.NumberDecimalDigits = 0;
				this.SubItems[2].Text = count.ToString("N", numberFormatInfo);
			}
		}

		private void SetStatus(string text, int imageIndex)
		{
			this.SubItems[1].Text = text;
			this.ImageIndex = imageIndex;
		}
	}
}
