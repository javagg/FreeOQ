using FreeQuant.Data;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Shared.Data.Import.CSV
{
  public class BarEngine : Engine
  {
    private bool kNrHzZrYuE;

    
    public BarEngine(bool makeDaily)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.kNrHzZrYuE = makeDaily;
    }

    
    protected override IDataObject Process()
    {
      DateTime dateTime = this.GetDateTime();
      double doubleValue1 = this.GetDoubleValue(ColumnType.High);
      double doubleValue2 = this.GetDoubleValue(ColumnType.Low);
      double doubleValue3 = this.GetDoubleValue(ColumnType.Open);
      double doubleValue4 = this.GetDoubleValue(ColumnType.Close);
      int intValue1 = this.GetIntValue(ColumnType.Volume);
      int intValue2 = this.GetIntValue(ColumnType.OpenInt);
      IDataObject dataObject;
      if (this.kNrHzZrYuE)
        dataObject = (IDataObject) new Daily(dateTime, doubleValue3, doubleValue1, doubleValue2, doubleValue4, (long) intValue1, (long) intValue2);
      else
        dataObject = (IDataObject) new Bar(dateTime, doubleValue3, doubleValue1, doubleValue2, doubleValue4, (long) intValue1, (long) this.template.DataOptions.BarSize)
        {
          OpenInt = (long) intValue2
        };
      return dataObject;
    }

    
    protected override void Add(IDataSeries series, IDataObject obj)
    {
      series.Update(obj.DateTime, (object) obj);
    }
  }
}
