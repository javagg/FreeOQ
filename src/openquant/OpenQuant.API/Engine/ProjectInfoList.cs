using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API.Engine
{
  public class ProjectInfoList : IEnumerable
  {
    private Dictionary<string, ProjectInfo> projects;

    public int Count
    {
      get
      {
        return this.projects.Count;
      }
    }

    public ProjectInfo this[string name]
    {
      get
      {
        return this.projects[name];
      }
    }

    public ProjectInfo this[int index]
    {
      get
      {
        int num = 0;
        foreach (ProjectInfo projectInfo in this.projects.Values)
        {
          if (num == index)
            return projectInfo;
          ++num;
        }
        throw new IndexOutOfRangeException("Project with specified index does not exist");
      }
    }

    internal ProjectInfoList(List<ProjectInfo> list)
    {
      this.projects = new Dictionary<string, ProjectInfo>();
      foreach (ProjectInfo projectInfo in list)
        this.projects[projectInfo.Name] = projectInfo;
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.projects.Values.GetEnumerator();
    }

    public bool Contains(string name)
    {
      return this.projects.ContainsKey(name);
    }

    public bool TryGetValue(string name, out ProjectInfo project)
    {
      return this.projects.TryGetValue(name, out project);
    }
  }
}
