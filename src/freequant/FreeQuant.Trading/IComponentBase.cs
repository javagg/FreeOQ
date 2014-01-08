
namespace FreeQuant.Trading
{
  public interface IComponentBase
  {
    string Name { get; set; }

    string Description { get; set; }

    void Init();

    void Connect();

    void Disconnect();
  }
}
