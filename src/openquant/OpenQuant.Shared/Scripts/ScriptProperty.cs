using System;
using System.ComponentModel;

namespace OpenQuant.Shared.Scripts
{
	class ScriptProperty
	{
		private string name;
		private Type type;
		private object value;
		private object codeValue;
		private string category;
		private string description;

		[Browsable(false)]
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		[Browsable(false)]
		public Type Type
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}

		[Browsable(true)]
		public object Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
			}
		}

		public object CodeValue
		{
			get
			{
				return this.codeValue;
			}
			set
			{
				this.codeValue = value;
			}
		}

		public string Category
		{
			get
			{
				return this.category;
			}
			set
			{
				this.category = value;
			}
		}

		public string Description
		{
			get
			{
				if (!string.IsNullOrEmpty(this.description))
					return this.description;
				else
					return this.type.Name;
			}
			set
			{
				this.description = value;
			}
		}

		public ScriptProperty(string name, Type type, object value, string category, string description)
		{
			this.name = name;
			this.type = type;
			this.value = value;
			this.codeValue = (object)null;
			this.category = category;
			this.description = description;
		}

		public ScriptProperty(string name, Type type, object value) : this(name, type, value, "", "")
		{
		}
	}
}
