using System;

namespace CleverQuant.Projects
{
    class ProjectManager
    {
		public ProjectManager()
        {
        }

		public Solution ActiveSolution { get; set; }

		public void CloseActiveSolution()
		{
			if (this.ActiveSolution == null)
				return;
			this.ActiveSolution.Close();
			this.ActiveSolution = null;
			if (this.SolutionClosed == null)
				return;
			this.SolutionClosed((object) this, EventArgs.Empty);
		}

		public event EventHandler SolutionOpened;
		public event EventHandler SolutionClosed;
		public event EventHandler ProjectAdded;
		public event EventHandler ProjectRemoved;
		public event EventHandler RecentSolutionsUpdated;
    }
}

