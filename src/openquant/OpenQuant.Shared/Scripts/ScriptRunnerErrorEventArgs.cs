namespace OpenQuant.Shared.Scripts
{
	public class ScriptRunnerErrorEventArgs : ScriptRunnerEventArgs
	{
		public ScriptRunnerError Error { get; private set; }

		internal ScriptRunnerErrorEventArgs(ScriptRunner runner, ScriptRunnerError error) : base(runner)
		{
			this.Error = error;
		}
	}
}
