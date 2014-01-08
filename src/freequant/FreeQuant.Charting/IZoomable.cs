namespace FreeQuant.Charting
{
  public interface IZoomable
  {
    bool IsPadRangeX();

    bool IsPadRangeY();

    PadRange GetPadRangeX(Pad pad);

    PadRange GetPadRangeY(Pad pad);
  }
}
