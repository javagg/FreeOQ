using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class D_Slow : Indicator
  {
    protected int fLength;
    protected int fOrder1;
    protected int fOrder2;
    protected K_Fast fK;

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
    public int Order1
    {
       get
      {
        return this.fOrder1;
      }
       set
      {
        this.fOrder1 = value;
        this.Init();
      }
    }

    [IndicatorParameter(2)]
    [Category("Parameters")]
    [Description("")]
    public int Order2
    {
       get
      {
        return this.fOrder2;
      }
       set
      {
        this.fOrder2 = value;
        this.Init();
      }
    }

    
		public D_Slow(): base()
    {
      this.fLength = 14;
      this.fOrder1 = 10;
      this.fOrder2 = 5;
      this.Init();
    }

    
		public D_Slow(TimeSeries input, int length, int order1, int order2)	: base(input) 
    {
      this.fLength = 14;
      this.fOrder1 = 10;
      this.fOrder2 = 5;
      this.fLength = length;
      this.fOrder1 = order1;
      this.fOrder2 = order2;
      this.Init();
    }

    
    public D_Slow(TimeSeries input, int length, int order1, int order2, Color color)
			: base(input)   {
      this.fLength = 14;
      this.fOrder1 = 10;
      this.fOrder2 = 5;
      this.fLength = length;
      this.fOrder1 = order1;
      this.fOrder2 = order2;
      this.Init();
      this.Color = color;
    }

    
    public D_Slow(TimeSeries input, int length, int order1, int order2, Color color, EDrawStyle drawStyle)
			: base(input) {
      this.fLength = 14;
      this.fOrder1 = 10;
      this.fOrder2 = 5;
      this.fLength = length;
      this.fOrder1 = order1;
      this.fOrder2 = order2;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "DSlow"+ (object) this.fLength  + (string) (object) this.fOrder1 + (string) (object) this.fOrder2;
			this.Title = "DSlow";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
			if (TimeSeries.nameOption == ENameOption.Long)
        this.Name = this.fInput.Name + this.Name;
      this.Disconnect();
      if (this.fK != null)
        this.fK.Detach();
      this.fK = new K_Fast(this.fInput, this.fLength);
      this.fK.DrawEnabled = false;
      this.Connect();
    }

    
    protected override void Calculate(int index)
    {
      double Data = D_Slow.Value(this.fInput, index, this.fLength, this.fOrder1, this.fOrder2);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, int order1, int order2)
    {
      if (index < length + order1 + order2 - 1 + input.FirstIndex)
        return double.NaN;
      double num = 0.0;
      for (int index1 = index; index1 > index - order2; --index1)
        num += K_Slow.Value(input, index1, length, order1);
      return num / (double) order2;
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
        this.Calculate(Index);
    }

    
    public override void Detach()
    {
      this.fK.Detach();
      base.Detach();
    }
  }
}
