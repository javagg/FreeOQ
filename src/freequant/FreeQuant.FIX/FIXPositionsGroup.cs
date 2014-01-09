using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPositionsGroup : FIXGroup
  {
    private ArrayList Mkcupst1Wb;

    [FIXField("703", EFieldOption.Optional)]
    public string PosType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(703);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(703, value);
      }
    }

    [FIXField("704", EFieldOption.Optional)]
    public double LongQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(704);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(704, value);
      }
    }

    [FIXField("705", EFieldOption.Optional)]
    public double ShortQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(705);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(705, value);
      }
    }

    [FIXField("706", EFieldOption.Optional)]
    public int PosQtyStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(706);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(706, value);
      }
    }

    [FIXField("539", EFieldOption.Optional)]
    public int NoNestedPartyIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(539);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(539, value);
      }
    }

    public FIXPositionsGroup(): base()
    {

      this.Mkcupst1Wb = new ArrayList();
    }
    public FIXNestedPartyIDsGroup GetNestedPartyIDsGroup(int i)
    {
      if (i < this.NoNestedPartyIDs)
        return (FIXNestedPartyIDsGroup) this.Mkcupst1Wb[i];
      else
        return (FIXNestedPartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXNestedPartyIDsGroup group)
    {
      this.Mkcupst1Wb.Add((object) group);
      ++this.NoNestedPartyIDs;
    }
  }
}
