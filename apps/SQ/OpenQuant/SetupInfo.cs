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

	public SetupInfo() : base(new ProductInfo(), new SetupFolders())
    {
    }
  }
}
