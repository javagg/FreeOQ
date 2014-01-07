// Type: OpenQuant.Projects.MarketDataRequestList
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Projects.UI;
using OpenQuant.Trading;
using System.ComponentModel;
using System.Drawing.Design;

namespace OpenQuant.Projects
{
  [Editor(typeof (MarketDataRequestListEditor), typeof (UITypeEditor))]
  internal class MarketDataRequestList : OpenQuantList<MarketDataRequest>
  {
  }
}
