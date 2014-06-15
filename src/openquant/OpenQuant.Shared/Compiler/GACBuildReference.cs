using System;
using System.Reflection;
using FreeQuant;

namespace OpenQuant.Shared.Compiler
{
    class GACBuildReference : BuildReference
    {
        public GACBuildReference(string name, Version version) : base(BuildReferenceType.NET)
        {
            this.name = name;
            if (version != null)
                this.version = version;
            foreach (AssemblyName assemblyName in GAC.Assemblies)
            {
                if (assemblyName.Name == name && (version == null || assemblyName.Version == version))
                {
                    this.assembly = assemblyName;
                    break;
                }
            }
        }
    }
}
