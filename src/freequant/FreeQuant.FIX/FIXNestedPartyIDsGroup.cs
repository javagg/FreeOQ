// Type: SmartQuant.FIX.FIXNestedPartyIDsGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXNestedPartyIDsGroup : FIXGroup
  {
    private ArrayList NvIAsyYcl0;

    [FIXField("524", EFieldOption.Optional)]
    public string NestedPartyID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(524).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(524, value);
      }
    }

    [FIXField("525", EFieldOption.Optional)]
    public char NestedPartyIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(525).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(525, value);
      }
    }

    [FIXField("538", EFieldOption.Optional)]
    public int NestedPartyRole
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(538).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(538, value);
      }
    }

    [FIXField("804", EFieldOption.Optional)]
    public int NoNestedPartySubIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(804).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(804, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNestedPartyIDsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.NvIAsyYcl0 = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNestedPartySubIDsGroup GetNestedPartySubIDsGroup(int i)
    {
      if (i < this.NoNestedPartySubIDs)
        return (FIXNestedPartySubIDsGroup) this.NvIAsyYcl0[i];
      else
        return (FIXNestedPartySubIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXNestedPartySubIDsGroup group)
    {
      this.NvIAsyYcl0.Add((object) group);
      ++this.NoNestedPartySubIDs;
    }
  }
}
