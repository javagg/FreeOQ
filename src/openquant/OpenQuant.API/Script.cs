using FreeQuant;
using System;
using System.Windows.Forms;

namespace OpenQuant.API
{
	///<summary>
	///  A script
	///</summary>
	public abstract class Script
	{
		private Form mainForm;

		public abstract void Run();

		///<summary>
		///  Initializes a new instance of this class
		///</summary>
		public Script() {}

		///<summary>
		///  Invoke a action
		///</summary>
		public void Invoke(Action action)
		{
			this.mainForm.Invoke((Delegate)action);
		}

		///<summary>
		///  Adds reminder on specified datetime
		///</summary>
		public void AddTimer(DateTime dateTime, object data)
		{
			FreeQuant.Clock.AddReminder(new ReminderEventHandler(this.OnReminder), dateTime, data);
		}

		///<summary>
		///  Removes all reminders
		///</summary>
		public void RemoveTimers()
		{
			FreeQuant.Clock.RemoveReminder(new ReminderEventHandler(this.OnReminder));
		}

		///<summary>
		///  Removes reminder at specified datatime
		///</summary>
		public void RemoveTimer(DateTime dateTime)
		{
			FreeQuant.Clock.RemoveReminder(new ReminderEventHandler(this.OnReminder), dateTime);
		}


		private void OnReminder(ReminderEventArgs args)
		{
			this.OnTimer(args.SignalTime, args.Data);
		}

		///<summary>
		///  Called when a reminder gets triggered
		///</summary>
		public virtual void OnTimer(DateTime dateTime, object data)
		{
		}

		///<summary>
		///  Called when solution is starting
		///</summary>
		public virtual void OnSolutionStarting()
		{
		}

		///<summary>
		///  Called when solution is stopping
		///</summary>
		public virtual void OnSolutionStopping()
		{
		}

		///<summary>
		///  Called when solution is stopped
		///</summary>
		public virtual void OnSolutionStopped()
		{
		}

		///<summary>
		///  Called when solution is started 
		///</summary>
		public virtual void OnSolutionStarted()
		{
		}

		///<summary>
		///  Called when solution is opened
		///</summary>
		public virtual void OnSolutionOpened(string name)
		{
		}

		///<summary>
		///  Called when script is stopped
		///</summary>
		public virtual void OnScriptStopped(string path)
		{
		}

		///<summary>
		///  Called when this script is about to stop 
		///</summary>
		public virtual void OnStop()
		{
		}
	}
}
