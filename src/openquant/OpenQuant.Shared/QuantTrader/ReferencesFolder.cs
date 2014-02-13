using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Shared.QuantTrader
{
	public class ReferencesFolder : PackageFolder, IEnumerable<AssemblyFile>, IEnumerable
	{
		public AssemblyFile this [string name]
		{
			get
			{
				return this.GetEntry<AssemblyFile>(name);
			}
		}

		public IEnumerator<AssemblyFile> GetEnumerator()
		{
			return this.GetFilesAs<AssemblyFile>();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
