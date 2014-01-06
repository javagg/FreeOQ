// Type: SmartQuant.Instruments.TransactionCost
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant.FIX;
using System;
using System.Runtime.CompilerServices;
using VFUvY5knK01pUIalDo;

namespace SmartQuant.Instruments
{
  public class TransactionCost
  {
    private CommType gfPEjlXl60;
    private double GjdEkGReeo;

    public double Commission
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GjdEkGReeo;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.GjdEkGReeo = value;
      }
    }

    public CommType CommType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gfPEjlXl60;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.gfPEjlXl60 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TransactionCost(CommType commType, double commission)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Set(commType, commission);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TransactionCost()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      this.\u002Ector(CommType.Absolute, 0.0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(CommType commType, double commission)
    {
      this.gfPEjlXl60 = commType;
      this.GjdEkGReeo = commission;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetCost(Transaction transaction)
    {
      if (this.GjdEkGReeo == 0.0)
        return 0.0;
      switch (this.gfPEjlXl60)
      {
        case CommType.PerShare:
          return this.Commission * transaction.Qty;
        case CommType.Percent:
          return this.Commission * transaction.Value;
        case CommType.Absolute:
          return this.Commission;
        default:
          throw new NotSupportedException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(5332) + (object) this.gfPEjlXl60);
      }
    }
  }
}
