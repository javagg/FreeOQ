using System.Collections;

namespace OpenQuant.API
{
  public class PositionList : IEnumerable
  {
    private FreeQuant.Instruments.PositionList positionList;

    public int Count
    {
      get
      {
        return this.positionList.Count;
      }
    }

    public Position this[string symbol]
    {
      get
      {
        FreeQuant.Instruments.Position position = this.positionList[symbol];
        if (position != null)
          return new Position(position);
        else
          return (Position) null;
      }
    }

    public Position this[Instrument instrument]
    {
      get
      {
        FreeQuant.Instruments.Position position = this.positionList[instrument.instrument];
        if (position != null)
          return new Position(position);
        else
          return (Position) null;
      }
    }

    internal PositionList(FreeQuant.Instruments.PositionList positionList)
    {
      this.positionList = positionList;
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) new PositionListEnumerator(this.positionList);
    }
  }
}
