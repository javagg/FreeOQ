using System;

namespace FreeQuant.Services
{
	public class ServiceEventArgs : EventArgs
	{
		public IService Service { get; private set; }
		public ServiceEventArgs(IService service) : base()
		{
			this.Service = service;
		}
	}
}
