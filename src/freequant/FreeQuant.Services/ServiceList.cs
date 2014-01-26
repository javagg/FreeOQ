using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FreeQuant.Services
{
	public class ServiceList : ICollection, IEnumerable
	{
		private SortedList<string, IService> l6LAy7BYb;
		private SortedList<byte, IService> wsSykLPBq;
		private List<IService> Vag5R41WI;

		public int Count
		{
			get
			{
				return this.Vag5R41WI.Count; 
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		public object SyncRoot
		{
			get
			{
				return (object)null;
			}
		}

		public IService this[string name]
		{
			get
			{
				IService service;
				if (this.l6LAy7BYb.TryGetValue(name, out service))
					return service;
				else
					return (IService)null;
			}
		}

		public IService this[byte id]
		{
			get
			{
				IService service;
				if (this.wsSykLPBq.TryGetValue(id, out service))
					return service;
				else
					return null;
			}
		}

		internal ServiceList()
		{
			this.l6LAy7BYb = new SortedList<string, IService>();
			this.wsSykLPBq = new SortedList<byte, IService>();
			this.Vag5R41WI = new List<IService>();
		}

		public void CopyTo(Array array, int index)
		{
			this.Vag5R41WI.ToArray().CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.Vag5R41WI.GetEnumerator();
		}

		internal void jLl6RmfZp([In] IService obj0)
		{
			this.l6LAy7BYb.Add(obj0.Name, obj0);
			this.wsSykLPBq.Add(obj0.Id, obj0);
			this.k7BVcoadr();
		}

		private void k7BVcoadr()
		{
			this.Vag5R41WI.Clear();
			foreach (IService service in (IEnumerable<IService>) this.l6LAy7BYb.Values)
				this.Vag5R41WI.Add(service);
		}
	}
}
