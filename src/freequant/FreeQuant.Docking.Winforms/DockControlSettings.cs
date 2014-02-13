using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace FreeQuant.Docking.WinForms
{
	public class DockControlSettings : IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		private Dictionary<string, string> settings;

		internal DockControlSettings()
		{
			this.settings = new Dictionary<string, string>();
		}

		public void Clear()
		{
			this.settings.Clear();
		}

		public void SetValue(string key, string value)
		{
			this.settings[key] = value;
		}

		public void SetValue(string key, byte value)
		{
			this.SetValue(key, value.ToString(CultureInfo.InvariantCulture));
		}

		public void SetValue(string key, bool value)
		{
			this.SetValue(key, value.ToString(CultureInfo.InvariantCulture));
		}

		public void SetEnumValue<T>(string key, T value) where T : struct
		{
			this.SetValue(key, value.ToString());
		}

		public void SetValue(string key, TimeSpan value)
		{
			this.SetValue(key, value.ToString("c", CultureInfo.InvariantCulture));
		}

		public void SetValue(string key, int[] value)
		{
			List<string> list = new List<string>();
			foreach (int num in value)
				list.Add(num.ToString());
			this.SetValue(key, string.Join(",", list));
		}

		public string GetStringValue(string key, string defaultValue)
		{
			string str;
			if (!this.settings.TryGetValue(key, out str))
				str = defaultValue;
			return str;
		}

		public byte GetByteValue(string key, byte defaultValue)
		{
			byte result;
			if (!byte.TryParse(this.GetStringValue(key, defaultValue.ToString(CultureInfo.InvariantCulture)), NumberStyles.None, (IFormatProvider) CultureInfo.InvariantCulture, out result))
				result = defaultValue;
			return result;
		}

		public bool GetBooleanValue(string key, bool defaultValue)
		{
			bool result;
			if (!bool.TryParse(this.GetStringValue(key, defaultValue.ToString(CultureInfo.InvariantCulture)), out result))
				result = defaultValue;
			return result;
		}

		public T GetEnumValue<T>(string key, T defaultValue) where T : struct
		{
			T result;
			if (!Enum.TryParse<T>(this.GetStringValue(key, defaultValue.ToString()), out result))
				result = defaultValue;
			return result;
		}

		public TimeSpan GetTimeSpanValue(string key, TimeSpan defaultValue)
		{
			TimeSpan result;
			if (!TimeSpan.TryParse(this.GetStringValue(key, defaultValue.ToString("c", CultureInfo.InvariantCulture)), out result))
				result = defaultValue;
			return result;
		}

		public int[] GetInt32ArrayValue(string key, int[] defaultValue)
		{
			string stringValue = this.GetStringValue(key, null);
			if (string.IsNullOrWhiteSpace(stringValue))
				return defaultValue;
			List<int> list = new List<int>();
			string str = stringValue;
			char[] chArray = new char[] { ',' };
			foreach (string s in str.Split(chArray))
			{
				int result;
				if (!int.TryParse(s, out result))
					return defaultValue;
				list.Add(result);
			}
			return list.ToArray();
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return this.settings.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
