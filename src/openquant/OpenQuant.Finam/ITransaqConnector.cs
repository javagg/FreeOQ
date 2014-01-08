using System;

namespace OpenQuant.Finam
{
  public interface ITransaqConnector
  {
    event EventHandler<NewDataEventArgs> NewData;

    string SendCommand(string command);

    string ConnectorInitialize(string Path, short LogLevel);

    string ConnectorUnInitialize();
  }
}
