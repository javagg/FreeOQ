using System;
using System.ComponentModel;

namespace FreeQuant.Optimization
{
	[Serializable]
	public class ParamSet
	{
		protected int fNParam;
		protected double[] fParam;
		protected string[] fParamName;
		protected EParamType[] fParamType;
		protected double[] fLowerBound;
		protected double[] fUpperBound;
		protected bool[] fIsParamFixed;
		protected double[] fSteps;

		[Browsable(false)]
		public int Count
		{
			get
			{
				return this.fNParam;
			}
		}

		public double this[int index]
		{
			get
			{
				return this.GetParam(index);
			}
			set
			{
				this.SetParam(index, value);
			}
		}

		public ParamSet()
		{
			this.fNParam = 0;
		}

		public ParamSet(double param1)
		{
			this.fNParam = 0;
			this.SetNParam(1);
			this.fParam[0] = param1;
		}

		public ParamSet(double param1, double param2)
		{
			this.fNParam = 0;
			this.SetNParam(2);
			this.fParam[0] = param1;
			this.fParam[1] = param2;
		}

		public ParamSet(double param1, double Param2, double Param3)
		{
			this.fNParam = 0;
			this.SetNParam(3);
			this.fParam[0] = param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
		}

		public ParamSet(double param1, double Param2, double Param3, double Param4)
		{
			this.fNParam = 0;
			this.SetNParam(4);
			this.fParam[0] = param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
		}

		public ParamSet(double param1, double Param2, double Param3, double Param4, double Param5)
		{
			this.fNParam = 0;
			this.SetNParam(5);
			this.fParam[0] = param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
			this.fParam[4] = Param5;
		}

		public ParamSet(double param1, double Param2, double Param3, double Param4, double Param5, double Param6)
		{
			this.fNParam = 0;
			this.SetNParam(6);
			this.fParam[0] = param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
			this.fParam[4] = Param5;
			this.fParam[5] = Param6;
		}

		public ParamSet(double param1, double Param2, double Param3, double Param4, double Param5, double Param6, double Param7)
		{
			this.fNParam = 0;
			this.SetNParam(7);
			this.fParam[0] = param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
			this.fParam[4] = Param5;
			this.fParam[5] = Param6;
			this.fParam[6] = Param7;
		}

		public ParamSet(double param1, double Param2, double Param3, double Param4, double Param5, double Param6, double Param7, double Param8)
		{
			this.fNParam = 0;
			this.SetNParam(8);
			this.fParam[0] = param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
			this.fParam[4] = Param5;
			this.fParam[5] = Param6;
			this.fParam[6] = Param7;
			this.fParam[7] = Param8;
		}

		public ParamSet(double param1, double Param2, double Param3, double Param4, double Param5, double Param6, double Param7, double Param8, double Param9)
		{
			this.fNParam = 0;
			this.SetNParam(9);
			this.fParam[0] = param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
			this.fParam[4] = Param5;
			this.fParam[5] = Param6;
			this.fParam[6] = Param7;
			this.fParam[7] = Param8;
			this.fParam[8] = Param9;
		}

		public ParamSet(double param1, double Param2, double Param3, double Param4, double Param5, double Param6, double Param7, double Param8, double Param9, double Param10)
		{
			this.fNParam = 0;
			this.SetNParam(10);
			this.fParam[0] = param1;
			this.fParam[1] = Param2;
			this.fParam[2] = Param3;
			this.fParam[3] = Param4;
			this.fParam[4] = Param5;
			this.fParam[5] = Param6;
			this.fParam[6] = Param7;
			this.fParam[7] = Param8;
			this.fParam[8] = Param9;
			this.fParam[9] = Param10;
		}

		public int GetNParam()
		{
			return this.fNParam;
		}

		public double GetParam(int NParam)
		{
			return this.fParam[NParam];
		}

		public EParamType GetParamType(int NParam)
		{
			return this.fParamType[NParam];
		}

		public string GetParamName(int NParam)
		{
			return this.fParamName[NParam];
		}

		public double GetLowerBound(int NParam)
		{
			return this.fLowerBound[NParam];
		}

		public double GetUpperBound(int NParam)
		{
			return this.fUpperBound[NParam];
		}

		public double GetSteps(int NParam)
		{
			return this.fSteps[NParam];
		}

