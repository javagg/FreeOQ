// Type: OpenQuant.Startup.AppDataInstaller
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant;
using System.IO;

namespace OpenQuant.Startup
{
  internal class AppDataInstaller : DataInstaller
  {
    public override void CheckInstallation()
    {
      this.IsInstalled = this.setup.Folders.ChartColorTemplates.Exists && this.setup.Folders.Ini.Exists && (Framework.Installation.QUANTDAT.Exists && Framework.Installation.IniDir.Exists) && Framework.Installation.LogDir.Exists && Framework.Installation.TempDir.Exists;
    }

    public override void Install()
    {
      if (!this.setup.Folders.ChartColorTemplates.Exists)
        this.UnpackFile("cct.zip", this.setup.Folders.ChartColorTemplates);
      if (!this.setup.Folders.Ini.Exists)
        this.UnpackFile("ini.zip", this.setup.Folders.Ini);
      if (!Framework.Installation.QUANTDAT.Exists)
        this.UnpackFile("framework.data.zip", Framework.Installation.QUANTDAT);
      if (!Framework.Installation.IniDir.Exists)
        this.UnpackFile("framework.ini.zip", Framework.Installation.IniDir);
      if (!Framework.Installation.LogDir.Exists)
        Framework.Installation.LogDir.Create();
      if (Framework.Installation.TempDir.Exists)
        return;
      Framework.Installation.TempDir.Create();
    }

    private void UnpackFile(string filename, DirectoryInfo targetDirectory)
    {
      base.UnpackFile(new FileInfo(string.Format("{0}\\{1}", (object) this.setup.Folders.get_AppDataSource().FullName, (object) filename)), targetDirectory);
    }
  }
}
