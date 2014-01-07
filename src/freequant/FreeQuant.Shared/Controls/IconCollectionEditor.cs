// Type: SmartQuant.Shared.Controls.IconCollectionEditor
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Controls
{
  public class IconCollectionEditor : CollectionEditor
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IconCollectionEditor()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeof (IconCollection));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override object CreateInstance(System.Type itemType)
    {
      if (itemType == typeof (Icon))
      {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Multiselect = false;
        openFileDialog.CheckFileExists = true;
        openFileDialog.Filter = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11202);
        if (openFileDialog.ShowDialog() == DialogResult.OK)
          return (object) new Icon(openFileDialog.FileName);
        openFileDialog.Dispose();
      }
      throw new ArgumentException(RNaihRhYEl0wUmAftnB.aYu7exFQKN(11244) + itemType.ToString());
    }
  }
}
