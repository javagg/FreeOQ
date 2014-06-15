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

        public BarFactoryItemListEditor() : base(typeof(BarFactoryItemList))
        {
        }

        protected override CollectionEditor.CollectionForm CreateCollectionForm()
        {
            this.form = base.CreateCollectionForm();
            this.form.Closed += (sender, e) => 
            {
                if (this.form.DialogResult != DialogResult.OK || BarFactoryItemListEditor.ListChanged == null)
                    return;
                BarFactoryItemListEditor.ListChanged(this, EventArgs.Empty);
            };
            return this.form;
        }
    }
}
