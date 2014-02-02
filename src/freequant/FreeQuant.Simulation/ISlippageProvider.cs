using FreeQuant.FIX;

namespace FreeQuant.Simulation
{
	//  [TypeConverter(typeof (EA5Xig43kIhYaLLAbb))]
	public interface ISlippageProvider
	{
		double GetExecutionPrice(ExecutionReport report);
	}
}
