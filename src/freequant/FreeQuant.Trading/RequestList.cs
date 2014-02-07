using System;
using System.Collections;

namespace FreeQuant.Trading
{
	public class RequestList : CollectionBase
	{
		public string this[int index]
		{
			get
			{
				return this.InnerList[index] as string;
			}
		}

		public RequestList() : base()
		{
		}

		public void Add(string request)
		{
			this.List.Add(request);
		}

		public void Remove(string request)
		{
			if (!this.List.Contains(request))
				return;
			this.List.Remove(request);
		}

		public bool Contains(string request)
		{
			return this.InnerList.Contains(request);
		}

		protected override void OnInsert(int index, object value)
		{
			if (value == null)
				throw new ArgumentNullException("dfdfs", "fdsf");
			string str = value as string;
			if (str == null)
				throw new ArgumentException(value.GetType().ToString());
			if (this.InnerList.Contains((object)str))
				throw new ArgumentException(str);
		}
	}
}
