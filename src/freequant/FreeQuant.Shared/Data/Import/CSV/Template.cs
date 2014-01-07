// Type: SmartQuant.Shared.Data.Import.CSV.Template
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class Template
  {
    private CSVOptions CScGUFJ30;
    private DataOptions NW5ZdqjBk;
    private DateOptions WEB4aYUAf;
    private ColumnCollection aTPI1emcc;
    private SymbolOptions uKdSCwQCd;
    private SeriesOptions NBHUS3Nmi;
    private OtherOptions G8mjDaRnp;
    private bool Fsx6WFcPg;
    private string GtZrrPUwU;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GtZrrPUwU;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.GtZrrPUwU = value;
      }
    }

    public CSVOptions CSVOptions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.CScGUFJ30;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.CScGUFJ30 = value;
      }
    }

    public DataOptions DataOptions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.NW5ZdqjBk;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.NW5ZdqjBk = value;
      }
    }

    public DateOptions DateOptions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WEB4aYUAf;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.WEB4aYUAf = value;
      }
    }

    public SymbolOptions SymbolOptions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.uKdSCwQCd;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.uKdSCwQCd = value;
      }
    }

    public SeriesOptions SeriesOptions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.NBHUS3Nmi;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.NBHUS3Nmi = value;
      }
    }

    public OtherOptions OtherOptions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.G8mjDaRnp;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.G8mjDaRnp = value;
      }
    }

    public ColumnCollection Columns
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aTPI1emcc;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aTPI1emcc = value;
      }
    }

    public bool IsCompleted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Fsx6WFcPg;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Template()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.CScGUFJ30 = new CSVOptions();
      this.NW5ZdqjBk = new DataOptions();
      this.WEB4aYUAf = new DateOptions();
      this.aTPI1emcc = new ColumnCollection();
      this.uKdSCwQCd = new SymbolOptions();
      this.NBHUS3Nmi = new SeriesOptions();
      this.G8mjDaRnp = new OtherOptions();
      this.Fsx6WFcPg = false;
      this.GtZrrPUwU = "";
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string[] Validate()
    {
      ArrayList arrayList = new ArrayList();
      switch (this.NW5ZdqjBk.DataType)
      {
        case DataType.Daily:
          this.tIsO4DQaI(ColumnType.Date, arrayList);
          break;
        case DataType.Trade:
          this.GuTa8WEd5(arrayList);
          break;
        case DataType.Quote:
          this.GuTa8WEd5(arrayList);
          break;
        case DataType.Bar:
          this.GuTa8WEd5(arrayList);
          break;
      }
      switch (this.uKdSCwQCd.Option)
      {
        case SymbolOption.Column:
          this.tIsO4DQaI(ColumnType.Symbol, arrayList);
          break;
        case SymbolOption.Manually:
          if (this.uKdSCwQCd.Name == "")
          {
            arrayList.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(578));
            break;
          }
          else
            break;
      }
      this.Fsx6WFcPg = arrayList.Count == 0;
      return arrayList.ToArray(typeof (string)) as string[];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return this.GtZrrPUwU;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Column Q9UyPKkpL([In] ColumnType obj0)
    {
      foreach (Column column in (CollectionBase) this.aTPI1emcc)
      {
        if (obj0 == column.ColumnType)
          return column;
      }
      return (Column) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void tIsO4DQaI([In] ColumnType obj0, [In] ArrayList obj1)
    {
      if (this.Q9UyPKkpL(obj0) != null)
        return;
      obj1.Add((object) (RNaihRhYEl0wUmAftnB.aYu7exFQKN(638) + ((object) obj0).ToString() + RNaihRhYEl0wUmAftnB.aYu7exFQKN(658)));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GuTa8WEd5([In] ArrayList obj0)
    {
      switch (this.WEB4aYUAf.DateType)
      {
        case DateType.Column:
          if (this.Q9UyPKkpL(ColumnType.DateTime) != null)
            break;
          Column column1 = this.Q9UyPKkpL(ColumnType.Date);
          Column column2 = this.Q9UyPKkpL(ColumnType.Time);
          if (column1 == null && column2 == null)
          {
            obj0.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(686));
            break;
          }
          else if (column1 == null)
          {
            obj0.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(814));
            break;
          }
          else
          {
            if (column2 != null)
              break;
            obj0.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(866));
            break;
          }
        case DateType.Manually:
          this.tIsO4DQaI(ColumnType.Time, obj0);
          break;
      }
    }
  }
}
