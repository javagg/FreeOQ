// Type: OpenQuant.Finam.NewDataEventArgs
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

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
