using System.Collections;

namespace OpenQuant.API
{
  internal class PositionListEnumerator : IEnumerator
  {
    private SmartQuant.Instruments.PositionList positionList;
    private IEnumerator enumerator;

    public object Current
    {
      get
      {
        return (object) new Position(this.enumerator.Current as SmartQuant.Instruments.Position);
      }
    }

    internal PositionListEnumerator(SmartQuant.Instruments.PositionList positionList)
    {
      this.positionList = positionList;
      this.enumerator = positionList.GetEnumerator();
    }

    public bool MoveNext()
    {
      return this.enumerator.MoveNext();
    }

    public void Reset()
    {
      this.enumerator.Reset();
    }
  }
}
