// Type: SmartQuant.Trading.StrategyComponentAttribute
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
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
