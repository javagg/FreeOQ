using MrJl8IUbxcYBf5fXWg;
using FreeQuant.FIX;
using System.ComponentModel;

namespace FreeQuant.Simulation
{
  [TypeConverter(typeof (EA5Xig43kIhYaLLAbb))]
  public interface ISlippageProvider
  {
    double GetExecutionPrice(ExecutionReport report);
  }
}
