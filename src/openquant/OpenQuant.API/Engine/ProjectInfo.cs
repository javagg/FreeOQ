using System.IO;

namespace OpenQuant.API.Engine
{
  public class ProjectInfo
  {
    public string Name { get; private set; }

    public FileInfo ProjectFile { get; private set; }

    public FileInfo CodeFile { get; private set; }

    internal ProjectInfo(string name, FileInfo projectFile, FileInfo codeFile)
    {
      this.Name = name;
      this.ProjectFile = projectFile;
      this.CodeFile = codeFile;
    }
  }
}
