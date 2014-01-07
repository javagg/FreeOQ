// Type: SmartQuant.FinChart.IAxesMarked
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using System.Drawing;

namespace SmartQuant.FinChart
{
  public interface IAxesMarked
  {
    Color Color { get; }

    double LastValue { get; }

    bool IsMarkEnable { get; }

    int LabelDigitsCount { get; }
  }
}
