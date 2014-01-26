using System;

namespace FreeQuant.FIX
{
	public class FIXSecurityDefinitionRequestEventArgs : EventArgs
	{
		public FIXSecurityDefinitionRequest SecurityDefinitionRequest { get; set; }

		public FIXSecurityDefinitionRequestEventArgs(FIXSecurityDefinitionRequest securityDefinitionRequest)
		{
			this.SecurityDefinitionRequest = securityDefinitionRequest;
		}
	}
}
