namespace FreeQuant.Providers
{
	public interface IMultiRouteExecutionProvider : IExecutionProvider
	{
		BrokerInfo GetBrokerInfo(byte providerId);
	}
}
