using System.ComponentModel;

namespace OpenQuant.Shared
{
	public interface ITimerItem
	{
		double Interval { get; }
		ISynchronizeInvoke SynchronizingObject { get; }
		void OnElapsed();
	}
}
