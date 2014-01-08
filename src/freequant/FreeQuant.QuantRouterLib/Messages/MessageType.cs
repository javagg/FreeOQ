namespace FreeQuant.QuantRouterLib.Messages
{
  public static class MessageType
  {
    public const int Logon = 1;
    public const int LogonStatus = 2;
    public const int Heartbeat = 3;
    public const int Subscribe = 10;
    public const int Unsubscribe = 11;
    public const int ProviderError = 12;
    public const int SubscriptionStatus = 13;
    public const int Tick = 1000;
    public const int Level2 = 1001;
    public const int Command = 1100;
    public const int Report = 1101;
    public const int OrderCancelReject = 1102;
    public const int BrokerInfoRequest = 2000;
    public const int BrokerInfoResponse = 2001;
  }
}
