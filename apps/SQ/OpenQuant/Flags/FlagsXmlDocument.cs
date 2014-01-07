// Type: OpenQuant.Flags.FlagsXmlDocument
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Flags
{
  internal class FlagsXmlDocument : XmlDocumentBase
  {
    public UpdateUIXmlNode UpdateUI
    {
      get
      {
        return this.GetChildNode<UpdateUIXmlNode>();
      }
    }

    public FlagsXmlDocument()
      : base("flags")
    {
    }
  }
}
