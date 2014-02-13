// Type: OpenQuant.Shared.Data.Management.DateNodeComparer
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System;
using System.Collections;

namespace OpenQuant.Shared.Data.Management
{
  internal class DateNodeComparer : IComparer
  {
    public int Compare(object x, object y)
    {
      return DateTime.Compare(((DateNode) x).Date, ((DateNode) y).Date);
    }
  }
}
