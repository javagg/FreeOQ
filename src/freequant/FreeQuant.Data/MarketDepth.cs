using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.Data
{
  [Serializable]
  public class MarketDepth : IComparable, IDataObject, ICloneable, ISeriesObject
  {
    private const byte sP4fptbej = 3;
    private DateTime dateTime;
    private byte providerId;
    private string JLOpfyh4y;
    private string eg7FZMr0F;
    private int Me1WkVtkG;
    private MDOperation jPJqD9uF9;
    private MDSide B5WkwTEyx;
    private double G6iR5ebrL;
    private int zy1PMqcD3;

    public byte ProviderId
    {
        get
      {
				return this.providerId; 
      }
      set
      {
        this.providerId = value;
      }
    }

    public DateTime DateTime
    {
       get
      {
				return this.dateTime; 
      }
        set
      {
        this.dateTime = value;
      }
    }

    [View]
    public string MarketMaker
    {
      get
      {
        return this.JLOpfyh4y;
      }
       set
      {
        this.JLOpfyh4y = value;
      }
    }

    [View]
    public string Source
    {
        get
      {
        return this.eg7FZMr0F;
      }
      set
      {
        this.eg7FZMr0F = value;
      }
    }

    [View]
    public int Position
    {
      get
      {
        return this.Me1WkVtkG;
      }
       set
      {
        this.Me1WkVtkG = value;
      }
    }

    [View]
    public MDOperation Operation
    {
      get
      {
        return this.jPJqD9uF9;
      }
     set
      {
        this.jPJqD9uF9 = value;
      }
    }

    [View]
    public MDSide Side
    {
      get
      {
        return this.B5WkwTEyx;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.B5WkwTEyx = value;
      }
    }

    [PriceView]
    public double Price
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.G6iR5ebrL;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.G6iR5ebrL = value;
      }
    }

    [View]
    public int Size
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.zy1PMqcD3;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.zy1PMqcD3 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketDepth(DateTime datetime, byte providerId, string marketMaker, string source, int position, MDOperation operation, MDSide side, double price, int size)
    {
      this.dateTime = datetime;
      this.providerId = providerId;
      this.JLOpfyh4y = marketMaker;
      this.eg7FZMr0F = source;
      this.Me1WkVtkG = position;
      this.jPJqD9uF9 = operation;
      this.B5WkwTEyx = side;
      this.G6iR5ebrL = price;
      this.zy1PMqcD3 = size;
    }

	public MarketDepth() {}

	public MarketDepth(DateTime datetime, string marketMaker, int position, MDOperation operation, MDSide side, double price, int size):this(datetime, (byte) 0, marketMaker, "", position, operation, side, price, size)
    {

    }

		public MarketDepth(MarketDepth marketDepth):  this(marketDepth.dateTime, marketDepth.providerId, marketDepth.JLOpfyh4y, marketDepth.eg7FZMr0F, marketDepth.Me1WkVtkG, marketDepth.jPJqD9uF9, marketDepth.B5WkwTEyx, marketDepth.G6iR5ebrL, marketDepth.zy1PMqcD3)
    {
    }

    public int CompareTo(object obj)
    {
      if (obj is MarketDepth)
        return this.G6iR5ebrL.CompareTo((obj as MarketDepth).G6iR5ebrL);
      else
			throw new ArgumentException("" + obj.GetType().ToString());
    }

    public virtual void WriteTo(BinaryWriter writer)
    {
      writer.Write((byte) 3);
      writer.Write(this.dateTime.Ticks);
      writer.Write(this.JLOpfyh4y);
      writer.Write(this.eg7FZMr0F);
      writer.Write((byte) this.B5WkwTEyx);
      writer.Write(this.G6iR5ebrL);
      writer.Write(this.zy1PMqcD3);
      writer.Write(this.providerId);
      writer.Write(this.Me1WkVtkG);
      writer.Write((byte) this.jPJqD9uF9);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ReadFrom(BinaryReader reader)
    {
      byte num = reader.ReadByte();
      switch (num)
      {
        case (byte) 1:
          this.dateTime = new DateTime(reader.ReadInt64());
          this.JLOpfyh4y = reader.ReadString();
          this.eg7FZMr0F = reader.ReadString();
          this.B5WkwTEyx = (MDSide) reader.ReadByte();
          this.G6iR5ebrL = Math.Round((double) reader.ReadSingle(), 4);
          this.zy1PMqcD3 = reader.ReadInt32();
          this.providerId = reader.ReadByte();
          this.Me1WkVtkG = -1;
          this.jPJqD9uF9 = MDOperation.Undefined;
          break;
        case (byte) 2:
          this.dateTime = new DateTime(reader.ReadInt64());
          this.JLOpfyh4y = reader.ReadString();
          this.eg7FZMr0F = reader.ReadString();
          this.B5WkwTEyx = (MDSide) reader.ReadByte();
          this.G6iR5ebrL = Math.Round((double) reader.ReadSingle(), 4);
          this.zy1PMqcD3 = reader.ReadInt32();
          this.providerId = reader.ReadByte();
          this.Me1WkVtkG = reader.ReadInt32();
          this.jPJqD9uF9 = (MDOperation) reader.ReadByte();
          break;
        case (byte) 3:
          this.dateTime = new DateTime(reader.ReadInt64());
          this.JLOpfyh4y = reader.ReadString();
          this.eg7FZMr0F = reader.ReadString();
          this.B5WkwTEyx = (MDSide) reader.ReadByte();
          this.G6iR5ebrL = reader.ReadDouble();
          this.zy1PMqcD3 = reader.ReadInt32();
          this.providerId = reader.ReadByte();
          this.Me1WkVtkG = reader.ReadInt32();
          this.jPJqD9uF9 = (MDOperation) reader.ReadByte();
          break;
        default:
			throw new Exception(""+ (object) num);
      }
    }

    public virtual ISeriesObject NewInstance()
    {
      return (ISeriesObject) new MarketDepth();
    }

    public virtual object Clone()
    {
      return (object) new MarketDepth(this);
    }

  }
}
