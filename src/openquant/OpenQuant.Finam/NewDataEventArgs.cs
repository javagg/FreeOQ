using System;

namespace OpenQuant.Finam
{
  public class NewDataEventArgs : EventArgs
  {
    public string Data { get; private set; }

    public NewDataEventArgs(string data)
    {
      this.Data = data;
    }
  }
}
