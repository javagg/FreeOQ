using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCapacitiesGroup : FIXGroup
  {
    [FIXField("528", EFieldOption.Required)]
    public char OrderCapacity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(528).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(528, value);
      }
    }

    [FIXField("529", EFieldOption.Optional)]
    public string OrderRestrictions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(529).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(529, value);
      }
    }

    [FIXField("863", EFieldOption.Required)]
    public double OrderCapacityQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(863).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(863, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXCapacitiesGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXCapacitiesGroup(char OrderCapacity, double OrderCapacityQty)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OrderCapacity = OrderCapacity;
      this.OrderCapacityQty = OrderCapacityQty;
    }
  }
}
