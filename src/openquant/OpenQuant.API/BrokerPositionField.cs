namespace OpenQuant.API
{
  public class BrokerPositionField
  {
    private SmartQuant.Providers.BrokerPositionField field;

    public string Name
    {
      get
      {
        return this.field.Name;
      }
    }

    public string Value
    {
      get
      {
        return this.field.Value;
      }
    }

    internal BrokerPositionField(SmartQuant.Providers.BrokerPositionField field)
    {
      this.field = field;
    }

    public override string ToString()
    {
      return string.Format("Name={0} Value={1}", (object) this.field.Name, (object) this.field.Value);
    }
  }
}
