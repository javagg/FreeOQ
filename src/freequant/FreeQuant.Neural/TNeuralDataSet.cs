// Type: SmartQuant.Neural.TNeuralDataSet
// Assembly: SmartQuant.Neural, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: E5DFC29A-4534-4F54-827A-AC305F5F2864
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Neural.dll

using aq250XLTtWVBJufbvY;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Neural
{
  [Serializable]
  public class TNeuralDataSet
  {
    protected int fNInput;
    protected int fNOutput;
    protected int fNData;
    protected ArrayList fData;
    protected double fNoiseLevel;
    protected int fFirst;
    protected int fLast;
    protected bool fIsOwner;
    protected bool fIsChanged;
    protected double[] fMean;
    protected double[] fVariance;

    public int NInput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fNInput;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fNInput = value;
      }
    }

    public int NOutput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fNOutput;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fNOutput = value;
      }
    }

    public int NData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fNData;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fNData = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralDataSet()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fIsOwner = true;
      this.embmG1hcf();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralDataSet(int NInput, int NOutput, bool IsOwner)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fNData = 0;
      this.fNInput = NInput;
      this.fNOutput = NOutput;
      this.fIsOwner = IsOwner;
      this.embmG1hcf();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralDataSet(int NInput, int NOutput)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fNData = 0;
      this.fNInput = NInput;
      this.fNOutput = NOutput;
      this.fIsOwner = true;
      this.embmG1hcf();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void embmG1hcf()
    {
      this.fNData = 0;
      this.fNoiseLevel = 0.0;
      this.fData = new ArrayList();
      this.fFirst = -1;
      this.fLast = -1;
      this.fMean = new double[this.fNInput];
      this.fVariance = new double[this.fNInput];
      this.fIsChanged = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddData(TNeuralData NeuralData)
    {
      this.fData.Add((object) NeuralData);
      ++this.fNData;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddData(int NInput, int NOutput, double[] Input, double[] Output)
    {
      this.AddData(new TNeuralData(NInput, NOutput, Input, Output));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNData()
    {
      if (this.fIsChanged)
      {
        this.PrepareData();
        this.fIsChanged = false;
      }
      this.fNData = (this.fLast != -1 ? this.fLast : this.fData.Count - 1) - (this.fFirst != -1 ? this.fFirst : 0) + 1;
      return this.fNData;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralData GetData(int Seek)
    {
      if (this.fIsChanged)
      {
        this.PrepareData();
        this.fIsChanged = false;
      }
      int num1 = this.fFirst != -1 ? this.fFirst : 0;
      int num2 = this.fLast != -1 ? this.fLast : this.fData.Count - 1;
      return (TNeuralData) this.fData[Seek != -1 ? num1 + Seek : num1 + (int) ((double) (num2 - num1 + 1) * SmartQuant.Quant.Random.Rndm())];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double[] GetInput(int Seek)
    {
      return this.GetData(Seek).Input;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double[] GetOutput(int Seek)
    {
      return this.GetData(Seek).Output;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TNeuralData GetData()
    {
      return this.GetData(-1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double[] GetInput()
    {
      return this.GetInput(-1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double[] GetOutput()
    {
      return this.GetOutput(-1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RandomizeInput(int Input, double Min, double Max)
    {
      for (int Seek = 0; Seek < this.fData.Count; ++Seek)
        this.GetData(Seek).RandomizeInput(Input, Min, Max);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RandomizeOutput(int Output, double Min, double Max)
    {
      for (int Seek = 0; Seek < this.fData.Count; ++Seek)
        this.GetData(Seek).RandomizeInput(Output, Min, Max);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetMean(int Col)
    {
      double num1 = 0.0;
      int num2 = 0;
      for (int Seek = 0; Seek < this.fData.Count; ++Seek)
      {
        num1 += this.GetData(Seek).Input[Col];
        ++num2;
      }
      double num3 = num1 / (double) num2;
      this.fMean[Col] = num3;
      return num3;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetVariance(int Col)
    {
      double mean = this.GetMean(Col);
      double num1 = 0.0;
      int num2 = 0;
      for (int Seek = 0; Seek < this.fData.Count; ++Seek)
      {
        num1 += (this.GetData(Seek).Input[Col] - mean) * (this.GetData(Seek).Input[Col] - mean);
        ++num2;
      }
      double num3 = num1 / (double) (num2 - 1);
      this.fVariance[Col] = num3;
      return num3;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStandardDeviation(int Col)
    {
      return Math.Sqrt(this.GetVariance(Col));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NormalizeInput()
    {
      for (int Seek = 0; Seek < this.fData.Count; ++Seek)
        this.GetData(Seek).NormalizeInput();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Renormalize()
    {
      for (int Col = 0; Col < this.fNInput; ++Col)
      {
        double storedMean = this.GetStoredMean(Col);
        double num1 = Math.Sqrt(this.GetStoredVariance(Col));
        for (int Seek = 0; Seek < this.fData.Count; ++Seek)
        {
          TNeuralData data = this.GetData(Seek);
          double num2 = data.Input[Col];
          data.Input[Col] = num2 * num1 + storedMean;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NormalizeOutput()
    {
      for (int Seek = 0; Seek < this.fData.Count; ++Seek)
        this.GetData(Seek).NormalizeOutput();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void PrepareData()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStoredMean(int Col)
    {
      return this.fMean[Col];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStoredVariance(int Col)
    {
      return this.fVariance[Col];
    }
  }
}
