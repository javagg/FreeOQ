using FreeQuant.FIX;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API
{
	internal class ExecutionReportListEnumerator : IEnumerator
	{
		private List<FIXMessage> messages;
		private IEnumerator enumerator;

		public object Current
		{
			get
			{
				return (object)new ExecutionReport((FIXMessage)(this.enumerator.Current as FreeQuant.FIX.ExecutionReport));
			}
		}

		internal ExecutionReportListEnumerator(List<FIXMessage> messages)
		{
			this.messages = messages;
			this.enumerator = (IEnumerator)messages.GetEnumerator();
		}

		public bool MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		public void Reset()
		{
			this.enumerator.Reset();
		}
	}
}
