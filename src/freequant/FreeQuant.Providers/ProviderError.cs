using System;

namespace FreeQuant.Providers
{
	public class ProviderError
	{
		public DateTime DateTime { get; private set; }
		public IProvider Provider { get; private set; }
		public int Id { get; private set; }
		public int Code  { get; private set; }
		public string Message  { get; private set; }

		public ProviderError(DateTime datetime, IProvider provider, int id, int code, string message)
		{
			this.DateTime = datetime;
			this.Provider = provider;
			this.Id = id;
			this.Code = code;
			this.Message = message;
		}
	}
}