		public void SetNParam(int NParam)
		{
			if (NParam <= this.fNParam)
				return;
			double[] numArray1 = new double[NParam];
			EParamType[] eparamTypeArray = new EParamType[NParam];
			string[] strArray = new string[NParam];
			double[] numArray2 = new double[NParam];
			double[] numArray3 = new double[NParam];
			bool[] flagArray = new bool[NParam];
			double[] numArray4 = new double[NParam];
			int num = Math.Min(this.fNParam, NParam);
			if (this.fNParam != 0)
			{
				for (int index = 0; index < num; ++index)
				{
					numArray1[index] = this.fParam[index];
					eparamTypeArray[index] = this.fParamType[index];
					strArray[index] = this.fParamName[index];
					numArray2[index] = this.fLowerBound[index];
					numArray3[index] = this.fUpperBound[index];
					flagArray[index] = this.fIsParamFixed[index];
					numArray4[index] = this.fSteps[index];
				}
			}
			this.fParam = numArray1;
			this.fParamType = eparamTypeArray;
			this.fParamName = strArray;
			this.fLowerBound = numArray2;
			this.fUpperBound = numArray3;
			this.fIsParamFixed = flagArray;
			this.fSteps = numArray4;
			for (int index = this.fNParam; index < NParam; ++index)
			{
				this.fParamType[index] = EParamType.Float;
				this.fParamName[index] = "";
				this.fLowerBound[index] = double.NegativeInfinity;
				this.fUpperBound[index] = double.PositiveInfinity;
				this.fIsParamFixed[index] = false;
				this.fSteps[index] = 0.0;
			}
			this.fNParam = NParam;
		}

		public void Clear()
		{
			this.fNParam = 0;
		}

		public void SetParam(int NParam, double Param)
		{
			if (NParam + 1 > this.fNParam)
				this.SetNParam(NParam + 1);
			this.fParam[NParam] = Param;
		}

		public void SetParam(int NParam, string ParamName, double Param)
		{
			if (NParam + 1 > this.fNParam)
				this.SetNParam(NParam + 1);
			this.fParamName[NParam] = ParamName;
			this.fParam[NParam] = Param;
		}

		public void SetParamName(int NParam, string ParamName)
		{
			if (NParam + 1 > this.fNParam)
				this.SetNParam(NParam + 1);
			this.fParamName[NParam] = ParamName;
		}

		public void SetParamType(int NParam, EParamType Type)
		{
			if (NParam + 1 > this.fNParam)
				this.SetNParam(NParam + 1);
			this.fParamType[NParam] = Type;
		}

		public void SetLowerBound(int NParam, double Bound)
		{
			if (NParam + 1 > this.fNParam)
				this.SetNParam(NParam + 1);
			this.fLowerBound[NParam] = Bound;
		}

		public void SetUpperBound(int NParam, double Bound)
		{
			if (NParam + 1 > this.fNParam)
				this.SetNParam(NParam + 1);
			this.fUpperBound[NParam] = Bound;
		}

		public void SetParamBounds(int NParam, double LowerBound, double UpperBound)
		{
			if (NParam + 1 > this.fNParam)
				this.SetNParam(NParam + 1);
			this.fLowerBound[NParam] = LowerBound;
			this.fUpperBound[NParam] = UpperBound;
		}

		public void FixParam(int NParam, bool Fixed)
		{
			if (NParam + 1 > this.fNParam)
				this.SetNParam(NParam + 1);
			this.fIsParamFixed[NParam] = Fixed;
		}

		public void SetSteps(int NParam, double Steps)
		{
			if (NParam + 1 > this.fNParam)
				this.SetNParam(NParam + 1);
			this.fSteps[NParam] = Steps;
		}

		public bool IsParamFixed(int NParam)
		{
			return this.fIsParamFixed[NParam];
		}

		public int GetNFixedParam()
		{
			int num = 0;
			for (int NParam = 0; NParam < this.fNParam; ++NParam)
			{
				if (this.IsParamFixed(NParam))
					++num;
			}
			return num;
		}

		public double GetMinLowerBound()
		{
			double val1 = this.fLowerBound[0];
			for (int index = 1; index < this.fNParam; ++index)
				val1 = Math.Min(val1, this.fLowerBound[index]);
			return val1;
		}

		public double GetMaxLowerBound()
		{
			double val1 = this.fLowerBound[0];
			for (int index = 1; index < this.fNParam; ++index)
				val1 = Math.Max(val1, this.fLowerBound[index]);
			return val1;
		}

		public double GetMinUpperBound()
		{
			double val1 = this.fUpperBound[0];
			for (int index = 1; index < this.fNParam; ++index)
				val1 = Math.Min(val1, this.fUpperBound[index]);
			return val1;
		}

		public double GetMaxUpperBound()
		{
			double val1 = this.fUpperBound[0];
			for (int index = 1; index < this.fNParam; ++index)
				val1 = Math.Max(val1, this.fUpperBound[index]);
			return val1;
		}

		public void Print(string Option)
		{
			Console.WriteLine("", this.fNParam);
			for (int index = 0; index < this.fNParam; ++index)
				Console.WriteLine("", index, this.fParam[index], this.fParamName[index]);
		}
	}
}
