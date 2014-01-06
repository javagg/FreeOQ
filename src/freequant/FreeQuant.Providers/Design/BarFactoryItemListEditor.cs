// Type: SmartQuant.Providers.Design.BarFactoryItemListEditor
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using SmartQuant.Providers;
using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartQuant.Providers.Design
{
  public class BarFactoryItemListEditor : CollectionEditor
  {
    private CollectionEditor.CollectionForm LogLcqLx6Q;

    public static event EventHandler ListChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarFactoryItemListEditor()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeof (BarFactoryItemList));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override CollectionEditor.CollectionForm CreateCollectionForm()
    {
      this.LogLcqLx6Q = base.CreateCollectionForm();
      this.LogLcqLx6Q.Closed += new EventHandler(this.ydDLvwReUA);
      return this.LogLcqLx6Q;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ydDLvwReUA([In] object obj0, [In] EventArgs obj1)
    {
      if (this.LogLcqLx6Q.DialogResult != DialogResult.OK || BarFactoryItemListEditor.DHbLBvAGVC == null)
        return;
      BarFactoryItemListEditor.DHbLBvAGVC((object) this, EventArgs.Empty);
    }
  }
}
