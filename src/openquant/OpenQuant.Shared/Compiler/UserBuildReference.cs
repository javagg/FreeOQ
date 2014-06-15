using System.Reflection;

namespace OpenQuant.Shared.Compiler
{
	class UserBuildReference : BuildReference
	{
		public UserBuildReference(string hintPath) : base(BuildReferenceType.User)
		{
			this.hintPath = hintPath;
			try
			{
				this.assembly = AssemblyName.GetAssemblyName(hintPath);
			}
			catch
			{
			}
		}
	}
}
