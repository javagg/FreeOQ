namespace FreeQuant.Providers
{
	public interface IMultiRouteExecutionProvider : IExecutionProvider, IProvider
	{
		BrokerInfo GetBrokerInfo(byte providerId);
	}
}
