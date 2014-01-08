using System.ComponentModel;

namespace FreeQuant
{
  public class RAMInfo : InfoBase<RAMItemInfo>
  {
    public long TotalCapacity
    {
        get
      {
        return 0L;
      }
    }

    public string TotalCapacityString
    {
     get
      {
        return (string) null;
      }
    }
  }
}
