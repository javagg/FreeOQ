// Type: OpenQuant.Orders2.SecurityTypeItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared;

namespace OpenQuant.Orders2
{
  internal class SecurityTypeItem
  {
    public string SecurityType { get; private set; }

    public SecurityTypeItem(string securityType)
    {
      this.SecurityType = securityType;
    }

    public override string ToString()
    {
      return ((object) APITypeConverter.InstrumentType.Convert(this.SecurityType)).ToString();
    }
  }
}
