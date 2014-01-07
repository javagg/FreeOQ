// Type: SmartQuant.Data.IDataSeries
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using System;
using System.Collections;

namespace FreeQuant.Data
{
  public interface IDataSeries : IEnumerable
  {
    string Name { get; }

    string Description { get; set; }

    int Count { get; }

    object this[DateTime datetime] { get; set; }

    object this[int index] { get; }

    DateTime FirstDateTime { get; }

    DateTime LastDateTime { get; }

    void Add(DateTime datetime, object obj);

    void Update(DateTime datetime, object obj);

    void Update(int index, object obj);

    bool Contains(DateTime datetime);

    int IndexOf(DateTime datetime);

    int IndexOf(DateTime datetime, SearchOption option);

    DateTime DateTimeAt(int index);

    void Remove(DateTime datetime);

    void RemoveAt(int index);

    void Clear();

    void Flush();
  }
}
