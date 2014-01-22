using FreeQuant.Simulation;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.Simulation.Design
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
