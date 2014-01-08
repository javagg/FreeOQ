using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXDlvyInstGroup : FIXGroup
  {
    private ArrayList zSFuvPUpI5;

    [FIXField("165", EFieldOption.Optional)]
    public char SettlInstSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(165).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(165, value);
      }
    }

    [FIXField("787", EFieldOption.Optional)]
    public char DlvyInstType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(787).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(787, value);
      }
    }

    [FIXField("781", EFieldOption.Optional)]
    public int NoSettlPartyIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(781).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(781, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXDlvyInstGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.zSFuvPUpI5 = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSettlPartyIDsGroup GetSettlPartyIDsGroup(int i)
    {
      if (i < this.NoSettlPartyIDs)
        return (FIXSettlPartyIDsGroup) this.zSFuvPUpI5[i];
      else
        return (FIXSettlPartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXSettlPartyIDsGroup group)
    {
      this.zSFuvPUpI5.Add((object) group);
      ++this.NoSettlPartyIDs;
    }
  }
}
