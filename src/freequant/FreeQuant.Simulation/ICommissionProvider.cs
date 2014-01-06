// Type: SmartQuant.Simulation.ICommissionProvider
// Assembly: SmartQuant.Simulation, Version=1.0.5036.28353, Culture=neutral, PublicKeyToken=null
// MVID: 7CFB1E94-1672-436F-90C9-C8B7893A5618
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Simulation.dll

using Cg0OjjilBjFlIHvWqv;
using SmartQuant.FIX;
using System.ComponentModel;

namespace SmartQuant.Simulation
{
  [TypeConverter(typeof (YpYHYx5yIRE0Z5fuwq))]
  public interface ICommissionProvider
  {
    CommType CommType { get; set; }

    double Commission { get; set; }

    FIXCommissionData GetCommissionData(FIXExecutionReport report);
  }
}
