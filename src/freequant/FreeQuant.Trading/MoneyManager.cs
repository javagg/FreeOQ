// Type: SmartQuant.Trading.MoneyManager
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  [StrategyComponent("{9637DF40-0F84-46e3-AC54-0EC2D2CE2699}", ComponentType.MoneyManager, Description = "", Name = "Default_MoneyManager")]
  public class MoneyManager : StrategySingleComponent
  {
    public const string GUID = "{9637DF40-0F84-46e3-AC54-0EC2D2CE2699}";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoneyManager()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetPositionRisk()
    {
      return this.Strategy.kEApCnqU3X()[this.Instrument].GetPositionRisk();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetPositionSize(Signal signal)
    {
      return 0.0;
    }
  }
}
