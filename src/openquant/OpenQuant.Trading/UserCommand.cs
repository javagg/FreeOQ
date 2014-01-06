namespace OpenQuant.Trading
{
  public class UserCommand
  {
    public string Strategy { get; private set; }

    public OpenQuant.API.UserCommand Command { get; private set; }

    public UserCommand(string strategy, OpenQuant.API.UserCommand command)
    {
      this.Strategy = strategy;
      this.Command = command;
    }
  }
}
