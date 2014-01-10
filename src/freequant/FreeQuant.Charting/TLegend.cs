using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class TLegend
  {
    private Pad TKBs3XOfS;
    private ArrayList QubpfK7Qg;
    private int qKrdFkULm;
    private int LHfxtJBYE;
    private int m6TIS8v1N;
    private int SMTqvOxUh;
    private bool STlt0BS6v;
    private Color Ohok8A9LK;
    private Color WsMu1f61r;

    public Pad Pad
    {
       get
      {
        return this.TKBs3XOfS;
      }
       set
      {
        this.TKBs3XOfS = value;
      }
    }

    public int X
    {
       get
      {
        return this.qKrdFkULm;
      }
       set
      {
        this.qKrdFkULm = value;
      }
    }

    public int Y
    {
       get
      {
        return this.LHfxtJBYE;
      }
       set
      {
        this.LHfxtJBYE = value;
      }
    }

    public int Width
    {
       get
      {
        this.m6TIS8v1N = 0;
        foreach (TLegendItem tlegendItem in this.QubpfK7Qg)
        {
          int num = (int) this.TKBs3XOfS.Graphics.MeasureString(tlegendItem.Text, tlegendItem.Font).Width;
          if (num > this.m6TIS8v1N)
            this.m6TIS8v1N = num;
        }
        this.m6TIS8v1N += 12;
        return this.m6TIS8v1N;
      }
       set
      {
        this.m6TIS8v1N = value;
      }
    }

    public int Height
    {
       get
      {
        this.SMTqvOxUh = 0;
        foreach (TLegendItem tlegendItem in this.QubpfK7Qg)
          this.SMTqvOxUh += (int) this.TKBs3XOfS.Graphics.MeasureString(tlegendItem.Text, tlegendItem.Font).Height + 2;
        this.SMTqvOxUh += 2;
        return this.SMTqvOxUh;
      }
       set
      {
        this.SMTqvOxUh = value;
      }
    }

    public bool BorderEnabled
    {
       get
      {
        return this.STlt0BS6v;
      }
       set
      {
        this.STlt0BS6v = value;
      }
    }

    public Color BorderColor
    {
       get
      {
        return this.Ohok8A9LK;
      }
       set
      {
        this.Ohok8A9LK = value;
      }
    }

    public Color BackColor
    {
       get
      {
        return this.WsMu1f61r;
      }
       set
      {
        this.WsMu1f61r = value;
      }
    }

    public ArrayList Items
    {
       get
      {
        return this.QubpfK7Qg;
      }
    }


    public TLegend(Pad Pad):base()
    {

      this.TKBs3XOfS = Pad;
      this.Ua2WEbOVG();
    }

    
    private void Ua2WEbOVG()
    {
      this.STlt0BS6v = true;
      this.Ohok8A9LK = Color.Black;
      this.WsMu1f61r = Color.LightYellow;
      this.QubpfK7Qg = new ArrayList();
    }

    
    public void Add(string Text, Color Color)
    {
      this.QubpfK7Qg.Add((object) new TLegendItem(Text, Color));
    }

    
    public void Add(string Text, Color Color, Font Font)
    {
      this.QubpfK7Qg.Add((object) new TLegendItem(Text, Color, Font));
    }

    
    public void Add(TLegendItem Item)
    {
      this.QubpfK7Qg.Add((object) Item);
    }

    
    public virtual void Paint()
    {
      this.TKBs3XOfS.Graphics.FillRectangle((Brush) new SolidBrush(this.WsMu1f61r), this.qKrdFkULm, this.LHfxtJBYE, this.Width, this.Height);
      if (this.STlt0BS6v)
        this.TKBs3XOfS.Graphics.DrawRectangle(new Pen(this.Ohok8A9LK), this.qKrdFkULm, this.LHfxtJBYE, this.Width, this.Height);
      int x1 = this.qKrdFkULm + 5;
      int num1 = this.LHfxtJBYE + 2;
      foreach (TLegendItem tlegendItem in this.QubpfK7Qg)
      {
        int num2 = (int) this.TKBs3XOfS.Graphics.MeasureString(tlegendItem.Text, tlegendItem.Font).Height;
        this.TKBs3XOfS.Graphics.DrawLine(new Pen(tlegendItem.Color), x1, num1 + num2 / 2, x1 + 5, num1 + num2 / 2);
        this.TKBs3XOfS.Graphics.DrawString(tlegendItem.Text, tlegendItem.Font, (Brush) new SolidBrush(Color.Black), (float) (x1 + 5 + 2), (float) num1);
        num1 += 2 + num2;
      }
    }
  }
}
