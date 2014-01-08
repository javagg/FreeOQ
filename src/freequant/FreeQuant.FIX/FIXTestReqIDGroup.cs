using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTestReqIDGroup : FIXGroup
  {
    [FIXField("112", EFieldOption.Required)]
    public string TestReqID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(112).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(112, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTestReqIDGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTestReqIDGroup(string TestReqID)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.TestReqID = TestReqID;
    }
  }
}
