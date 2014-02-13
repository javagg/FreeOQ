// Type: OpenQuant.Shared.Charting.ColorComparer
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System.Collections.Generic;
using System.Drawing;

namespace OpenQuant.Shared.Charting
{
  internal class ColorComparer : IComparer<Color>
  {
    public int Compare(Color color, Color color2)
    {
      if (color == color2)
        return 0;
      if ((int) color.A < (int) color2.A)
        return -1;
      if ((int) color.A > (int) color2.A)
        return 1;
      if ((double) color.GetHue() < (double) color2.GetHue())
        return -1;
      if ((double) color.GetHue() > (double) color2.GetHue())
        return 1;
      if ((double) color.GetSaturation() < (double) color2.GetSaturation())
        return -1;
      if ((double) color.GetSaturation() > (double) color2.GetSaturation())
        return 1;
      if ((double) color.GetBrightness() < (double) color2.GetBrightness())
        return -1;
      return (double) color.GetBrightness() > (double) color2.GetBrightness() ? 1 : 0;
    }
  }
}
