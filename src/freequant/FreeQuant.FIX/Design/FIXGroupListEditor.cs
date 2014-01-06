// Type: SmartQuant.FIX.Design.FIXGroupListEditor
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using SmartQuant.FIX;
using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartQuant.FIX.Design
{
  public class FIXGroupListEditor : CollectionEditor
  {
    private CollectionEditor.CollectionForm sbvZ5aZAaM;

    public static event EventHandler ListChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected FIXGroupListEditor(System.Type type)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(type);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXGroupListEditor()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      this.\u002Ector(typeof (FIXGroupList));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override CollectionEditor.CollectionForm CreateCollectionForm()
    {
      this.sbvZ5aZAaM = base.CreateCollectionForm();
      this.sbvZ5aZAaM.Closed += new EventHandler(this.p7XZxSg6C1);
      return this.sbvZ5aZAaM;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void p7XZxSg6C1([In] object obj0, [In] EventArgs obj1)
    {
      if (this.sbvZ5aZAaM.DialogResult != DialogResult.OK || FIXGroupListEditor.EilZgJcHBx == null)
        return;
      FIXGroupListEditor.EilZgJcHBx((object) this, EventArgs.Empty);
    }
  }
}
