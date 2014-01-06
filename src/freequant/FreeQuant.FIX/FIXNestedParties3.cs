// Type: SmartQuant.FIX.FIXNestedParties3
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXNestedParties3 : FIXMessage
  {
    private ArrayList aYBQQmRTGU;

    [FIXField("948", EFieldOption.Optional)]
    public int NoNested3PartyIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(948).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(948, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNestedParties3()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.aYBQQmRTGU = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNested3PartyIDsGroup GetNested3PartyIDsGroup(int i)
    {
      if (i < this.NoNested3PartyIDs)
        return (FIXNested3PartyIDsGroup) this.aYBQQmRTGU[i];
      else
        return (FIXNested3PartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXNested3PartyIDsGroup group)
    {
      this.aYBQQmRTGU.Add((object) group);
      ++this.NoNested3PartyIDs;
    }
  }
}
