namespace FreeQuant.Providers
{
  public interface INewsProvider : IProvider
  {
    event NewsEventHandler News;

    void SendNewsRequest();

    void SendNewsCancelRequest();
  }
}
