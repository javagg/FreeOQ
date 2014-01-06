using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API.Compression
{
  internal abstract class DataEntryEnumerator : IEnumerator<DataEntry>, IDisposable, IEnumerator
  {
    protected int index;
    private int count;

    public abstract DataEntry Current { get; }

    object IEnumerator.Current
    {
      get
      {
        throw new NotImplementedException();
      }
    }

    protected DataEntryEnumerator(int count)
    {
      this.count = count;
      this.Reset();
    }

    public void Dispose()
    {
    }

    public bool MoveNext()
    {
      return ++this.index < this.count;
    }

    public void Reset()
    {
      this.index = -1;
    }
  }
}
