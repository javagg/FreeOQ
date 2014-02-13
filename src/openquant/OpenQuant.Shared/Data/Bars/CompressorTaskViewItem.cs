using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Bars
{
	class CompressorTaskViewItem : ListViewItem
	{
		private CompressorTaskItem item;

		public CompressorTaskViewItem(CompressorTaskItem item) : base(new string[4])
		{
			this.item = item;
			this.UpdateValues();
		}

		public void UpdateValues()
		{
			this.SubItems[0].Text = this.item.Title;
			this.SubItems[1].Text = ((object)this.item.Status).ToString();
			this.SubItems[2].Text = ((object)this.item.Result).ToString();
			this.SubItems[3].Text = this.item.Message;
			switch (this.item.Status)
			{
				case CompressorTaskStatus.Pending:
					this.ImageIndex = 0;
					break;
				case CompressorTaskStatus.Processing:
					this.ImageIndex = 1;
					break;
				case CompressorTaskStatus.Done:
					switch (this.item.Result)
					{
						case CompressorTaskResult.None:
							this.ImageIndex = 4;
							return;
						case CompressorTaskResult.Success:
							this.ImageIndex = 2;
							return;
						case CompressorTaskResult.Error:
							this.ImageIndex = 3;
							return;
						default:
							return;
					}
			}
		}
	}
}
