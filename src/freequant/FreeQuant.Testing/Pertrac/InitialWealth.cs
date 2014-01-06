// Type: SmartQuant.Testing.Pertrac.InitialWealth
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using ASQMKC8WePBGJ83PL4;
using Byqm85MNrFBe6JPJlI;
using SmartQuant.Testing;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.Pertrac
{
  public class InitialWealth : SimpleItem
  {
    protected LiveTester tester;

    public override double LastValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.tester.InitialWealth;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InitialWealth(string name, LiveTester tester, string format)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, format);
      this.tester = tester;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InitialWealth(string name, LiveTester tester)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2098));
      this.tester = tester;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InitialWealth(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
    }
  }
}
