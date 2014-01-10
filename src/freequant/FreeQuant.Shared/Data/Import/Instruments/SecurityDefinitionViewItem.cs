using FreeQuant.FIX;
using System.Windows.Forms;

namespace FreeQuant.Shared.Data.Import.Instruments
{
  public class SecurityDefinitionViewItem : ListViewItem
  {
    private FIXSecurityDefinition spCHSgVpLT;

    public FIXSecurityDefinition SecurityDefinition
    {
        get
      {
        return this.spCHSgVpLT;
      }
    }

    
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
