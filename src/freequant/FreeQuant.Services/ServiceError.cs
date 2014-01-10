using System;

namespace FreeQuant.Services
{
	public class ServiceError
	{
		private IService service;
		private ServiceErrorType errorType;
		private DateTime dateTime;
		private string text;

		public IService Service
		{
			get
			{
				return this.service; 
			}
		}

		public ServiceErrorType ErrorType
		{
			get
			{
				return this.errorType; 
			}
		}

		public DateTime DateTime
		{
			get
			{
				return this.dateTime; 
			}
		}

		public string Text
		{
			get
			{
				return this.text; 
			}
		}

		public ServiceError(IService service, ServiceErrorType errorType, DateTime datetime, string text)
		{
			this.service = service;
			this.errorType = errorType;
			this.dateTime = datetime;
			this.text = text;
		}
	}
}
