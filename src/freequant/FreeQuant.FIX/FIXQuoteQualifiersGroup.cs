// Type: SmartQuant.FIX.FIXQuoteQualifiersGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXQuoteQualifiersGroup : FIXGroup
  {
    [FIXField("695", EFieldOption.Optional)]
    public char QuoteQualifier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(695).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(695, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXQuoteQualifiersGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
