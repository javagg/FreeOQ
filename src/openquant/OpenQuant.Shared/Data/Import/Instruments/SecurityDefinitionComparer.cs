using FreeQuant.FIX;
using System;
using System.Collections;

namespace OpenQuant.Shared.Data.Import.Instruments
{
  internal class SecurityDefinitionComparer : IComparer
  {
    private int column;
    private bool descending;

    public SecurityDefinitionComparer(int column, bool descending)
    {
      this.column = column;
      this.descending = descending;
    }

    public int Compare(object x, object y)
    {
      FIXSecurityDefinition securityDefinition1 = ((SecurityDefinitionViewItem) x).SecurityDefinition;
      FIXSecurityDefinition securityDefinition2 = ((SecurityDefinitionViewItem) y).SecurityDefinition;
      int num;
      switch (this.column)
      {
        case 0:
          num = securityDefinition1.Symbol.CompareTo(securityDefinition2.Symbol);
          break;
        case 1:
          num = securityDefinition1.SecurityType.CompareTo(securityDefinition2.SecurityType);
          break;
        case 2:
          num = securityDefinition1.SecurityExchange.CompareTo(securityDefinition2.SecurityExchange);
          break;
        case 3:
          num = securityDefinition1.Currency.CompareTo(securityDefinition2.Currency);
          break;
        case 4:
          num = securityDefinition1.MaturityDate.CompareTo(securityDefinition2.MaturityDate);
          break;
        default:
          throw new ArgumentException(string.Format("Unknown column number", (object) this.column));
      }
      if (this.descending)
        num = -num;
      return num;
    }
  }
}
