// Type: OpenQuant.Shared.Data.Management.DayNode
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System;

namespace OpenQuant.Shared.Data.Management
{
  internal class DayNode : DateNode
  {
    public DayNode(DateTime date, int count)
      : base(date, "dd")
    {
      this.ToolTipText = string.Format("{0:D} {1:n0} objects", (object) date, (object) count);
    }
  }
}
