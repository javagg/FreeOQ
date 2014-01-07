// Type: SmartQuant.Shared.Data.Import.Instruments.SecurityDefinitionViewItem
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.FIX;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmartQuant.Shared.Data.Import.Instruments
{
  public class SecurityDefinitionViewItem : ListViewItem
  {
    private FIXSecurityDefinition spCHSgVpLT;

    public FIXSecurityDefinition SecurityDefinition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.spCHSgVpLT;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SecurityDefinitionViewItem(string symbol, FIXSecurityDefinition securityDefinition)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(new string[5]);
      this.spCHSgVpLT = securityDefinition;
      this.SubItems[0].Text = symbol;
      this.SubItems[1].Text = securityDefinition.SecurityType;
      this.SubItems[2].Text = securityDefinition.SecurityID;
      this.SubItems[3].Text = securityDefinition.SecurityExchange;
      this.SubItems[4].Text = securityDefinition.Currency;
    }
  }
}
