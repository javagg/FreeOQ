using System.Collections.Generic;
using System.Threading;

namespace OpenQuant.Shared
{
	public class EventQueue<T>
	{
		private Queue<T> queue;
		private ManualResetEventSlim handle;

		public int Count
		{
			get {
				return this.queue.Count;
			}
		}

		public EventQueue ()
		{
			this.queue = new Queue<T>();
			this.handle = new ManualResetEventSlim(false);
		}

		public void Enqueue (T item)
		{
			lock (this.queue) {
				this.queue.Enqueue (item);
				if (this.queue.Count != 1)
					return;
				this.handle.Set ();
			}
		}

		public T Dequeue ()
		{
			this.handle.Wait ();
			T obj = default (T);
			lock (this.queue) {
				if (this.queue.Count > 0) {
					obj = this.queue.Dequeue ();
					if (this.queue.Count == 0)
						this.handle.Reset ();
				}
			}
			return obj;
		}
	}
}
