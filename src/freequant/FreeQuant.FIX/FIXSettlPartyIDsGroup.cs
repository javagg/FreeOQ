// Type: SmartQuant.FIX.FIXSettlPartyIDsGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXSettlPartyIDsGroup : FIXGroup
  {
    private ArrayList rTwtW5j0d5;

    [FIXField("782", EFieldOption.Optional)]
    public string SettlPartyID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(782).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(782, value);
      }
    }

    [FIXField("783", EFieldOption.Optional)]
    public char SettlPartyIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(783).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(783, value);
      }
    }

    [FIXField("784", EFieldOption.Optional)]
    public int SettlPartyRole
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(784).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(784, value);
      }
    }

    [FIXField("801", EFieldOption.Optional)]
    public int NoSettlPartySubIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(801).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(801, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSettlPartyIDsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.rTwtW5j0d5 = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSettlPartySubIDsGroup GetSettlPartySubIDsGroup(int i)
    {
      if (i < this.NoSettlPartySubIDs)
        return (FIXSettlPartySubIDsGroup) this.rTwtW5j0d5[i];
      else
        return (FIXSettlPartySubIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXSettlPartySubIDsGroup group)
    {
      this.rTwtW5j0d5.Add((object) group);
      ++this.NoSettlPartySubIDs;
    }
  }
}
