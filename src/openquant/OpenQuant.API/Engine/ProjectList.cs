using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API.Engine
{
	///<summary>
	///  A project list
	///</summary>
	public class ProjectList : IEnumerable
	{
		private Dictionary<string, Project> projects;

		public int Count
		{
			get
			{
				return this.projects.Count;
			}
		}

		public Project this [string name]
		{
			get
			{
				return this.projects[name];
			}
		}

		public Project this [int index]
		{
			get
			{
				int num = 0;
				foreach (Project project in this.projects.Values)
				{
					if (num == index)
						return project;
					++num;
				}
				throw new IndexOutOfRangeException("Project with specified index does not exist");
			}
		}

		internal ProjectList(List<Project> list)
		{
			this.projects = new Dictionary<string, Project>();
			foreach (Project project in list)
				this.projects[project.Name] = project;
		}

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)this.projects.Values.GetEnumerator();
		}

		public bool Contains(string name)
		{
			return this.projects.ContainsKey(name);
		}

		public bool TryGetValue(string name, out Project project)
		{
			return this.projects.TryGetValue(name, out project);
		}
	}
}
