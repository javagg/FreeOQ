namespace OpenQuant.QuantTrader
{
  internal class PropertiesNode : ExportItemNode
  {
    public override bool AutoCheckFromParent
    {
      get
      {
        return false;
      }
    }

    public override bool AutoUncheckParent
    {
      get
      {
        return false;
      }
    }

    public PropertiesNode()
      : base("Properties", 6)
    {
    }
  }
}
