using System.IO;
using System.Reflection;

namespace OpenQuant.Shared.Compiler
{
    class APIBuildReference : BuildReference
    {
        public APIBuildReference(string name, DirectoryInfo directory) : base(BuildReferenceType.API)
        {
            this.name = name;
            try
            {
                this.assembly = AssemblyName.GetAssemblyName(System.IO.Path.Combine(directory.FullName, string.Format("{0}.dll", name)));
            }
            catch
            {
            }
        }
    }
}
