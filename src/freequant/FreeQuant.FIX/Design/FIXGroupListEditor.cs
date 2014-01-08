using FreeQuant.FIX;
using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.FIX.Design
{
  public class FIXGroupListEditor : CollectionEditor
  {
    private CollectionEditor.CollectionForm sbvZ5aZAaM;

    public static event EventHandler ListChanged;

	protected FIXGroupListEditor(System.Type type) : base(type)
    {

    }

	public FIXGroupListEditor() : this(typeof (FIXGroupList))
    {

    }

    protected override CollectionEditor.CollectionForm CreateCollectionForm()
    {
      this.sbvZ5aZAaM = base.CreateCollectionForm();
      this.sbvZ5aZAaM.Closed += new EventHandler(this.p7XZxSg6C1);
      return this.sbvZ5aZAaM;
    }

    private void p7XZxSg6C1([In] object obj0, [In] EventArgs obj1)
    {
      if (this.sbvZ5aZAaM.DialogResult != DialogResult.OK || FIXGroupListEditor.EilZgJcHBx == null)
        return;
      FIXGroupListEditor.EilZgJcHBx((object) this, EventArgs.Empty);
    }
  }
}
