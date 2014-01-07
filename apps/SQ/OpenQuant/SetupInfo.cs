// Type: OpenQuant.SetupInfo
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared;

namespace OpenQuant
{
  internal class SetupInfo : SetupInfo
  {
    public SetupFolders Folders
    {
      get
      {
        return (SetupFolders) base.get_Folders();
      }
    }

    public SetupInfo()
    {
      base.\u002Ector(new ProductInfo(), (SetupFolders) new SetupFolders());
    }
  }
}
