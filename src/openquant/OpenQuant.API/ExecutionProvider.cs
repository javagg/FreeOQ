using FreeQuant.Providers;

namespace OpenQuant.API
{
	/// <summary>
	/// Execution provider
	/// </summary>
	public class ExecutionProvider : Provider
	{
		internal ExecutionProvider(IExecutionProvider provider) : base((IProvider)provider)
		{
			this.provider = (IProvider)provider;
		}
	}
}
