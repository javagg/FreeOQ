using FreeQuant.Providers;

namespace OpenQuant.API
{
  public class BarFactory
  {
    private IBarFactory barFactory;

    internal BarFactory(IBarFactory barFactory)
    {
      this.barFactory = barFactory;
    }

    public void Reset()
    {
      this.barFactory.Reset();
    }
  }
}
