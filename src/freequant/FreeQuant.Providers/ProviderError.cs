using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	public class ProviderError
	{
		private DateTime dateTime;
		private IProvider provider;
		private int id;
		private int code;
		private string mMessage;

		public DateTime DateTime
		{
			get
			{
				return this.dateTime;  
			}
		}

		public IProvider Provider
		{
			get
			{
				return this.provider; 
			}
		}

		public int Id
		{
			get
			{
				return this.id; 
			}
		}

		public int Code
		{
			get
			{
				return this.code; 
			}
		}

		public string Message
		{
			get
			{
				return this.mMessage; 
			}
		}

		public ProviderError(DateTime datetime, IProvider provider, int id, int code, string message)
		{
			this.dateTime = datetime;
			this.provider = provider;
			this.id = id;
			this.code = code;
			this.mMessage = message;
		}
	}
}
