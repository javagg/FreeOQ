using System;

namespace FreeQuant.Services
{
	public interface IService
	{
		byte Id { get; }
		string Name { get; }
		string Description { get; }
		ServiceStatus Status { get; }
		event EventHandler StatusChanged;
		event ServiceErrorEventHandler Error;
		void Start();
		void Stop();
	}
}
