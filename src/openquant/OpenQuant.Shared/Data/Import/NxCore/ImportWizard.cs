// Type: OpenQuant.Shared.Data.Import.NxCore.ImportWizard
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.NxCore
{
  public static class ImportWizard
  {
    public static void Run(IWin32Window owner)
    {
      ImportSettings settings = new ImportSettings();
      ImportSettingsForm importSettingsForm = new ImportSettingsForm();
      importSettingsForm.Init(settings);
      if (importSettingsForm.ShowDialog(owner) == DialogResult.OK)
      {
        ImportForm importForm = new ImportForm();
        importForm.Init(settings);
        int num = (int) importForm.ShowDialog(owner);
        importForm.Dispose();
      }
      importSettingsForm.Dispose();
    }
  }
}
