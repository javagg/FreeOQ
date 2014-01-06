// Type: SmartQuant.Simulation.Design.BarFilterItemListEditor
// Assembly: SmartQuant.Simulation, Version=1.0.5036.28353, Culture=neutral, PublicKeyToken=null
// MVID: 7CFB1E94-1672-436F-90C9-C8B7893A5618
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Simulation.dll

using CJ5Xsgeg9JvhJUnvO3D;
using SmartQuant.Simulation;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartQuant.Simulation.Design
{
  public class BarFilterItemListEditor : CollectionEditor
  {
    private CollectionEditor.CollectionForm tmvwQYAsq;

    public static event EventHandler ListChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarFilterItemListEditor()
    {
      eekpcgzPjZLOyP2Ysv.eyppkuTzDkifX();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeof (List<BarFilterItem>));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override CollectionEditor.CollectionForm CreateCollectionForm()
    {
      this.tmvwQYAsq = base.CreateCollectionForm();
      this.tmvwQYAsq.FormClosed += new FormClosedEventHandler(this.UWtSfYmpY);
      return this.tmvwQYAsq;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UWtSfYmpY([In] object obj0, [In] FormClosedEventArgs obj1)
    {
      if (this.tmvwQYAsq.DialogResult != DialogResult.OK || BarFilterItemListEditor.ODbclBde0 == null)
        return;
      BarFilterItemListEditor.ODbclBde0((object) this, EventArgs.Empty);
    }
  }
}
