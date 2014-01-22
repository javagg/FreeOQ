using FreeQuant.Testing.TesterItems;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class SimpleItem : TesterItem
  {
    protected string format;

    [Category("Properties")]
    public string Format
    {
       get
      {
        return this.format;
      }
       set
      {
        this.format = value;
      }
    }

    
		public SimpleItem(string name, string format) :base(name)
    {

      this.format = format;
    }

    
		public SimpleItem(string name) : base(name)
    {

    }

    
    public override string ValueToSrting()
    {
      return this.LastValue.ToString(this.format);
    }
  }
}
