using FreeQuant;
using System;

namespace FreeQuant.Services
{
	public abstract class ServiceBase : IService
	{
		protected ServiceStatus status;

		public abstract byte Id { get; }

		public abstract string Name { get; }

		public abstract string Description { get; }

		public virtual ServiceStatus Status
		{
			get
			{
				return this.status;
			}
		}

		public event EventHandler StatusChanged;
		public event ServiceErrorEventHandler Error;

		protected ServiceBase()
		{
		}

		public abstract void Start();
		public abstract void Stop();

		protected void SetServiceStatus(ServiceStatus status)
		{
			this.status = status;
			if (this.StatusChanged != null)
				this.StatusChanged(this, EventArgs.Empty);
		}

		protected void EmitServiceError(ServiceError error)
		{
			if (this.Error != null)
				this.Error(this, new ServiceErrorEventArgs(error));
		}

		protected void EmitServiceError(string text)
		{
			this.EmitServiceError(new ServiceError(this, ServiceErrorType.Error, DateTime.Now, text));
		}

		protected void EmitServiceWarning(string text)
		{
			this.EmitServiceError(new ServiceError(this, ServiceErrorType.Warning, DateTime.Now, text));
		}

		protected void EmitServiceMessage(string text)
		{
			this.EmitServiceError(new ServiceError(this, ServiceErrorType.Message, DateTime.Now, text));
		}
	}
}
