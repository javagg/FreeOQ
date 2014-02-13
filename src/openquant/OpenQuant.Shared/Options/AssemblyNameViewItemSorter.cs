using System.Collections;
using System.Reflection;

namespace OpenQuant.Shared.Options
{
	class AssemblyNameViewItemSorter : IComparer
	{
		public int Compare(object x, object y)
		{
			AssemblyName assembly1 = ((AssemblyNameViewItem)x).Assembly;
			AssemblyName assembly2 = ((AssemblyNameViewItem)y).Assembly;
			int num = string.Compare(assembly1.Name, assembly2.Name);
			if (num == 0)
				num = assembly1.Version.CompareTo(assembly2.Version);
			return num;
		}
	}
}
