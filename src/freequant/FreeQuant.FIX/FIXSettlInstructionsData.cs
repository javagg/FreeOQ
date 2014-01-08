using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSettlInstructionsData : FIXMessage
  {
    private ArrayList SZvZYfTgiZ;

    [FIXField("172", EFieldOption.Optional)]
    public int SettlDeliveryType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(172).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(172, value);
      }
    }

    [FIXField("169", EFieldOption.Optional)]
    public int StandInstDbType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(169).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(169, value);
      }
    }

    [FIXField("170", EFieldOption.Optional)]
    public string StandInstDbName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(170).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(170, value);
      }
    }

    [FIXField("171", EFieldOption.Optional)]
    public string StandInstDbID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(171).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(171, value);
      }
    }

    [FIXField("85", EFieldOption.Optional)]
    public int NoDlvyInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(85).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(85, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSettlInstructionsData()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.SZvZYfTgiZ = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXDlvyInstGroup GetDlvyInstGroup(int i)
    {
      if (i < this.NoDlvyInst)
        return (FIXDlvyInstGroup) this.SZvZYfTgiZ[i];
      else
        return (FIXDlvyInstGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXDlvyInstGroup group)
    {
      this.SZvZYfTgiZ.Add((object) group);
      ++this.NoDlvyInst;
    }
  }
}
