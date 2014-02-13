namespace OpenQuant.Shared.Compiler
{
	public class CompilerParameters : System.CodeDom.Compiler.CompilerParameters
	{
		internal CompilerParameters()
		{
			this.GenerateInMemory = false;
			this.IncludeDebugInformation = true;
			this.GenerateExecutable = false;
			this.WarningLevel = 3;
			this.TempFiles.KeepFiles = true;
		}
	}
}
