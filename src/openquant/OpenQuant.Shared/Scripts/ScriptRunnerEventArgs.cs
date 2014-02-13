using System;

namespace OpenQuant.Shared.Scripts
{
	public class ScriptRunnerEventArgs : EventArgs
	{
		public ScriptRunner Runner { get; private set; }

		internal ScriptRunnerEventArgs(ScriptRunner runner)
		{
			this.Runner = runner;
		}
	}
}
