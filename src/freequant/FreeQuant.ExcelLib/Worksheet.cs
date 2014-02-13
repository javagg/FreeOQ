using Interop.Excel;
using System.Reflection;

namespace FreeQuant.ExcelLib
{
  public class Worksheet
  {
    private Interop.Excel.Worksheet worksheet;

    public string Name
    {
      get
      {
        return this.worksheet.Name;
      }
      set
      {
        this.worksheet.Name = value;
      }
    }

    internal Worksheet(Interop.Excel.Worksheet worksheet)
    {
      this.worksheet = worksheet;
    }

    public Range GetRange(int row, int column)
    {
      return new Range(this.worksheet.Cells[row, column] as Interop.Excel.Range);
    }

    public void Activate()
    {
    	((Worksheet)(this.worksheet)).Activate();
    }

    public void InsertPicture(string filename)
    {
      this.GetRange(1, 1).Select();
      (this.worksheet.Pictures(Missing.Value) as Pictures).Insert(filename, Missing.Value);
    }
  }
}
