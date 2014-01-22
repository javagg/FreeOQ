using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Components
{
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
  public class TesterComponentAttribute : Attribute
  {
    private Guid OKRyrLQ5yq;
    private string e85yyNrFBe;
    private string WJPyeJlI4g;

    public Guid GUID
    {
       get
      {
        return this.OKRyrLQ5yq;
      }
    }

    public string Name
    {
       get
      {
        return this.e85yyNrFBe;
      }
       set
      {
        this.e85yyNrFBe = value;
      }
    }

    public string Description
    {
       get
      {
        return this.WJPyeJlI4g;
      }
       set
      {
        this.WJPyeJlI4g = value;
      }
    }

    
		public TesterComponentAttribute(string guid):base()
    {

      this.OKRyrLQ5yq = new Guid(guid);
      this.e85yyNrFBe = (string) null;
      this.WJPyeJlI4g = (string) null;
    }
  }
}
