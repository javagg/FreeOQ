// Type: OpenQuant.Options.PortfolioItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Instruments;

namespace OpenQuant.Options
{
  internal class PortfolioItem
  {
    private Portfolio portfolio;

    public Portfolio Portfolio
    {
      get
      {
        return this.portfolio;
      }
    }

    public PortfolioItem(Portfolio portfolio)
    {
      this.portfolio = portfolio;
    }

    public override string ToString()
    {
      return this.portfolio.Name;
    }

    public override int GetHashCode()
    {
      return this.portfolio.GetHashCode();
    }

    public override bool Equals(object obj)
    {
      return this.portfolio == obj;
    }
  }
}
