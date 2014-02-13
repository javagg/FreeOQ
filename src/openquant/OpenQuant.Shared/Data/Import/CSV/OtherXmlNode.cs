using OpenQuant.API;
using FreeQuant.Xml;
using System;

namespace OpenQuant.Shared.Data.Import.CSV
{
  class OtherXmlNode : XmlNodeBase
  {
    private const string ATTR_CREATE_INSTRUMENT = "createInstrument";
    private const string ATTR_CLEAR_SERIES = "clearSeries";
    private const string ATTR_SKIP_DATA_INSIDE_EXISTING_RANGE = "skipDataInsideExistingRange";
    private const string ATTR_INSTRUMENT_TYPE = "instrumentType";

		public override string NodeName
    {
      get
      {
        return "other";
      }
    }

    public bool CreateInstrument
    {
      get
      {
        return this.GetBooleanAttribute("createInstrument");
      }
      set
      {
        this.SetAttribute("createInstrument", value);
      }
    }

    public bool SkipDataInsideExistingRange
    {
      get
      {
        if (this.ContainsAttribute("skipDataInsideExistingRange"))
          return this.GetBooleanAttribute("skipDataInsideExistingRange");
        else
          return false;
      }
      set
      {
        this.SetAttribute("skipDataInsideExistingRange", value);
      }
    }

    public bool ClearSeries
    {
      get
      {
        return this.GetBooleanAttribute("clearSeries");
      }
      set
      {
        this.SetAttribute("clearSeries", value);
      }
    }

    public InstrumentType InstrumentType
    {
      get
      {
        return (InstrumentType) this.GetEnumAttribute("instrumentType", typeof (InstrumentType));
      }
      set
      {
        this.SetAttribute("instrumentType", (Enum) value);
      }
    }

		public OtherXmlNode() : base()
    {
    }
  }
}
