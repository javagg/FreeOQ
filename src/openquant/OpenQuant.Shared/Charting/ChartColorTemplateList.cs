using FreeQuant.Xml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;

namespace OpenQuant.Shared.Charting
{
    class ChartColorTemplateList
    {
        private const string TEMPLATE_EXT = ".cctp";
        private DirectoryInfo directory;
        private FileInfo configFile;
        private List<string> templateNameList;
        private Dictionary<string, ChartColorTemplate> templates;
        private ChartColorTemplate defaultTemplate;

        public ChartColorTemplate DefaultTemplate
        {
            get
            {
                return this.defaultTemplate;
            }
            set
            {
                this.defaultTemplate = value;
                this.SaveConfig();
            }
        }

        public Dictionary<string, ChartColorTemplate> All
        {
            get
            {
                return this.templates;
            }
        }

        public ChartColorTemplateList(DirectoryInfo directory)
        {
            this.directory = directory;
            this.configFile = new FileInfo(Path.Combine(directory.FullName, "config.xml"));
            this.templateNameList = new List<string>();
            this.templates = new Dictionary<string, ChartColorTemplate>();
            this.LoadTemplates();
        }

        private void LoadTemplates()
        {
            foreach (FileInfo fileInfo in this.directory.GetFiles("*.cctp"))
                this.LoadTemplate(fileInfo);
            this.LoadConfig();
            this.SaveConfig();
        }

        private void LoadConfig()
        {
            ChartColorTemplateConfigXmlDocument configXmlDocument = new ChartColorTemplateConfigXmlDocument();
            if (File.Exists(this.configFile.FullName))
                ((XmlDocument)configXmlDocument).Load(this.configFile.FullName);
            string defaultTemplate = configXmlDocument.DefaultTemplate;
            if (defaultTemplate != null && this.templates.TryGetValue(defaultTemplate.ToLower(), out this.defaultTemplate))
                return;
            this.defaultTemplate = new ChartColorTemplate("Default Template");
        }

        private void SaveConfig()
        {
            ((XmlDocument)new ChartColorTemplateConfigXmlDocument()
            {
                DefaultTemplate = this.defaultTemplate.Name
            }).Save(this.configFile.FullName);
        }

        private void LoadTemplate(FileInfo fileInfo)
        {
            ChartColorTemplateXmlDocument templateXmlDocument = new ChartColorTemplateXmlDocument();
            ((XmlDocument)templateXmlDocument).Load(fileInfo.FullName);
            ChartColorTemplate chartColorTemplate = new ChartColorTemplate(templateXmlDocument.TemplateName);
            IEnumerator enumerator = ((ListXmlNode<PropertyXmlNode>)templateXmlDocument.Properties).GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    PropertyXmlNode propertyXmlNode = (PropertyXmlNode)enumerator.Current;
                    string[] strArray = propertyXmlNode.Value.Split(new char[]  { ',' });
                    int alpha = int.Parse(strArray[0]);
                    int red = int.Parse(strArray[1]);
                    int green = int.Parse(strArray[2]);
                    int blue = int.Parse(strArray[3]);
                    chartColorTemplate.Settings[propertyXmlNode.Name] = Color.FromArgb(alpha, red, green, blue);
                }
            }
            finally
            {
                IDisposable disposable = enumerator as IDisposable;
                if (disposable != null)
                    disposable.Dispose();
            }
            this.templateNameList.Add(chartColorTemplate.Name);
            this.templates.Add(chartColorTemplate.Name.ToLower(), chartColorTemplate);
        }

        private void SaveTemplate(string name, ChartColorTemplate template)
        {
            ChartColorTemplateXmlDocument templateXmlDocument = new ChartColorTemplateXmlDocument();
            templateXmlDocument.TemplateName = template.Name;
            foreach (KeyValuePair<string, Color> keyValuePair in template.Settings)
            {
                Color color = keyValuePair.Value;
                string str = (string)(object)color.A + (object)"," + (string)(object)color.R + "," + (string)(object)color.G + "," + (string)(object)color.B;
                templateXmlDocument.Properties.Add(keyValuePair.Key, typeof(Color), str);
            }
            ((XmlDocument)templateXmlDocument).Save(this.directory.FullName + "\\" + name + ".cctp");
        }

        public ChartColorTemplate GetTemplate(string name)
        {
            if (!this.templates.ContainsKey(name.ToLower()))
                return (ChartColorTemplate)null;
            else
                return this.templates[name.ToLower()];
        }

        public void AddTemplate(string name, ChartColorTemplate template)
        {
            this.templates.Add(name.ToLower(), template);
            this.templateNameList.Add(name);
            this.SaveTemplate(name, template);
        }

        public void RemoveTemplate(ChartColorTemplate template)
        {
            this.templates.Remove(template.Name.ToLower());
            this.templateNameList.Remove(template.Name);
            string path = this.directory.FullName + "\\" + template.Name + ".cctp";
            if (!File.Exists(path))
                return;
            File.Delete(path);
        }

        public bool Contains(string templateName)
        {
            return this.templates.ContainsKey(templateName.ToLower());
        }

        public void SaveAll()
        {
            foreach (KeyValuePair<string, ChartColorTemplate> keyValuePair in this.templates)
                this.SaveTemplate(keyValuePair.Key, keyValuePair.Value);
        }
    }
}
