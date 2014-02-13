using System.IO;
using System.Threading;
using System.Xml.Serialization;

namespace OpenQuant.Shared.Options
{
  [OptionsNode("Scripts", typeof (ScriptsOptionsPanel))]
  public class ScriptsOptions : OptionsBase
  {
    private FileInfo configFile;

    public ApartmentState ApartmentState { get; set; }

    public ScriptsOptions(FileInfo configFile)
    {
      this.configFile = configFile;
    }

    protected override void OnLoad()
    {
      if (this.configFile.Exists)
      {
        try
        {
          using (FileStream fileStream = new FileStream(this.configFile.FullName, FileMode.Open))
            this.ApartmentState = ((ScriptsXmlData) new XmlSerializer(typeof (ScriptsXmlData)).Deserialize((Stream) fileStream)).ApartmentState;
        }
        catch
        {
        }
      }
      else
        this.ApartmentState = ApartmentState.STA;
    }

    protected override void OnSave()
    {
      ScriptsXmlData scriptsXmlData = new ScriptsXmlData();
      scriptsXmlData.ApartmentState = this.ApartmentState;
      using (FileStream fileStream = new FileStream(this.configFile.FullName, FileMode.Create))
        new XmlSerializer(typeof (ScriptsXmlData)).Serialize((Stream) fileStream, scriptsXmlData);
    }
  }
}
