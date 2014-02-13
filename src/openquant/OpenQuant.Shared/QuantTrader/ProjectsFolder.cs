using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Shared.QuantTrader
{
	public class ProjectsFolder : PackageFolder, IEnumerable<ProjectFolder>, IEnumerable
	{
		public ProjectFolder this [string name]
		{
			get
			{
				return this.GetEntry<ProjectFolder>(name);
			}
		}

		public IEnumerator<ProjectFolder> GetEnumerator()
		{
			return this.GetFoldersAs<ProjectFolder>();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
