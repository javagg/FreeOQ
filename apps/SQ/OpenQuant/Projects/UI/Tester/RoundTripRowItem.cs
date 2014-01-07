// Type: OpenQuant.Projects.UI.Tester.RoundTripRowItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Testing.TesterItems;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Tester
{
  public class RoundTripRowItem : ListViewItem
  {
    protected SeriesTesterItem component1;
    protected SeriesTesterItem component2;
    protected SeriesTesterItem component3;
    protected string title;

    public SeriesTesterItem Component1
    {
      get
      {
        return this.component1;
      }
      set
      {
        this.component1 = value;
      }
    }

    public SeriesTesterItem Component2
    {
      get
      {
        return this.component2;
      }
      set
      {
        this.component2 = value;
      }
    }

    public SeriesTesterItem Component3
    {
      get
      {
        return this.component3;
      }
      set
      {
        this.component3 = value;
      }
    }

    public RoundTripRowItem(SeriesTesterItem component1, SeriesTesterItem component2, SeriesTesterItem component3, string title)
    {
      this.component1 = component1;
      this.component2 = component2;
      this.component3 = component3;
      this.title = title;
      this.SubItems[0].Text = title;
      this.SubItems.Add(component1.ValueToSrting());
      this.SubItems.Add(component2.ValueToSrting());
      this.SubItems.Add(component3.ValueToSrting());
    }

    public void UpdateText()
    {
      this.SubItems[0].Text = this.title;
      this.SubItems[1].Text = this.component1.ValueToSrting();
      this.SubItems[2].Text = this.component2.ValueToSrting();
      this.SubItems[3].Text = this.component3.ValueToSrting();
    }

    public void UpdateText(string format)
    {
      this.SubItems[0].Text = this.title;
      this.SubItems[1].Text = this.component1.ValueToSrting(format);
      this.SubItems[2].Text = this.component2.ValueToSrting(format);
      this.SubItems[3].Text = this.component3.ValueToSrting(format);
    }
  }
}
