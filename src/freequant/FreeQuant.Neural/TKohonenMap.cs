using FreeQuant.Charting;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TKohonenMap : TNeuralNetwork
  {
    private EKohonenTopology M7SYu5gxf;
    private EKohonenKernel a8fxHLKhg;
    private double g5ykpFFS7;
    private double yem372767;
    private int crqUrCA6J;
    private int R00zPKwYO;
    private TInputNeuron[] x0pBGNZNEv;
    private TKohonenNeuron[,] C4gBBYR9YW;
    private TKohonenNeuron oGkBVEIgUD;
    private TNeuralDataSet en8Br1nJcm;
    private Histogram2D NZFB8Hsyyk;
    private Graph lHWBj2LFHb;
    private double L2kBAuWI5g;

    public EKohonenTopology Topology
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.M7SYu5gxf;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.M7SYu5gxf = value;
      }
    }

    public EKohonenKernel Kernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a8fxHLKhg;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a8fxHLKhg = value;
      }
    }

    public double InitLearningRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.g5ykpFFS7;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.g5ykpFFS7 = value;
      }
    }

    public double InitNeighborhoodRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.yem372767;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.yem372767 = value;
      }
    }

    public double NeighborhoodRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.L2kBAuWI5g;
      }
    }

    public int NCols
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.crqUrCA6J;
      }
    }

    public int NRows
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.R00zPKwYO;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TKohonenMap()
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.en8Br1nJcm = (TNeuralDataSet) null;
      this.NZFB8Hsyyk = (Histogram2D) null;
      this.lHWBj2LFHb = (Graph) null;
      this.L2kBAuWI5g = this.yem372767;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TKohonenMap(string Name, string Title, int NCols, int NRows, TNeuralDataSet DataSet, int NPatterns)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector(Name, Title);
      this.crqUrCA6J = NCols;
      this.R00zPKwYO = NRows;
      this.en8Br1nJcm = DataSet;
      this.fNInput = DataSet.NInput;
      this.SetStopping(EStoppingMethod.PatternNumber, (double) NPatterns);
      this.yem372767 = (double) Math.Max(NCols, NRows);
      this.L2kBAuWI5g = this.yem372767;
      this.P2odmXxb0();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TKohonenMap(string Name, string Title, int NCols, int NRows, int Topology, TNeuralDataSet DataSet, int NPatterns)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector(Name, Title);
      this.crqUrCA6J = NCols;
      this.R00zPKwYO = NRows;
      this.en8Br1nJcm = DataSet;
      this.fNInput = DataSet.NInput;
      this.SetStopping(EStoppingMethod.PatternNumber, (double) NPatterns);
      this.yem372767 = (double) Math.Max(NCols, NRows);
      this.L2kBAuWI5g = this.yem372767;
      this.P2odmXxb0();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TKohonenMap(string Name, int NCols, int NRows, TNeuralDataSet DataSet, int NPatterns)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector(Name);
      this.crqUrCA6J = NCols;
      this.R00zPKwYO = NRows;
      this.en8Br1nJcm = DataSet;
      this.fNInput = DataSet.NInput;
      this.SetStopping(EStoppingMethod.PatternNumber, (double) NPatterns);
      this.yem372767 = (double) Math.Max(NCols, NRows);
      this.L2kBAuWI5g = this.yem372767;
      this.P2odmXxb0();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TKohonenMap(string Name, int NCols, int NRows, int Topology, TNeuralDataSet DataSet, int NPatterns)
    {
      dYYlo5mOFCQvCLWITo.LnsUthkzmPDgB();
      // ISSUE: explicit constructor call
      base.\u002Ector(Name);
      this.crqUrCA6J = NCols;
      this.R00zPKwYO = NRows;
      this.en8Br1nJcm = DataSet;
      this.fNInput = DataSet.NInput;
      this.SetStopping(EStoppingMethod.PatternNumber, (double) NPatterns);
      this.yem372767 = (double) Math.Max(NCols, NRows);
      this.L2kBAuWI5g = this.yem372767;
      this.P2odmXxb0();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void P2odmXxb0()
    {
      this.x0pBGNZNEv = new TInputNeuron[this.fNInput];
      for (int index = 0; index < this.fNInput; ++index)
        this.x0pBGNZNEv[index] = new TInputNeuron();
      this.C4gBBYR9YW = new TKohonenNeuron[this.crqUrCA6J, this.R00zPKwYO];
      for (int Col = 0; Col < this.crqUrCA6J; ++Col)
      {
        for (int Row = 0; Row < this.R00zPKwYO; ++Row)
          this.C4gBBYR9YW[Col, Row] = new TKohonenNeuron(this, Col, Row);
      }
      for (int index1 = 0; index1 < this.fNInput; ++index1)
      {
        for (int index2 = 0; index2 < this.crqUrCA6J; ++index2)
        {
          for (int index3 = 0; index3 < this.R00zPKwYO; ++index3)
            this.C4gBBYR9YW[index2, index3].Connect((TNeuron) this.x0pBGNZNEv[index1]);
        }
      }
      this.NZFB8Hsyyk = (Histogram2D) null;
      this.lHWBj2LFHb = (Graph) null;
      this.M7SYu5gxf = EKohonenTopology.Rectangular;
      this.a8fxHLKhg = EKohonenKernel.Bubble;
      this.g5ykpFFS7 = 0.05;
      this.yem372767 = 10.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessInput(double[] Input)
    {
      this.fInput = Input;
      for (int index = 0; index < this.fNInput; ++index)
        this.x0pBGNZNEv[index].Input = Input[index];
      for (int index = 0; index < this.fNInput; ++index)
        this.x0pBGNZNEv[index].ProcessInput();
      for (int index1 = 0; index1 < this.crqUrCA6J; ++index1)
      {
        for (int index2 = 0; index2 < this.R00zPKwYO; ++index2)
          this.C4gBBYR9YW[index1, index2].ProcessInput();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetError()
    {
      double num = 0.0;
      for (int index1 = 0; index1 < this.crqUrCA6J; ++index1)
      {
        for (int index2 = 0; index2 < this.R00zPKwYO; ++index2)
          num += this.C4gBBYR9YW[index1, index2].GetError();
      }
      return num / (double) (this.crqUrCA6J * this.R00zPKwYO);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAverageError()
    {
      double num = 0.0;
      for (int Seek = 0; Seek < this.en8Br1nJcm.GetNData(); ++Seek)
      {
        this.ProcessInput(this.en8Br1nJcm.GetInput(Seek));
        num += this.GetError();
      }
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TKohonenNeuron GetWinner()
    {
      TKohonenNeuron tkohonenNeuron = this.C4gBBYR9YW[0, 0];
      double num = tkohonenNeuron.GetError();
      for (int index1 = 0; index1 < this.crqUrCA6J; ++index1)
      {
        for (int index2 = 0; index2 < this.R00zPKwYO; ++index2)
        {
          double error = this.C4gBBYR9YW[index1, index2].GetError();
          if (error < num)
          {
            num = error;
            tkohonenNeuron = this.C4gBBYR9YW[index1, index2];
          }
        }
      }
      return tkohonenNeuron;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update()
    {
      for (int index1 = 0; index1 < this.crqUrCA6J; ++index1)
      {
        for (int index2 = 0; index2 < this.R00zPKwYO; ++index2)
          this.C4gBBYR9YW[index1, index2].Update(this.oGkBVEIgUD);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TrainThread()
    {
      this.fNPattern = 0;
      for (int index = 0; (double) index < this.fSParameter; ++index)
      {
        this.fInput = this.en8Br1nJcm.GetData().Input;
        this.ProcessInput(this.fInput);
        this.oGkBVEIgUD = this.GetWinner();
        this.Update();
        TKohonenMap tkohonenMap = this;
        int num1 = tkohonenMap.fNPattern + 1;
        tkohonenMap.fNPattern = num1;
        double num2 = (double) this.fNPattern / this.fSParameter;
        this.fLearningRate = this.g5ykpFFS7 * (1.0 - num2);
        this.L2kBAuWI5g = 1.0 + this.yem372767 * (1.0 - num2);
      }
      Console.WriteLine(nsoHwqAxvM4sAIorFP.auoBSZuq3T(420) + (object) this.fNPattern + nsoHwqAxvM4sAIorFP.auoBSZuq3T(462));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Histogram2D GetMapHist()
    {
      this.NZFB8Hsyyk = new Histogram2D(this.fName, this.fTitle, this.crqUrCA6J, 0.0, (double) this.crqUrCA6J, this.R00zPKwYO, 0.0, (double) this.R00zPKwYO);
      for (int index1 = 0; index1 < this.crqUrCA6J; ++index1)
      {
        for (int index2 = 0; index2 < this.R00zPKwYO; ++index2)
          this.C4gBBYR9YW[index1, index2].ResetWin();
      }
      for (int Seek = 0; Seek < this.en8Br1nJcm.GetNData(); ++Seek)
      {
        TKohonenData tkohonenData = (TKohonenData) this.en8Br1nJcm.GetData(Seek);
        double[] input = tkohonenData.Input;
        double[] output = tkohonenData.Output;
        this.ProcessInput(input);
        TKohonenNeuron winner = this.GetWinner();
        if (output != null)
        {
          if (output[0] != 0.0)
            winner.AddWin(output[0]);
        }
        else
        {
          winner.AddWin(1.0);
          winner.SetNWins(1);
        }
        tkohonenData.X = winner.Col;
        tkohonenData.Y = winner.Row;
      }
      for (int index1 = 0; index1 < this.crqUrCA6J; ++index1)
      {
        for (int index2 = 0; index2 < this.R00zPKwYO; ++index2)
        {
          TKohonenNeuron tkohonenNeuron = this.C4gBBYR9YW[index1, index2];
          if (tkohonenNeuron.GetNWins() != 0)
            this.NZFB8Hsyyk.Set((double) tkohonenNeuron.Col, (double) tkohonenNeuron.Row, tkohonenNeuron.GetWin() / (double) tkohonenNeuron.GetNWins());
          else
            this.NZFB8Hsyyk.Set((double) tkohonenNeuron.Col, (double) tkohonenNeuron.Row, 0.0);
        }
      }
      return this.NZFB8Hsyyk;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawData(int X, int Y)
    {
      if (this.lHWBj2LFHb == null)
      {
        this.lHWBj2LFHb = new Graph(nsoHwqAxvM4sAIorFP.auoBSZuq3T(506));
        this.lHWBj2LFHb.Style = EGraphStyle.Scatter;
        this.lHWBj2LFHb.MarkerSize = 1;
      }
      for (int Seek = 0; Seek < this.en8Br1nJcm.GetNData(); ++Seek)
      {
        double[] input = this.en8Br1nJcm.GetInput(Seek);
        this.lHWBj2LFHb.Add(input[X], input[Y]);
      }
      this.lHWBj2LFHb.Draw();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawData()
    {
      this.DrawData(0, 1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawMesh(int X, int Y)
    {
      for (int index1 = 0; index1 < this.crqUrCA6J; ++index1)
      {
        for (int index2 = 0; index2 < this.R00zPKwYO; ++index2)
        {
          TKohonenNeuron tkohonenNeuron1 = this.C4gBBYR9YW[index1, index2];
          if (index1 < this.crqUrCA6J - 1)
          {
            TKohonenNeuron tkohonenNeuron2 = this.C4gBBYR9YW[index1 + 1, index2];
            new TLine(tkohonenNeuron1.GetWeight(X).Weight, tkohonenNeuron1.GetWeight(Y).Weight, tkohonenNeuron2.GetWeight(X).Weight, tkohonenNeuron2.GetWeight(Y).Weight)
            {
              Color = Color.Blue
            }.Draw();
          }
          if (index2 < this.R00zPKwYO - 1)
          {
            TKohonenNeuron tkohonenNeuron2 = this.C4gBBYR9YW[index1, index2 + 1];
            new TLine(tkohonenNeuron1.GetWeight(X).Weight, tkohonenNeuron1.GetWeight(Y).Weight, tkohonenNeuron2.GetWeight(X).Weight, tkohonenNeuron2.GetWeight(Y).Weight)
            {
              Color = Color.Blue
            }.Draw();
          }
          new TMarker(tkohonenNeuron1.GetWeight(X).Weight, tkohonenNeuron1.GetWeight(Y).Weight, 20.0)
          {
            Color = Color.Red
          }.Draw();
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawMesh()
    {
      this.DrawMesh(0, 1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw(string Option)
    {
      if (this.NZFB8Hsyyk == null || Option.ToLower() == nsoHwqAxvM4sAIorFP.auoBSZuq3T(534))
        this.GetMapHist();
      this.NZFB8Hsyyk.Draw();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw()
    {
      this.Draw("");
    }
  }
}
