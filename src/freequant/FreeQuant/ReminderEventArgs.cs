using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant
{
  public class ReminderEventArgs : EventArgs
  {
    private DateTime agrM0NYpb;
    private object I3UUD24Bv;

    public DateTime SignalTime
    {
        get
      {
				return agrM0NYpb;
      }
    }

    public object Data
    {
        get
      {
        return (object) null;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ReminderEventArgs(DateTime signalTime, object data)
    {
    }
  }
}
