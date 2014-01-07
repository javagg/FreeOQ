// Type: SmartQuant.FinChart.Objects.DrawingImage
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart.Objects
{
  public class DrawingImage : IUpdatable
  {
    private DateTime kK7y702WDY;
    private double JPXyR8VTA9;
    private Image aipyEffZDd;

    public string Name { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public DateTime X
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.kK7y702WDY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.kK7y702WDY = value;
        this.hw2ybdMqpF();
      }
    }

    public double Y
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.JPXyR8VTA9;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.JPXyR8VTA9 = value;
        this.hw2ybdMqpF();
      }
    }

    public Image Image
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aipyEffZDd;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aipyEffZDd = value;
        this.hw2ybdMqpF();
      }
    }

    public event EventHandler Updated;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DrawingImage(DateTime x, double y, Image image, string name)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Name = name;
      this.kK7y702WDY = x;
      this.JPXyR8VTA9 = y;
      this.aipyEffZDd = image;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void hw2ybdMqpF()
    {
      if (this.enQyncNsH9 == null)
        return;
      this.enQyncNsH9((object) this, EventArgs.Empty);
    }
  }
}
