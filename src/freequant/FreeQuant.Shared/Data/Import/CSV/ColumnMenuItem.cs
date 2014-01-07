// Type: SmartQuant.Shared.Data.Import.CSV.ColumnMenuItem
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class ColumnMenuItem : MenuItem
  {
    private ColumnType ms2uRIXVR6;
    private string gL8uHXQiST;

    public ColumnType ColumnType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ms2uRIXVR6;
      }
    }

    public string ColumnFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gL8uHXQiST;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColumnMenuItem(ColumnType columnType, string columnFormat, MenuItem[] subItems, EventHandler handler)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.ms2uRIXVR6 = columnType;
      this.gL8uHXQiST = columnFormat;
      if (subItems != null)
        this.MenuItems.AddRange(subItems);
      this.Text = columnFormat == "" ? Column.ToString(columnType) : columnFormat;
      if (handler == null)
        return;
      this.Click += handler;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColumnMenuItem(ColumnType columnType, MenuItem[] subItems)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      this.\u002Ector(columnType, "", subItems, (EventHandler) null);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColumnMenuItem(ColumnType columnType, EventHandler handler)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      this.\u002Ector(columnType, "", (MenuItem[]) null, handler);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColumnMenuItem(ColumnType columnType, string format, EventHandler handler)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      this.\u002Ector(columnType, format, (MenuItem[]) null, handler);
    }
  }
}
