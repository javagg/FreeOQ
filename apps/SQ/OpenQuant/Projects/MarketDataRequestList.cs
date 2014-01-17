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
