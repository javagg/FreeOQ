using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant
{
	public class RuntimeError
	{
		private DateTime datetime;
		private RuntimeErrorLevel level;
		private string description;
		private string details;
		private object source;
		public DateTime DateTime { get { return datetime; } }
		public RuntimeErrorLevel Level { get { return level; } }
		public string Description { get { return description; } }
		public string Details { get { return details; } }
		public object Source { get { return source; } }
	
		public RuntimeError(DateTime datetime, RuntimeErrorLevel level, string description, string details, object source)
		{
			this.datetime = datetime;
			this.level = level;
			this.description = description;
			this.details = details;
			this.source = source;
		}

		public RuntimeError(RuntimeErrorLevel level, string description, string details, object source)
		{
			this.level = level;
			this.description = description;
			this.details = details;
			this.source = source;
		}

		public RuntimeError(RuntimeErrorLevel level, Exception e, object source)
		{
			this.level = level;
			this.source = source;
		}

		public RuntimeError(RuntimeErrorLevel level, Exception e)
		{
			this.level = level;
		}

		public override string ToString()
		{
			return description;
		}
	}
}
