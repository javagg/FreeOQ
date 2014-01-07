// Type: SmartQuant.Instruments.PositionList
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using VFUvY5knK01pUIalDo;

namespace FreeQuant.Instruments
{
  public class PositionList : IEnumerable
  {
    private SortedList QCfsOHY9LB;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QCfsOHY9LB.Count;
      }
    }

    public Position this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QCfsOHY9LB.GetByIndex(index) as Position;
      }
    }

    public Position this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QCfsOHY9LB[(object) name] as Position;
      }
    }

    public Position this[Instrument instrument]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QCfsOHY9LB[(object) instrument.Symbol] as Position;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PositionList()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.QCfsOHY9LB = new SortedList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Position position)
    {
      if (this.QCfsOHY9LB.Contains((object) position.Name))
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10740) + position.Name);
      this.QCfsOHY9LB.Add((object) position.Name, (object) position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(Position position)
    {
      this.QCfsOHY9LB.Remove((object) position.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.QCfsOHY9LB.RemoveAt(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.QCfsOHY9LB.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(string name)
    {
      return this.QCfsOHY9LB.Contains((object) name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(Instrument instrument)
    {
      return this.QCfsOHY9LB.Contains((object) instrument.Symbol);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(Position position)
    {
      return this.QCfsOHY9LB.ContainsValue((object) position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICollection Clone()
    {
      Position[] positionArray = new Position[this.QCfsOHY9LB.Values.Count];
      this.QCfsOHY9LB.Values.CopyTo((Array) positionArray, 0);
      return (ICollection) positionArray;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.QCfsOHY9LB.Values.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      string str = "";
      foreach (Position position in (IEnumerable) this.QCfsOHY9LB.Values)
        str = str + position.ToString() + Environment.NewLine;
      return str;
    }
  }
}
