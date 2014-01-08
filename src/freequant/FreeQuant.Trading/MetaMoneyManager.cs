using FreeQuant;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  [StrategyComponent("{FED5076A-C710-4d3a-B134-3D9D32B8B248}", ComponentType.MetaMoneyManager, Description = "", Name = "Default_MetaMoneyManager")]
  public class MetaMoneyManager : MetaStrategyBaseComponent
  {
    public const string GUID = "{FED5076A-C710-4d3a-B134-3D9D32B8B248}";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Allocate()
    {
      foreach (StrategyBase strategy in this.MetaStrategyBase.Strategies)
        this.Deposit(strategy, this.MetaStrategyBase.SimulationManager.Cash / (double) this.MetaStrategyBase.Strategies.Count, Clock.Now, this.MetaStrategyBase.SimulationManager.Currency, USaG3GpjZagj1iVdv4u.Y4misFk9D9(16362));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Deposit(StrategyBase strategy, double amount, DateTime datetime, SmartQuant.Instruments.Currency currency, string comment)
    {
      strategy.cXaFP441d(amount, currency, datetime, comment);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Deposit(StrategyBase strategy, double amount, SmartQuant.Instruments.Currency currency, string comment)
    {
      this.Deposit(strategy, amount, Clock.Now, currency, comment);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Deposit(string strategyName, double amount, SmartQuant.Instruments.Currency currency, string comment)
    {
      this.Deposit(this.MetaStrategyBase.Strategies[strategyName], amount, currency, comment);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Deposit(string strategyName, double amount, DateTime datetime, SmartQuant.Instruments.Currency currency, string comment)
    {
      this.Deposit(this.MetaStrategyBase.Strategies[strategyName], amount, datetime, currency, comment);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Withdraw(StrategyBase strategy, double amount, DateTime datetime, SmartQuant.Instruments.Currency currency, string comment)
    {
      strategy.qZcLyn7Uf(amount, currency, datetime, comment);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Withdraw(StrategyBase strategy, double amount, SmartQuant.Instruments.Currency currency, string comment)
    {
      this.Withdraw(strategy, amount, Clock.Now, currency, comment);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Withdraw(string strategyName, double amount, SmartQuant.Instruments.Currency currency, string comment)
    {
      this.Withdraw(this.MetaStrategyBase.Strategies[strategyName], amount, currency, comment);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Withdraw(string strategyName, double amount, DateTime datetime, SmartQuant.Instruments.Currency currency, string comment)
    {
      this.Withdraw(this.MetaStrategyBase.Strategies[strategyName], amount, datetime, currency, comment);
    }
  }
}
