// Type: SmartQuant.Trading.Conditions.SignalItem
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
using SmartQuant.Trading;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading.Conditions
{
  public class SignalItem : RuleItem
  {
    private SignalItemType eASRvQmqnG;
    private IStrategyComponent TUdREdiNP8;

    public SignalItemType SignalType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.eASRvQmqnG;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.eASRvQmqnG = value;
      }
    }

    public override string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ((object) this.eASRvQmqnG).ToString();
      }
    }

    public override string CodeName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return USaG3GpjZagj1iVdv4u.Y4misFk9D9(16156) + (object) this.eASRvQmqnG;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SignalItem(SignalItemType signalType, IStrategyComponent component)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.eASRvQmqnG = signalType;
      this.TUdREdiNP8 = component;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SignalItem(SignalItemType signalType)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.eASRvQmqnG = signalType;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Execute()
    {
      if (this.TUdREdiNP8 is SmartQuant.Trading.Entry)
      {
        SmartQuant.Trading.Entry entry = this.TUdREdiNP8 as SmartQuant.Trading.Entry;
        switch (this.eASRvQmqnG)
        {
          case SignalItemType.Long:
            entry.LongEntry();
            break;
          case SignalItemType.Short:
            entry.ShortEntry();
            break;
        }
      }
      if (!(this.TUdREdiNP8 is Exit))
        return;
      Exit exit = this.TUdREdiNP8 as Exit;
      switch (this.eASRvQmqnG)
      {
        case SignalItemType.Long:
          exit.LongExit();
          break;
        case SignalItemType.Short:
          exit.ShortExit();
          break;
      }
    }
  }
}
