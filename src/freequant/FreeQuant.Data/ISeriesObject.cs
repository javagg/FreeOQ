using System;
using System.IO;

namespace FreeQuant.Data
{
	public interface ISeriesObject : ICloneable
	{
		DateTime DateTime { get; }

		void ReadFrom(BinaryReader reader);

		void WriteTo(BinaryWriter writer);

		ISeriesObject NewInstance();
	}
}
