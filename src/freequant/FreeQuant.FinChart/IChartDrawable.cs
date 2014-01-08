// Type: SmartQuant.FinChart.IChartDrawable
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using System;

namespace FreeQuant.FinChart
{
  public interface IChartDrawable
  {
    bool ToolTipEnabled { get; set; }

    string ToolTipFormat { get; set; }

    void Paint();

    void SetInterval(DateTime minDate, DateTime maxDate);

    Distance Distance(int x, double y);

    void Select();

    void UnSelect();
  }
}
