using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace OpenQuant.Shared.Options
{
	public class OptionsBase
	{
		private Dictionary<Type, OptionsBase> subOptions;

		[Browsable(false)]
		public ICollection<OptionsBase> SubOptions
		{
			get
			{
				return (ICollection<OptionsBase>)this.subOptions.Values;
			}
		}

		[Browsable(false)]
		internal Type PanelType
		{
			get
			{
				return this.GetAttribute().PanelType;
			}
		}

		[Browsable(false)]
		internal string Text
		{
			get
			{
				return this.GetAttribute().Text;
			}
		}

		protected OptionsBase()
		{
			this.subOptions = new Dictionary<Type, OptionsBase>();
		}

		protected void Add(OptionsBase item)
		{
			this.subOptions.Add(item.GetType(), item);
		}

		protected T GetSubOptions<T>() where T : OptionsBase
		{
			return this.subOptions[typeof(T)] as T;
		}

		public void Load()
		{
			this.OnLoad();
			foreach (OptionsBase optionsBase in this.subOptions.Values)
				optionsBase.Load();
		}

		protected virtual void OnLoad()
		{
		}

		public void Save()
		{
			this.OnSave();
		}

		protected virtual void OnSave()
		{
		}

		private OptionsNodeAttribute GetAttribute()
		{
			object[] customAttributes = this.GetType().GetCustomAttributes(typeof(OptionsNodeAttribute), true);
            return customAttributes.Length == 1 ? (OptionsNodeAttribute)customAttributes[0] : null;
		}
	}
}
