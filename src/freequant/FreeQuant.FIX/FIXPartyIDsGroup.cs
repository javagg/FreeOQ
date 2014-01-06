// Type: SmartQuant.FIX.FIXPartyIDsGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXPartyIDsGroup : FIXGroup
  {
    private ArrayList tW1yCJpdsG;

    [FIXField("448", EFieldOption.Optional)]
    public string PartyID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(448).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(448, value);
      }
    }

    [FIXField("447", EFieldOption.Optional)]
    public char PartyIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(447).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(447, value);
      }
    }

    [FIXField("452", EFieldOption.Optional)]
    public int PartyRole
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(452).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(452, value);
      }
    }

    [FIXField("802", EFieldOption.Optional)]
    public int NoPartySubIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(802).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(802, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPartyIDsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.tW1yCJpdsG = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPartySubIDsGroup GetPartySubIDsGroup(int i)
    {
      if (i < this.NoPartySubIDs)
        return (FIXPartySubIDsGroup) this.tW1yCJpdsG[i];
      else
        return (FIXPartySubIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXPartySubIDsGroup group)
    {
      this.tW1yCJpdsG.Add((object) group);
      ++this.NoPartySubIDs;
    }
  }
}
