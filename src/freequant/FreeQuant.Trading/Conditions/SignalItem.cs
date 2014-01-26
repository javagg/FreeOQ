using FreeQuant.Trading;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading.Conditions
{
  public class SignalItem : RuleItem
  {
    private SignalItemType eASRvQmqnG;
    private IStrategyComponent TUdREdiNP8;

    public SignalItemType SignalType
    {
       get
      {
        return this.eASRvQmqnG;
      }
       set
      {
        this.eASRvQmqnG = value;
      }
    }

    public override string Name
    {
       get
      {
        return ((object) this.eASRvQmqnG).ToString();
      }
    }

    public override string CodeName
    {
       get
      {
				return  this.eASRvQmqnG.ToString();
      }
    }

    
		public SignalItem(SignalItemType signalType, IStrategyComponent component):base()
    {
      this.eASRvQmqnG = signalType;
      this.TUdREdiNP8 = component;
    }

    
		public SignalItem(SignalItemType signalType):base()
    {
      this.eASRvQmqnG = signalType;
    }

    
    public override void Execute()
    {
			if (this.TUdREdiNP8 is FreeQuant.Trading.Entry)
      {
				FreeQuant.Trading.Entry entry = this.TUdREdiNP8 as FreeQuant.Trading.Entry;
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
