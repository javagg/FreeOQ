using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCollInquiryQualifierGroup : FIXGroup
  {
    [FIXField("896", EFieldOption.Optional)]
    public int CollInquiryQualifier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(896).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(896, value);
      }
    }

  }
}
