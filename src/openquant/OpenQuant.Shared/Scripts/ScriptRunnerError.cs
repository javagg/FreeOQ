using System;

namespace OpenQuant.Shared.Scripts
{
	public class ScriptRunnerError
	{
		public Exception Exception { get; private set; }

		internal ScriptRunnerError(Exception e)
		{
			this.Exception = e;
		}
	}
}
