using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXLegStipulations : FIXMessage
  {
    private ArrayList RrQZhV6g8c;

    [FIXField("683", EFieldOption.Optional)]
    public int NoLegStipulations
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(683).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(683, value);
      }
    }

    public FIXLegStipulations(): base()
    {
      this.RrQZhV6g8c = new ArrayList();
    }

    public FIXLegStipulationsGroup GetLegStipulationsGroup(int i)
    {
      if (i < this.NoLegStipulations)
        return (FIXLegStipulationsGroup) this.RrQZhV6g8c[i];
      else
        return (FIXLegStipulationsGroup) null;
    }

    public void AddGroup(FIXLegStipulationsGroup group)
    {
      this.RrQZhV6g8c.Add((object) group);
      ++this.NoLegStipulations;
    }
  }
}
