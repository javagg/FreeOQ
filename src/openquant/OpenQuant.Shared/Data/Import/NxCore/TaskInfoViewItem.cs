// Type: OpenQuant.Shared.Data.Import.NxCore.TaskInfoViewItem
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.NxCore
{
  internal class TaskInfoViewItem : ListViewItem
  {
    private TaskInfo task;

    public TaskInfoViewItem(TaskInfo task)
      : base(new string[6], 0)
    {
      this.task = task;
      this.SubItems[0].Text = task.File.Name;
      this.SubItems[1].Text = task.File.Length.ToString("n0");
      this.ToolTipText = task.File.FullName;
    }

    public void Begin()
    {
      this.task.StartTimer();
      this.ImageIndex = 1;
      this.Update();
      this.EnsureVisible();
    }

    public void Update()
    {
      this.SubItems[2].Text = this.task.DateTime.ToString("HH:mm:ss");
      this.SubItems[3].Text = this.task.TradeCount.ToString("n0");
      this.SubItems[4].Text = this.task.QuoteCount.ToString("n0");
      this.SubItems[5].Text = this.task.Elapsed.ToString("hh\\:mm\\:ss\\.fff");
    }

    public void Done(bool error, bool skip)
    {
      this.task.StopTimer();
      if (error)
        this.ImageIndex = 3;
      else if (skip)
        this.ImageIndex = 4;
      else
        this.ImageIndex = 2;
      this.SubItems[2].Text = string.Empty;
    }
  }
}
