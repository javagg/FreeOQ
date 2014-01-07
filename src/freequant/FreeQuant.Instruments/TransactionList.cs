// Type: SmartQuant.Instruments.TransactionList
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using FreeQuant.Charting;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using VFUvY5knK01pUIalDo;

namespace FreeQuant.Instruments
{
  public class TransactionList : IEnumerable, IDrawable, IZoomable
  {
    private ArrayList EY5WuV6fxr;
    protected string fDrawingOption;
    protected bool fToolTipEnabled;
    protected string fToolTipFormat;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.EY5WuV6fxr.Count;
      }
    }

    public Transaction First
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.EY5WuV6fxr.Count != 0)
          return this.EY5WuV6fxr[0] as Transaction;
        else
          return (Transaction) null;
      }
    }

    public Transaction Last
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.EY5WuV6fxr.Count != 0)
          return this.EY5WuV6fxr[this.EY5WuV6fxr.Count - 1] as Transaction;
        else
          return (Transaction) null;
      }
    }

    public Transaction this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.EY5WuV6fxr[index] as Transaction;
      }
    }

    [Category("ToolTip")]
    [Description("Enable or disable tooltip appearance for this marker.")]
    public bool ToolTipEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fToolTipEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fToolTipEnabled = value;
      }
    }

    [Category("ToolTip")]
    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    public string ToolTipFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fToolTipFormat;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fToolTipFormat = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TransactionList()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.EY5WuV6fxr = new ArrayList();
      this.fDrawingOption = "";
      this.fToolTipEnabled = true;
      this.fToolTipFormat = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1910);
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Transaction transaction)
    {
      this.Add(transaction, true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Transaction transaction, bool sort)
    {
      this.EY5WuV6fxr.Add((object) transaction);
      if (!sort || this.EY5WuV6fxr.Count == 1 || !(transaction.DateTime < this[this.EY5WuV6fxr.Count - 2].DateTime))
        return;
      this.EY5WuV6fxr.Sort();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(Transaction transaction)
    {
      this.EY5WuV6fxr.Remove((object) transaction);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.EY5WuV6fxr.RemoveAt(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.EY5WuV6fxr.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(Transaction transaction)
    {
      return this.EY5WuV6fxr.Contains((object) transaction);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Sort()
    {
      this.EY5WuV6fxr.Sort();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.EY5WuV6fxr.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      string str = "";
      foreach (Transaction transaction in this.EY5WuV6fxr)
        str = str + transaction.ToString() + Environment.NewLine;
      return str;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      foreach (Transaction transaction in this)
        transaction.Paint(Pad, MinX, MaxX, MinY, MaxY);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TDistance Distance(double X, double Y)
    {
      Transaction transaction1 = (Transaction) null;
      double num1 = double.MaxValue;
      TDistance tdistance = new TDistance();
      foreach (Transaction transaction2 in this)
      {
        double num2 = Math.Abs((double) transaction2.DateTime.Ticks - X);
        if (num2 < num1)
        {
          num1 = num2;
          transaction1 = transaction2;
        }
      }
      if (transaction1 != null)
      {
        tdistance.X = (double) transaction1.DateTime.Ticks;
        tdistance.Y = transaction1.Price;
        tdistance.dX = Math.Abs(X - tdistance.X);
        tdistance.dY = Math.Abs(Y - tdistance.Y);
        StringBuilder stringBuilder = new StringBuilder();
        if (transaction1.DateTime.Second != 0 || transaction1.DateTime.Minute != 0 || transaction1.DateTime.Hour != 0)
          stringBuilder.AppendFormat(this.fToolTipFormat, (object) ((object) transaction1.Side).ToString(), (object) transaction1.Instrument.Symbol, (object) transaction1.Qty, (object) transaction1.Price, (object) transaction1.DateTime);
        else
          stringBuilder.AppendFormat(this.fToolTipFormat, (object) ((object) transaction1.Side).ToString(), (object) transaction1.Instrument.Symbol, (object) transaction1.Qty, (object) transaction1.Price, (object) transaction1.DateTime.ToShortDateString());
        tdistance.ToolTipText = ((object) stringBuilder).ToString();
      }
      else
      {
        tdistance.dX = double.MaxValue;
        tdistance.dY = double.MaxValue;
      }
      return tdistance;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw(string option)
    {
      this.fDrawingOption = option;
      Chart.Pad.Add((IDrawable) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw()
    {
      this.Draw("");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPadRangeY()
    {
      return false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PadRange GetPadRangeY(Pad pad)
    {
      return (PadRange) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPadRangeX()
    {
      return false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PadRange GetPadRangeX(Pad pad)
    {
      return (PadRange) null;
    }
  }
}
