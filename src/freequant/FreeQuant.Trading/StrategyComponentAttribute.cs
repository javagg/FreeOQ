
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
  public class StrategyComponentAttribute : Attribute
  {
    private Guid FKt6afUVYg;
    private ComponentType Fgf6t1InAZ;
    private string qUB6dnbNLe;
    private string npb6wakWaw;

    public Guid GUID
    {
      get
      {
        return this.FKt6afUVYg;
      }
    }

    public ComponentType Type
    {
      get
      {
        return this.Fgf6t1InAZ;
      }
    }

    public string Name
    {
      get
      {
        return this.qUB6dnbNLe;
      }
      set
      {
        this.qUB6dnbNLe = value;
      }
    }

    public string Description
    {
      get
      {
        return this.npb6wakWaw;
      }
      set
      {
        this.npb6wakWaw = value;
      }
    }

   
		public StrategyComponentAttribute(string guid, ComponentType type):base()
    {

      this.FKt6afUVYg = new Guid(guid);
      this.Fgf6t1InAZ = type;
      this.qUB6dnbNLe = (string) null;
      this.npb6wakWaw = (string) null;
    }
  }
}
