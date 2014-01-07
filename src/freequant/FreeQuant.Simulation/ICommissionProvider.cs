using Cg0OjjilBjFlIHvWqv;
using FreeQuant.FIX;
using System.ComponentModel;

namespace FreeQuant.Simulation
{
  [TypeConverter(typeof (YpYHYx5yIRE0Z5fuwq))]
  public interface ICommissionProvider
  {
    CommType CommType { get; set; }

    double Commission { get; set; }

    FIXCommissionData GetCommissionData(FIXExecutionReport report);
  }
}
