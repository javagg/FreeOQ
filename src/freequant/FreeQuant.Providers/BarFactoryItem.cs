using FreeQuant.Data;
using System;
using System.ComponentModel;

namespace FreeQuant.Providers
{
  public class BarFactoryItem : IComparable
  {
    internal const BarType aYrgwoBvsH = BarType.Time;
    internal const long l27gtTMOx0 = 60L;
    internal const bool dAxggIVaoI = true;
    private BarType barType;
    private long barSize;
    private bool enabled;

    [DefaultValue(BarType.Time)]
    public BarType BarType
    {
       get
      {
				return this.barType; 
      }
       set
      {
        this.barType = value;
      }
    }

    [DefaultValue(60)]
    public long BarSize
    {
       get
      {
				return this.barSize; 
      }
       set
      {
        this.barSize = value;
      }
    }

    [DefaultValue(true)]
		public bool Enabled
    {
       get
      {
				return this.enabled; 
      }
       set
      {
        this.enabled = value;
      }
    }

    
    public BarFactoryItem(BarType barType, long barSize, bool enabled)
    {
      this.barType = barType;
      this.barSize = barSize;
      this.enabled = enabled;
    }

    
		public BarFactoryItem():this(BarType.Time, 60, true)
    {

    }

    
    public int CompareTo(object obj)
    {
      BarFactoryItem barFactoryItem = obj as BarFactoryItem;
      if (barFactoryItem != null)
      {
        if (this.barSize > barFactoryItem.barSize)
          return 1;
        if (this.barSize < barFactoryItem.barSize)
          return -1;
      }
      return 0;
    }

    
    public override string ToString()
    {
			return string.Format("{0}", this.barType, this.barSize, this.enabled);
    }
  }
}
