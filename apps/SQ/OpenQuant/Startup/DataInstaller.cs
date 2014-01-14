using OpenQuant;
using SharpZipLib.Zip;
using System.Collections.Generic;
using System.IO;

namespace OpenQuant.Startup
{
  internal abstract class DataInstaller
  {
    protected SetupInfo setup;

    public bool IsInstalled { get; protected set; }

    protected DataInstaller()
    {
      this.setup = new SetupInfo();
      this.IsInstalled = true;
    }

    public abstract void CheckInstallation();

    public abstract void Install();

    protected void UnpackFile(FileInfo zipFile, DirectoryInfo targetDirectory)
    {
      ZipFile zipFile1 = new ZipFile(zipFile.FullName);
      foreach (ZipEntry entry in zipFile1)
      {
        if (!entry.IsDirectory)
        {
          FileInfo fileInfo = new FileInfo(string.Format("{0}\\{1}", (object) targetDirectory.FullName, (object) entry.Name.Replace('/', '\\')));
          if (!fileInfo.Directory.Exists)
            fileInfo.Directory.Create();
          List<byte> list = new List<byte>();
          Stream inputStream = zipFile1.GetInputStream(entry);
          int num;
          while ((num = inputStream.ReadByte()) != -1)
            list.Add((byte) num);
          File.WriteAllBytes(fileInfo.FullName, list.ToArray());
        }
      }
    }
  }
}
