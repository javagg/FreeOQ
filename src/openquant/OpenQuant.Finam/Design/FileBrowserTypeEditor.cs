// Type: OpenQuant.Finam.Design.FileBrowserTypeEditor
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using SmartQuant;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace OpenQuant.Finam.Design
{
  public class FileBrowserTypeEditor : UITypeEditor
  {
    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
    {
      if (context != null && context.Instance != null)
        return UITypeEditorEditStyle.Modal;
      else
        return base.GetEditStyle(context);
    }

    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
    {
      if (context == null || context.Instance == null || provider == null)
        return base.EditValue(context, provider, value);
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      if (string.IsNullOrWhiteSpace((string) value))
        folderBrowserDialog.SelectedPath = Framework.Installation.LogDir.FullName;
      folderBrowserDialog.SelectedPath = (string) value;
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        return (object) folderBrowserDialog.SelectedPath;
      else
        return (object) Framework.Installation.LogDir.FullName;
    }
  }
}
