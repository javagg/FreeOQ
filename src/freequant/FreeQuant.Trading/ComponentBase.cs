using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class ComponentBase : IComponentBase
  {
    protected string name;
    protected string description;

    [Category("Description")]
    [ReadOnly(true)]
    [Description("Component name")]
    public virtual string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.name;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.name = value;
      }
    }

    [Category("Description")]
    [ReadOnly(true)]
    [Description("Component description")]
    public virtual string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.description;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.description = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComponentBase()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Init()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Connect()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Disconnect()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnStrategyStop()
    {
    }
  }
}
