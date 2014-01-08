using System;

namespace FreeQuant.Data
{
	public interface IDataObject
	{
		DateTime DateTime { get; set; }

		byte ProviderId { get; set; }
	}
}
