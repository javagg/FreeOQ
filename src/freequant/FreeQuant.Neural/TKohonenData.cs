using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TKohonenData : TNeuralData
  {
    private string iXtbZuYY7;
    private int UWRwwoI3Y;
    private int Xoa2UGRFa;

    public string Name
    {
      get
      {
        return this.iXtbZuYY7;
      }
      set
      {
        this.iXtbZuYY7 = value;
      }
    }

    public int X
    {
      get
      {
        return this.UWRwwoI3Y;
      }
      set
      {
        this.UWRwwoI3Y = value;
      }
    }

    public int Y
    {
      get
      {
        return this.Xoa2UGRFa;
      }
      set
      {
        this.Xoa2UGRFa = value;
      }
    }

    public TKohonenData(TKohonenData Data)
    {
      this.UWRwwoI3Y = Data.UWRwwoI3Y;
      this.Xoa2UGRFa = Data.Xoa2UGRFa;
    }

		public TKohonenData(int NInput):base(NInput, 0)
    {
      this.UWRwwoI3Y = 0;
      this.Xoa2UGRFa = 0;
    }

		public TKohonenData(int NInput, double[] Input) :base(NInput, 0, Input, null)
    {
      this.UWRwwoI3Y = 0;
      this.Xoa2UGRFa = 0;
    }

   
		public TKohonenData(int NInput, int NOutput) :base(NInput, NOutput)
    {
      this.UWRwwoI3Y = 0;
      this.Xoa2UGRFa = 0;
    }

		public TKohonenData(int NInput, int NOutput, double[] Input, double[] Output):base(NInput, NOutput, Input, Output)
    {
      this.UWRwwoI3Y = 0;
      this.Xoa2UGRFa = 0;
    }
  }
}
