using System.Collections.Generic;
using System.IO;

namespace OpenQuant.API.Engine
{
	///<summary>
	///  A solution info
	///</summary>
	public class SolutionInfo
	{
		private List<ProjectInfo> projects;

		public ProjectInfoList Projects
		{
			get
			{
				return new ProjectInfoList(this.projects);
			}
		}

		public FileInfo SolutionFile { get; private set; }

		public FileInfo ScenarioFile { get; private set; }

		public string Name { get; private set; }

		internal SolutionInfo(string name, FileInfo solutionFile, FileInfo scenarioFile)
		{
			this.Name = name;
			this.SolutionFile = solutionFile;
			this.ScenarioFile = scenarioFile;
			this.projects = new List<ProjectInfo>();
		}

		private void Add(string name, FileInfo projectFile, FileInfo codeFile)
		{
			this.projects.Add(new ProjectInfo(name, projectFile, codeFile));
		}
	}
}
