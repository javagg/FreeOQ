// Type: OpenQuant.Projects.ProjectInfoMenuItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System.Windows.Forms;

namespace OpenQuant.Projects
{
  internal class ProjectInfoMenuItem : ToolStripMenuItem
  {
    private SolutionInfo project;

    public SolutionInfo Project
    {
      get
      {
        return this.project;
      }
    }

    public ProjectInfoMenuItem(int num, SolutionInfo project)
    {
      this.project = project;
      this.Text = string.Format("{0} {1}", (object) num, (object) project.File.FullName);
      this.Enabled = project.File.Exists;
    }
  }
}
