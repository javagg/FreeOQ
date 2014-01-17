using CleverQuant.Shared.Compiler;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Build.Tasks;

namespace CleverQuant.Projects
{
	internal class BuildErrorCollection : List<BuildError>
	{
		public bool HasErrors
		{
			get
			{
				foreach (Error error in this)
				{
					if (!error.IsWarning)
						return true;
				}
				return false;
			}
		}

		public bool HasWarnings
		{
			get
			{
				foreach (Error error in this)
				{
					if (error.IsWarning)
						return true;
				}
				return false;
			}
		}

		public BuildErrorCollection(CompilerErrorCollection collection)
		{
			foreach (CompilerError error in collection)
				this.Add(new BuildError(error));
		}

		public BuildErrorCollection(CompilerErrorCollection collection, StrategyProject project)
		{
			foreach (CompilerError error in collection)
				this.Add(new BuildError(project, error));
		}

		public BuildErrorCollection(CompilerErrorCollection collection, Solution solution)
		{
			foreach (CompilerError error in collection)
				this.Add(new BuildError(solution, error));
		}
	}
}
