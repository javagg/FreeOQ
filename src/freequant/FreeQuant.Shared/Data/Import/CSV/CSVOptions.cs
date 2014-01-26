using System.Globalization;

namespace FreeQuant.Shared.Data.Import.CSV
{
  public class CSVOptions
  {
    private Separator dkGxbE39BP;
    private int pnjxVJgJjh;
    private CultureInfo aaNxRduLBo;

    public Separator Separator
    {
       get
      {
        return this.dkGxbE39BP;
      }
       set
      {
        this.dkGxbE39BP = value;
      }
    }

    public int HeaderLineCount
    {
       get
      {
        return this.pnjxVJgJjh;
      }
       set
      {
        this.pnjxVJgJjh = value;
      }
    }

    public CultureInfo CultureInfo
    {
       get
      {
        return this.aaNxRduLBo;
      }
       set
      {
        this.aaNxRduLBo = value;
      }
    }

    
    public CSVOptions()
    {
      this.dkGxbE39BP = Separator.Tab;
      this.pnjxVJgJjh = 0;
      this.aaNxRduLBo = new CultureInfo(RNaihRhYEl0wUmAftnB.aYu7exFQKN(5994));
    }
  }
}
