using FreeQuant.Indicators;
using FreeQuant.Series;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace OpenQuant.Shared.Charting
{
	class PadTemplate
	{
		private List<IndicatorTemplateItem> indicatorTemplateList = new List<IndicatorTemplateItem>();
		private Dictionary<Indicator, IndicatorTemplateItem> table = new Dictionary<Indicator, IndicatorTemplateItem>();

		internal List<IndicatorTemplateItem> IndicatorTemplates
		{
			get
			{
				return this.indicatorTemplateList;
			}
		}

		public List<Indicator> Indicators
		{
			get
			{
				return new List<Indicator>((IEnumerable<Indicator>)this.table.Keys);
			}
		}

		internal PadTemplate()
		{
		}

		internal PadTemplate(PadTemplate template)
		{
			foreach (IndicatorTemplateItem template1 in template.indicatorTemplateList)
				this.indicatorTemplateList.Add(new IndicatorTemplateItem(template1));
		}

		public void Create(DoubleSeries series)
		{
			this.table.Clear();
			foreach (IndicatorTemplateItem indicatorTemplateItem1 in this.indicatorTemplateList)
			{
				foreach (IndicatorTemplateItem indicatorTemplateItem2 in indicatorTemplateItem1.GetIndicatorTemplates(series))
					this.table[indicatorTemplateItem2.Indicator] = indicatorTemplateItem2;
			}
		}

		public void AddIndicator(Indicator indicator)
		{
			IndicatorTemplateItem indicatorTemplate = this.CreateIndicatorTemplate(indicator);
			this.indicatorTemplateList.Add(indicatorTemplate);
			this.table[indicator] = indicatorTemplate;
		}

		public void AddIndicator(Indicator indicator, Indicator inputIndicator)
		{
			IndicatorTemplateItem indicatorTemplate = this.CreateIndicatorTemplate(indicator);
			this.table[inputIndicator].AddChild(indicatorTemplate);
			this.table[indicator] = indicatorTemplate;
		}

		public void RemoveIndicator(Indicator indicator)
		{
			this.RemoveIndicatorTemplate(this.table[indicator]);
		}

		private void RemoveIndicatorTemplate(IndicatorTemplateItem indicatorTemplate)
		{
			this.table.Remove(indicatorTemplate.Indicator);
			this.indicatorTemplateList.Remove(indicatorTemplate);
			foreach (IndicatorTemplateItem indicatorTemplate1 in indicatorTemplate.Children)
				this.RemoveIndicatorTemplate(indicatorTemplate1);
		}

		private IndicatorTemplateItem CreateIndicatorTemplate(Indicator indicator)
		{
			Type type = ((object)indicator).GetType();
			IndicatorTemplateItem indicatorTemplateItem = new IndicatorTemplateItem(type);
			indicatorTemplateItem.SetProperty("Color", ((TimeSeries)indicator).Color);
			indicatorTemplateItem.SetProperty("Name", ((TimeSeries)indicator).Name);
			indicatorTemplateItem.SetProperty("Title", ((TimeSeries)indicator).Title);
			foreach (PropertyInfo propertyInfo in type.GetProperties())
			{
				foreach (Attribute attribute in propertyInfo.GetCustomAttributes(false))
				{
					if (attribute.GetType() == typeof(IndicatorParameterAttribute))
						indicatorTemplateItem.SetProperty(propertyInfo.Name, propertyInfo.GetValue((object)indicator, (object[])null));
				}
			}
			return indicatorTemplateItem;
		}
	}
}
