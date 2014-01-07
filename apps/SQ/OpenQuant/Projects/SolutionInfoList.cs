// Type: OpenQuant.Projects.SolutionInfoList
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;
using System.Collections.Generic;

namespace OpenQuant.Projects
{
  internal class SolutionInfoList : List<SolutionInfo>
  {
    public void SortByDates()
    {
      this.Sort(new Comparison<SolutionInfo>(this.CompareByDates));
      this.Reverse();
    }

    private int CompareByDates(SolutionInfo project1, SolutionInfo project2)
    {
      return DateTime.Compare(project1.DateModified, project2.DateModified);
    }
  }
}
