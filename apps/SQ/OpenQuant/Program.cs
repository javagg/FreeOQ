// Type: OpenQuant.Program
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared;
using OpenQuant.Startup;
using SmartQuant;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using System;
using System.Threading;
using System.Windows.Forms;

namespace OpenQuant
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.ThreadException += new ThreadExceptionEventHandler(Program.Application_ThreadException);
      Global.Setup = new SetupInfo();
      if (Framework.IsAlreadyRunning)
      {
        int num1 = MessageBox.Show("Cannot start OpenQuant because another instance of application is already running.", "OpenQuant", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        if (!Framework.Installation.GetLicense().Licensed)
          Application.Run(new DemoDialog());
        SplashScreen splashScreen = new SplashScreen();
        Application.Run(splashScreen);
        if (splashScreen.get_HasError())
          Environment.Exit(-1);
        Application.Run(new IDE());
        ProviderManager.Shutdown();
        try
        {
          DataManager.Close();
        }
        catch (Exception ex)
        {
          if (Trace.IsLevelEnabled(TraceLevel.Error))
            Trace.WriteLine(ex.ToString());
          int num2 = MessageBox.Show("Error closing data manager. See log file for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
    }

    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
      RuntimeErrorManager.ReportError(new RuntimeError(RuntimeErrorLevel.Medium, e.Exception, "Application"));
    }
  }
}
