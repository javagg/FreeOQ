using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Shared.QuantTrader
{
	public class SolutionsFolder : PackageFolder, IEnumerable<SolutionFolder>, IEnumerable
	{
		public SolutionFolder this [string name]
		{
			get
			{
				return this.GetEntry<SolutionFolder>(name);
			}
		}

		public IEnumerator<SolutionFolder> GetEnumerator()
		{
			return this.GetFoldersAs<SolutionFolder>();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
