using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class PositionList : IEnumerable
  {
		private SortedList positions; 

    public int Count
    {
       get
      {
        return this.positions.Count;
      }
    }

    public Position this[int index]
    {
       get
      {
        return this.positions.GetByIndex(index) as Position;
      }
    }

    public Position this[string name]
    {
       get
      {
        return this.positions[(object) name] as Position;
      }
    }

    public Position this[Instrument instrument]
    {
       get
      {
        return this.positions[(object) instrument.Symbol] as Position;
      }
    }

    
    public PositionList()
    {
      this.positions = new SortedList();
    }

    
    public void Add(Position position)
    {
      if (this.positions.Contains((object) position.Name))
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10740) + position.Name);
      this.positions.Add((object) position.Name, (object) position);
    }

    
    public void Remove(Position position)
    {
      this.positions.Remove((object) position.Name);
    }

    
    public void RemoveAt(int index)
    {
      this.positions.RemoveAt(index);
    }

    
    public void Clear()
    {
      this.positions.Clear();
    }

    
    public bool Contains(string name)
    {
      return this.positions.Contains((object) name);
    }

    
    public bool Contains(Instrument instrument)
    {
      return this.positions.Contains((object) instrument.Symbol);
    }

    
    public bool Contains(Position position)
    {
      return this.positions.ContainsValue((object) position);
    }

    
    public ICollection Clone()
    {
      Position[] positionArray = new Position[this.positions.Values.Count];
      this.positions.Values.CopyTo((Array) positionArray, 0);
      return (ICollection) positionArray;
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.positions.Values.GetEnumerator();
    }

    
    public override string ToString()
    {
      string str = "";
      foreach (Position position in (IEnumerable) this.positions.Values)
        str = str + position.ToString() + Environment.NewLine;
      return str;
    }
  }
}
