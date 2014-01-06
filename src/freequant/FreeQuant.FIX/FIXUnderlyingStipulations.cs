// Type: SmartQuant.FIX.FIXUnderlyingStipulations
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXUnderlyingStipulations : FIXMessage
  {
    private ArrayList lpUAFXjiTC;

    [FIXField("887", EFieldOption.Optional)]
    public int NoUnderlyingStips
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(887).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(887, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingStipulations()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.lpUAFXjiTC = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingStipsGroup GetUnderlyingStipsGroup(int i)
    {
      if (i < this.NoUnderlyingStips)
        return (FIXUnderlyingStipsGroup) this.lpUAFXjiTC[i];
      else
        return (FIXUnderlyingStipsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXUnderlyingStipsGroup group)
    {
      this.lpUAFXjiTC.Add((object) group);
      ++this.NoUnderlyingStips;
    }
  }
}
