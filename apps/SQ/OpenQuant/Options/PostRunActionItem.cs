// Type: OpenQuant.Options.PostRunActionItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Projects;
using System;

namespace OpenQuant.Options
{
  internal class PostRunActionItem
  {
    private PostRunAction action;

    public PostRunAction Action
    {
      get
      {
        return this.action;
      }
    }

    public PostRunActionItem(PostRunAction action)
    {
      this.action = action;
    }

    public override string ToString()
    {
      switch (this.action)
      {
        case PostRunAction.None:
          return "None";
        case PostRunAction.ShowPortfolio:
          return "Show portfolio composition";
        case PostRunAction.ShowOrders:
          return "Show orders";
        case PostRunAction.ShowPerformance:
          return "Show performance";
        case PostRunAction.ShowChart:
          return "Show chart";
        default:
          throw new NotSupportedException(string.Format("Unknown action - {0}", (object) this.action));
      }
    }

    public override int GetHashCode()
    {
      return this.action.GetHashCode();
    }

    public override bool Equals(object obj)
    {
      if (obj is PostRunAction)
        return this.action == (PostRunAction) obj;
      else
        return false;
    }
  }
}
