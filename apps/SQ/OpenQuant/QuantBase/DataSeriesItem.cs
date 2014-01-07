// Type: OpenQuant.QuantBase.DataSeriesItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Data;
using SmartQuant.QuantBaseLib;

namespace OpenQuant.QuantBase
{
  internal class DataSeriesItem
  {
    public DataSeriesInfo QB_Info { get; private set; }

    public DataSeriesInfo SH_Info { get; private set; }

    public DataSeriesItem(DataSeriesInfo qbInfo, DataSeriesInfo shInfo)
    {
      this.QB_Info = qbInfo;
      this.SH_Info = shInfo;
    }
  }
}
