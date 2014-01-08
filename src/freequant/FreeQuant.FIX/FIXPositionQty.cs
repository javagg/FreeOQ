using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPositionQty : FIXMessage
  {
    private ArrayList pvdZmZLRBD;

    [FIXField("702", EFieldOption.Optional)]
    public int NoPositions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(702).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(702, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPositionQty()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.pvdZmZLRBD = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPositionsGroup GetPositionsGroup(int i)
    {
      if (i < this.NoPositions)
        return (FIXPositionsGroup) this.pvdZmZLRBD[i];
      else
        return (FIXPositionsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXPositionsGroup group)
    {
      this.pvdZmZLRBD.Add((object) group);
      ++this.NoPositions;
    }
  }
}
