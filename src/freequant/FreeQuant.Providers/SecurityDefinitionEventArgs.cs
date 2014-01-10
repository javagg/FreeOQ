using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	public class SecurityDefinitionEventArgs : EventArgs
	{
		private FIXSecurityDefinition securityDefinition;

		public FIXSecurityDefinition SecurityDefinition
		{
			get
			{
				return this.securityDefinition; 
			}
		}

		public SecurityDefinitionEventArgs(FIXSecurityDefinition definition) : base()
		{
			this.securityDefinition = definition; 
		}
	}
}
