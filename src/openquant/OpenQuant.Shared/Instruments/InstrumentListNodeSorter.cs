using System;
using System.Collections;
using System.Windows.Forms;

namespace OpenQuant.Shared.Instruments
{
	class InstrumentListNodeSorter : IComparer
	{
		public int Compare(object x, object y)
		{
			if (x is MaturityGroupNode && y is MaturityGroupNode)
				return DateTime.Compare(((MaturityGroupNode)x).Maturity, ((MaturityGroupNode)y).Maturity);
			else
				return string.Compare(((TreeNode)x).Text, ((TreeNode)y).Text);
		}
	}
}
