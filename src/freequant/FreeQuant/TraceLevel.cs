namespace FreeQuant
{
	public class TraceLevel
	{
		public static readonly System.Diagnostics.TraceLevel Off;
		public static readonly System.Diagnostics.TraceLevel Error;
		public static readonly System.Diagnostics.TraceLevel Warning;
		public static readonly System.Diagnostics.TraceLevel Info;
		public static readonly System.Diagnostics.TraceLevel Verbose;

		static TraceLevel()
		{
			TraceLevel.Off = System.Diagnostics.TraceLevel.Off;
			TraceLevel.Error = System.Diagnostics.TraceLevel.Error;
			TraceLevel.Warning = System.Diagnostics.TraceLevel.Warning;
			TraceLevel.Info = System.Diagnostics.TraceLevel.Info;
			TraceLevel.Verbose = System.Diagnostics.TraceLevel.Verbose;
		}
	}
}
