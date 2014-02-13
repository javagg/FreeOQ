// Type: OpenQuant.Shared.Data.Import.TAQ.QuoteDataRecord
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System.IO;

namespace OpenQuant.Shared.Data.Import.TAQ
{
  internal class QuoteDataRecord : IQuoteRecord
  {
    private int QTIM;
    private int BID;
    private int OFR;
    private int QSEQ;
    private short BIDSIZ;
    private short OFRSIZ;
    private short MODE;
    private byte EX;
    private int MMID;

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
        return (double) this.BID / 100000.0;
      }
    }

    public double Ask
    {
      get
      {
        return (double) this.OFR / 100000.0;
      }
    }

    public int BidSize
    {
      get
      {
        return (int) this.BIDSIZ;
      }
    }

    public int AskSize
    {
      get
      {
        return (int) this.OFRSIZ;
      }
    }

    public QuoteDataRecord(BinaryReader reader, int num)
    {
      reader.BaseStream.Position = (long) ((num - 1) * 27);
      this.QTIM = reader.ReadInt32();
      this.BID = reader.ReadInt32();
      this.OFR = reader.ReadInt32();
      this.QSEQ = reader.ReadInt32();
      this.BIDSIZ = reader.ReadInt16();
      this.OFRSIZ = reader.ReadInt16();
      this.MODE = reader.ReadInt16();
      this.EX = reader.ReadByte();
      this.MMID = reader.ReadInt32();
    }
  }
}
