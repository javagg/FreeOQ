// Type: SmartQuant.Testing.TesterSettings
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using SmartQuant.Testing.TesterItems;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing
{
  public class TesterSettings
  {
    private LiveTester fNyFvVvOo;
    private TesterItemList U8g72RfTo;
    private TesterItemList SZctPlnKv;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TesterSettings(LiveTester tester)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fNyFvVvOo = tester;
      this.FXUR2afwm();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FXUR2afwm()
    {
      this.U8g72RfTo = new TesterItemList();
      this.SZctPlnKv = new TesterItemList();
      foreach (TesterItem testerItem in this.fNyFvVvOo.Components)
      {
        SeriesTesterItem seriesTesterItem = testerItem as SeriesTesterItem;
        if (seriesTesterItem != null)
        {
          if (seriesTesterItem.Enabled)
            this.U8g72RfTo.f9Ww98OVG((TesterItem) seriesTesterItem);
          if (seriesTesterItem.FillSeries)
            this.SZctPlnKv.f9Ww98OVG((TesterItem) seriesTesterItem);
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadState()
    {
      foreach (TesterItem testerItem in this.fNyFvVvOo.Components)
      {
        SeriesTesterItem seriesTesterItem = testerItem as SeriesTesterItem;
        if (seriesTesterItem != null)
        {
          if (this.U8g72RfTo.Contains(seriesTesterItem.Name))
            seriesTesterItem.Enabled = true;
          if (this.SZctPlnKv.Contains(seriesTesterItem.Name))
            seriesTesterItem.FillSeries = true;
        }
      }
    }
  }
}
