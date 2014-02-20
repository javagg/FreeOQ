using System;
using System.Collections;

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
				return this.positions[name] as Position;
			}
		}

		public Position this[Instrument instrument]
		{
			get
			{
				return this.positions[instrument.Symbol] as Position;
			}
		}

		public PositionList()
		{
			this.positions = new SortedList();
		}

		public void Add(Position position)
		{
			if (this.positions.Contains(position.Name))
                throw new ApplicationException("Already Added. {0}" + position.Name);
			this.positions.Add(position.Name, position);
		}

		public void Remove(Position position)
		{
			this.positions.Remove(position.Name);
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
			return this.positions.Contains(name);
		}

		public bool Contains(Instrument instrument)
		{
			return this.positions.Contains(instrument.Symbol);
		}

		public bool Contains(Position position)
		{
			return this.positions.ContainsValue(position);
		}

		public ICollection Clone()
		{
			Position[] positionArray = new Position[this.positions.Values.Count];
			this.positions.Values.CopyTo(positionArray, 0);
			return positionArray;
		}

		public IEnumerator GetEnumerator()
		{
			return this.positions.Values.GetEnumerator();
		}

		public override string ToString()
		{
			string str = "";
			foreach (var position in this.positions.Values)
				str = str + position + Environment.NewLine;
			return str;
		}
	}
}
