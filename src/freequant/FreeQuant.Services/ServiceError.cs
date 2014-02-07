using System;

namespace FreeQuant.Services
{
	public class ServiceError
	{
		public IService Service { get; private set; }

		public ServiceErrorType ErrorType { get; private set; }

		public DateTime DateTime { get; private set; }

		public string Text { get; private set; }

		public ServiceError(IService service, ServiceErrorType errorType, DateTime datetime, string text)
		{
			this.Service = service;
			this.ErrorType = errorType;
			this.DateTime = datetime;
			this.Text = text;
		}
	}
}
