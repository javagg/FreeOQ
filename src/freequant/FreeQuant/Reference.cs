using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System;

namespace FreeQuant
{
    public class Reference
    {
        protected AssemblyName assemblyName;
        protected ReferenceType referenceType;
        protected bool enabled;
        protected bool valid;

        private Configuration configuration;

        public AssemblyName AssemblyName
        {
            get
            {
                return assemblyName;
            }
        }

        public ReferenceType ReferenceType
        {
            get
            {
                return referenceType;
            }
        }

        [Browsable(false)]
        public bool Enabled
        {
            get
            {
                return enabled;
            }
        }

        public bool Valid
        {
            get
            {
                return valid;
            }
        }

        public virtual string Path
        {
            get
            {
                return new Uri(this.assemblyName.CodeBase).LocalPath;
            }
        }

        protected Reference(ReferenceType referenceType, bool enabled)
        {
            this.referenceType = referenceType;
            this.enabled = enabled;
        }

        internal void sq01wopyU(Configuration value)
        {
            this.configuration = value;
        }
    }
}
