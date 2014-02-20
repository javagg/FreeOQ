using FreeQuant.Indicators;
using FreeQuant.Series;
using System.Collections.Generic;

namespace OpenQuant.Shared.Charting
{
  class ChartTemplate
  {
    private Dictionary<int, PadTemplate> padTemplates = new Dictionary<int, PadTemplate>();

    internal Dictionary<int, PadTemplate> PadTemplates
    {
      get
      {
        return this.padTemplates;
      }
    }

    internal ChartTemplate()
    {
    }

    internal ChartTemplate(ChartTemplate template)
    {
      foreach (KeyValuePair<int, PadTemplate> keyValuePair in template.padTemplates)
        this.padTemplates.Add(keyValuePair.Key, new PadTemplate(keyValuePair.Value));
    }

    public void AddIndicator(int pad, Indicator indicator)
    {
      if (!this.padTemplates.ContainsKey(pad))
        this.padTemplates[pad] = new PadTemplate();
      this.padTemplates[pad].AddIndicator(indicator);
    }

    public void AddIndicator(int pad, Indicator indicator, Indicator inputIndicator)
    {
      if (!this.padTemplates.ContainsKey(pad))
        this.padTemplates[pad] = new PadTemplate();
      this.padTemplates[pad].AddIndicator(indicator, inputIndicator);
    }

    public void AddRemove(int pad, Indicator indicator)
    {
      this.padTemplates[pad].RemoveIndicator(indicator);
    }

    public void Create(DoubleSeries series)
    {
      foreach (PadTemplate padTemplate in this.padTemplates.Values)
        padTemplate.Create(series);
    }

    public Dictionary<int, List<Indicator>> GetIndicators()
    {
      Dictionary<int, List<Indicator>> dictionary = new Dictionary<int, List<Indicator>>();
      foreach (KeyValuePair<int, PadTemplate> keyValuePair in this.padTemplates)
        dictionary[keyValuePair.Key] = keyValuePair.Value.Indicators;
      return dictionary;
    }

    public List<Indicator> GetIndicatorList()
    {
      List<Indicator> list = new List<Indicator>();
      foreach (KeyValuePair<int, PadTemplate> keyValuePair in this.padTemplates)
        list.AddRange((IEnumerable<Indicator>) keyValuePair.Value.Indicators);
      return list;
    }
  }
}
