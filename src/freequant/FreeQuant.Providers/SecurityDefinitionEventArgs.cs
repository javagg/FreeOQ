using FreeQuant.FIX;
using System;

namespace FreeQuant.Providers
{
	public class SecurityDefinitionEventArgs : EventArgs
	{
		public FIXSecurityDefinition SecurityDefinition { get; private set; }

		public SecurityDefinitionEventArgs(FIXSecurityDefinition definition) : base()
		{
			this.SecurityDefinition = definition; 
		}
	}
}
