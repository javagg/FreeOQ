// Type: OpenQuant.Shared.Data.Import.TAQ.TradeDataRecord
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System.IO;

namespace OpenQuant.Shared.Data.Import.TAQ
{
  internal class TradeDataRecord : ITradeRecord
  {
    private int TTIM;
    private int PRICE;
    private int SIZ;
    private int TSEQ;
    private short G127;
    private short CORR;
    private byte COND;
    private byte EX;

    public int Time
    {
      get
      {
        return this.TTIM;
      }
    }

    public double Price
    {
      get
      {
        return (double) this.PRICE / 100000.0;
      }
    }

    public int Size
    {
      get
      {
        return this.SIZ;
      }
    }

    public TradeDataRecord(BinaryReader reader, int num)
    {
      reader.BaseStream.Position = (long) ((num - 1) * 22);
      this.TTIM = reader.ReadInt32();
      this.PRICE = reader.ReadInt32();
      this.SIZ = reader.ReadInt32();
      this.TSEQ = reader.ReadInt32();
      this.G127 = reader.ReadInt16();
      this.CORR = reader.ReadInt16();
      this.COND = reader.ReadByte();
      this.EX = reader.ReadByte();
    }
  }
}
