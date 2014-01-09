using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
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
    public FIXNestedPartyIDsGroup():base()
    {

      this.NvIAsyYcl0 = new ArrayList();

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
