using FreeQuant;
using System;
using System.Windows.Forms;

namespace OpenQuant.API
{
  public abstract class Script
  {
    private Form mainForm;

    public abstract void Run();

    public void Invoke(Action action)
    {
      this.mainForm.Invoke((Delegate) action);
    }

    public void AddTimer(DateTime dateTime, object data)
    {
      SmartQuant.Clock.AddReminder(new ReminderEventHandler(this.OnReminder), dateTime, data);
    }

    public void RemoveTimers()
    {
      SmartQuant.Clock.RemoveReminder(new ReminderEventHandler(this.OnReminder));
    }

    public void RemoveTimer(DateTime dateTime)
    {
      SmartQuant.Clock.RemoveReminder(new ReminderEventHandler(this.OnReminder), dateTime);
    }

    private void OnReminder(ReminderEventArgs args)
    {
      this.OnTimer(args.SignalTime, args.Data);
    }

    public virtual void OnTimer(DateTime dateTime, object data)
    {
    }

    public virtual void OnSolutionStarting()
    {
    }

    public virtual void OnSolutionStopping()
    {
    }

    public virtual void OnSolutionStopped()
    {
    }

    public virtual void OnSolutionStarted()
    {
    }

    public virtual void OnSolutionOpened(string name)
    {
    }

    public virtual void OnScriptStopped(string path)
    {
    }

    public virtual void OnStop()
    {
    }
  }
}
