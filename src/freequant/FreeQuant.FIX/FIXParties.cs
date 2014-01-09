using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXParties : FIXMessage
  {
    private ArrayList IpRqLjjJg;

    [FIXField("453", EFieldOption.Optional)]
    public int NoPartyIDs
    {
      get
      {
        return this.GetIntField(453).Value;
      }
      set
      {
        this.AddIntField(453, value);
      }
    }

    public FIXParties():base()
    {
      this.IpRqLjjJg = new ArrayList();
    }

    public FIXPartyIDsGroup GetPartyIDsGroup(int i)
    {
      if (i < this.NoPartyIDs)
        return (FIXPartyIDsGroup) this.IpRqLjjJg[i];
      else
        return (FIXPartyIDsGroup) null;
    }

    public void AddGroup(FIXPartyIDsGroup group)
    {
      this.IpRqLjjJg.Add((object) group);
      ++this.NoPartyIDs;
    }
  }
}
