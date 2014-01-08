using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
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

  }
}
