using System;

namespace OpenQuant.Shared.Logs
{
  class ColumnItem : IComparable<ColumnItem>
  {
    private string key;

    public ColumnType Type { get; private set; }

    public string Name { get; private set; }

    public ColumnItem(ColumnType type, string name)
    {
      this.Type = type;
      this.Name = name;
      this.key = string.Format("{0}\x0001{1}", (object) type, (object) name);
    }

    public override int GetHashCode()
    {
      return this.key.GetHashCode();
    }

    public override bool Equals(object obj)
    {
      if (obj is ColumnItem)
        return this.key.Equals(((ColumnItem)obj).key);
      else
        return base.Equals(obj);
    }

    public override string ToString()
    {
      return string.Format("{0}: {1}", this.Type, this.Name);
    }

    public int CompareTo(ColumnItem other)
    {
      if (this.Type == other.Type)
        return this.Name.CompareTo(other.Name);
      return this.Type != ColumnType.Strategy ? 1 : -1;
    }
  }
}
