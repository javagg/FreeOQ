// Type: SmartQuant.Trading.ComponentBase
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
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
