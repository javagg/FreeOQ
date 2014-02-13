// Type: OpenQuant.Shared.Data.Management.DataTypeNode
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal class DataTypeNode : TreeNode
  {
    private DataTypeItem item;

    public DataTypeItem Item
    {
      get
      {
        return this.item;
      }
    }

    public DataTypeNode(DataTypeItem item)
      : base(item.ToString(), 0, 0)
    {
      this.item = item;
    }
  }
}
