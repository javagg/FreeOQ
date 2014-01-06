namespace OpenQuant.API
{
  public class BarRequest
  {
    private long barSize;
    private BarType barType;
    private bool isBarFactoryRequest;

    public long BarSize
    {
      get
      {
        return this.barSize;
      }
    }

    public BarType BarType
    {
      get
      {
        return this.barType;
      }
    }

    public bool IsBarFactoryRequest
    {
      get
      {
        return this.isBarFactoryRequest;
      }
      set
      {
        this.isBarFactoryRequest = value;
      }
    }

    public BarRequest(BarType barType, long barSize, bool isBarFactoryRequest)
    {
      this.barType = barType;
      this.barSize = barSize;
      this.isBarFactoryRequest = isBarFactoryRequest;
    }

    private BarRequest(SmartQuant.Data.BarType barType, long barSize, bool isBarFactoryRequest)
      : this(EnumConverter.Convert(barType), barSize, isBarFactoryRequest)
    {
    }

    public override bool Equals(object obj)
    {
      BarRequest barRequest = obj as BarRequest;
      return barRequest != null && barRequest.BarType == this.barType && barRequest.BarSize == this.barSize;
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}
