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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXLegStipulations()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.RrQZhV6g8c = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXLegStipulationsGroup GetLegStipulationsGroup(int i)
    {
      if (i < this.NoLegStipulations)
        return (FIXLegStipulationsGroup) this.RrQZhV6g8c[i];
      else
        return (FIXLegStipulationsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXLegStipulationsGroup group)
    {
      this.RrQZhV6g8c.Add((object) group);
      ++this.NoLegStipulations;
    }
  }
}
