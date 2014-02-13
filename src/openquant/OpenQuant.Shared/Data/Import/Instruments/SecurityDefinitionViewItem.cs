using OpenQuant.Shared;
using FreeQuant.FIX;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.Instruments
{
  internal class SecurityDefinitionViewItem : ListViewItem
  {
    private FIXSecurityDefinition securityDefinition;

    public FIXSecurityDefinition SecurityDefinition
    {
      get
      {
        return this.securityDefinition;
      }
    }

    public SecurityDefinitionViewItem(FIXSecurityDefinition securityDefinition, byte providerId)
      : base(new string[5])
    {
      this.securityDefinition = securityDefinition;
      this.SubItems[0].Text = SecurityDefinitionHelper.GetSymbol(securityDefinition, providerId);
      this.SubItems[1].Text = ((object) APITypeConverter.InstrumentType.Convert(securityDefinition.SecurityType)).ToString();
      this.SubItems[2].Text = securityDefinition.SecurityExchange;
      this.SubItems[3].Text = securityDefinition.Currency;
      DateTime? nullable;
      if (((FIXGroup) securityDefinition).ContainsField(541))
        nullable = new DateTime?(securityDefinition.MaturityDate);
      else if (((FIXGroup) securityDefinition).ContainsField(200))
      {
        try
        {
          nullable = new DateTime?(new DateTime(int.Parse(securityDefinition.MaturityMonthYear.Substring(0, 4), (IFormatProvider) CultureInfo.InvariantCulture), int.Parse(securityDefinition.MaturityMonthYear.Substring(4, 2), (IFormatProvider) CultureInfo.InvariantCulture), 1));
        }
        catch
        {
          nullable = new DateTime?();
        }
      }
      else
        nullable = new DateTime?();
      this.SubItems[4].Text = !nullable.HasValue ? "" : nullable.Value.ToShortDateString();
    }
  }
}
