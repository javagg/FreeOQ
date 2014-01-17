using CleverQuant.Shared.Compiler;
using System.CodeDom.Compiler;
using Microsoft.Build.Tasks;

namespace CleverQuant.Projects
{
	class BuildError : Error
	{
		public StrategyProject Project { get; private set; }

		public Solution Solution { get; private set; }

		public BuildError(CompilerError error) : base(error)
		{
		}

		public BuildError(StrategyProject project, CompilerError error)
			: this(error)
		{
			this.Project = project;
		}

		public BuildError(Solution solution, CompilerError error)
			: this(error)
		{
			this.Solution = solution;
		}
	}
	class BuildErrorCollection : List<BuildError>
	{
	}
}
