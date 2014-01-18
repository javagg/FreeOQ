using System;

namespace FreeQuant.FinChart.Objects
{
  public interface IUpdatable
  {
    event EventHandler Updated;
  }
}
