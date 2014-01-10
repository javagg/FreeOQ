using System;

namespace FreeQuant.Services
{
	public class ServiceEventArgs : EventArgs
	{
		private IService srvice;

		public IService Service
		{
			get
			{
				return this.srvice; 
			}
		}

		public ServiceEventArgs(IService service) : base()
		{
			this.srvice = service;
		}
	}
}
