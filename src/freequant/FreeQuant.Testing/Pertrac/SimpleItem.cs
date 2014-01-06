// Type: SmartQuant.Testing.Pertrac.SimpleItem
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using SmartQuant.Testing.TesterItems;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.Pertrac
{
  public class SimpleItem : TesterItem
  {
    protected string format;

    [Category("Properties")]
    public string Format
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.format;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.format = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleItem(string name, string format)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
      this.format = format;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleItem(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ValueToSrting()
    {
      return this.LastValue.ToString(this.format);
    }
  }
}
