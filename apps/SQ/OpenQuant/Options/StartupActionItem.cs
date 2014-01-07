// Type: OpenQuant.Options.StartupActionItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Startup;
using System;

namespace OpenQuant.Options
{
  internal class StartupActionItem
  {
    private StartupAction action;

    public StartupAction Action
    {
      get
      {
        return this.action;
      }
    }

    public StartupActionItem(StartupAction action)
    {
      this.action = action;
    }

    public override string ToString()
    {
      switch (this.action)
      {
        case StartupAction.None:
          return "None";
        case StartupAction.ShowStartPage:
          return "Show Start Page";
        case StartupAction.LoadLastLoadedSolution:
          return "Load last loaded solution";
        case StartupAction.ShowStartPageAndLoadSolution:
          return "Show Start Page and load last loaded solution";
        default:
          throw new ArgumentException(string.Format("Unknown startup action - {0}", (object) this.action));
      }
    }

    public override int GetHashCode()
    {
      return this.action.GetHashCode();
    }

    public override bool Equals(object obj)
    {
      if (obj is StartupAction)
        return this.action == (StartupAction) obj;
      else
        return false;
    }
  }
}
