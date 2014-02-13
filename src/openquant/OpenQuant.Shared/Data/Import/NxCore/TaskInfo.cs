// Type: OpenQuant.Shared.Data.Import.NxCore.TaskInfo
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System;
using System.Diagnostics;
using System.IO;

namespace OpenQuant.Shared.Data.Import.NxCore
{
  internal class TaskInfo
  {
    private Stopwatch watch;

    public FileInfo File { get; private set; }

    public DateTime DateTime { get; set; }

    public long TradeCount { get; set; }

    public long QuoteCount { get; set; }

    public TimeSpan Elapsed
    {
      get
      {
        return this.watch.Elapsed;
      }
    }

    public TaskInfo(FileInfo file)
    {
      this.File = file;
      this.DateTime = DateTime.Today;
      this.TradeCount = 0L;
      this.QuoteCount = 0L;
      this.watch = new Stopwatch();
    }

    public void StartTimer()
    {
      this.watch.Start();
    }

    public void StopTimer()
    {
      this.watch.Stop();
    }
  }
}
