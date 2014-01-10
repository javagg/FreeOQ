using System;

namespace FreeQuant.Services
{
	public class ServiceErrorEventArgs : EventArgs
	{
		private ServiceError error;

		public ServiceError Error
		{
			get
			{
				return this.error; 
			}
		}

		public ServiceErrorEventArgs(ServiceError error) : base()
		{
			this.error = error;
		}
	}
}
