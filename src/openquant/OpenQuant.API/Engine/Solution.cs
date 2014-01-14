using OpenQuant.API;
using System;
using System.Collections.Generic;

namespace OpenQuant.API.Engine
{
	///<summary>
	///  A solition
	///</summary>
	public class Solution
	{
		private Statistics statistics;

		public DateTime StartDate { get; set; }

		public DateTime StopDate { get; set; }

		public double Cash { get; set; }

		public bool ReportEnabled { get; set; }

		public string Name { get; private set; }

		public ProjectList Projects { get; private set; }

		public Portfolio Portfolio { get; private set; }

		public Performance Performance { get; private set; }

		public Statistics Statistics
		{
			get
			{
				if (this.statistics != null)
					return this.statistics;
				this.statistics = new Statistics(this.Portfolio.portfolio);
				return this.statistics;
			}
		}

		public DataRequests Requests { get; set; }

		private Solution()
		{
			this.Requests = new DataRequests();
		}

		internal void OnStart()
		{
			if (this.statistics != null)
				this.statistics.IsCalculated = false;
			foreach (Project project in this.Projects)
				project.OnStart();
		}

		private void Init(string name, Portfolio portfolio, DateTime startDate, DateTime stopDate, double cash, bool reportEnabled, List<Project> projects)
		{
			this.Name = name;
			this.Portfolio = portfolio;
			this.Performance = new Performance(portfolio);
			this.StartDate = startDate;
			this.StopDate = stopDate;
			this.Cash = cash;
			this.ReportEnabled = reportEnabled;
			this.Projects = new ProjectList(projects);
		}
	}
}
