using OpenQuant.API;
using FreeQuant.Quant;
using System;

namespace OpenQuant.API.Quant
{
	public class FinMath
	{
		internal static EPutCall SPutCall(PutCall x)
		{
			switch (x)
			{
				case PutCall.Put:
					return EPutCall.Put;
				case PutCall.Call:
					return EPutCall.Call;
				default:
					throw new NotSupportedException();
			}
		}

		internal static EOptionPosition SOptionPosition(OptionPosition x)
		{
			switch (x)
			{
				case OptionPosition.InTheMoney:
					return EOptionPosition.InTheMoney;
				case OptionPosition.AtTheMoney:
					return EOptionPosition.AtTheMoney;
				case OptionPosition.OutOfTheMoney:
					return EOptionPosition.OutOfTheMoney;
				default:
					throw new NotSupportedException();
			}
		}

		internal static EOptionPrice SOptionPrice(OptionPrice x)
		{
			switch (x)
			{
				case OptionPrice.BlackScholes:
					return EOptionPrice.BlackScholes;
				case OptionPrice.Binomial:
					return EOptionPrice.Binomial;
				case OptionPrice.Trinomial:
					return EOptionPrice.Trinomial;
				case OptionPrice.MonteCarlo:
					return EOptionPrice.MonteCarlo;
				default:
					throw new NotSupportedException();
			}
		}

		internal static EOptionType SOptionType(OptionType x)
		{
			switch (x)
			{
				case OptionType.European:
					return EOptionType.European;
				case OptionType.American:
					return EOptionType.American;
				case OptionType.Exotic:
					return EOptionType.Exotic;
				case OptionType.Bermudian:
					return EOptionType.Bermudian;
				case OptionType.Digial:
					return EOptionType.Digial;
				default:
					throw new NotSupportedException();
			}
		}

		public static double FV1(double P, double r, double n)
		{
			return FreeQuant.Quant.FinMath.FV1(P, r, n);
		}

		public static double FV2(double P, double r, double n)
		{
			return FreeQuant.Quant.FinMath.FV2(P, r, n);
		}

		public static double FV3(double P, double r, double n, double m)
		{
			return FreeQuant.Quant.FinMath.FV3(P, r, n, m);
		}

		public static double FV4(double P, double r, double n)
		{
			return FreeQuant.Quant.FinMath.FV4(P, r, n);
		}

		public static double PV1(double F, double r, double n)
		{
			return FreeQuant.Quant.FinMath.PV1(F, r, n);
		}

		public static double PV2(double F, double r, double n)
		{
			return FreeQuant.Quant.FinMath.PV2(F, r, n);
		}

		public static double PV3(double F, double r, double n, double m)
		{
			return FreeQuant.Quant.FinMath.PV3(F, r, n, m);
		}

		public static double PV4(double F, double r, double n)
		{
			return FreeQuant.Quant.FinMath.PV4(F, r, n);
		}

		public static double dPV2(double F, double r, double n)
		{
			return FreeQuant.Quant.FinMath.dPV2(F, r, n);
		}

		public static double d2PV2(double F, double r, double n)
		{
			return FreeQuant.Quant.FinMath.d2PV2(F, r, n);
		}

		public static double Fact(int n)
		{
			return FreeQuant.Quant.FinMath.Fact(n);
		}

		public static double C(int m, int n)
		{
			return FreeQuant.Quant.FinMath.C(m, n);
		}

		public static double Binom(int m, int n, double p)
		{
			return FreeQuant.Quant.FinMath.Binom(m, n, p);
		}

		public static double u(double t, double s, int n)
		{
			return FreeQuant.Quant.FinMath.u(t, s, n);
		}

		public static double d(double t, double s, int n)
		{
			return FreeQuant.Quant.FinMath.d(t, s, n);
		}

		public static double p(double t, double s, int n, double r)
		{
			return FreeQuant.Quant.FinMath.p(t, s, n, r);
		}

		public static double N(double z)
		{
			return FreeQuant.Quant.FinMath.N(z);
		}

		public static double n(double z)
		{
			return FreeQuant.Quant.FinMath.n(z);
		}

		public static double Call(double S, double X)
		{
			return FreeQuant.Quant.FinMath.Call(S, X);
		}

		public static double Put(double S, double X)
		{
			return FreeQuant.Quant.FinMath.Put(S, X);
		}

		public static double Payoff(double S, double X, PutCall PutCall)
		{
			return FreeQuant.Quant.FinMath.Payoff(S, X, FinMath.SPutCall(PutCall));
		}

		public static double Parity(double P, double S, double X, double t, double r, PutCall PutCall)
		{
			return FreeQuant.Quant.FinMath.Parity(P, S, X, t, r, FinMath.SPutCall(PutCall));
		}

		public static double BM(double S, double X, double t, double s, double r, PutCall PutCall, int n)
		{
			return FreeQuant.Quant.FinMath.BM(S, X, t, s, r, FinMath.SPutCall(PutCall));
		}

		public static double BM(double S, double X, double t, double s, double r, PutCall PutCall)
		{
			return FreeQuant.Quant.FinMath.BM(S, X, t, s, r, FinMath.SPutCall(PutCall));
		}

		public static double MC(double S, double X, double t, double s, double r, PutCall PutCall, int n)
		{
			return FreeQuant.Quant.FinMath.MC(S, X, t, s, r, FinMath.SPutCall(PutCall));
		}

