// Type: OpenQuant.Projects.UI.Tester.TesterComponentItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Testing.TesterItems;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Tester
{
  public class TesterComponentItem : ListViewItem
  {
    protected TesterItem component;

    public TesterItem Component
    {
      get
      {
        return this.component;
      }
      set
      {
        this.component = value;
      }
    }

    public TesterComponentItem(TesterItem component)
    {
      this.component = component;
      this.SubItems[0].Text = component.Name;
      this.SubItems.Add(component.ValueToSrting());
    }

    public void UpdateText()
    {
      this.SubItems[0].Text = this.component.Name;
      this.SubItems[1].Text = this.component.ValueToSrting();
    }

    public void UpdateText(string format)
    {
      this.SubItems[0].Text = this.component.Name;
      this.SubItems[1].Text = this.component.ValueToSrting(format);
    }
  }
}
