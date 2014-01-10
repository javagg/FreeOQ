using FreeQuant.Providers;
using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.Providers.Design
{
  public class BarFactoryItemListEditor : CollectionEditor
  {
    private CollectionEditor.CollectionForm LogLcqLx6Q;

    public static event EventHandler ListChanged;

    
    public BarFactoryItemListEditor()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeof (BarFactoryItemList));
    }

    
    protected override CollectionEditor.CollectionForm CreateCollectionForm()
    {
      this.LogLcqLx6Q = base.CreateCollectionForm();
      this.LogLcqLx6Q.Closed += new EventHandler(this.ydDLvwReUA);
      return this.LogLcqLx6Q;
    }

    
    private void ydDLvwReUA([In] object obj0, [In] EventArgs obj1)
    {
      if (this.LogLcqLx6Q.DialogResult != DialogResult.OK || BarFactoryItemListEditor.DHbLBvAGVC == null)
        return;
      BarFactoryItemListEditor.DHbLBvAGVC((object) this, EventArgs.Empty);
    }
  }
}
