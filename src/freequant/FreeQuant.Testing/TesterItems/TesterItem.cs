using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace FreeQuant.Testing.TesterItems
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
      get
      {
        return this.name;
      }
      set
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
      get
      {
        return this.description;
      }
      set
      {
        this.description = value;
        this.EmitPropertyChanged();
      }
    }

    [Browsable(false)]
    public virtual double LastValue
    {
      get
      {
        return this.lastValue;
      }
    }

    [Browsable(false)]
    public virtual DoubleSeries Series
    {
      get
      {
        return (DoubleSeries) null;
      }
    }

    public event TesterComponentNameEventHandler ComponentNameChanged;

    public event TesterItemEventHandler PropertyChanged;

   
		public TesterItem():  base()
    {
      this.name = "";
      this.description = "";

    }

   
		public TesterItem(string name):  base()
    {
      this.name = "";
      this.description = "";
      this.name = name;
    }

   
    public virtual string ValueToSrting()
    {
			return this.LastValue.ToString();
    }

   
    public virtual string ValueToSrting(string format)
    {
			if (!(format.ToLower() != "sdd"))
        return this.DateTimeValueToString();
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(format, (object) this.LastValue);
      return ((object) stringBuilder).ToString();
    }

   
    public virtual string DateTimeValueToString()
    {
      string str = "";
      long ticks = (long) this.LastValue;
      if (ticks <= 0L)
        return "";
      TimeSpan timeSpan = new TimeSpan(ticks);
      if (timeSpan.Days != 0)
        str = str + timeSpan.Days.ToString();
      if (timeSpan.Hours != 0)
        str = str + timeSpan.Hours.ToString();
      if (timeSpan.Minutes != 0)
        str = str + timeSpan.Minutes.ToString();
      return str;
    }

   
    public virtual void Reset()
    {
    }

   
    public virtual void Disconnect()
    {
    }

   
    public virtual void Connect()
    {
    }

   
    private void U2Iyf39VD([In] string obj0, [In] string obj1)
    {
//      if (this.tineIa1P6 == null)
//        return;
//      this.tineIa1P6(this, new ComponentNameEventArgs(obj0, obj1));
    }

   
    protected void EmitPropertyChanged()
    {
//      if (this.oH3I0f0FT == null)
//        return;
//      this.oH3I0f0FT(this);
    }
  }
}
