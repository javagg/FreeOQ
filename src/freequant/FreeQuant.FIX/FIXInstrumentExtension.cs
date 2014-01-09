using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXInstrumentExtension : FIXMessage
  {
    private ArrayList hGw8TMaSJI;

    [FIXField("668", EFieldOption.Optional)]
    public int DeliveryForm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(668).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(668, value);
      }
    }

    [FIXField("869", EFieldOption.Optional)]
    public double PctAtRisk
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(869).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(869, value);
      }
    }

    [FIXField("870", EFieldOption.Optional)]
    public int NoInstrAttrib
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(870).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(870, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXInstrumentExtension(): base()
    {

      this.hGw8TMaSJI = new ArrayList();

    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXInstrAttribGroup GetInstrAttribGroup(int i)
    {
      if (i < this.NoInstrAttrib)
        return (FIXInstrAttribGroup) this.hGw8TMaSJI[i];
      else
        return (FIXInstrAttribGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXInstrAttribGroup group)
    {
      this.hGw8TMaSJI.Add((object) group);
      ++this.NoInstrAttrib;
    }
  }
}
