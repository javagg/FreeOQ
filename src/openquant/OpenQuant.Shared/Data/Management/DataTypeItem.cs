// Type: OpenQuant.Shared.Data.Management.DataTypeItem
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using OpenQuant.Shared.Data;

namespace OpenQuant.Shared.Data.Management
{
  internal class DataTypeItem
  {
    public DataType DataType { get; private set; }

    public DataTypeItem(DataType dataType)
    {
      this.DataType = dataType;
    }

    public override string ToString()
    {
      return ((object) this.DataType).ToString();
    }
  }
}
