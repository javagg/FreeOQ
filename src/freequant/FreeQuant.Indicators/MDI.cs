using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class MDI : Indicator
  {
    protected EIndicatorStyle fStyle;
    protected int fLength;
    protected DoubleSeries fMDM;
    protected DoubleSeries fTR;

    [Description("")]
    [Category("Parameters")]
    [IndicatorParameter(0)]
    public int Length
    {
       get
      {
        return this.fLength;
      }
       set
      {
        this.fLength = value;
        this.Init();
      }
    }

    [Category("Parameters")]
    [IndicatorParameter(1)]
    [Description("")]
    public EIndicatorStyle Style
    {
       get
      {
        return this.fStyle;
      }
       set
      {
        this.fStyle = value;
        this.Init();
      }
    }

    
		public MDI(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public MDI(TimeSeries input, int length, EIndicatorStyle style)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
    }

    
		public MDI(TimeSeries input, int length, EIndicatorStyle style, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
    }

    
    public MDI(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle)
			: base(input)  {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public MDI(TimeSeries input, int length)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public MDI(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "MDI" + (object) this.fLength;
			this.Title = "MDI";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
			if (TimeSeries.fNameOption == ENameOption.Long)
        this.Name = this.fInput.Name  + this.Name;
      this.fMDM = new DoubleSeries();
      this.fTR = new DoubleSeries();
    }

    
    protected override void Calculate(int index)
    {
      double Data1 = double.NaN;
      if (this.fStyle == EIndicatorStyle.QuantStudio)
      {
        double Data2 = 0.0;
        double Data3 = 0.0;
        if (index >= this.fLength + this.fInput.FirstIndex)
        {
          if (index == this.fLength + this.fInput.FirstIndex)
          {
            for (int index1 = index; index1 >= index - this.fLength + 1; --index1)
            {
              Data3 += TR.Value(this.fInput, index1);
              Data2 += MDM.Value(this.fInput, index1);
            }
          }
          else
          {
            Data2 = this.fMDM[index - 1] - MDM.Value(this.fInput, index - this.fLength) + MDM.Value(this.fInput, index);
            Data3 = this.fTR[index - 1] - TR.Value(this.fInput, index - this.fLength) + TR.Value(this.fInput, index);
          }
          if (Data3 != 0.0)
            Data1 = Data2 / Data3 * 100.0;
        }
        this.fMDM.Add(this.fInput.GetDateTime(index), Data2);
        this.fTR.Add(this.fInput.GetDateTime(index), Data3);
      }
      else
      {
        double Data2 = 0.0;
        double Data3 = 0.0;
        if (index >= this.fLength + this.fInput.FirstIndex)
        {
          if (index == this.fLength + this.fInput.FirstIndex)
          {
            for (int index1 = index; index1 >= index - this.fLength + 1; --index1)
            {
              Data3 += TR.Value(this.fInput, index1);
              Data2 += MDM.Value(this.fInput, index1);
            }
          }
          else
          {
            Data2 = this.fMDM[index - 1] - this.fMDM[index - 1] / (double) this.fLength + MDM.Value(this.fInput, index);
            Data3 = this.fTR[index - 1] - this.fTR[index - 1] / (double) this.fLength + TR.Value(this.fInput, index);
          }
          if (Data3 != 0.0)
            Data1 = Data2 / Data3 * 100.0;
        }
        this.fMDM.Add(this.fInput.GetDateTime(index), Data2);
        this.fTR.Add(this.fInput.GetDateTime(index), Data3);
      }
      this.Add(this.fInput.GetDateTime(index), Data1);
    }

    
    public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
    {
      if (style == EIndicatorStyle.QuantStudio)
      {
        double num1 = 0.0;
        double num2 = 0.0;
        if (index < length + input.FirstIndex)
          return double.NaN;
        for (int index1 = index; index1 > index - length; --index1)
        {
          num2 += TR.Value(input, index1);
          num1 += MDM.Value(input, index1);
        }
        return num1 / num2 * 100.0;
      }
      else
      {
        double num1 = 0.0;
        double num2 = 0.0;
        if (index < length + input.FirstIndex)
          return double.NaN;
        for (int index1 = length + input.FirstIndex; index1 >= input.FirstIndex + 1; --index1)
        {
          num2 += TR.Value(input, index1);
          num1 += MDM.Value(input, index1);
        }
        for (int index1 = length + 1 + input.FirstIndex; index1 <= index; ++index1)
        {
          num1 = num1 - num1 / (double) length + MDM.Value(input, index1);
          num2 = num2 - num2 / (double) length + TR.Value(input, index1);
        }
        return num1 / num2 * 100.0;
      }
    }

    
    public static double Value(TimeSeries input, int index, int length)
    {
      return MDI.Value(input, index, length, EIndicatorStyle.QuantStudio);
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      if (this.fStyle == EIndicatorStyle.QuantStudio)
      {
        for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.fLength); ++Index)
          this.Calculate(Index);
      }
      else
      {
        for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
          this.Calculate(Index);
      }
    }
  }
}
