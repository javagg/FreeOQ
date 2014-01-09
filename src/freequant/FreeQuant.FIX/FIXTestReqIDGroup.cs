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


    public FIXTestReqIDGroup(string TestReqID) :base()
    {
      this.TestReqID = TestReqID;
    }
  }
}
