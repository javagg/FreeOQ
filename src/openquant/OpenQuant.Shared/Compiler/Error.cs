using System.CodeDom.Compiler;

namespace OpenQuant.Shared.Compiler
{
	public class Error
	{
		protected CompilerError error;

		public int Line
		{
			get
			{
				return this.error.Line;
			}
		}

		public int Column
		{
			get
			{
				return this.error.Column;
			}
		}

		public string Description
		{
			get
			{
				return this.error.ErrorText;
			}
		}

		public bool IsWarning
		{
			get
			{
				return this.error.IsWarning;
			}
		}

		public string FileName
		{
			get
			{
				return this.error.FileName;
			}
		}

		public Error(CompilerError error)
		{
			this.error = error;
		}
	}
}
