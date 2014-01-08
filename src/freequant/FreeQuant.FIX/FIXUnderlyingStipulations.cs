using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXUnderlyingStipulations : FIXMessage
  {
    private ArrayList lpUAFXjiTC;

    [FIXField("887", EFieldOption.Optional)]
    public int NoUnderlyingStips
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(887).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(887, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingStipulations()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.lpUAFXjiTC = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
    {
      if (i < this.NoUnderlyingStips)
        return (FIXUnderlyingStipsGroup) this.lpUAFXjiTC[i];
      else
        return (FIXUnderlyingStipsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXUnderlyingStipsGroup group)
    {
      this.lpUAFXjiTC.Add((object) group);
      ++this.NoUnderlyingStips;
    }
  }
}
