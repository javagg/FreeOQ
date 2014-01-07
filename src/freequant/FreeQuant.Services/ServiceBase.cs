// Type: SmartQuant.Services.ServiceBase
// Assembly: SmartQuant.Services, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: BBD4879A-0902-4B9F-9A9A-214E03CD2FAE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Services.dll

using SmartQuant;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using yVXZ4JIJtSP6EX4fjq;

namespace SmartQuant.Services
{
  public abstract class ServiceBase : IService
  {
    protected ServiceStatus status;

    public abstract byte Id { get; }

    public abstract string Name { get; }

    public abstract string Description { get; }

    public virtual ServiceStatus Status
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.status;
      }
    }

    public event EventHandler StatusChanged;

    public event ServiceErrorEventHandler Error;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ServiceBase()
    {
      BjOiEgGuG7SsSXTumY.w07s1ndzACihi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    public abstract void Start();

    public abstract void Stop();

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetServiceStatus(ServiceStatus status)
    {
      this.status = status;
      if (this.JqfcuNWXs == null)
        return;
      this.JqfcuNWXs((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitServiceError(ServiceError error)
    {
      if (this.FrJZfqUgi == null)
        return;
      this.FrJZfqUgi((object) this, new ServiceErrorEventArgs(error));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitServiceError(string text)
    {
      this.EhoB2ppPe(ServiceErrorType.Error, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitServiceWarning(string text)
    {
      this.EhoB2ppPe(ServiceErrorType.Warning, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitServiceMessage(string text)
    {
      this.EhoB2ppPe(ServiceErrorType.Message, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EhoB2ppPe([In] ServiceErrorType obj0, [In] string obj1)
    {
      this.EmitServiceError(new ServiceError((IService) this, obj0, Clock.Now, obj1));
    }
  }
}
