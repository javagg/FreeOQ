using FreeQuant.Series;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Testing.TesterItems
{
//  [Editor(typeof (NFYDmemfMcZVeiIsfe), typeof (UITypeEditor))]
//  [TypeConverter(typeof (QOoL8gW2RfToAZcPln))]
  public class SeriesTesterItem : TesterItem
  {
    protected SeriesTesterItem parentComponent;
    protected DoubleSeries parentSeries;
    protected DoubleSeries series;
    protected bool fillSeries;
    protected int lastIndex;
    protected bool isUpdating;
    protected bool enabled;
    protected ArrayList parentList;
    protected DateTime lastDateTime;

    [Browsable(false)]
    [Category("Properties")]
    public virtual bool Enabled
    {
      get
      {
        return this.enabled;
      }
      set
      {
        if (this.enabled == value)
          return;
        this.enabled = value;
        if (this.enabled)
        {
          if (this.parentComponent != null)
          {
            this.parentComponent.Enabled = true;
            this.parentComponent.FillSeries = true;
          }
          foreach (SeriesTesterItem seriesTesterItem in this.parentList)
          {
            seriesTesterItem.Enabled = true;
            seriesTesterItem.FillSeries = true;
          }
        }
        this.EmitComponentEnabledChanged();
        this.EmitPropertyChanged();
      }
    }

    [Category("Parameters")]
    public virtual bool FillSeries
    {
      get
      {
        return this.fillSeries;
      }
      set
      {
        this.fillSeries = value;
        if (this.fillSeries)
        {
          this.isUpdating = true;
          if (this.parentComponent != null)
            this.parentComponent.FillSeries = true;
          this.Calculate();
          this.isUpdating = false;
        }
        this.EmitPropertyChanged();
      }
    }

    [Browsable(false)]
    public override double LastValue
    {
      get
      {
        if (!this.enabled)
          return double.NaN;
        if (this.fillSeries)
        {
          if (this.series.Count > 0)
            return this.series.Last;
          else
            return double.NaN;
        }
        else
        {
          this.CalculateParentSeries();
          if (this.parentSeries.Count > 0)
            return this.GetValue(this.parentSeries.LastDateTime);
          else
            return double.NaN;
        }
      }
    }

    [Browsable(false)]
    public virtual DoubleSeries ParentSeries
    {
      get
      {
        return this.parentSeries;
      }
    }

    [Browsable(false)]
    public override DoubleSeries Series
    {
      get
      {
        return this.series;
      }
    }

    [Category("Parent Components")]
    [Browsable(false)]
    public virtual SeriesTesterItem ParentComponent
    {
      get
      {
        return this.parentComponent;
      }
      set
      {
        SeriesTesterItem seriesTesterItem = this.parentComponent;
        if (value == seriesTesterItem)
          return;
        this.parentComponent = value;
        this.parentSeries = this.parentComponent.Series;
        this.XD5mZhm60(seriesTesterItem, value);
        this.EmitPropertyChanged();
      }
    }

    public event EventHandler ComponentEnabledChanged;

   
		public SeriesTesterItem() : base()
    {
      this.parentList = new ArrayList();

    }

   
		public SeriesTesterItem(string name) : base(name)
    {
      this.parentList = new ArrayList();

    }

   
    public SeriesTesterItem(string name, SeriesTesterItem parentSeriesItem, string title)
			: base(name)  {
      this.parentList = new ArrayList();
      this.Init(name, parentSeriesItem, title, false);
    }

   
    public SeriesTesterItem(string name, SeriesTesterItem parentSeriesItem, string title, bool fillSeries)
			: base(name) {
      this.parentList = new ArrayList();
      this.Init(name, parentSeriesItem, title, fillSeries);
    }

   
    protected void Init(string name, SeriesTesterItem parentSeriesItem, string title, bool fillSeries)
    {
      this.isUpdating = false;
      this.lastDateTime = DateTime.MinValue;
      this.series = new DoubleSeries();
      this.series.Name = name;
      this.series.Title = title;
      this.parentComponent = parentSeriesItem;
      this.parentSeries = parentSeriesItem.Series;
      if (this.parentSeries != null)
        this.parentSeries.ItemAdded += new ItemAddedEventHandler(this.syrQYCdiq);
      this.FillSeries = fillSeries;
    }

   
    private void XD5mZhm60([In] SeriesTesterItem obj0, [In] SeriesTesterItem obj1)
    {
      this.Reset();
      if (obj0 != null)
        obj0.Series.ItemAdded -= new ItemAddedEventHandler(this.syrQYCdiq);
      this.isUpdating = true;
      if (this.fillSeries)
        obj1.FillSeries = true;
      this.isUpdating = false;
      obj1.Series.ItemAdded += new ItemAddedEventHandler(this.syrQYCdiq);
    }

   
    protected virtual double GetValue(DateTime date)
    {
      return double.NaN;
    }

   
    private void syrQYCdiq([In] object obj0, [In] DateTimeEventArgs obj1)
    {
      this.lastDateTime = obj1.DateTime;
      if (this.isUpdating || !this.fillSeries)
        return;
      this.Calculate();
    }

   
    protected virtual void CalculateSeries(int firstIndex, int lastIndex)
    {
      for (int index = firstIndex; index <= lastIndex; ++index)
        this.txHWUR99S(this.parentSeries.GetDateTime(index));
    }

   
    protected void CalculateParentSeries()
    {
      this.isUpdating = true;
      if (this.parentComponent != null)
        this.parentComponent.Calculate();
      this.isUpdating = false;
    }

   
    private void txHWUR99S([In] DateTime obj0)
    {
      double num = this.GetValue(obj0);
      if (double.IsNaN(num))
        return;
      this.series.Add(obj0, num);
    }

   
    public virtual void Calculate()
    {
      if (!this.enabled)
        return;
      this.CalculateParentSeries();
      int firstIndex = 0;
      if (this.series.Count != 0)
        firstIndex = !this.parentSeries.Contains(this.lastDateTime) ? this.lastIndex + 1 : Math.Min(this.lastIndex + 1, this.parentSeries.GetIndex(this.lastDateTime));
      this.lastDateTime = DateTime.MinValue;
      this.lastIndex = this.parentSeries.Count - 1;
      this.CalculateSeries(firstIndex, this.lastIndex);
    }

   
    public override void Reset()
    {
      base.Reset();
      if (this.series != null)
        this.series.Clear();
      this.lastIndex = -1;
      this.lastDateTime = DateTime.MinValue;
    }

   
    public override void Connect()
    {
      this.parentSeries.ItemAdded += new ItemAddedEventHandler(this.syrQYCdiq);
    }

   
    public override void Disconnect()
    {
      this.parentSeries.ItemAdded -= new ItemAddedEventHandler(this.syrQYCdiq);
    }

   
    protected void EmitComponentEnabledChanged()
    {
//      if (this.Xf5sSFYDm == null)
//        return;
//      this.Xf5sSFYDm((object) this, EventArgs.Empty);
    }
  }
}
