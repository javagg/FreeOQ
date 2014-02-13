// Type: OpenQuant.Shared.Data.Import.TAQ.Importer
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System;
using System.Threading;

namespace OpenQuant.Shared.Data.Import.TAQ
{
  internal class Importer
  {
    private static ImportEngine engine;
    private static Thread thread;

    public static int PercentDone
    {
      get
      {
        return Importer.engine.PercentDone;
      }
    }

    public static event EventHandler Progress;

    public static event EventHandler Stopped;

    public static void SetSettings(ImportSettings settings)
    {
      switch (settings.DataFormatVersion)
      {
        case DataFormatVersion.Version1:
          Importer.engine = (ImportEngine) new ImportEngineV1();
          break;
        case DataFormatVersion.Version2:
          Importer.engine = (ImportEngine) new ImportEngineV2();
          break;
      }
      Importer.engine.SetSettings(settings);
      Importer.engine.Progress += new EventHandler(Importer.OnProgress);
      Importer.engine.Stopped += new EventHandler(Importer.OnStopped);
      Importer.thread = new Thread(new ThreadStart(Importer.engine.Run));
      Importer.thread.Name = "TAQ Import Engine";
    }

    public static void Dispose()
    {
      Importer.engine = (ImportEngine) null;
      Importer.thread = (Thread) null;
    }

    public static void Start()
    {
      Importer.thread.Start();
    }

    public static void Stop()
    {
      Importer.engine.Stop();
    }

    private static void OnProgress(object sender, EventArgs e)
    {
      if (Importer.Progress == null)
        return;
      Importer.Progress(sender, e);
    }

    private static void OnStopped(object sender, EventArgs e)
    {
      if (Importer.Stopped == null)
        return;
      Importer.Stopped(sender, e);
    }
  }
}
