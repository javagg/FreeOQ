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
       get
      {
        return this.mqxB9tafd;
      }
       set
      {
        this.mqxB9tafd = value;
      }
    }

    public int NOutput
    {
       get
      {
        return this.XkLVodNhF;
      }
       set
      {
        this.XkLVodNhF = value;
      }
    }

    public double[] Input
    {
       get
      {
        return this.dRXrjBaeW;
      }
       set
      {
        this.dRXrjBaeW = value;
      }
    }

    public double[] Output
    {
       get
      {
        return this.s9P8N17Q3;
      }
       set
      {
        this.s9P8N17Q3 = value;
      }
    }

    
    public TNeuralData()
    {
    }

    
    public TNeuralData(TNeuralData Data)
    {
      this.mqxB9tafd = Data.mqxB9tafd;
      this.XkLVodNhF = Data.mqxB9tafd;
      this.dRXrjBaeW = this.mqxB9tafd == 0 ? (double[]) null : new double[this.mqxB9tafd];
      this.s9P8N17Q3 = this.XkLVodNhF == 0 ? (double[]) null : new double[this.XkLVodNhF];
      for (int index = 0; index < this.mqxB9tafd; ++index)
        this.dRXrjBaeW[index] = Data.dRXrjBaeW[index];
      for (int index = 0; index < this.XkLVodNhF; ++index)
        this.s9P8N17Q3[index] = Data.s9P8N17Q3[index];
    }

    
    public TNeuralData(int NInput, int NOutput)
    {
      this.mqxB9tafd = NInput;
      this.XkLVodNhF = NOutput;
      this.dRXrjBaeW = NInput == 0 ? (double[]) null : new double[NInput];
      if (NOutput != 0)
        this.s9P8N17Q3 = new double[NOutput];
      else
        this.s9P8N17Q3 = (double[]) null;
    }

    
    public TNeuralData(int NInput, int NOutput, double[] Input, double[] Output, bool Copy)
    {
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

    
    public TNeuralData(int NInput, int NOutput, double[] Input, double[] Output)
    {
      this.mqxB9tafd = NInput;
      this.XkLVodNhF = NOutput;
      this.dRXrjBaeW = new double[NInput];
      this.s9P8N17Q3 = new double[NOutput];
      for (int index = 0; index < NInput; ++index)
        this.dRXrjBaeW[index] = Input[index];
      for (int index = 0; index < NOutput; ++index)
        this.s9P8N17Q3[index] = Output[index];
    }

    
    public void SetInput(int i, double Input)
    {
      this.dRXrjBaeW[i] = Input;
    }

    
    public void SetOutput(int i, double Output)
    {
      this.s9P8N17Q3[i] = Output;
    }

    
    public void RandomizeInput(int Input, double Min, double Max)
    {
      if (Input == -1)
      {
        for (int Input1 = 0; Input1 < this.mqxB9tafd; ++Input1)
          this.RandomizeInput(Input1, Min, Max);
      }
      else
				this.dRXrjBaeW[Input] = Min + FreeQuant.Quant.Random.Rndm() * (Max - Min);
    }

    
    public void RandomizeOutput(int Output, double Min, double Max)
    {
      if (Output == -1)
      {
        for (int Input = 0; Input < this.XkLVodNhF; ++Input)
          this.RandomizeInput(Input, Min, Max);
      }
      else
        this.s9P8N17Q3[Output] = Min + FreeQuant.Quant.Random.Rndm() * (Max - Min);
    }

    
    public void NormalizeInput()
    {
      double d = 0.0;
      for (int index = 0; index < this.mqxB9tafd; ++index)
        d += this.dRXrjBaeW[index] * this.dRXrjBaeW[index];
      double num = Math.Sqrt(d);
      for (int index = 0; index < this.mqxB9tafd; ++index)
        this.dRXrjBaeW[index] /= num;
    }

    
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
