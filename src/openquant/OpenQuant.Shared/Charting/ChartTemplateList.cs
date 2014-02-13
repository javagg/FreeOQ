using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Xml;

namespace OpenQuant.Shared.Charting
{
  internal class ChartTemplateList
  {
    private const string TEMPLATE_EXT = ".ctp";
    private DirectoryInfo directory;
    private Dictionary<string, ChartTemplate> templates;
    private HashSet<string> templateNames;

    public IEnumerable<string> TemplateNames
    {
      get
      {
        return (IEnumerable<string>) this.templateNames;
      }
    }

    public ChartTemplate EmptyTemplate
    {
      get
      {
        return new ChartTemplate();
      }
    }

    public ChartTemplate this[string name]
    {
      get
      {
        ChartTemplate chartTemplate;
        if (this.templates.TryGetValue(name.ToLower(), out chartTemplate))
          return chartTemplate;
        else
          return this.EmptyTemplate;
      }
    }

    public ChartTemplateList(DirectoryInfo directory)
    {
      this.directory = directory;
      this.templates = new Dictionary<string, ChartTemplate>();
      this.templateNames = new HashSet<string>();
      this.LoadTemplates();
    }

    private void LoadTemplates()
    {
      foreach (FileInfo file in this.directory.GetFiles("*.ctp"))
        this.LoadTemplate(file);
    }

    private void LoadTemplate(FileInfo file)
    {
      ChartTemplateXmlDocument templateXmlDocument = new ChartTemplateXmlDocument();
      ((XmlDocument) templateXmlDocument).Load(file.FullName);
      ChartTemplate chartTemplate = new ChartTemplate();
      foreach (PadTemplateXmlNode padTemplateXmlNode in templateXmlDocument.PadTemplates)
      {
        PadTemplate padTemplate = new PadTemplate();
        chartTemplate.PadTemplates.Add(padTemplateXmlNode.Number, padTemplate);
        foreach (IndicatorTemplateXmlNode indicatorNode in padTemplateXmlNode.IndicatorTemplates)
        {
          IndicatorTemplateItem indicatorTemplate = new IndicatorTemplateItem(indicatorNode.Type);
          padTemplate.IndicatorTemplates.Add(indicatorTemplate);
          this.LoadIndicatorTemplate(indicatorTemplate, indicatorNode);
        }
      }
      string withoutExtension = Path.GetFileNameWithoutExtension(file.Name);
      this.templates.Add(withoutExtension.ToLower(), chartTemplate);
      this.templateNames.Add(withoutExtension);
    }

    private void LoadIndicatorTemplate(IndicatorTemplateItem indicatorTemplate, IndicatorTemplateXmlNode indicatorNode)
    {
      foreach (SettingXmlNode settingXmlNode in indicatorNode.Settings)
      {
        object obj;
        if (settingXmlNode.Type.IsEnum)
          obj = Enum.Parse(settingXmlNode.Type, settingXmlNode.Value);
        else if (settingXmlNode.Type == typeof (Color))
        {
          string[] strArray = settingXmlNode.Value.Split(new char[1]
          {
            ','
          });
          obj = (object) Color.FromArgb(int.Parse(strArray[0]), int.Parse(strArray[1]), int.Parse(strArray[2]), int.Parse(strArray[3]));
        }
        else
          obj = Convert.ChangeType((object) settingXmlNode.Value, settingXmlNode.Type, (IFormatProvider) NumberFormatInfo.InvariantInfo);
        indicatorTemplate.SetProperty(settingXmlNode.Name, obj);
      }
      foreach (IndicatorTemplateXmlNode indicatorNode1 in indicatorNode.IndicatorTemplates)
      {
        IndicatorTemplateItem indicatorTemplate1 = new IndicatorTemplateItem(indicatorNode1.Type);
        indicatorTemplate.Children.Add(indicatorTemplate1);
        this.LoadIndicatorTemplate(indicatorTemplate1, indicatorNode1);
      }
    }

    private void SaveTemplate(string name, ChartTemplate template)
    {
      ChartTemplateXmlDocument templateXmlDocument = new ChartTemplateXmlDocument();
      foreach (KeyValuePair<int, PadTemplate> keyValuePair in template.PadTemplates)
      {
        PadTemplateXmlNode padTemplateXmlNode = templateXmlDocument.PadTemplates.Add();
        padTemplateXmlNode.Number = keyValuePair.Key;
        foreach (IndicatorTemplateItem indicatorTemplate in keyValuePair.Value.IndicatorTemplates)
          this.SaveIndicatorTemplate(padTemplateXmlNode.IndicatorTemplates.Add(), indicatorTemplate);
      }
      ((XmlDocument) templateXmlDocument).Save(string.Format("{0}\\{1}{2}", (object) this.directory.FullName, (object) name, (object) ".ctp"));
    }

    private void SaveIndicatorTemplate(IndicatorTemplateXmlNode indicator, IndicatorTemplateItem indicatorTemplate)
    {
      indicator.Type = indicatorTemplate.IndicatorType;
      foreach (KeyValuePair<string, object> keyValuePair in indicatorTemplate.Properties)
      {
        string str;
        if (keyValuePair.Value.GetType() == typeof (Color))
        {
          Color color = (Color) keyValuePair.Value;
          str = (string) (object) color.A + (object) "," + (string) (object) color.R + "," + (string) (object) color.G + "," + (string) (object) color.B;
        }
        else
          str = !keyValuePair.Value.GetType().IsEnum ? (string) Convert.ChangeType(keyValuePair.Value, typeof (string), (IFormatProvider) NumberFormatInfo.InvariantInfo) : keyValuePair.Value.ToString();
        indicator.Settings.Add(keyValuePair.Key, keyValuePair.Value.GetType(), str);
      }
      foreach (IndicatorTemplateItem indicatorTemplate1 in indicatorTemplate.Children)
        this.SaveIndicatorTemplate(indicator.IndicatorTemplates.Add(), indicatorTemplate1);
    }

    public bool Contains(string name)
    {
      return this.templates.ContainsKey(name.ToLower());
    }

    public void Add(string name, ChartTemplate template)
    {
      this.templates.Add(name.ToLower(), template);
      this.templateNames.Add(name);
      this.SaveTemplate(name, template);
    }

    public void Replace(string name, ChartTemplate template)
    {
      this.templates[name.ToLower()] = template;
      if (!this.templateNames.Contains(name))
        this.templateNames.Add(name);
      this.SaveTemplate(name, template);
    }
  }
}
