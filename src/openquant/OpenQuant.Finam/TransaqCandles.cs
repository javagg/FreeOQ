// Type: OpenQuant.Finam.TransaqCandles
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using System.Collections.Generic;

namespace OpenQuant.Finam
{
  public sealed class TransaqCandles
  {
    public int SecId { get; private set; }

    public string SecCode { get; private set; }

    public string Board { get; private set; }

    public int Period { get; private set; }

    public int Status { get; private set; }

    public string SecCodeBoard { get; private set; }

    public List<TransaqCandle> TransaqCandleList { get; private set; }

    public TransaqCandles(string data)
    {
      this.TransaqCandleList = new List<TransaqCandle>();
      string[] strArray1 = data.Split(new char[1]
      {
        '|'
      });
      string[] strArray2 = strArray1[0].Split(new char[1]
      {
        ';'
      });
      int index1 = 0;
      while (index1 < strArray2.Length - 1)
      {
        switch (strArray2[index1])
        {
          case "secid":
            this.SecId = int.Parse(strArray2[index1 + 1]);
            break;
          case "seccode":
            this.SecCode = strArray2[index1 + 1];
            break;
          case "board":
            this.Board = strArray2[index1 + 1];
            break;
          case "period":
            this.Period = int.Parse(strArray2[index1 + 1]);
            break;
          case "status":
            this.Status = int.Parse(strArray2[index1 + 1]);
            break;
        }
        index1 += 2;
      }
      this.SecCodeBoard = this.SecCode + "|" + this.Board;
      for (int index2 = 1; index2 < strArray1.Length; ++index2)
        this.TransaqCandleList.Add(new TransaqCandle(strArray1[index2]));
    }
  }
}
