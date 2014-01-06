// Type: OpenQuant.Finam.Design.SessionDataTypeEditor
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using OpenQuant.Finam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace OpenQuant.Finam.Design
{
  public class SessionDataTypeEditor : UITypeEditor
  {
    public static Dictionary<string, TransaqSecurity> instruments = new Dictionary<string, TransaqSecurity>();
    public static Dictionary<int, string> markets = new Dictionary<int, string>();

    static SessionDataTypeEditor()
    {
    }

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
      IWindowsFormsEditorService formsEditorService = provider.GetService(typeof (IWindowsFormsEditorService)) as IWindowsFormsEditorService;
      if (formsEditorService != null)
      {
        SessionDataForm sessionDataForm = new SessionDataForm();
        sessionDataForm.Init(SessionDataTypeEditor.instruments, SessionDataTypeEditor.markets);
        int num = (int) formsEditorService.ShowDialog((Form) sessionDataForm);
      }
      return value;
    }
  }
}
