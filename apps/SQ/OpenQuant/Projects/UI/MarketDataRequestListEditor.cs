// Type: OpenQuant.Projects.UI.MarketDataRequestListEditor
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Projects;
using OpenQuant.Trading;
using System.ComponentModel.Design;
using System.Reflection;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI
{
  public class MarketDataRequestListEditor : CollectionEditor
  {
    public MarketDataRequestListEditor()
      : base(typeof (MarketDataRequestList))
    {
    }

    protected override CollectionEditor.CollectionForm CreateCollectionForm()
    {
      CollectionEditor.CollectionForm collectionForm = base.CreateCollectionForm();
      PropertyGrid propertyGrid = (PropertyGrid) collectionForm.GetType().GetField("propertyBrowser", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).GetValue((object) collectionForm);
      propertyGrid.ToolbarVisible = false;
      propertyGrid.HelpVisible = true;
      propertyGrid.PropertySort = PropertySort.Alphabetical;
      return collectionForm;
    }

    protected override object CreateInstance(System.Type itemType)
    {
      if (!(itemType == typeof (MarketDataRequestListEditor.Bar)))
        return (object) new MarketDataRequest((RequestType) itemType.GetField("RequestType", BindingFlags.Static | BindingFlags.Public | BindingFlags.GetField).GetValue((object) itemType));
      BarRequstPropertiesDialog propertiesDialog = new BarRequstPropertiesDialog();
      if (propertiesDialog.ShowDialog() != DialogResult.OK)
        return (object) null;
      BarRequest barRequest = new BarRequest(propertiesDialog.BarType, propertiesDialog.BarSize);
      barRequest.set_IsBarFactoryRequest(propertiesDialog.IsBarFactoryRequest);
      return (object) barRequest;
    }

    protected override System.Type[] CreateNewItemTypes()
    {
      return new System.Type[5]
      {
        typeof (MarketDataRequestListEditor.Bar),
        typeof (MarketDataRequestListEditor.Daily),
        typeof (MarketDataRequestListEditor.Quote),
        typeof (MarketDataRequestListEditor.Trade),
        typeof (MarketDataRequestListEditor.MarketDepth)
      };
    }

    private class Bar
    {
      public static RequestType RequestType = (RequestType) 5;

      static Bar()
      {
      }
    }

    private class Trade
    {
      public static RequestType RequestType;

      static Trade()
      {
      }
    }

    private class Quote
    {
      public static RequestType RequestType = (RequestType) 1;

      static Quote()
      {
      }
    }

    private class Daily
    {
      public static RequestType RequestType = (RequestType) 6;

      static Daily()
      {
      }
    }

    private class MarketDepth
    {
      public static RequestType RequestType = (RequestType) 2;

      static MarketDepth()
      {
      }
    }
  }
}
