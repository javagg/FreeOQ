using System;

namespace OpenQuant.API.Engine
{
	///<summary>
	///  A parameter
	///</summary>
	public class Parameter
	{
		///<summary>
		///  Parameter Name 
		///</summary>
		public string Name { get; set; }

		///<summary>
		///  Parameter Value 
		///</summary>
		public object Value { get; set; }

		///<summary>
		///  Parameter Type 
		///</summary>
		public Type Type { get; private set; }

		///<summary>
		///  Parameter constructor
		///</summary>
		public Parameter(string name, object value, Type type)
		{
			this.Name = name;
			this.Value = value;
			this.Type = type;
		}
	}
}
