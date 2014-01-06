// Type: SmartQuant.Simulation.BarFilter
// Assembly: SmartQuant.Simulation, Version=1.0.5036.28353, Culture=neutral, PublicKeyToken=null
// MVID: 7CFB1E94-1672-436F-90C9-C8B7893A5618
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Simulation.dll

using CJ5Xsgeg9JvhJUnvO3D;
using ETwk6SvHPJSw9nYkWy;
using SmartQuant;
using SmartQuant.Data;
using SmartQuant.Simulation.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Y9kGLiKILMabFE38T3;

namespace SmartQuant.Simulation
{
  [TypeConverter(typeof (YYAsqAaDblBde0lNpo))]
  public class BarFilter
  {
    private bool UIpyWbdsFD;
    private List<BarFilterItem> nl6yODbWN0;

    [DefaultValue(false)]
    public bool Enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.UIpyWbdsFD;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.UIpyWbdsFD = value;
      }
    }

    [Editor(typeof (BarFilterItemListEditor), typeof (UITypeEditor))]
    public List<BarFilterItem> Items
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nl6yODbWN0;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarFilter()
    {
      eekpcgzPjZLOyP2Ysv.eyppkuTzDkifX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.nl6yODbWN0 = new List<BarFilterItem>();
      this.UIpyWbdsFD = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(BarType barType, long barSize)
    {
      if (!this.UIpyWbdsFD)
        return true;
      foreach (BarFilterItem barFilterItem in this.nl6yODbWN0)
      {
        if (barFilterItem.BarType == barType && barFilterItem.BarSize == barSize)
          return barFilterItem.Enabled;
      }
      return false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset()
    {
      this.UIpyWbdsFD = false;
      this.nl6yODbWN0.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      List<string> list = new List<string>();
      list.Add(this.UIpyWbdsFD.ToString());
      foreach (BarFilterItem barFilterItem in this.nl6yODbWN0)
        list.Add(string.Format(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(2448), (object) (bool) (barFilterItem.Enabled ? 1 : 0), (object) barFilterItem.BarType, (object) barFilterItem.BarSize));
      return string.Join(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(2474), list.ToArray());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Vx1yomJJIf([In] string obj0)
    {
      try
      {
        this.Reset();
        string[] strArray1 = obj0.Split(new char[1]
        {
          '-'
        });
        this.UIpyWbdsFD = bool.Parse(strArray1[0]);
        for (int index = 1; index < strArray1.Length; ++index)
        {
          string[] strArray2 = strArray1[index].Split(new char[1]
          {
            ','
          });
          this.nl6yODbWN0.Add(new BarFilterItem((BarType) Enum.Parse(typeof (BarType), strArray2[1]), long.Parse(strArray2[2]), bool.Parse(strArray2[0])));
        }
      }
      catch (Exception ex)
      {
        if (Trace.IsLevelEnabled(TraceLevel.Error))
          Trace.WriteLine(((object) ex).ToString());
        this.Reset();
      }
    }
  }
}
