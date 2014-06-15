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
            foreach (FileInfo fileInfo in this.directory.GetFiles(string.Format("*{0}", TEMPLATE_EXT)))
                this.LoadTemplate(fileInfo);
            this.LoadConfig();
            this.SaveConfig();
        }

        private void LoadConfig()
        {
            ChartColorTemplateConfigXmlDocument doc = new ChartColorTemplateConfigXmlDocument();
            if (File.Exists(this.configFile.FullName))
                doc.Load(this.configFile.FullName);
            string defaultTemplate = doc.DefaultTemplate;
            if (defaultTemplate != null && this.templates.TryGetValue(defaultTemplate.ToLower(), out this.defaultTemplate))
                return;
            this.defaultTemplate = new ChartColorTemplate("Default Template");
        }

        private void SaveConfig()
        {
            new ChartColorTemplateConfigXmlDocument()
            {
                DefaultTemplate = this.defaultTemplate.Name
            }.Save(this.configFile.FullName);
        }

        private void LoadTemplate(FileInfo fileInfo)
        {
            ChartColorTemplateXmlDocument doc = new ChartColorTemplateXmlDocument();
            doc.Load(fileInfo.FullName);
            ChartColorTemplate template = new ChartColorTemplate(doc.TemplateName);

            foreach (PropertyXmlNode node in doc.Properties)
            {
                string[] array = node.Value.Split(new char[]  { ',' });
                int a = int.Parse(array[0]);
                int r = int.Parse(array[1]);
                int g = int.Parse(array[2]);
                int b = int.Parse(array[3]);
                template.Settings[node.Name] = Color.FromArgb(a, r, g, b);
            }

//            IEnumerator enumerator = ((ListXmlNode<PropertyXmlNode>)doc.Properties).GetEnumerator();
//            try
//            {
//                while (enumerator.MoveNext())
//                {
//                    PropertyXmlNode propertyXmlNode = (PropertyXmlNode)enumerator.Current;
//                    string[] strArray = propertyXmlNode.Value.Split(new char[]  { ',' });
//                    int alpha = int.Parse(strArray[0]);
//                    int red = int.Parse(strArray[1]);
//                    int green = int.Parse(strArray[2]);
//                    int blue = int.Parse(strArray[3]);
//                    template.Settings[propertyXmlNode.Name] = Color.FromArgb(alpha, red, green, blue);
//                }
//            }
//            finally
//            {
//                IDisposable disposable = enumerator as IDisposable;
//                if (disposable != null)
//                    disposable.Dispose();
//            }
            this.templateNameList.Add(template.Name);
            this.templates.Add(template.Name.ToLower(), template);
        }

        private void SaveTemplate(string name, ChartColorTemplate template)
        {
            ChartColorTemplateXmlDocument doc = new ChartColorTemplateXmlDocument();
            doc.TemplateName = template.Name;
            foreach (KeyValuePair<string, Color> pair in template.Settings)
            {
                Color color = pair.Value;
                string str = (string)(object)color.A + "," + (string)(object)color.R + "," + (string)(object)color.G + "," + (string)(object)color.B;
                doc.Properties.Add(pair.Key, typeof(Color), str);
            }
            doc.Save(Path.Combine(this.directory.FullName, string.Format("{0}{1}" + name + TEMPLATE_EXT)));
        }

        public ChartColorTemplate GetTemplate(string name)
        {
            return this.templates.ContainsKey(name.ToLower()) ? this.templates[name.ToLower()] : null;
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
            string path = Path.Combine(this.directory.FullName, string.Format("{0}{1}", template.Name, TEMPLATE_EXT));
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
            foreach (KeyValuePair<string, ChartColorTemplate> pair in this.templates)
                this.SaveTemplate(pair.Key, pair.Value);
        }
    }
}
