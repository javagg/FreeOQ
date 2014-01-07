// Type: SmartQuant.Shared.Data.Import.TAQ.InstrumentNode
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.Instruments;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmartQuant.Shared.Data.Import.TAQ
{
  public class InstrumentNode : TreeNode
  {
    private Instrument ijdxXmDIwH;

    public Instrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ijdxXmDIwH;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InstrumentNode(Instrument instrument)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(instrument.Symbol, 1, 1);
      this.ijdxXmDIwH = instrument;
    }
  }
}
