using System;

namespace OpenQuant.API
{
  public class Clock
  {
    public static DateTime Now
    {
      get
      {
        return SmartQuant.Clock.Now;
      }
    }
  }
}
