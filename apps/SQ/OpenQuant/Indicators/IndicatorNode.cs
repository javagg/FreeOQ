// Type: OpenQuant.Indicators.IndicatorNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System.Windows.Forms;

namespace OpenQuant.Indicators
{
  internal class IndicatorNode : TreeNode
  {
    private System.Type indicatorType;

    public System.Type IndicatorType
    {
      get
      {
        return this.indicatorType;
      }
    }

    public IndicatorNode(System.Type indicatorType)
      : base(indicatorType.Name, 2, 2)
    {
      this.indicatorType = indicatorType;
    }
  }
}
