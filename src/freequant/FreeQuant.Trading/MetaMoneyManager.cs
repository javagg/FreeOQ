using FreeQuant;
using System;

namespace FreeQuant.Trading
{
  [StrategyComponent("{FED5076A-C710-4d3a-B134-3D9D32B8B248}", ComponentType.MetaMoneyManager, Description = "", Name = "Default_MetaMoneyManager")]
  public class MetaMoneyManager : MetaStrategyBaseComponent
  {
    public const string GUID = "{FED5076A-C710-4d3a-B134-3D9D32B8B248}";

    
    public virtual void Allocate()
    {
      foreach (StrategyBase strategy in this.MetaStrategyBase.Strategies)
				this.Deposit(strategy, this.MetaStrategyBase.SimulationManager.Cash / (double) this.MetaStrategyBase.Strategies.Count, Clock.Now, this.MetaStrategyBase.SimulationManager.Currency, "");
    }

    
		public virtual void Deposit(StrategyBase strategy, double amount, DateTime datetime, FreeQuant.Instruments.Currency currency, string comment)
    {
      strategy.cXaFP441d(amount, currency, datetime, comment);
    }

    
		public virtual void Deposit(StrategyBase strategy, double amount, FreeQuant.Instruments.Currency currency, string comment)
    {
      this.Deposit(strategy, amount, Clock.Now, currency, comment);
    }

    
		public virtual void Deposit(string strategyName, double amount, FreeQuant.Instruments.Currency currency, string comment)
    {
      this.Deposit(this.MetaStrategyBase.Strategies[strategyName], amount, currency, comment);
    }

    
		public virtual void Deposit(string strategyName, double amount, DateTime datetime, FreeQuant.Instruments.Currency currency, string comment)
    {
      this.Deposit(this.MetaStrategyBase.Strategies[strategyName], amount, datetime, currency, comment);
    }

    
		public virtual void Withdraw(StrategyBase strategy, double amount, DateTime datetime, FreeQuant.Instruments.Currency currency, string comment)
    {
      strategy.qZcLyn7Uf(amount, currency, datetime, comment);
    }

    
		public virtual void Withdraw(StrategyBase strategy, double amount, FreeQuant.Instruments.Currency currency, string comment)
    {
      this.Withdraw(strategy, amount, Clock.Now, currency, comment);
    }

    
		public virtual void Withdraw(string strategyName, double amount, FreeQuant.Instruments.Currency currency, string comment)
    {
      this.Withdraw(this.MetaStrategyBase.Strategies[strategyName], amount, currency, comment);
    }

    
		public virtual void Withdraw(string strategyName, double amount, DateTime datetime, FreeQuant.Instruments.Currency currency, string comment)
    {
      this.Withdraw(this.MetaStrategyBase.Strategies[strategyName], amount, datetime, currency, comment);
    }
  }
}
