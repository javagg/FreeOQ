// Type: SmartQuant.Optimization.TOptimizable
// Assembly: SmartQuant.Optimization, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 1C417731-0514-4808-9329-6B635F19637E
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Optimization.dll

using E32I8CMPFnk6XwkgnC;
using System.Runtime.CompilerServices;

namespace SmartQuant.Optimization
{
  public abstract class TOptimizable : IOptimizable
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected TOptimizable()
    {
      C7bjlF4Ph208kGmVJO.IHdBTbCzDaa6o();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Init(ParamSet paramSet)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Update(ParamSet paramSet)
    {
    }

    public abstract double Objective();

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnStep()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnCircle()
    {
    }
  }
}
