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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.iXtbZuYY7;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.iXtbZuYY7 = value;
      }
    }

    public int X
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.UWRwwoI3Y;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
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
      [MethodImpl(MethodImplOptions.NoInlining)] set
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

    public TKohonenData(int NInput, double[] Input)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector(NInput, 0, Input, (double[]) null);
      this.UWRwwoI3Y = 0;
      this.Xoa2UGRFa = 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TKohonenData(int NInput, int NOutput)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector(NInput, NOutput);
      this.UWRwwoI3Y = 0;
      this.Xoa2UGRFa = 0;
    }

    public TKohonenData(int NInput, int NOutput, double[] Input, double[] Output)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector(NInput, NOutput, Input, Output);
      this.UWRwwoI3Y = 0;
      this.Xoa2UGRFa = 0;
    }
  }
}
