using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true)]
  public class FIXFieldAttribute : Attribute
  {
    protected int fTag;
    protected bool fRequired;

    public int Tag
    {
       get
      {
        return this.fTag;
      }
      set
      {
        this.fTag = value;
      }
    }

    public bool Required
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fRequired;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fRequired = value;
      }
    }

    public FIXFieldAttribute(int tag):base()
    {
      this.fTag = tag;
    }

    public FIXFieldAttribute(string Tag, EFieldOption Required):base()
    {
      this.fTag = int.Parse(Tag);
      if (Required != EFieldOption.Required)
        return;
      this.fRequired = true;
    }
  }
}
