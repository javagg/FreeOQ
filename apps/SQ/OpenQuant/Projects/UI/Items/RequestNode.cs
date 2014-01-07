// Type: OpenQuant.Projects.UI.Items.RequestNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Data;
using OpenQuant.Trading;
using System;

namespace OpenQuant.Projects.UI.Items
{
  internal class RequestNode : ObjectNode
  {
    private MarketDataRequest request;
    private bool isBarRequest;

    public MarketDataRequest Request
    {
      get
      {
        return this.request;
      }
    }

    public RequestNode(MarketDataRequest request)
      : base(((object) request).ToString(), 7)
    {
      this.request = request;
      request.add_EnabledChanged(new EventHandler(this.request_EnabledChanged));
      if (request is BarRequest)
      {
        BarRequest barRequest = (BarRequest) request;
        this.Text = string.Format("Bars {0}", (object) DataSeriesHelper.BarTypeSizeToString(barRequest.get_BarType(), barRequest.get_BarSize()));
        this.isBarRequest = true;
        barRequest.add_IsBarFactoryChanged(new EventHandler(this.RequestNode_IsBarFactoryChanged));
      }
      this.UpdateImage();
    }

    private void RequestNode_IsBarFactoryChanged(object sender, EventArgs e)
    {
      this.UpdateImage();
    }

    private void request_EnabledChanged(object sender, EventArgs e)
    {
      this.UpdateImage();
    }

    private new void UpdateImage()
    {
      if (!this.request.get_Enabled())
      {
        this.ImageIndex = 6;
        this.SelectedImageIndex = 6;
      }
      else if (this.isBarRequest && (this.request as BarRequest).get_IsBarFactoryRequest())
      {
        this.ImageIndex = 4;
        this.SelectedImageIndex = 4;
      }
      else
      {
        this.ImageIndex = 7;
        this.SelectedImageIndex = 7;
      }
    }
  }
}
