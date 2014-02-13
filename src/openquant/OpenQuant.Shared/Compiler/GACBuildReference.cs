using FreeQuant;
using System;
using System.Reflection;

namespace OpenQuant.Shared.Compiler
{
	internal class GACBuildReference : BuildReference
	{
		public GACBuildReference(string name, Version version)
      : base(BuildReferenceType.NET)
		{
			this.name = name;
			if (version != (Version)null)
				this.version = version;
			foreach (AssemblyName assemblyName in GAC.Assemblies)
			{
				if (assemblyName.Name == name && (version == (Version)null || assemblyName.Version == version))
				{
					this.assembly = assemblyName;
					break;
				}
			}
		}
	}
}
