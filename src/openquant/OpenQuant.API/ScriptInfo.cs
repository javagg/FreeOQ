namespace OpenQuant.API
{
  public class ScriptInfo
  {
    public ScriptSettings Settings { get; private set; }

    public string Path { get; set; }

    public ScriptInfo(string path)
    {
      this.Path = path;
      this.Settings = new ScriptSettings();
    }
  }
}
