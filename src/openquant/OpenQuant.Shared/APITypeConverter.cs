using OpenQuant.API;
using FreeQuant.FIX;
using System;

namespace OpenQuant.Shared
{
	public static class APITypeConverter
	{
		public static class InstrumentType
		{
			public static string Convert(OpenQuant.API.InstrumentType value)
			{
				switch (value)
				{
					case OpenQuant.API.InstrumentType.Stock:
						return "CS";
					case OpenQuant.API.InstrumentType.Futures:
						return "FUT";
					case OpenQuant.API.InstrumentType.Option:
						return "OPT";
					case OpenQuant.API.InstrumentType.FutOpt:
						return "FOP";
					case OpenQuant.API.InstrumentType.Bond:
						return "TBOND";
					case OpenQuant.API.InstrumentType.Index:
						return "IDX";
					case OpenQuant.API.InstrumentType.ETF:
						return "ETF";
					case OpenQuant.API.InstrumentType.FX:
						return "FOR";
					case OpenQuant.API.InstrumentType.MultiLeg:
						return "MLEG";
					case OpenQuant.API.InstrumentType.Commodity:
						return "CMDTY";
					default:
						throw new ArgumentException(string.Format("Unknown InstrumentType - {0}", value));
				}
			}

			public static OpenQuant.API.InstrumentType Convert(string value)
			{
				switch (value)
				{
					case "TBOND":
						return OpenQuant.API.InstrumentType.Bond;
					case "ETF":
						return OpenQuant.API.InstrumentType.ETF;
					case "FUT":
						return OpenQuant.API.InstrumentType.Futures;
					case "FOR":
						return OpenQuant.API.InstrumentType.FX;
					case "IDX":
						return OpenQuant.API.InstrumentType.Index;
					case "OPT":
						return OpenQuant.API.InstrumentType.Option;
					case "CS":
						return OpenQuant.API.InstrumentType.Stock;
					case "FOP":
						return OpenQuant.API.InstrumentType.FutOpt;
					case "MLEG":
						return OpenQuant.API.InstrumentType.MultiLeg;
					case "CMDTY":
						return OpenQuant.API.InstrumentType.Commodity;
					default:
						throw new ArgumentException(string.Format("Unknown SecurityType - {0}", (object)value));
				}
			}

			public static bool CanConvert(string value)
			{
				switch (value)
				{
					case "TBOND":
					case "ETF":
					case "FUT":
					case "FOR":
					case "IDX":
					case "OPT":
					case "CS":
					case "FOP":
					case "MLEG":
					case "CMDTY":
						return true;
					default:
						return false;
				}
			}
		}

		public static class PutCall
		{
			public static PutOrCall Convert(OpenQuant.API.PutCall value)
			{
				switch (value)
				{
					case OpenQuant.API.PutCall.Put:
						return (PutOrCall)0;
					case OpenQuant.API.PutCall.Call:
						return (PutOrCall)1;
					default:
						throw new ArgumentException(string.Format("Unknown PutCall - {0}", value));
				}
			}

			public static OpenQuant.API.PutCall Convert(PutOrCall value)
			{
				switch ((int)value)
				{
					case 0:
						return OpenQuant.API.PutCall.Put;
					case 1:
						return OpenQuant.API.PutCall.Call;
					default:
						throw new ArgumentException(string.Format("Unknown PutOrCall - {0}", value));
				}
			}
		}

		public static class TimeInForce
		{
			public static FreeQuant.FIX.TimeInForce Convert(OpenQuant.API.TimeInForce value)
			{
				switch (value)
				{
					case OpenQuant.API.TimeInForce.Day:
						return (FreeQuant.FIX.TimeInForce)1;
					case OpenQuant.API.TimeInForce.GTC:
						return (FreeQuant.FIX.TimeInForce)2;
					case OpenQuant.API.TimeInForce.OPG:
						return (FreeQuant.FIX.TimeInForce)3;
					case OpenQuant.API.TimeInForce.IOC:
						return (FreeQuant.FIX.TimeInForce)4;
					case OpenQuant.API.TimeInForce.FOK:
						return (FreeQuant.FIX.TimeInForce)5;
					case OpenQuant.API.TimeInForce.GTX:
						return (FreeQuant.FIX.TimeInForce)6;
					case OpenQuant.API.TimeInForce.GTD:
						return (FreeQuant.FIX.TimeInForce)7;
					case OpenQuant.API.TimeInForce.ATC:
						return (FreeQuant.FIX.TimeInForce)8;
					case OpenQuant.API.TimeInForce.GFS:
						return (FreeQuant.FIX.TimeInForce)9;
					default:
						throw new ArgumentException(string.Format("Unknown TimeInForce - {0}", value));
				}
			}
		}
	}
}
