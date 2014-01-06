// Type: SmartQuant.FIX.FIXNestedParties
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXNestedParties : FIXMessage
  {
    private ArrayList obePoHEok;

    [FIXField("539", EFieldOption.Optional)]
    public int NoNestedPartyIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(539).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(539, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNestedParties()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.obePoHEok = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNestedPartyIDsGroup GetNestedPartyIDsGroup(int i)
    {
      if (i < this.NoNestedPartyIDs)
        return (FIXNestedPartyIDsGroup) this.obePoHEok[i];
      else
        return (FIXNestedPartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXNestedPartyIDsGroup group)
    {
      this.obePoHEok.Add((object) group);
      ++this.NoNestedPartyIDs;
    }
  }
}
