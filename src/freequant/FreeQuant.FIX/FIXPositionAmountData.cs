using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPositionAmountData : FIXMessage
  {
    private ArrayList skJt74QCFe;

    [FIXField("753", EFieldOption.Optional)]
    public int NoPosAmt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(753).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(753, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPositionAmountData()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.skJt74QCFe = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPosAmtGroup GetPosAmtGroup(int i)
    {
      if (i < this.NoPosAmt)
        return (FIXPosAmtGroup) this.skJt74QCFe[i];
      else
        return (FIXPosAmtGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXPosAmtGroup group)
    {
      this.skJt74QCFe.Add((object) group);
      ++this.NoPosAmt;
    }
  }
}
