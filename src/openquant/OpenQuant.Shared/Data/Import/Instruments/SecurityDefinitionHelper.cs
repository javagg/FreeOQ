using FreeQuant.FIX;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace OpenQuant.Shared.Data.Import.Instruments
{
	static class SecurityDefinitionHelper
	{
		public static string GetSymbol(FIXSecurityDefinition definition, byte providerId)
		{
			switch (providerId)
			{
				case FreeQuant.Providers.ProviderId.IB:  // 4
					return SecurityDefinitionHelper.GetSymbol_IB(definition);
				case FreeQuant.Providers.ProviderId.TTFIX:
					return SecurityDefinitionHelper.GetSymbol_TTFIX(definition);
				case FreeQuant.Providers.ProviderId.OpenECry: // 22:
					return SecurityDefinitionHelper.GetSymbol_OEC(definition);
				default:
					return definition.Symbol;
			}
		}

		private static string GetSymbol_TTFIX(FIXSecurityDefinition definition)
		{
			List<string> list = new List<string>();
			list.Add(definition.Symbol);
			if (definition.SecurityType == "FUT" || definition.SecurityType == "OPT")
			{
				if (((FIXGroup)definition).ContainsField(200))
				{
					int year = int.Parse(definition.MaturityMonthYear.Substring(0, 4), (IFormatProvider)CultureInfo.InvariantCulture);
					int month = int.Parse(definition.MaturityMonthYear.Substring(4, 2), (IFormatProvider)CultureInfo.InvariantCulture);
					list.Add(new DateTime(year, month, 1).ToString("MMMyy", (IFormatProvider)CultureInfo.InvariantCulture));
				}
				else if (((FIXGroup)definition).ContainsField(541))
					list.Add(definition.MaturityDate.ToString("MMMyy", (IFormatProvider)CultureInfo.InvariantCulture));
				if (definition.SecurityType == "OPT")
				{
					if (((FIXGroup)definition).ContainsField(202))
						list.Add(definition.StrikePrice.ToString((IFormatProvider)CultureInfo.InvariantCulture));
					if (((FIXGroup)definition).ContainsField(201))
					{
						if (definition.PutOrCall == 0)
							list.Add("P");
						else
							list.Add("C");
					}
				}
			}
			if (definition.SecurityType == "MLEG")
			{
				for (int index = 0; index < definition.NoUnderlyings; ++index)
				{
					FIXUnderlyingsGroup underlyingsGroup = definition.GetUnderlyingsGroup(index);
					if (((FIXGroup)underlyingsGroup).ContainsField(313))
					{
						int year = int.Parse(underlyingsGroup.UnderlyingMaturityMonthYear.Substring(0, 4), (IFormatProvider)CultureInfo.InvariantCulture);
						int month = int.Parse(underlyingsGroup.UnderlyingMaturityMonthYear.Substring(4, 2), (IFormatProvider)CultureInfo.InvariantCulture);
						list.Add(new DateTime(year, month, 1).ToString("MMMyy", CultureInfo.InvariantCulture));
					}
				}
			}
			return string.Join(" ", (IEnumerable<string>)list);
		}

		private static string GetSymbol_IB(FIXSecurityDefinition definition)
		{
			switch (definition.SecurityType)
			{
				case "FOR":
					if (!string.IsNullOrEmpty(definition.Currency))
						return string.Format("{0}/{1}", definition.Symbol, definition.Currency);
					else
						return definition.Symbol;
				case "FUT":
				case "OPT":
				case "FOP":
					List<string> list = new List<string>();
					list.Add(definition.Symbol);
					if (((FIXGroup)definition).ContainsField(541))
						list.Add(definition.MaturityDate.ToString("MMMyy", (IFormatProvider)CultureInfo.InvariantCulture));
					if (((FIXGroup)definition).ContainsField(202))
						list.Add(definition.StrikePrice.ToString((IFormatProvider)CultureInfo.InvariantCulture).Replace('.', '\''));
					if (((FIXGroup)definition).ContainsField(201))
					{
						switch (definition.PutOrCall)
						{
							case 0:
								list.Add("P");
								break;
							case 1:
								list.Add("C");
								break;
						}
					}
					return string.Join(" ", list);
				default:
					return definition.Symbol;
			}
		}

		private static string GetSymbol_OEC(FIXSecurityDefinition definition)
		{
			string str = definition.Symbol;
			if (definition.SecurityType == "FUT" || definition.SecurityType == "OPT")
			{
				if (((FIXGroup)definition).ContainsField(541))
					str = str + " " + definition.MaturityDate.ToString("MMMyy", (IFormatProvider)CultureInfo.InvariantCulture);
				if (definition.SecurityType == "OPT")
				{
					if (((FIXGroup)definition).ContainsField(202))
						str = str + (object)" " + (string)(object)definition.StrikePrice;
					if (((FIXGroup)definition).ContainsField(201))
					{
						switch (definition.PutOrCall)
						{
							case 0:
								str = str + " P";
								break;
							case 1:
								str = str + " C";
								break;
						}
					}
				}
			}
			return str;
		}
	}
}
