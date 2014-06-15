using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections;
using System;

namespace FreeQuant
{
    public class GAC
    {
        private static ArrayList assemblies;
      
        public static AssemblyName[] Assemblies
        {
            get
            { 
                return assemblies.ToArray(typeof(AssemblyName)) as AssemblyName[];;
            }
        }

        static GAC()
        {
            assemblies = new ArrayList();
            IAssemblyEnum assemblyEnum = null;
            IAssemblyName assemblyName = null;
            Fusion.CreateAssemblyEnum(out assemblyEnum, null, null, (uint)Fusion.AssemblyCacheFlags.GAC, IntPtr.Zero);
            assemblyEnum.GetNextAssembly(IntPtr.Zero, out assemblyName, 0);
            while (assemblyName != null)
            {
                uint ccbuf = 1024;
                StringBuilder sb = new StringBuilder((int)ccbuf);
                assemblyName.GetDisplayName(sb, ref ccbuf, (uint)Fusion.AssemblyNameDisplayFlags.ALL);
                assemblies.Add(new AssemblyName(sb.ToString()));
                assemblyEnum.GetNextAssembly(IntPtr.Zero, out assemblyName, 0);
            }
        }
        public static bool Exists(AssemblyName assemblyName)
        {
            return GAC.assemblies.Contains(assemblyName);
        }

        public static string GetPath(AssemblyName assemblyName)
        {
            return GAC.Exists(assemblyName) ? new Uri(assemblyName.CodeBase).LocalPath : string.Empty;
        }
    }
}
