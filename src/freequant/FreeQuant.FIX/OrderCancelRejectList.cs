using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class OrderCancelRejectList : FIXGroupList
  {
    public OrderCancelReject this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[index] as OrderCancelReject;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderCancelReject GetById(int id)
    {
      return base.GetById(id) as OrderCancelReject;
    }
  }
}
