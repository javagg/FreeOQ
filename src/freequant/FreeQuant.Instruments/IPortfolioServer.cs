// Type: SmartQuant.Instruments.IPortfolioServer
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using System;

namespace SmartQuant.Instruments
{
  public interface IPortfolioServer
  {
    void Open(Type connectionType, string connectionString);

    void Close();

    PortfolioList Load();

    void Save(Portfolio portfolio);

    void Remove(Portfolio portfolio);

    void Update(Portfolio portfolio);

    void Clear(Portfolio portfolio);

    void Add(Portfolio portfolio, Transaction transaction);

    void Add(Portfolio portfolio, AccountTransaction transaction);
  }
}
