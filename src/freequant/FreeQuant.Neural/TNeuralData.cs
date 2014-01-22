using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TNeuralData
  {
    private int mqxB9tafd;
    private int XkLVodNhF;
    private double[] dRXrjBaeW;
    private double[] s9P8N17Q3;

    public int NInput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mqxB9tafd;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.mqxB9tafd = value;
      }
    }

    public int NOutput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.XkLVodNhF;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.XkLVodNhF = value;
      }
    }

    public double[] Input
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.dRXrjBaeW;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.dRXrjBaeW = value;
      }
    }

    public double[] Output
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.s9P8N17Q3;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.s9P8N17Q3 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralData()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralData(TNeuralData Data)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.mqxB9tafd = Data.mqxB9tafd;
      this.XkLVodNhF = Data.mqxB9tafd;
      this.dRXrjBaeW = this.mqxB9tafd == 0 ? (double[]) null : new double[this.mqxB9tafd];
      this.s9P8N17Q3 = this.XkLVodNhF == 0 ? (double[]) null : new double[this.XkLVodNhF];
      for (int index = 0; index < this.mqxB9tafd; ++index)
        this.dRXrjBaeW[index] = Data.dRXrjBaeW[index];
      for (int index = 0; index < this.XkLVodNhF; ++index)
        this.s9P8N17Q3[index] = Data.s9P8N17Q3[index];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralData(int NInput, int NOutput)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.mqxB9tafd = NInput;
      this.XkLVodNhF = NOutput;
      this.dRXrjBaeW = NInput == 0 ? (double[]) null : new double[NInput];
      if (NOutput != 0)
        this.s9P8N17Q3 = new double[NOutput];
      else
        this.s9P8N17Q3 = (double[]) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralData(int NInput, int NOutput, double[] Input, double[] Output, bool Copy)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.mqxB9tafd = NInput;
      this.XkLVodNhF = NOutput;
      if (Copy)
      {
        this.dRXrjBaeW = new double[NInput];
        this.s9P8N17Q3 = new double[NOutput];
        for (int index = 0; index < NInput; ++index)
          this.dRXrjBaeW[index] = Input[index];
        for (int index = 0; index < NOutput; ++index)
          this.s9P8N17Q3[index] = Output[index];
      }
      else
      {
        this.dRXrjBaeW = Input;
        this.s9P8N17Q3 = Output;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralData(int NInput, int NOutput, double[] Input, double[] Output)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.mqxB9tafd = NInput;
      this.XkLVodNhF = NOutput;
      this.dRXrjBaeW = new double[NInput];
      this.s9P8N17Q3 = new double[NOutput];
      for (int index = 0; index < NInput; ++index)
        this.dRXrjBaeW[index] = Input[index];
      for (int index = 0; index < NOutput; ++index)
        this.s9P8N17Q3[index] = Output[index];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInput(int i, double Input)
    {
      this.dRXrjBaeW[i] = Input;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOutput(int i, double Output)
    {
      this.s9P8N17Q3[i] = Output;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RandomizeInput(int Input, double Min, double Max)
    {
      if (Input == -1)
      {
        for (int Input1 = 0; Input1 < this.mqxB9tafd; ++Input1)
          this.RandomizeInput(Input1, Min, Max);
      }
      else
        this.dRXrjBaeW[Input] = Min + SmartQuant.Quant.Random.Rndm() * (Max - Min);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RandomizeOutput(int Output, double Min, double Max)
    {
      if (Output == -1)
      {
        for (int Input = 0; Input < this.XkLVodNhF; ++Input)
          this.RandomizeInput(Input, Min, Max);
      }
      else
        this.s9P8N17Q3[Output] = Min + SmartQuant.Quant.Random.Rndm() * (Max - Min);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NormalizeInput()
    {
      double d = 0.0;
      for (int index = 0; index < this.mqxB9tafd; ++index)
        d += this.dRXrjBaeW[index] * this.dRXrjBaeW[index];
      double num = Math.Sqrt(d);
      for (int index = 0; index < this.mqxB9tafd; ++index)
        this.dRXrjBaeW[index] /= num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NormalizeOutput()
    {
      double d = 0.0;
      for (int index = 0; index < this.XkLVodNhF; ++index)
        d += this.s9P8N17Q3[index] * this.s9P8N17Q3[index];
      double num = Math.Sqrt(d);
      for (int index = 0; index < this.XkLVodNhF; ++index)
        this.s9P8N17Q3[index] /= num;
    }
  }
}