		public static double MC(double S, double X, double t, double s, double r, PutCall PutCall)
		{
			return FreeQuant.Quant.FinMath.MC(S, X, t, s, r, FinMath.SPutCall(PutCall));
		}

		public static double d1(double S, double X, double t, double s, double r)
		{
			return FreeQuant.Quant.FinMath.d1(S, X, t, s, r);
		}

		public static double d2(double S, double X, double t, double s, double r)
		{
			return FreeQuant.Quant.FinMath.d2(S, X, t, s, r);
		}

		public static double BS(double S, double X, double t, double s, double r, PutCall PutCall)
		{
			return FreeQuant.Quant.FinMath.BS(S, X, t, s, r, FinMath.SPutCall(PutCall));
		}

		public static double Delta(double S, double X, double t, double s, double r, PutCall PutCall)
		{
			return FreeQuant.Quant.FinMath.Delta(S, X, t, s, r, FinMath.SPutCall(PutCall));
		}

		public static double Gamma(double S, double X, double t, double s, double r)
		{
			return FreeQuant.Quant.FinMath.Gamma(S, X, t, s, r);
		}

		public static double Theta(double S, double X, double t, double s, double r, PutCall PutCall)
		{
			return FreeQuant.Quant.FinMath.Theta(S, X, t, s, r, FinMath.SPutCall(PutCall));
		}

		public static double Vega(double S, double X, double t, double s, double r)
		{
			return FreeQuant.Quant.FinMath.Vega(S, X, t, s, r);
		}

		public static double Rho(double S, double X, double t, double s, double r, PutCall PutCall)
		{
			return FreeQuant.Quant.FinMath.Rho(S, X, t, s, r, FinMath.SPutCall(PutCall));
		}

		public static double ImpliedVolatility(double S, double X, double t, double r, double P, OptionType OptionType, PutCall PutCall, OptionPrice Method, int n, double Eps)
		{
			return FreeQuant.Quant.FinMath.ImpliedVolatility(S, X, t, r, P, FinMath.SOptionType(OptionType), FinMath.SPutCall(PutCall), FinMath.SOptionPrice(Method), n, Eps);
		}

		public static double ImpliedVolatility(double S, double X, double t, double r, double P, OptionType OptionType, PutCall PutCall, OptionPrice Method)
		{
			return FreeQuant.Quant.FinMath.ImpliedVolatility(S, X, t, r, P, FinMath.SOptionType(OptionType), FinMath.SPutCall(PutCall), FinMath.SOptionPrice(Method));
		}

		public static double FuturesPrice(double S, double t, double r)
		{
			return FreeQuant.Quant.FinMath.FuturesPrice(S, t, r);
		}

		public static double FuturesPrice(double S, double t, double r, double I)
		{
			return FreeQuant.Quant.FinMath.FuturesPrice(S, t, r, I);
		}

		public static double Min(double Value1, double Value2, double Value3)
		{
			return FreeQuant.Quant.FinMath.Min(Value1, Value2, Value3);
		}

		public static double Max(double Value1, double Value2, double Value3)
		{
			return FreeQuant.Quant.FinMath.Max(Value1, Value2, Value3);
		}

		public static int Min(int Value1, int Value2, int Value3)
		{
			return FreeQuant.Quant.FinMath.Min(Value1, Value2, Value3);
		}

		public static int Max(int Value1, int Value2, int Value3)
		{
			return FreeQuant.Quant.FinMath.Max(Value1, Value2, Value3);
		}

		public static DateTime Min(DateTime DateTime1, DateTime DateTime2)
		{
			return FreeQuant.Quant.FinMath.Min(DateTime1, DateTime2);
		}

		public static DateTime Max(DateTime DateTime1, DateTime DateTime2)
		{
			return FreeQuant.Quant.FinMath.Max(DateTime1, DateTime2);
		}

		public static DateTime Min(DateTime DateTime1, DateTime DateTime2, DateTime DateTime3)
		{
			return FreeQuant.Quant.FinMath.Min(DateTime1, DateTime2, DateTime3);
		}

		public static DateTime Max(DateTime DateTime1, DateTime DateTime2, DateTime DateTime3)
		{
			return FreeQuant.Quant.FinMath.Max(DateTime1, DateTime2, DateTime3);
		}

		public static double Percentile(double Level, double[] Data)
		{
			return FreeQuant.Quant.FinMath.Percentile(Level, Data);
		}

		public static int BinarySearch(int n, double[] SearchArray, double SearchValue)
		{
			return FreeQuant.Quant.FinMath.BinarySearch(n, SearchArray, SearchValue);
		}

		public static int BinarySearch(int n, int[] SearchArray, int SearchValue)
		{
			return FreeQuant.Quant.FinMath.BinarySearch(n, SearchArray, SearchValue);
		}

		public static double Distance(double X1, double Y1, double X2, double Y2)
		{
			return FreeQuant.Quant.FinMath.Distance(X1, Y1, X2, Y2);
		}

		public static double Distance(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
		{
			return FreeQuant.Quant.FinMath.Distance(X1, Y1, Z1, X2, Y2, Z2);
		}

		public static double Percent(double P, double Base)
		{
			return FreeQuant.Quant.FinMath.Percent(P, Base);
		}

		public static int GetNDays(DateTime Date1, DateTime Date2)
		{
			return FreeQuant.Quant.FinMath.GetNDays(Date1, Date2);
		}
	}
}
