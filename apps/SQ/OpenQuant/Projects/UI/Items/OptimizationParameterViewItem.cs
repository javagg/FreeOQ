// Type: OpenQuant.Projects.UI.Items.OptimizationParameterViewItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Trading;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Items
{
  public class OptimizationParameterViewItem : ListViewItem
  {
    private OptimizationParameter parameter;

    public OptimizationParameter Parameter
    {
      get
      {
        return this.parameter;
      }
    }

    public OptimizationParameterViewItem(OptimizationParameter parameter)
    {
      this.parameter = parameter;
      this.Text = parameter.get_Name();
      this.SubItems.Add(parameter.get_Strategy());
      this.SubItems.Add(parameter.get_Start().ToString());
      this.SubItems.Add(parameter.get_Stop().ToString());
      this.SubItems.Add(parameter.get_Step().ToString());
      this.Checked = parameter.get_Enabled();
    }
  }
}
