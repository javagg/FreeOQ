// Type: SmartQuant.Trading.Conditions.Condition
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading.Conditions
{
  public abstract class Condition : RuleItem
  {
    protected Hashtable childs;

    public Hashtable Childs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.childs;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Condition()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.childs = new Hashtable();
    }

    public abstract string GetInitCode(string name);
  }
}
