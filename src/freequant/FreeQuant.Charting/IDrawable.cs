// Type: SmartQuant.Charting.IDrawable
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

namespace SmartQuant.Charting
{
  public interface IDrawable
  {
    bool ToolTipEnabled { get; set; }

    string ToolTipFormat { get; set; }

    void Draw();

    void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY);

    TDistance Distance(double X, double Y);
  }
}
