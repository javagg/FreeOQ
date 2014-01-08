using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Data
{
  [Serializable]
  public class BarSize
  {
    public const long Second = 1L;
    public const long Minute = 60L;
    public const long Hour = 3600L;
    public const long Day = 86400L;
    public const long Week = 604800L;
    public const long Month = 2592000L;
    public const long Year = 31536000L;
  }
}
