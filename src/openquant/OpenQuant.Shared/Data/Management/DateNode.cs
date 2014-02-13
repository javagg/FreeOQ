// Type: OpenQuant.Shared.Data.Management.DateNode
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal class DateNode : TreeNode
  {
    public DateTime Date { get; private set; }

    public DateNode(DateTime date, string format)
    {
      this.Date = date;
      this.Text = date.ToString(format);
    }
  }
}
