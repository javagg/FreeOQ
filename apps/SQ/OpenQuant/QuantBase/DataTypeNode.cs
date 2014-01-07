// Type: OpenQuant.QuantBase.DataTypeNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System.Collections.Generic;
using System.Windows.Forms;

namespace OpenQuant.QuantBase
{
  internal class DataTypeNode : TreeNode
  {
    public List<DataSeriesItem> Items { get; private set; }

    public DataTypeNode(string text)
      : base(text)
    {
      this.Items = new List<DataSeriesItem>();
    }
  }
}
