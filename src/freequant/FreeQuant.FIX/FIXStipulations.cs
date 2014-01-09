using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXStipulations : FIXMessage
  {
    private ArrayList DDFuaVuZbM;

    [FIXField("232", EFieldOption.Optional)]
    public int NoStipulations
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(232).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(232, value);
      }
    }

    public FIXStipulations() : base()
    {
      this.DDFuaVuZbM = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXStipulationsGroup GetStipulationsGroup(int i)
    {
      if (i < this.NoStipulations)
        return (FIXStipulationsGroup) this.DDFuaVuZbM[i];
      else
        return (FIXStipulationsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXStipulationsGroup group)
    {
      this.DDFuaVuZbM.Add((object) group);
      ++this.NoStipulations;
    }
  }
}
