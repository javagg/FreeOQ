using FreeQuant.Indicators;
using FreeQuant.Series;
using System;
using System.Collections.Generic;

namespace OpenQuant.Shared.Charting
{
	class IndicatorTemplateItem
	{
		private Dictionary<string, object> properties = new Dictionary<string, object>();
		private List<IndicatorTemplateItem> children = new List<IndicatorTemplateItem>();
		private Type indicatorType;
		private Indicator indicator;

		public Dictionary<string, object> Properties
		{
			get
			{
				return this.properties;
			}
		}

		public List<IndicatorTemplateItem> Children
		{
			get
			{
				return this.children;
			}
		}

		public Indicator Indicator
		{
			get
			{
				return this.indicator;
			}
		}

		public Type IndicatorType
		{
			get
			{
				return this.indicatorType;
			}
		}

		public IndicatorTemplateItem(Type indicatorType)
		{
			this.indicatorType = indicatorType;
		}

		public IndicatorTemplateItem(Indicator indicator, Type indicatorType)
      : this(indicatorType)
		{
			this.indicator = indicator;
		}

		internal IndicatorTemplateItem(IndicatorTemplateItem template)
		{
			foreach (KeyValuePair<string, object> keyValuePair in template.properties)
				this.properties.Add(keyValuePair.Key, keyValuePair.Value);
			foreach (IndicatorTemplateItem template1 in template.children)
				this.children.Add(new IndicatorTemplateItem(template1));
			this.indicatorType = template.indicatorType;
		}

		public List<IndicatorTemplateItem> GetIndicatorTemplates(DoubleSeries series)
		{
			List<IndicatorTemplateItem> list = new List<IndicatorTemplateItem>();
			this.Create(series);
			list.Add(this);
			foreach (IndicatorTemplateItem indicatorTemplateItem in this.children)
				list.AddRange((IEnumerable<IndicatorTemplateItem>)indicatorTemplateItem.GetIndicatorTemplates((DoubleSeries)this.indicator));
			return list;
		}

		public void Create(DoubleSeries series)
		{
			this.indicator = Activator.CreateInstance(this.indicatorType) as Indicator;
			foreach (KeyValuePair<string, object> keyValuePair in this.properties)
				this.indicatorType.GetProperty(keyValuePair.Key).SetValue(this.indicator, keyValuePair.Value, (object[])null);
			this.indicator.Input = series;
		}

		public void AddChild(IndicatorTemplateItem child)
		{
			this.children.Add(child);
		}

		public void SetProperty(string name, object value)
		{
			this.properties[name] = value;
		}
	}
}
