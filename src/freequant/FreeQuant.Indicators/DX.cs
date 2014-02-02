using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class DX : Indicator
  {
    protected EIndicatorStyle fStyle;
    protected int fLength;
    protected DoubleSeries fPDM;
    protected DoubleSeries fMDM;

    [Category("Parameters")]
    [IndicatorParameter(0)]
    [Description("")]
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

    [Description("")]
    [IndicatorParameter(1)]
    [Category("Parameters")]
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

    
		public DX(): base()
    {
      this.fLength = 14;
      this.Init();
    }

    
		public DX(TimeSeries input, int length, EIndicatorStyle style)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
    }

    
    public DX(TimeSeries input, int length, EIndicatorStyle style, Color color)
			: base(input)    {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
    }

    
    public DX(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle)
			: base(input)  {
      this.fLength = 14;
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
		public DX(TimeSeries input, int length)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Init();
    }

    
		public DX(TimeSeries input, int length, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    
    protected override void Init()
    {
			this.Name = "DX" + (object) this.fLength;
			this.Title = "DX";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
			if (TimeSeries.fNameOption == ENameOption.Long)
				this.Name = this.fInput.Name + this.Name;
      this.fPDM = new DoubleSeries();
      this.fMDM = new DoubleSeries();
    }

    
    protected override void Calculate(int index)
    {
      if (this.fStyle == EIndicatorStyle.QuantStudio)
      {
        double Data1 = 0.0;
        double Data2 = 0.0;
        double Data3 = 0.0;
        if (index >= this.fLength + this.fInput.FirstIndex)
        {
          if (index == this.fLength + this.fInput.FirstIndex)
          {
            for (int index1 = index; index1 >= index - this.fLength + 1; --index1)
            {
              Data1 += PDM.Value(this.fInput, index1);
              Data2 += MDM.Value(this.fInput, index1);
            }
          }
          else
          {
            Data2 = this.fMDM[index - 1] - MDM.Value(this.fInput, index - this.fLength) + MDM.Value(this.fInput, index);
            Data1 = this.fPDM[index - 1] - PDM.Value(this.fInput, index - this.fLength) + PDM.Value(this.fInput, index);
          }
          if (Data1 + Data2 != 0.0)
            Data3 = Math.Abs(Data1 - Data2) / (Data1 + Data2) * 100.0;
          this.Add(this.fInput.GetDateTime(index), Data3);
        }
        else
          this.Add(this.fInput.GetDateTime(index), double.NaN);
        this.fPDM.Add(this.fInput.GetDateTime(index), Data1);
        this.fMDM.Add(this.fInput.GetDateTime(index), Data2);
      }
      else
      {
        double Data1 = 0.0;
        double Data2 = 0.0;
        double Data3 = 0.0;
        if (index >= this.fLength + this.fInput.FirstIndex)
        {
          if (index == this.fLength + this.fInput.FirstIndex)
          {
            for (int index1 = index; index1 >= index - this.fLength + 1; --index1)
            {
              Data1 += PDM.Value(this.fInput, index1);
              Data2 += MDM.Value(this.fInput, index1);
            }
          }
          else
          {
            Data1 = this.fPDM[index - 1] - this.fPDM[index - 1] / (double) this.fLength + PDM.Value(this.fInput, index);
            Data2 = this.fMDM[index - 1] - this.fMDM[index - 1] / (double) this.fLength + MDM.Value(this.fInput, index);
          }
          if (Data1 + Data2 != 0.0)
            Data3 = Math.Abs(Data1 - Data2) / (Data1 + Data2) * 100.0;
          this.Add(this.fInput.GetDateTime(index), Data3);
        }
        else
          this.Add(this.fInput.GetDateTime(index), double.NaN);
        this.fPDM.Add(this.fInput.GetDateTime(index), Data1);
        this.fMDM.Add(this.fInput.GetDateTime(index), Data2);
      }
    }

    
    public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
    {
      if (index < length + input.FirstIndex)
        return double.NaN;
      double num1 = 0.0;
      double num2 = PDI.Value(input, index, length, style);
      double num3 = MDI.Value(input, index, length, style);
      if (num2 + num3 != 0.0)
        num1 = 100.0 * Math.Abs(num2 - num3) / (num2 + num3);
      return num1;
    }

    
    public static double Value(TimeSeries input, int index, int length)
    {
      return DX.Value(input, index, length, EIndicatorStyle.QuantStudio);
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
