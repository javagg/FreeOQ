using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIXData
{
  public class Fundamental : FIXGroup, IDataObject, ISeriesObject, ICloneable
  {
    private const byte sc1R9Co0v = (byte) 1;
    private DateTime v4ZFuDIqA;
    private byte ITfawAy72;

    public double EarningsPerShare
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(10300);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(10300, value);
      }
    }

    public double CashPerShare
    {
      get
      {
        return this.GetDoubleValue(10302);
      }
      set
      {
        this.SetDoubleValue(10302, value);
      }
    }

    public double RevenuePerShare
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(10303);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(10303, value);
      }
    }

    public double DebtPerShare
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(10304);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(10304, value);
      }
    }

    public double CashFlowPerShare
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(10305);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(10305, value);
      }
    }

    public double InterestPaymentPerShare
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(10306);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(10306, value);
      }
    }

    public byte ProviderId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ITfawAy72;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.ITfawAy72 = value;
      }
    }

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.v4ZFuDIqA;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.v4ZFuDIqA = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Fundamental()
    {
      aHVXF4EQTqOeMK8FH8.jYIb1Y6zBfgK8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ISeriesObject NewInstance()
    {
      return (ISeriesObject) new Fundamental();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WriteTo(BinaryWriter writer)
    {
      writer.Write((byte) 1);
      writer.Write(this.v4ZFuDIqA.Ticks);
      writer.Write(this.ITfawAy72);
      FIXGroupStreamer.WriteTo(writer, (FIXGroup) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReadFrom(BinaryReader reader)
    {
      int num = (int) reader.ReadByte();
      this.v4ZFuDIqA = new DateTime(reader.ReadInt64());
      this.ITfawAy72 = reader.ReadByte();
      FIXGroupStreamer.ReadFrom(reader, (FIXGroup) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object Clone()
    {
      return (object) this;
    }
  }
}
