using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API
{
	///<summary>
	///  Script settings
	///</summary>
	public class ScriptSettings : IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		private Dictionary<string, object> settings;

		///<summary>
		///  Count of script settings 
		///</summary>
		public int Count
		{
			get
			{
				return this.settings.Count;
			}
		}

		///<summary>
		///  Gets or sets script setting by name
		///</summary>
		public object this[string name]
		{
			get
			{
				object obj = (object)null;
				this.settings.TryGetValue(name, out obj);
				return obj;
			}
			set
			{
				this.settings[name] = value;
			}
		}

		internal ScriptSettings()
		{
			this.settings = new Dictionary<string, object>();
		}

		///<summary>
		///  Gets enumerator 
		///</summary>
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return (IEnumerator<KeyValuePair<string, object>>)this.settings.GetEnumerator();
		}

		///<summary>
		///  Adds script setting by name
		///</summary>
		public void Add(string name, object data)
		{
			this.settings.Add(name, data);
		}

		///<summary>
		///  Removes script settings by name
		///</summary>
		public void Remove(string name)
		{
			this.settings.Remove(name);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.settings.GetEnumerator();
		}
	}
}
