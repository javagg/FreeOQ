using System.ComponentModel;

namespace FreeQuant
{
    public class Plugin
    {
        public string AssemblyName { get; private set; }
        public string TypeName { get; private set; }
        public bool Enabled { get; set; }
        public bool X64Supported { get; private set; }
        public bool Loaded
        { 
            get
            {
                return true;
            }
        }

        public Plugin(string assemblyName, string typeName, bool enabled, bool x64Supported)
        {
            this.AssemblyName = assemblyName;
            this.TypeName = typeName;
            this.Enabled = enabled;
            this.X64Supported = x64Supported;
        }

//        internal object e6CmMXeUG5()
//        {
//            return (object)null;
//        }
//
//        internal void ixymUtLVYL(Configuration value)
//        {
//        }
    }
}
