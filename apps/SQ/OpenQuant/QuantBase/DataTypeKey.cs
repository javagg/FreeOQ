// Type: OpenQuant.QuantBase.DataTypeKey
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Data;

namespace OpenQuant.QuantBase
{
  internal class DataTypeKey
  {
    public DataSeriesInfo Info { get; private set; }

    public DataTypeKey(DataSeriesInfo info)
    {
      this.Info = info;
    }
  }
}
