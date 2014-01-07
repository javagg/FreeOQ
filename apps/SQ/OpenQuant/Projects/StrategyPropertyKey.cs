// Type: OpenQuant.Projects.StrategyPropertyKey
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;

namespace OpenQuant.Projects
{
  public class StrategyPropertyKey
  {
    private string name;
    private Type type;

    public StrategyPropertyKey(string name, Type type)
    {
      this.name = name;
      this.type = type;
    }

    public override bool Equals(object obj)
    {
      StrategyPropertyKey strategyPropertyKey = (StrategyPropertyKey) obj;
      return strategyPropertyKey != null && !(strategyPropertyKey.name != this.name) && !(strategyPropertyKey.type != this.type);
    }

    public override int GetHashCode()
    {
      return this.name.GetHashCode();
    }
  }
}
