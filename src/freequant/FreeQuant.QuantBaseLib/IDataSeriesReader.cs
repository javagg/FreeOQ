using FreeQuant.Data;

namespace FreeQuant.QuantBaseLib
{
  public interface IDataSeriesReader
  {
    int Count { get; }

    IDataObject[] ReadNext(int count);
  }
}
