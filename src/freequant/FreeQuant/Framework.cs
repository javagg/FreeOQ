// Type: SmartQuant.Framework
// Assembly: SmartQuant, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=null
// MVID: BC86C0EF-576E-453D-8BFD-FAB33B893C15
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.dll

using aPqI2kmeVjWsoIHqc3F;
using BoBSVVX0yGpEOB0Qj2;
using oZ1IlQmSDifdcZke9oZ;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace FreeQuant
{
  public class Framework
  {
    private static Configuration Jmtw8dmK6;
    private static Installation DGghk9Nln;
    private static Storage HhVs2ITrn;
    private static Runtime DVVyxKgnL;
    private static Mutex mDOEiS9EL;
    private static bool mY0TnM837;

    public static bool IsAlreadyRunning
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return true;
      }
    }

    public static Configuration Configuration
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (Configuration) null;
      }
    }

    public static Installation Installation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (Installation) null;
      }
    }

    public static Storage Storage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (Storage) null;
      }
    }

    public static Runtime Runtime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (Runtime) null;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Framework()
    {
      GItcYDqSxj5aE60JeS.GRAroVBQNR();
      U11BeMmYvqFIQ38CeV7.y89NYTfzAIJ6Q();
      Framework.mDOEiS9EL = new Mutex(false, Framework.Installation.QUANTAPP.FullName.Replace('\\', ':').Replace('/', ':'));
      Framework.mY0TnM837 = !Framework.mDOEiS9EL.WaitOne(0);
      if (Framework.mY0TnM837)
        return;
      switch (Framework.Installation.Edition)
      {
        case Edition.Demo:
          if (!Framework.Installation.tnABvXFOOP() && !Framework.Installation.c7kBpxixDa())
            break;
          if (Trace.IsLevelEnabled(TraceLevel.Info))
            Trace.WriteLine(GItcYDqSxj5aE60JeS.GFmrbXlIxf(76));
          if (Environment.UserInteractive)
          {
            int num1 = (int) MessageBox.Show(string.Format(GItcYDqSxj5aE60JeS.GFmrbXlIxf(140), (object) Framework.Installation.MainProduct), GItcYDqSxj5aE60JeS.GFmrbXlIxf(368), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          Environment.Exit(-1);
          break;
        case Edition.Research:
        case Edition.Professional:
          if (Framework.Installation.i94BcvgC0K())
            break;
          if (Trace.IsLevelEnabled(TraceLevel.Info))
            Trace.WriteLine(GItcYDqSxj5aE60JeS.GFmrbXlIxf(392));
          if (Environment.UserInteractive)
          {
            int num2 = (int) MessageBox.Show(GItcYDqSxj5aE60JeS.GFmrbXlIxf(462), GItcYDqSxj5aE60JeS.GFmrbXlIxf(532), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          Environment.Exit(-1);
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Framework()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Init()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LoadPlugins()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LoadPlugin(Plugin plugin)
    {
    }
  }
}
