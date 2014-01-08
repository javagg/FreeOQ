using System.Drawing;

namespace FreeQuant.FinChart
{
  public interface IAxesMarked
  {
    Color Color { get; }

    double LastValue { get; }

    bool IsMarkEnable { get; }

    int LabelDigitsCount { get; }
  }
}
