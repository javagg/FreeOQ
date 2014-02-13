using System.IO;
using System.Reflection;

namespace OpenQuant.Shared.Compiler
{
	internal class APIBuildReference : BuildReference
	{
		public APIBuildReference (string name, DirectoryInfo directory) : base(BuildReferenceType.API)
		{
			this.name = name;
			try
			{
				this.assembly = AssemblyName.GetAssemblyName (string.Format ("{0}\\{1}.dll", directory.FullName, name));
			} catch
			{
			}
		}
	}
}
