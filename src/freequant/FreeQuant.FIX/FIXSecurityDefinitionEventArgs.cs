using System;

namespace FreeQuant.FIX
{
	public class FIXSecurityDefinitionEventArgs : EventArgs
	{
		public FIXSecurityDefinition SecurityDefinition { get; set; }

		public FIXSecurityDefinitionEventArgs(FIXSecurityDefinition securityDefinition)
		{
			this.SecurityDefinition = securityDefinition;
		}
	}
}
