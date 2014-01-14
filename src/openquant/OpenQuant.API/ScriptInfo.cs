namespace OpenQuant.API
{
	///<summary>
	///  ScriptInfo class. ScriptInfo is used to start scripts from the code
	///</summary>
	public class ScriptInfo
	{
		///<summary>
		///  Gets settings
		///</summary>
		public ScriptSettings Settings { get; private set; }

		///<summary>
		///  Gets or sets path to the script
		///</summary>
		public string Path { get; set; }

		///<summary>
		///  ScriptInfo constructor 
		///</summary>
		public ScriptInfo(string path)
		{
			this.Path = path;
			this.Settings = new ScriptSettings();
		}
	}
}
