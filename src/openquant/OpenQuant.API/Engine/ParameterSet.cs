using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API.Engine
{

	///<summary>
	///  A parameter set
	///</summary>
	public class ParameterSet : IEnumerable
	{
		private Dictionary<string, Parameter> parameters;

		///<summary>
		///  Gets the number of parameters in this parameter set
		///</summary>
		public int Count
		{
			get
			{
				return this.parameters.Count;
			}
		}

		///<summary>
		///  Gets parameter by name
		///</summary>
		public Parameter this[string name]
		{
			get
			{
				return this.parameters[name];
			}
		}

		internal ParameterSet(List<Parameter> list)
		{
			this.parameters = new Dictionary<string, Parameter>();
			foreach (Parameter parameter in list)
			{
				this.parameters[parameter.Name] = parameter;
			}
		}

		///<summary>
		///  Gets enumerator
		///</summary>
		public IEnumerator GetEnumerator()
		{
			return this.parameters.Values.GetEnumerator();
		}

		///<summary>
		///  Gets if the parameter set contains a parameter with specified name
		///</summary>
		public bool Contains(string name)
		{
			return this.parameters.ContainsKey(name);
		}

		///<summary>
		///  Gets parameter by name
		///</summary>
		public bool TryGetValue(string name, out Parameter parameter)
		{
			return this.parameters.TryGetValue(name, out parameter);
		}
	}
}
