using System;
using System.Collections.Generic;

namespace FreeQuant
{
	public struct LicenseInfo
	{
		public bool Licensed;
		public bool EvaluationLockEnabled;
		public EvaluationType EvaluationType;
		public int EvaluationTime;
		public int EvaluationTimeCurrent;
		public bool ExpirationDateLockEnabled;
		public DateTime ExpirationDate;
		public bool NumberOfUsesLockEnables;
		public int NumberOfUses;
		public int NumberOfUsesCurrent;
		public SortedList<string, string> KeyValueList;
	}
}
