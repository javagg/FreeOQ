using System.IO;

namespace OpenQuant.API.Engine
{

	///<summary>
	///  A Project Info 
	///</summary>
	public class ProjectInfo
	{
		///<summary>
		///  Gets project name 
		///</summary>
		public string Name { get; private set; }

		///<summary>
		///  Gets project settings file path
		///</summary>
		public FileInfo ProjectFile { get; private set; }

		///<summary>
		///  Gets project code file path 
		///</summary>
		public FileInfo CodeFile { get; private set; }

		internal ProjectInfo(string name, FileInfo projectFile, FileInfo codeFile)
		{
			this.Name = name;
			this.ProjectFile = projectFile;
			this.CodeFile = codeFile;
		}
	}
}
