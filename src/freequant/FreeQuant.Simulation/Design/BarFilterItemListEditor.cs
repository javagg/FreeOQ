using FreeQuant.Simulation;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace FreeQuant.Simulation.Design
{
	public class BarFilterItemListEditor : CollectionEditor
	{
		private CollectionEditor.CollectionForm form;

		public static event EventHandler ListChanged;

		
		public BarFilterItemListEditor() :  base(typeof(List<BarFilterItem>))
		{
		}

		
		protected override CollectionEditor.CollectionForm CreateCollectionForm()
		{
			this.form = base.CreateCollectionForm();
			this.form.FormClosed += new FormClosedEventHandler(this.UWtSfYmpY);
			return this.form;
		}

		
		private void UWtSfYmpY(object sender, FormClosedEventArgs e)
		{
			if (this.form.DialogResult != DialogResult.OK || BarFilterItemListEditor.ListChanged == null)
				return;
			BarFilterItemListEditor.ListChanged(this, EventArgs.Empty);
		}
	}
}
