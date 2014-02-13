// Type: OpenQuant.Shared.Data.Management.CustomBarSeriesMenuItem
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal class CustomBarSeriesMenuItem : BarSeriesMenuItem
  {
    public override bool CreateSeries
    {
      get
      {
        NewBarSeriesForm newBarSeriesForm = new NewBarSeriesForm();
        bool flag;
        if (newBarSeriesForm.ShowDialog() == DialogResult.OK)
        {
          this.barType = newBarSeriesForm.BarType;
          this.barSize = newBarSeriesForm.BarSize;
          flag = true;
        }
        else
          flag = false;
        newBarSeriesForm.Dispose();
        return flag;
      }
    }

    public CustomBarSeriesMenuItem()
    {
      this.Text = "Custom...";
    }
  }
}
