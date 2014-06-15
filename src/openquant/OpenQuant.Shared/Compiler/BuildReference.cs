using System;
using System.Reflection;

namespace OpenQuant.Shared.Compiler
{
    public class BuildReference
    {
        protected string name;
        protected Version version;
        protected string hintPath;
        protected AssemblyName assembly;

        public BuildReferenceType Type { get; private set; }

        public string Name
        {
            get
            {
                return !this.Valid ? this.name : this.assembly.Name;
            }
        }

        public Version Version
        {
            get
            {
                return !this.Valid ? this.version : this.assembly.Version;
            }
        }

        public bool Valid
        { 
            get
            {
                return this.assembly != null;
            }
        }

        public string Path
        {
            get
            {
//                return Uri.UnescapeDataString(new UriBuilder(this.assembly.CodeBase));
                return new Uri(this.assembly.CodeBase).LocalPath;
//                return this.assembly.CodeBase.Replace("file:///", "").Replace('/', System.IO.Path.DirectorySeparatorChar);
            }
        }

        public string HintPath
        {
            get
            {
                return !this.Valid ? this.hintPath : this.Path;
            }
        }

        public AssemblyName Assembly
        {
            get
            {
                return this.assembly;
            }
        }

        protected BuildReference(BuildReferenceType type)
        {
            this.Type = type;
            this.name = string.Empty;
            this.version = new Version(0, 0, 0, 0);
            this.hintPath = string.Empty;
        }
    }
}
