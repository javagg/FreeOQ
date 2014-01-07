// Type: OpenQuant.SetupFolders
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared;
using System;
using System.IO;

namespace OpenQuant
{
  internal class SetupFolders : SetupFolders
  {
    public DirectoryInfo AppData
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\SmartQuant Ltd\\OpenQuant", (object) Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).TrimEnd(new char[1]
        {
          '\\'
        })));
      }
    }

    public DirectoryInfo Documents
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\OpenQuant", (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal).TrimEnd(new char[1]
        {
          '\\'
        })));
      }
    }

    public DirectoryInfo Bin
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\Bin", (object) this.get_Base().FullName));
      }
    }

    public DirectoryInfo FrameworkBin
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\Framework\\bin", (object) this.get_Base().FullName));
      }
    }

    public DirectoryInfo SamplesSource
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\Setup\\Samples", (object) this.get_Base().FullName));
      }
    }

    public DirectoryInfo Ini
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\Ini", (object) this.AppData.FullName));
      }
    }

    public DirectoryInfo Layout
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\Layout", (object) this.Ini.FullName));
      }
    }

    public DirectoryInfo Projects
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\Projects", (object) this.Documents.FullName));
      }
    }

    public DirectoryInfo Solutions
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\Solutions", (object) this.Documents.FullName));
      }
    }

    public DirectoryInfo Scripts
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\Scripts", (object) this.Documents.FullName));
      }
    }

    public DirectoryInfo SampleIndicators
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\Samples\\SampleIndicators", (object) this.Documents.FullName));
      }
    }

    public DirectoryInfo SampleProviders
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\Samples\\SampleProviders", (object) this.Documents.FullName));
      }
    }

    public DirectoryInfo Templates
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\Templates", (object) this.get_Base().FullName));
      }
    }

    public DirectoryInfo ChartColorTemplates
    {
      get
      {
        return new DirectoryInfo(string.Format("{0}\\Chart Color Templates", (object) this.AppData.FullName));
      }
    }

    public SetupFolders()
    {
      base.\u002Ector();
    }
  }
}
