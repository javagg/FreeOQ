using FreeQuant.Providers;
using System;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace FreeQuant.Providers.Design
{
  public class BarFactoryItemListEditor : CollectionEditor
  {
    private CollectionEditor.CollectionForm form;

    public static event EventHandler ListChanged;

    
    public BarFactoryItemListEditor() :  base(typeof(BarFactoryItemList))
    {
    }

    
    protected override CollectionEditor.CollectionForm CreateCollectionForm()
    {
      this.form = base.CreateCollectionForm();
      this.form.Closed += new EventHandler(this.ydDLvwReUA);
      return this.form;
    }

    
    private void ydDLvwReUA(object obj0, EventArgs obj1)
    {
      if (this.form.DialogResult != DialogResult.OK || BarFactoryItemListEditor.ListChanged == null)
        return;
      BarFactoryItemListEditor.ListChanged(this, EventArgs.Empty);
    }
  }
}
