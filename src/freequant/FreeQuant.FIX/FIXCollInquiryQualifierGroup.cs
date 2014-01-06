// Type: SmartQuant.FIX.FIXCollInquiryQualifierGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXCollInquiryQualifierGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
