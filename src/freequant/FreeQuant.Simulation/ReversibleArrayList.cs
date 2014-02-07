using System;
using System.Collections;

namespace FreeQuant.Simulation
{
	internal class ReversibleArrayList : ArrayList
    {
		public override object this[int index]
		{
			 get
			{
				return base[this.Count - index - 1];
			}
			 set
			{
				base[this.Count - index - 1] = value;
			}
		}

		public ReversibleArrayList()
		{
		}

		
		public override int Add(object obj)
		{
			base.Insert(0, obj);
			return 0;
		}

		public override void Sort()
		{
			base.Sort();
			this.Reverse();
		}

		public override void RemoveAt(int index)
		{
			base.RemoveAt(this.Count - index - 1);
		}

		public override void Insert(int index, object obj)
		{
			base.Insert(this.Count - index, obj);
		}
    }
}

