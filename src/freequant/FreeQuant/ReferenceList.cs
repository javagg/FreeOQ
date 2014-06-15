using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant
{
    public class ReferenceList : ReadOnlyCollectionBase
    {
        private ArrayList references;
        public Reference this[int index]
        {
            get
            {
                return (Reference)this.references[index];
            }
        }

        internal ReferenceList()
        {
            this.references = new ArrayList();
        }

        internal void Add(Reference reference)
        {
            this.references.Add(reference);
        }

        internal void Remove(Reference reference)
        {
            this.references.Remove(reference);
        }
    }
}
