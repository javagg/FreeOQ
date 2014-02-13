using System;
using System.ComponentModel;
using System.IO;
using System.Xml;

namespace OpenQuant.Shared.Options
{
  [OptionsNode("Editor", typeof (EditorOptionsPanel))]
  public class EditorOptions : OptionsBase
  {
    private const string CATEGORY_DISPLAY = "Display";
    private const string CATEGORY_OUTLINING = "Outlining";
    private const string CATEGORY_AUTOSAVE = "Auto-save changes";
    private const bool DEFAULT_DISPLAY_LINE_NUMBERS = false;
    private const bool DEFAULT_ALLOW_OUTLINING = true;
    private const bool DEFAULT_AUTOSAVE_ENABLED = false;
    private FileInfo configFile;

    [DefaultValue(false)]
    [Category("Display")]
    [DisplayName("Line Numbers")]
    public bool DisplayLineNumbers { get; set; }

    [Category("Outlining")]
    [DisplayName("Allow Outlining")]
    [DefaultValue(true)]
    public bool AllowOutlining { get; set; }

    [Category("Auto-save changes")]
    [DefaultValue(false)]
    [DisplayName("Enabled")]
    public bool AutoSaveEnabled { get; set; }

    [Category("Auto-save changes")]
    [DisplayName("Interval")]
    [DefaultValue(typeof (TimeSpan), "00:01:00")]
    public TimeSpan AutoSaveInterval { get; set; }

    public EditorOptions(FileInfo configFile)
    {
      this.configFile = configFile;
    }

    protected override void OnLoad()
    {
      if (this.configFile.Exists)
      {
        EditorXmlDocument editorXmlDocument = new EditorXmlDocument();
        ((XmlDocument) editorXmlDocument).Load(this.configFile.FullName);
        this.DisplayLineNumbers = editorXmlDocument.Settings.DisplayLineNumbers.Value;
        this.AllowOutlining = editorXmlDocument.Settings.AllowOutlining.Value;
        this.AutoSaveEnabled = editorXmlDocument.Settings.AutoSave.Enabled;
        this.AutoSaveInterval = editorXmlDocument.Settings.AutoSave.Interval;
      }
      else
      {
        this.DisplayLineNumbers = false;
        this.AllowOutlining = true;
        this.AutoSaveEnabled = false;
        this.AutoSaveInterval = TimeSpan.FromMinutes(1.0);
      }
    }

    protected override void OnSave()
    {
      EditorXmlDocument editorXmlDocument = new EditorXmlDocument();
			editorXmlDocument.Settings.DisplayLineNumbers.Value = this.DisplayLineNumbers;
			editorXmlDocument.Settings.AllowOutlining.Value = this.AllowOutlining;
      editorXmlDocument.Settings.AutoSave.Enabled = this.AutoSaveEnabled;
      editorXmlDocument.Settings.AutoSave.Interval = this.AutoSaveInterval;
      ((XmlDocument) editorXmlDocument).Save(this.configFile.FullName);
    }
  }
}
