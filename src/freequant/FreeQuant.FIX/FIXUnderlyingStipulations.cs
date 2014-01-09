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

    public FIXUnderlyingStipulations() : base()
    {
      this.lpUAFXjiTC = new ArrayList();
    }

    public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
    {
      if (i < this.NoUnderlyingStips)
        return (FIXUnderlyingStipsGroup) this.lpUAFXjiTC[i];
      else
        return (FIXUnderlyingStipsGroup) null;
    }

    public void AddGroup(FIXUnderlyingStipsGroup group)
    {
      this.lpUAFXjiTC.Add((object) group);
      ++this.NoUnderlyingStips;
    }
  }
}
