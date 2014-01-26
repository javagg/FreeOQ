using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FreeQuant.FIX
{
	public class FIXGroup
	{
		private Dictionary<int, FIXField> fields;
		private object oncZo3Ix5;

		[Browsable(false)]
		public int Id { get; set; }

		[Browsable(false)]
		public virtual int Tag
		{
			get
			{
				return -1;
			}
		}

		[Browsable(false)]
		public FIXField[] Fields
		{
			get
			{
				lock (this.oncZo3Ix5)
				{
					FIXField[] local_0 = new FIXField[this.fields.Count];
					this.fields.Values.CopyTo(local_0, 0);
					return local_0;
				}
			}
		}

		[Browsable(false)]
		public FIXGroupTable Groups { get; private set; }

		public FIXGroup()
		{
			this.fields = new Dictionary<int, FIXField>();
			this.oncZo3Ix5 = new object();
			this.Id = -1;
			this.Groups = new FIXGroupTable();
		}

		public bool ContainsField(int tag)
		{
			lock (this.oncZo3Ix5)
				return this.fields.ContainsKey(tag);
		}

		public void RemoveField(int tag)
		{
			lock (this.oncZo3Ix5)
				this.fields.Remove(tag);
		}

		public void Clear()
		{
			lock (this.oncZo3Ix5)
				this.fields.Clear();
		}

		public void AddField(FIXField field)
		{
			lock (this.oncZo3Ix5)
				this.fields[field.Tag] = field;
		}

		public void AddField(int tag, object value)
		{
			if (value is char)
				this.AddCharField(tag, (char)value);
			else if (value is int)
				this.AddIntField(tag, (int)value);
			else if (value is double)
				this.AddDoubleField(tag, (double)value);
			else if (value is bool)
				this.AddBoolField(tag, (bool)value);
			else if (value is string)
			{
				this.AddStringField(tag, (string)value);
			}
			else
			{
				if (!(value is DateTime))
					return;
				this.AddDateTimeField(tag, (DateTime)value);
			}
		}

		public void AddStringField(int tag, string value)
		{
			this.AddField(new FIXStringField(tag, value));
		}

		public void AddCharField(int tag, char value)
		{
			this.AddField(new FIXCharField(tag, value));
		}

		public void AddBoolField(int tag, bool value)
		{
			this.AddField(new FIXBoolField(tag, value));
		}

		public void AddIntField(int tag, int value)
		{
			this.AddField(new FIXIntField(tag, value));
		}

		public void AddDoubleField(int tag, double value)
		{
			this.AddField(new FIXDoubleField(tag, value));
		}

		public void AddDateTimeField(int tag, DateTime value)
		{
			this.AddField(new FIXDateTimeField(tag, value));
		}

		public void AddNumInGroupField(int tag, int value)
		{
			this.AddField(new FIXNumInGroupField(tag, value));
		}

		public void AddFields(FIXGroup from)
		{
			foreach (FIXField field in from.Fields)
				this.AddField(field);
		}

		public FIXField GetField(int tag)
		{
			lock (this.oncZo3Ix5)
			{
				FIXField local_0;
				return this.fields.TryGetValue(tag, out local_0) ? local_0 : (FIXField)null;
			}
		}

		public FIXStringField GetStringField(int tag)
		{
			return (FIXStringField)this.GetField(tag);
		}

		public FIXCharField GetCharField(int tag)
		{
			return (FIXCharField)this.GetField(tag);
		}

		public FIXBoolField GetBoolField(int tag)
		{
			return (FIXBoolField)this.GetField(tag);
		}

		public FIXIntField GetIntField(int tag)
		{
			return (FIXIntField)this.GetField(tag);
		}

		public FIXDoubleField GetDoubleField(int tag)
		{
			return (FIXDoubleField)this.GetField(tag);
		}

		public FIXDateTimeField GetDateTimeField(int tag)
		{
			return this.GetField(tag) as FIXDateTimeField;
		}

		public FIXNumInGroupField GetNumInGroupField(int tag)
		{
			return this.GetField(tag) as FIXNumInGroupField;
		}

		public object GetValue(int tag)
		{
			FIXField field = this.GetField(tag);
			if (field != null)
				return field.GetValue();
			else
				return null;
		}

		public bool GetBoolValue(int tag)
		{
			FIXBoolField boolField = this.GetBoolField(tag);
			if (boolField != null)
				return boolField.Value;
			else
				return false;
		}

		public int GetIntValue(int tag)
		{
			FIXIntField intField = this.GetIntField(tag);
			if (intField != null)
				return intField.Value;
			else
				return 0;
		}

		public double GetDoubleValue(int tag)
		{
			FIXDoubleField doubleField = this.GetDoubleField(tag);
			if (doubleField != null)
				return doubleField.Value;
			else
				return 0.0;
		}

		public char GetCharValue(int tag)
		{
			FIXCharField charField = this.GetCharField(tag);
			if (charField != null)
				return charField.Value;
			else
				return char.MinValue;
		}

		public string GetStringValue(int tag)
		{
			FIXStringField stringField = this.GetStringField(tag);
			if (stringField != null)
				return stringField.Value;
			else
				return string.Empty;
		}

		public DateTime GetDateTimeValue(int tag)
		{
			FIXDateTimeField dateTimeField = this.GetDateTimeField(tag);
			if (dateTimeField != null)
				return dateTimeField.Value;
			else
				return new DateTime(0L);
		}

		public int GetNumInGroupValue(int tag)
		{
			FIXNumInGroupField numInGroupField = this.GetNumInGroupField(tag);
			if (numInGroupField != null)
				return numInGroupField.Value;
			else
				return 0;
		}

		public void SetBoolValue(int tag, bool value)
		{
			this.AddBoolField(tag, value);
		}

		public void SetIntValue(int tag, int value)
		{
			this.AddIntField(tag, value);
		}

		public void SetDoubleValue(int tag, double value)
		{
			this.AddDoubleField(tag, value);
		}

		public void SetCharValue(int tag, char value)
		{
			this.AddCharField(tag, value);
		}

		public void SetStringValue(int tag, string value)
		{
			this.AddStringField(tag, value);
		}

		public void SetDateTimeValue(int tag, DateTime value)
		{
			this.AddDateTimeField(tag, value);
		}

		public void SetNumInGroupValue(int tag, int value)
		{
			this.AddNumInGroupField(tag, value);
		}
		//    public override string ToString()
		//    {
		//      List<string> list = new List<string>();
		//      foreach (FIXField fixField in this.Fields)
		//				list.Add(string.Format("", (object) EFIXField.ToString(fixField.Tag), (object) fixField));
		//			return string.Join(",", list.ToArray());
		//    }
	}
}
