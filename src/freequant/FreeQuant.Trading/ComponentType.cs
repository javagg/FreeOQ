namespace FreeQuant.Trading
{
  public enum ComponentType
  {
    All = -1,
    Unknown = 1,
    Entry = 2,
    Exit = 4,
    ExposureManager = 8,
    MoneyManager = 16,
    RiskManager = 32,
    MarketManager = 64,
    OptimizationManager = 128,
    MetaExposureManager = 256,
    SimulationManager = 512,
    ExecutionManager = 1024,
    MetaMoneyManager = 2048,
    MetaRiskManager = 4096,
    ReportManager = 8192,
    ATSComponent = 16384,
    CrossEntry = 32768,
    CrossExit = 65536,
    ATSCrossComponent = 131072,
    Stop = 262144,
    Trigger = 524288,
  }
}
