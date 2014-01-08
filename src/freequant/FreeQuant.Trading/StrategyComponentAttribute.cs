
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
  public class StrategyComponentAttribute : Attribute
  {
    private Guid FKt6afUVYg;
    private ComponentType Fgf6t1InAZ;
    private string qUB6dnbNLe;
    private string npb6wakWaw;

    public Guid GUID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FKt6afUVYg;
      }
    }

    public ComponentType Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Fgf6t1InAZ;
      }
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qUB6dnbNLe;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.qUB6dnbNLe = value;
      }
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.npb6wakWaw;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.npb6wakWaw = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StrategyComponentAttribute(string guid, ComponentType type)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.FKt6afUVYg = new Guid(guid);
      this.Fgf6t1InAZ = type;
      this.qUB6dnbNLe = (string) null;
      this.npb6wakWaw = (string) null;
    }
  }
}
