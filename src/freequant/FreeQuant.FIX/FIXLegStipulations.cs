// Type: SmartQuant.FIX.FIXLegStipulations
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXLegStipulations : FIXMessage
  {
    private ArrayList RrQZhV6g8c;

    [FIXField("683", EFieldOption.Optional)]
    public int NoLegStipulations
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(683).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(683, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXLegStipulations()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.RrQZhV6g8c = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXLegStipulationsGroup GetLegStipulationsGroup(int i)
    {
      if (i < this.NoLegStipulations)
        return (FIXLegStipulationsGroup) this.RrQZhV6g8c[i];
      else
        return (FIXLegStipulationsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXLegStipulationsGroup group)
    {
      this.RrQZhV6g8c.Add((object) group);
      ++this.NoLegStipulations;
    }
  }
}
