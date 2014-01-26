using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Trading.Conditions
{
  public class RulesParser
  {
    protected string text;

    
    public RulesParser(string text)
    {
      this.text = text;
    }

    
    public ArrayList Parse()
    {
      ArrayList arrayList = new ArrayList();
      this.RoWRVFG1Qx(this.text, 0, arrayList);
      return arrayList;
    }

    
    private void RoWRVFG1Qx([In] string obj0, [In] int obj1, [In] ArrayList obj2)
    {
    }
  }
}
