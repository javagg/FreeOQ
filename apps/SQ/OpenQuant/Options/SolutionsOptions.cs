// Type: OpenQuant.Options.SolutionsOptions
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Options.Xml;
using OpenQuant.Projects;
using OpenQuant.Shared.Options;
using System.IO;

namespace OpenQuant.Options
{
  [OptionsNode("Projects and Solutions", typeof (SolutionsOptionsPanel))]
  internal class SolutionsOptions : OptionsBase
  {
    private const string FILENAME = "solutions.xml";
    private const int DEFAULT_MAX_RECENT_SOLUTION = 32;
    private const int DEFAULT_SHOW_RECENT_SOLUTION = 16;
    private const PostRunAction DEFAULT_POST_RUN_ACTION = PostRunAction.ShowPerformance;
    private int maxRecentSolutions;
    private int showRecentSolutions;
    private PostRunAction postRunAction;

    public int MaxRecentSolutions
    {
      get
      {
        return this.maxRecentSolutions;
      }
      set
      {
        this.maxRecentSolutions = value;
      }
    }

    public int ShowRecentSolutions
    {
      get
      {
        return this.showRecentSolutions;
      }
      set
      {
        this.showRecentSolutions = value;
      }
    }

    public PostRunAction PostRunAction
    {
      get
      {
        return this.postRunAction;
      }
      set
      {
        this.postRunAction = value;
      }
    }

    public BuildOptions Build
    {
      get
      {
        return (BuildOptions) this.GetSubOptions<BuildOptions>();
      }
    }

    public EditorOptions Editor
    {
      get
      {
        return (EditorOptions) this.GetSubOptions<EditorOptions>();
      }
    }

    public ScriptsOptions Scripts
    {
      get
      {
        return (ScriptsOptions) this.GetSubOptions<ScriptsOptions>();
      }
    }

    public SolutionsOptions()
    {
      base.\u002Ector();
      this.Add((OptionsBase) new BuildOptions(new FileInfo(string.Format("{0}\\build.xml", (object) Global.Setup.Folders.Ini.FullName)), Global.Setup.Folders.Bin));
      this.Add((OptionsBase) new EditorOptions(new FileInfo(string.Format("{0}\\editor.xml", (object) Global.Setup.Folders.Ini.FullName))));
      this.Add((OptionsBase) new ScriptsOptions(new FileInfo(string.Format("{0}\\scripts.options.xml", (object) Global.Setup.Folders.Ini.FullName))));
    }

    protected virtual void OnLoad()
    {
      string configFileName = this.GetConfigFileName();
      if (File.Exists(configFileName))
      {
        SolutionsXmlDocument solutionsXmlDocument = new SolutionsXmlDocument();
        solutionsXmlDocument.Load(configFileName);
        this.maxRecentSolutions = solutionsXmlDocument.Recent.MaxCount;
        this.showRecentSolutions = solutionsXmlDocument.Recent.ShowCount;
        this.postRunAction = solutionsXmlDocument.PostRunAction.Value;
      }
      else
      {
        this.maxRecentSolutions = 32;
        this.showRecentSolutions = 16;
        this.postRunAction = PostRunAction.ShowPerformance;
      }
    }

    protected virtual void OnSave()
    {
      new SolutionsXmlDocument()
      {
        Recent = {
          MaxCount = this.maxRecentSolutions,
          ShowCount = this.showRecentSolutions
        },
        PostRunAction = {
          Value = this.postRunAction
        }
      }.Save(this.GetConfigFileName());
    }

    private string GetConfigFileName()
    {
      return string.Format("{0}\\{1}", (object) Global.Setup.Folders.Ini.FullName, (object) "solutions.xml");
    }
  }
}
