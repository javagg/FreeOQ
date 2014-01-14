using OpenQuant;
using OpenQuant.API;
using OpenQuant.API.Engine;
using OpenQuant.Config;
using OpenQuant.ObjectMap;
using OpenQuant.Projects.Xml;
using OpenQuant.Shared.Compiler;
using OpenQuant.Trading;
using FreeQuant.Instruments;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace OpenQuant.Projects
{
  internal class StrategyProject
  {
    private bool enabled = true;
    public const string FILE_EXT = "oqp";
    private const int VERSION = 1;
    private string name;
    private string description;
    private int version;
    private DateTime dateModified;
    private FileInfo projectFile;
    private FileInfo codeFile;
    private Strategy strategy;
    private StrategySettings strategySettings;
    private CodeLang codeLang;
    private StrategyRunner strategyRunner;

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

    public int Version
    {
      get
      {
        return this.version;
      }
    }

    public DateTime DateModified
    {
      get
      {
        return this.dateModified;
      }
    }

    public FileInfo ProjectFile
    {
      get
      {
        return this.projectFile;
      }
    }

    public FileInfo CodeFile
    {
      get
      {
        return this.codeFile;
      }
    }

    public CodeLang CodeLang
    {
      get
      {
        return this.codeLang;
      }
    }

    public bool Enabled
    {
      get
      {
        return this.enabled;
      }
      set
      {
        this.enabled = value;
      }
    }

    public Strategy Strategy
    {
      get
      {
        return this.strategy;
      }
    }

    public StrategySettings StrategySettings
    {
      get
      {
        return this.strategySettings;
      }
    }

    public StrategyRunner StrategyRunner
    {
      get
      {
        return this.strategyRunner;
      }
    }

    private StrategyProject(FileInfo projectFile, CodeLang codeLang, string name, string description)
    {
      this.name = name;
      this.description = description;
      this.version = 1;
      this.dateModified = DateTime.Now;
      this.projectFile = projectFile;
      this.codeFile = (FileInfo) null;
      this.codeLang = codeLang;
      this.strategy = Activator.CreateInstance(typeof (Strategy), true) as Strategy;
      this.strategySettings = new StrategySettings();
      this.strategyRunner = new StrategyRunner(name);
    }

    private StrategyProject(FileInfo projectFile)
      : this(projectFile, (CodeLang) 0, "", "")
    {
    }

    public static StrategyProject Create(FileInfo projectFile, CodeLang codeLang, string name, string description)
    {
      StrategyProject strategyProject = new StrategyProject(projectFile, codeLang, name, description);
      strategyProject.Save();
      return strategyProject;
    }

    public static StrategyProject Open(FileInfo projectFile)
    {
      StrategyProject strategyProject = new StrategyProject(projectFile);
      strategyProject.Load();
      strategyProject.Build();
      return strategyProject;
    }

    public void Close()
    {
    }

    public StrategyRunner GetStrategyRunner(Project strategyInfo)
    {
      this.strategyRunner.set_Strategy(this.strategy);
      this.strategyRunner.set_Enabled(this.enabled);
      this.strategyRunner.set_PerformanceEnabled(Configuration.get_Active().get_Portfolio().Performance.Enabled);
      this.strategyRunner.set_CalculateDrawdown(Configuration.get_Active().get_Portfolio().Performance.CalculateDrawdown);
      this.strategyRunner.set_CalculatePnL(Configuration.get_Active().get_Portfolio().Performance.CalculatePnL);
      this.strategyRunner.set_UpdateOnIntervalEnabled(Configuration.get_Active().get_Portfolio().Performance.UpdateOnIntervalEnabled);
      this.strategyRunner.set_UpdateOnIntervalInterval(Configuration.get_Active().get_Portfolio().Performance.UpdateInterval);
      IEnumerator enumerator = strategyInfo.get_Instruments().GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
        {
          Instrument instrument = (Instrument) enumerator.Current;
          this.strategyRunner.get_Instruments().Add((Instrument) ((Hashtable) Map.OQ_SQ_Instrument)[(object) instrument]);
        }
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
      return this.strategyRunner;
    }

    public bool Validate()
    {
      return true;
    }

    public BuildErrorCollection Build()
    {
      CompilerErrorCollection collection = this.Compile();
      if (!collection.HasErrors)
      {
        this.strategySettings.Merge(this.strategy);
        this.strategySettings.Populate(this.strategy);
      }
      this.Save();
      return new BuildErrorCollection(collection, this);
    }

    private CompilerErrorCollection Compile()
    {
      this.strategy = (Strategy) null;
      CompilingServices compilingServices = new CompilingServices(this.codeLang);
      foreach (BuildReference buildReference in Global.Options.Solutions.Build.GetReferences())
      {
        if (buildReference.get_Valid())
          compilingServices.AddReference(buildReference.get_Path());
      }
      compilingServices.AddFile(this.codeFile.FullName);
      CompilerResults compilerResults = compilingServices.Compile();
      if (!compilerResults.Errors.HasErrors)
      {
        foreach (Type type in compilerResults.CompiledAssembly.GetTypes())
        {
          if (type.IsSubclassOf(typeof (Strategy)))
          {
            this.strategy = Activator.CreateInstance(type) as Strategy;
            break;
          }
        }
        if (this.strategy == null)
          compilerResults.Errors.Add(new CompilerError(this.codeFile.FullName, -1, -1, "", "No strategy found."));
      }
      return compilerResults.Errors;
    }

    public void Save()
    {
      if (!this.projectFile.Directory.Exists)
        this.projectFile.Directory.Create();
      this.codeFile = new FileInfo(string.Format("{0}\\{1}", (object) this.projectFile.Directory.FullName, (object) Global.ProjectManager.GetCodeFileName(this.codeLang)));
      if (!this.codeFile.Exists)
        this.codeFile = Global.ProjectManager.GetCodeTemplate(this.codeLang).CopyTo(this.codeFile.FullName);
      ProjectXmlDocument projectXmlDocument = new ProjectXmlDocument();
      projectXmlDocument.ProjectName = this.name;
      projectXmlDocument.Description = this.description;
      projectXmlDocument.Version = 1;
      projectXmlDocument.CodeLang = this.codeLang;
      foreach (Instrument instrument in (IEnumerable) this.strategySettings.Instruments)
        projectXmlDocument.Instruments.Add(instrument.Symbol);
      foreach (StrategyProperty strategyProperty in this.strategySettings.StrategyProperties.Values)
      {
        if (strategyProperty.Value != null)
        {
          string str;
          if (strategyProperty.Value.GetType() == typeof (Color))
          {
            Color color = (Color) strategyProperty.Value;
            str = (string) (object) color.A + (object) "," + (string) (object) color.R + "," + (string) (object) color.G + "," + (string) (object) color.B;
          }
          else if (strategyProperty.Value.GetType().IsEnum)
            str = strategyProperty.Value.ToString();
          else if (typeof (IConvertible).IsAssignableFrom(strategyProperty.Type))
            str = (string) Convert.ChangeType(strategyProperty.Value, typeof (string), (IFormatProvider) NumberFormatInfo.InvariantInfo);
          else if (strategyProperty.Type == typeof (TimeSpan))
            str = strategyProperty.Value.ToString();
          else
            continue;
          projectXmlDocument.Properties.Add(strategyProperty.Name, strategyProperty.Type, str, strategyProperty.Category, strategyProperty.Description);
        }
      }
      projectXmlDocument.Save(this.projectFile.FullName);
    }

    private void Load()
    {
      this.LoadSettingsFrom(this.projectFile, false);
      this.codeFile = new FileInfo(string.Format("{0}\\{1}", (object) this.projectFile.Directory.FullName, (object) Global.ProjectManager.GetCodeFileName(this.codeLang)));
      if (!this.codeFile.Exists)
        this.codeFile = Global.ProjectManager.GetCodeTemplate(this.codeLang).CopyTo(this.codeFile.FullName);
      this.strategyRunner = new StrategyRunner(this.name);
    }

    public void LoadSettingsFrom(FileInfo projectFile)
    {
      this.LoadSettingsFrom(projectFile, true);
    }

    private void LoadSettingsFrom(FileInfo projectFile, bool justParameters)
    {
      ProjectXmlDocument projectXmlDocument = new ProjectXmlDocument();
      projectXmlDocument.Load(projectFile.FullName);
      if (!justParameters)
      {
        this.name = projectXmlDocument.ProjectName;
        this.description = projectXmlDocument.Description;
        this.version = projectXmlDocument.Version;
        this.codeLang = projectXmlDocument.CodeLang;
      }
      this.strategySettings.Clear();
      foreach (InstrumentXmlNode instrumentXmlNode in projectXmlDocument.Instruments)
      {
        Instrument instrument = InstrumentManager.Instruments[instrumentXmlNode.Symbol];
        if (instrument != null)
          this.strategySettings.Instruments.Add(instrument);
      }
      foreach (PropertyXmlNode propertyXmlNode in projectXmlDocument.Properties)
      {
        if (!(propertyXmlNode.Type == (Type) null) || propertyXmlNode.IsEnum)
        {
          Type type = propertyXmlNode.Type;
          object obj;
          if (propertyXmlNode.Type != (Type) null)
          {
            if (propertyXmlNode.Type.IsEnum)
              obj = Enum.Parse(propertyXmlNode.Type, propertyXmlNode.Value);
            else if (propertyXmlNode.Type == typeof (Color))
            {
              string[] strArray = propertyXmlNode.Value.Split(new char[1]
              {
                ','
              });
              obj = (object) Color.FromArgb(int.Parse(strArray[0]), int.Parse(strArray[1]), int.Parse(strArray[2]), int.Parse(strArray[3]));
            }
            else if (typeof (IConvertible).IsAssignableFrom(propertyXmlNode.Type))
              obj = Convert.ChangeType((object) propertyXmlNode.Value, propertyXmlNode.Type, (IFormatProvider) NumberFormatInfo.InvariantInfo);
            else if (propertyXmlNode.Type == typeof (TimeSpan))
              obj = (object) TimeSpan.Parse(propertyXmlNode.Value);
            else
              continue;
          }
          else
          {
            obj = (object) propertyXmlNode.Value;
            if (this.strategy != null)
            {
              FieldInfo field = ((object) this.strategy).GetType().GetField(propertyXmlNode.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
              if (field != (FieldInfo) null && field.FieldType.IsEnum)
              {
                type = field.FieldType;
                if (Enum.IsDefined(field.FieldType, (object) propertyXmlNode.Value))
                  obj = Enum.Parse(field.FieldType, propertyXmlNode.Value);
              }
            }
          }
          this.strategySettings.StrategyProperties.Add(new StrategyPropertyKey(propertyXmlNode.Name, type), new StrategyProperty(propertyXmlNode.Name, type, obj, propertyXmlNode.Category, propertyXmlNode.Descrition));
        }
      }
    }
  }
}
