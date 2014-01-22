using FreeQuant;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Services
{
  public abstract class ServiceBase : IService
  {
    protected ServiceStatus status;

    public abstract byte Id { get; }

    public abstract string Name { get; }

    public abstract string Description { get; }

    public virtual ServiceStatus Status
    {
      get
      {
        return this.status;
      }
    }

    public event EventHandler StatusChanged;

    public event ServiceErrorEventHandler Error;

 
    protected ServiceBase()
    {
    }

    public abstract void Start();

    public abstract void Stop();


    protected void SetServiceStatus(ServiceStatus status)
    {
      this.status = status;
//      if (this.JqfcuNWXs == null)
//        return;
//      this.JqfcuNWXs((object) this, EventArgs.Empty);
   }

    
    protected void EmitServiceError(ServiceError error)
    {
//      if (this.FrJZfqUgi == null)
//        return;
//      this.FrJZfqUgi((object) this, new ServiceErrorEventArgs(error));
    }


    protected void EmitServiceError(string text)
    {
      this.EhoB2ppPe(ServiceErrorType.Error, text);
    }


    protected void EmitServiceWarning(string text)
    {
      this.EhoB2ppPe(ServiceErrorType.Warning, text);
    }


    protected void EmitServiceMessage(string text)
    {
      this.EhoB2ppPe(ServiceErrorType.Message, text);
    }


    private void EhoB2ppPe([In] ServiceErrorType obj0, [In] string obj1)
    {
      this.EmitServiceError(new ServiceError((IService) this, obj0, Clock.Now, obj1));
    }
  }
}
