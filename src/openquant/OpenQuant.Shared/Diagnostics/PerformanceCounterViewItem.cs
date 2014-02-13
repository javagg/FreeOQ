using System.Windows.Forms;

namespace OpenQuant.Shared.Diagnostics
{
	class PerformanceCounterViewItem : ListViewItem
	{
		private PerformanceCounterItem counter;

		public PerformanceCounterViewItem(string name, ListViewGroup group, PerformanceCounterItem counter)
      : base(new string[4])
		{
			this.counter = counter;
			this.SubItems[0].Text = name;
			this.Group = group;
			this.Update();
		}

		public void Update()
		{
			this.SubItems[1].Text = this.counter.Count.ToString("n0");
			this.SubItems[2].Text = this.counter.Average.ToString("n0");
			this.SubItems[3].Text = this.counter.Peak.ToString("n0");
		}
	}
}
