// Type: SmartQuant.Shared.Data.Import.TAQ.Importer
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using DdS3VkGiTwQOmRJ7Mh;
using rfZtgRWJXxwtcJHifs;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.TAQ
{
  public class Importer
  {
    private static ImportEngine ch7dtZiPhO;
    private static Thread XAxdEyk3y5;

    public static int PercentDone
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Importer.ch7dtZiPhO.PercentDone;
      }
    }

    public static event EventHandler Progress;

    public static event EventHandler Stopped;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Importer()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetSettings(ImportSettings settings)
    {
      switch (settings.DataFormatVersion)
      {
        case DataFormatVersion.Version1:
          Importer.ch7dtZiPhO = (ImportEngine) new noARWWaXHjp5SfgZ99();
          break;
        case DataFormatVersion.Version2:
          Importer.ch7dtZiPhO = (ImportEngine) new cFIie634SM7fKWplsf();
          break;
      }
      Importer.ch7dtZiPhO.SetSettings(settings);
      Importer.ch7dtZiPhO.Progress += new EventHandler(Importer.QePdpV6cd0);
      Importer.ch7dtZiPhO.Stopped += new EventHandler(Importer.O7BdNtaRUQ);
      Importer.XAxdEyk3y5 = new Thread(new ThreadStart(Importer.ch7dtZiPhO.Run));
      Importer.XAxdEyk3y5.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11326);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Dispose()
    {
      Importer.ch7dtZiPhO = (ImportEngine) null;
      Importer.XAxdEyk3y5 = (Thread) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Start()
    {
      Importer.XAxdEyk3y5.Start();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Stop()
    {
      Importer.ch7dtZiPhO.Stop();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void QePdpV6cd0([In] object obj0, [In] EventArgs obj1)
    {
      if (Importer.eYUdQx43M8 == null)
        return;
      Importer.eYUdQx43M8(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void O7BdNtaRUQ([In] object obj0, [In] EventArgs obj1)
    {
      if (Importer.rUpdv0QfOG == null)
        return;
      Importer.rUpdv0QfOG(obj0, obj1);
    }
  }
}
