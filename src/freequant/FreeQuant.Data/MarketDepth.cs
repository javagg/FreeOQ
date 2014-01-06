// Type: SmartQuant.Data.MarketDepth
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using oL6nXjcX2wYBRbhX2q;
using RadDBE9P5I945u5gCE;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.Data
{
  [Serializable]
  public class MarketDepth : IComparable, IDataObject, ICloneable, ISeriesObject
  {
    private const byte sP4fptbej = (byte) 3;
    private DateTime R3W3NAEij;
    private byte wjav9oO6m;
    private string JLOpfyh4y;
    private string eg7FZMr0F;
    private int Me1WkVtkG;
    private MDOperation jPJqD9uF9;
    private MDSide B5WkwTEyx;
    private double G6iR5ebrL;
    private int zy1PMqcD3;

    public byte ProviderId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.wjav9oO6m;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.wjav9oO6m = value;
      }
    }

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.R3W3NAEij;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.R3W3NAEij = value;
      }
    }

    [View]
    public string MarketMaker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.JLOpfyh4y;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.JLOpfyh4y = value;
      }
    }

    [View]
    public string Source
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.eg7FZMr0F;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.eg7FZMr0F = value;
      }
    }

    [View]
    public int Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Me1WkVtkG;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Me1WkVtkG = value;
      }
    }

    [View]
    public MDOperation Operation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jPJqD9uF9;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.jPJqD9uF9 = value;
      }
    }

    [View]
    public MDSide Side
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
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
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.R3W3NAEij = datetime;
      this.wjav9oO6m = providerId;
      this.JLOpfyh4y = marketMaker;
      this.eg7FZMr0F = source;
      this.Me1WkVtkG = position;
      this.jPJqD9uF9 = operation;
      this.B5WkwTEyx = side;
      this.G6iR5ebrL = price;
      this.zy1PMqcD3 = size;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketDepth(DateTime datetime, string marketMaker, int position, MDOperation operation, MDSide side, double price, int size)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(datetime, (byte) 0, marketMaker, "", position, operation, side, price, size);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketDepth(MarketDepth marketDepth)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      this.\u002Ector(marketDepth.R3W3NAEij, marketDepth.wjav9oO6m, marketDepth.JLOpfyh4y, marketDepth.eg7FZMr0F, marketDepth.Me1WkVtkG, marketDepth.jPJqD9uF9, marketDepth.B5WkwTEyx, marketDepth.G6iR5ebrL, marketDepth.zy1PMqcD3);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketDepth()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(object obj)
    {
      if (obj is MarketDepth)
        return this.G6iR5ebrL.CompareTo((obj as MarketDepth).G6iR5ebrL);
      else
        throw new ArgumentException(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(900) + obj.GetType().ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void WriteTo(BinaryWriter writer)
    {
      writer.Write((byte) 3);
      writer.Write(this.R3W3NAEij.Ticks);
      writer.Write(this.JLOpfyh4y);
      writer.Write(this.eg7FZMr0F);
      writer.Write((byte) this.B5WkwTEyx);
      writer.Write(this.G6iR5ebrL);
      writer.Write(this.zy1PMqcD3);
      writer.Write(this.wjav9oO6m);
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
          this.R3W3NAEij = new DateTime(reader.ReadInt64());
          this.JLOpfyh4y = reader.ReadString();
          this.eg7FZMr0F = reader.ReadString();
          this.B5WkwTEyx = (MDSide) reader.ReadByte();
          this.G6iR5ebrL = Math.Round((double) reader.ReadSingle(), 4);
          this.zy1PMqcD3 = reader.ReadInt32();
          this.wjav9oO6m = reader.ReadByte();
          this.Me1WkVtkG = -1;
          this.jPJqD9uF9 = MDOperation.Undefined;
          break;
        case (byte) 2:
          this.R3W3NAEij = new DateTime(reader.ReadInt64());
          this.JLOpfyh4y = reader.ReadString();
          this.eg7FZMr0F = reader.ReadString();
          this.B5WkwTEyx = (MDSide) reader.ReadByte();
          this.G6iR5ebrL = Math.Round((double) reader.ReadSingle(), 4);
          this.zy1PMqcD3 = reader.ReadInt32();
          this.wjav9oO6m = reader.ReadByte();
          this.Me1WkVtkG = reader.ReadInt32();
          this.jPJqD9uF9 = (MDOperation) reader.ReadByte();
          break;
        case (byte) 3:
          this.R3W3NAEij = new DateTime(reader.ReadInt64());
          this.JLOpfyh4y = reader.ReadString();
          this.eg7FZMr0F = reader.ReadString();
          this.B5WkwTEyx = (MDSide) reader.ReadByte();
          this.G6iR5ebrL = reader.ReadDouble();
          this.zy1PMqcD3 = reader.ReadInt32();
          this.wjav9oO6m = reader.ReadByte();
          this.Me1WkVtkG = reader.ReadInt32();
          this.jPJqD9uF9 = (MDOperation) reader.ReadByte();
          break;
        default:
          throw new Exception(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(968) + (object) num);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ISeriesObject NewInstance()
    {
      return (ISeriesObject) new MarketDepth();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object Clone()
    {
      return (object) new MarketDepth(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return string.Format(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(1008), (object) this.R3W3NAEij, (object) this.B5WkwTEyx, (object) this.jPJqD9uF9, (object) this.Me1WkVtkG, (object) this.Price, (object) this.zy1PMqcD3);
    }
  }
}
