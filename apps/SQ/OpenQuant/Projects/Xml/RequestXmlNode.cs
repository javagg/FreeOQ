// Type: OpenQuant.Projects.Xml.RequestXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Trading;
using SmartQuant.Xml;
using System;

namespace OpenQuant.Projects.Xml
{
  internal class RequestXmlNode : XmlNodeBase
  {
    private const string ATTR_REQUEST_TYPE = "type";
    private const string ATTR_REQUEST_NAME = "name";
    private const string ATTR_REQUEST_ENABLED = "enabled";
    private const string ATTR_IS_BAR_FACTORY_REQUEST = "is_bar_factory_request";

    public override string NodeName
    {
      get
      {
        return "request";
      }
    }

    public MarketDataRequest Request
    {
      get
      {
        MarketDataRequest marketDataRequest = Activator.CreateInstance(this.RequestType, new object[1]
        {
          (object) this.RequestName
        }) as MarketDataRequest;
        marketDataRequest.set_Enabled(this.RequestEnabled);
        if (marketDataRequest is BarRequest)
          (marketDataRequest as BarRequest).set_IsBarFactoryRequest(this.IsBarFactoryRequest);
        return marketDataRequest;
      }
      set
      {
        this.RequestType = ((object) value).GetType();
        this.RequestName = value.GetName();
        this.RequestEnabled = value.get_Enabled();
        if (!(value is BarRequest))
          return;
        this.IsBarFactoryRequest = (value as BarRequest).get_IsBarFactoryRequest();
      }
    }

    private Type RequestType
    {
      get
      {
        return this.GetTypeAttribute("type");
      }
      set
      {
        this.SetAttribute("type", value);
      }
    }

    private string RequestName
    {
      get
      {
        return this.GetStringAttribute("name");
      }
      set
      {
        this.SetAttribute("name", value);
      }
    }

    private bool RequestEnabled
    {
      get
      {
        return this.GetBooleanAttribute("enabled");
      }
      set
      {
        this.SetAttribute("enabled", value);
      }
    }

    private bool IsBarFactoryRequest
    {
      get
      {
        return this.GetBooleanAttribute("is_bar_factory_request");
      }
      set
      {
        this.SetAttribute("is_bar_factory_request", value);
      }
    }
  }
}
