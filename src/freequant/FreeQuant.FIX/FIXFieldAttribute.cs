// Type: SmartQuant.FIX.FIXFieldAttribute
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true)]
  public class FIXFieldAttribute : Attribute
  {
    protected int fTag;
    protected bool fRequired;

    public int Tag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTag;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXFieldAttribute(int tag)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fTag = tag;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXFieldAttribute(string Tag, EFieldOption Required)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fTag = int.Parse(Tag);
      if (Required != EFieldOption.Required)
        return;
      this.fRequired = true;
    }
  }
}
