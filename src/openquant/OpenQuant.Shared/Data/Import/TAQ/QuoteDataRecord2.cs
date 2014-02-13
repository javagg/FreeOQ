// Type: OpenQuant.Shared.Data.Import.TAQ.QuoteDataRecord2
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System.IO;

namespace OpenQuant.Shared.Data.Import.TAQ
{
  internal class QuoteDataRecord2 : IQuoteRecord
  {
    private int QTIM;
    private long BID;
    private long OFR;
    private int QSEQ;
    private int BIDSIZ;
    private int OFRSIZ;
    private short MODE;
    private byte EX;
    private byte[] MMID;

    public int Time
    {
      get
      {
        return this.QTIM;
      }
    }

    public double Bid
    {
      get
      {
        return (double) this.BID / 100000000.0;
      }
    }

    public double Ask
    {
      get
      {
        return (double) this.OFR / 100000000.0;
      }
    }

    public int BidSize
    {
      get
      {
        return this.BIDSIZ;
      }
    }

    public int AskSize
    {
      get
      {
        return this.OFRSIZ;
      }
    }

    public QuoteDataRecord2(BinaryReader reader, int num)
    {
      reader.BaseStream.Position = (long) ((num - 1) * 39);
      this.QTIM = reader.ReadInt32();
      this.BID = reader.ReadInt64();
      this.OFR = reader.ReadInt64();
      this.QSEQ = reader.ReadInt32();
      this.BIDSIZ = reader.ReadInt32();
      this.OFRSIZ = reader.ReadInt32();
      this.MODE = reader.ReadInt16();
      this.EX = reader.ReadByte();
      this.MMID = reader.ReadBytes(4);
    }
  }
}
