// Type: SmartQuant.Testing.TesterItems.TesterItem
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using ASQMKC8WePBGJ83PL4;
using Byqm85MNrFBe6JPJlI;
using SmartQuant.Series;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SmartQuant.Testing.TesterItems
{
  public class TesterItem
  {
    protected string name;
    protected string description;
    protected double lastValue;

    [Category("Properties")]
    [Browsable(false)]
    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.name;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (!(this.name != value))
          return;
        string str = this.name;
        this.name = value;
        this.U2Iyf39VD(str, this.name);
        this.EmitPropertyChanged();
      }
    }

    [Browsable(false)]
    [Category("Properties")]
    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.description;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.description = value;
        this.EmitPropertyChanged();
      }
    }

    [Browsable(false)]
    public virtual double LastValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.lastValue;
      }
    }

    [Browsable(false)]
    public virtual DoubleSeries Series
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (DoubleSeries) null;
      }
    }

    public event TesterComponentNameEventHandler ComponentNameChanged;

    public event TesterItemEventHandler PropertyChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TesterItem()
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      this.name = "";
      this.description = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TesterItem(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      this.name = "";
      this.description = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.name = name;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string ValueToSrting()
    {
      return this.LastValue.ToString(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string ValueToSrting(string format)
    {
      if (!(format.ToLower() != s3j2vikrJi2pVH1Xpv.aMieSmUS9G(8)))
        return this.DateTimeValueToString();
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(format, (object) this.LastValue);
      return ((object) stringBuilder).ToString();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string DateTimeValueToString()
    {
      string str = "";
      long ticks = (long) this.LastValue;
      if (ticks <= 0L)
        return "";
      TimeSpan timeSpan = new TimeSpan(ticks);
      if (timeSpan.Days != 0)
        str = str + timeSpan.Days.ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(14);
      if (timeSpan.Hours != 0)
        str = str + timeSpan.Hours.ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(26);
      if (timeSpan.Minutes != 0)
        str = str + timeSpan.Minutes.ToString() + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(34);
      return str;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Reset()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Disconnect()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Connect()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void U2Iyf39VD([In] string obj0, [In] string obj1)
    {
      if (this.tineIa1P6 == null)
        return;
      this.tineIa1P6(this, new ComponentNameEventArgs(obj0, obj1));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitPropertyChanged()
    {
      if (this.oH3I0f0FT == null)
        return;
      this.oH3I0f0FT(this);
    }
  }
}
