using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.IO;

namespace FreeQuant.FIXData
{
  public class Fundamental : FIXGroup, IDataObject, ISeriesObject, ICloneable
  {
    private const byte sc1R9Co0v = (byte) 1;
    private DateTime v4ZFuDIqA;
    private byte ITfawAy72;

    public double EarningsPerShare
    {
       get
      {
        return this.GetDoubleValue(10300);
      }
       set
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
       get
      {
        return this.GetDoubleValue(10303);
      }
       set
      {
        this.SetDoubleValue(10303, value);
      }
    }

    public double DebtPerShare
    {
       get
      {
        return this.GetDoubleValue(10304);
      }
       set
      {
        this.SetDoubleValue(10304, value);
      }
    }

    public double CashFlowPerShare
    {
       get
      {
        return this.GetDoubleValue(10305);
      }
       set
      {
        this.SetDoubleValue(10305, value);
      }
    }

    public double InterestPaymentPerShare
    {
       get
      {
        return this.GetDoubleValue(10306);
      }
       set
      {
        this.SetDoubleValue(10306, value);
      }
    }

    public byte ProviderId
    {
       get
      {
        return this.ITfawAy72;
      }
       set
      {
        this.ITfawAy72 = value;
      }
    }

    public DateTime DateTime
    {
       get
      {
        return this.v4ZFuDIqA;
      }
       set
      {
        this.v4ZFuDIqA = value;
      }
    }

   
    public ISeriesObject NewInstance()
    {
      return (ISeriesObject) new Fundamental();
    }

    
    public void WriteTo(BinaryWriter writer)
    {
      writer.Write((byte) 1);
      writer.Write(this.v4ZFuDIqA.Ticks);
      writer.Write(this.ITfawAy72);
      FIXGroupStreamer.WriteTo(writer, (FIXGroup) this);
    }

    
    public void ReadFrom(BinaryReader reader)
    {
      int num = (int) reader.ReadByte();
      this.v4ZFuDIqA = new DateTime(reader.ReadInt64());
      this.ITfawAy72 = reader.ReadByte();
      FIXGroupStreamer.ReadFrom(reader, (FIXGroup) this);
    }

    
    public object Clone()
    {
      return (object) this;
    }
  }
}
