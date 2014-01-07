// Type: OpenQuant.Projects.SolutionInfo
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;
using System.IO;

namespace OpenQuant.Projects
{
  internal class SolutionInfo
  {
    private FileInfo file;
    private string name;
    private string description;
    private DateTime dateModified;

    public FileInfo File
    {
      get
      {
        return this.file;
      }
    }

    public string Name
    {
      get
      {
        return this.name;
      }
    }

    public string Description
    {
      get
      {
        return this.description;
      }
    }

    public DateTime DateModified
    {
      get
      {
        return this.dateModified;
      }
    }

    public SolutionInfo(FileInfo file, string name, string description, DateTime dateModified)
    {
      this.file = file;
      this.name = name;
      this.description = description;
      this.dateModified = dateModified;
    }

    public SolutionInfo(Solution solution)
      : this(solution.SolutionFile, solution.Name, solution.Description, DateTime.Now)
    {
    }

    public override int GetHashCode()
    {
      return this.file.FullName.ToUpper().GetHashCode();
    }

    public override bool Equals(object obj)
    {
      if (obj is SolutionInfo)
        return this.file.FullName.ToUpper() == (obj as SolutionInfo).file.FullName.ToUpper();
      else
        return base.Equals(obj);
    }
  }
}
