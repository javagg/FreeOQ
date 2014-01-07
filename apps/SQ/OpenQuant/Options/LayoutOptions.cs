// Type: OpenQuant.Options.LayoutOptions
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Shared.Options;
using System.IO;

namespace OpenQuant.Options
{
  [OptionsNode("Layout", typeof (LayoutOptionsPanel))]
  internal class LayoutOptions : LayoutOptions
  {
    public LayoutOptions()
    {
      base.\u002Ector(new FileInfo(string.Format("{0}\\layout.xml", (object) Global.Setup.Folders.Ini.FullName)));
    }
  }
}
