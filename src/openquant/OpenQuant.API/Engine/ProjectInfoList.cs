using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API.Engine
{
	///<summary>
	/// A project info list 
	///</summary>
	public class ProjectInfoList : IEnumerable
	{
		private Dictionary<string, ProjectInfo> projects;

		///<summary>
		/// Gets the number of parameters in this parameter set
		///</summary>
		public int Count
		{
			get
			{
				return this.projects.Count;
			}
		}

		///<summary>
		/// Gets project info by name
		///</summary>
		public ProjectInfo this[string name]
		{
			get
			{
				return this.projects[name];
			}
		}

		///<summary>
		/// Gets project info by index 
		///</summary>
		public ProjectInfo this[int index]
		{
			get
			{
				int num = 0;
				foreach (ProjectInfo projectInfo in this.projects.Values)
				{
					if (num == index)
						return projectInfo;
					++num;
				}
				throw new IndexOutOfRangeException("Project with specified index does not exist");
			}
		}

		internal ProjectInfoList(List<ProjectInfo> list)
		{
			this.projects = new Dictionary<string, ProjectInfo>();
			foreach (ProjectInfo projectInfo in list)
				this.projects[projectInfo.Name] = projectInfo;
		}

		///<summary>
		///  Gets IEnumerator
		///</summary>
		public IEnumerator GetEnumerator()
		{
			return this.projects.Values.GetEnumerator();
		}

		///<summary>
		/// See if contains 
		///</summary>
		public bool Contains(string name)
		{
			return this.projects.ContainsKey(name);
		}

		///<summary>
		///  Gets value 
		///</summary>
		public bool TryGetValue(string name, out ProjectInfo project)
		{
			return this.projects.TryGetValue(name, out project);
		}
	}
}
