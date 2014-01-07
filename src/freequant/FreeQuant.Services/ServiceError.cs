// Type: SmartQuant.Services.ServiceError
// Assembly: SmartQuant.Services, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: BBD4879A-0902-4B9F-9A9A-214E03CD2FAE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Services.dll

using nJWWheZ9X0DmMNUyVT;
using System;
using System.Runtime.CompilerServices;
using yVXZ4JIJtSP6EX4fjq;

namespace SmartQuant.Services
{
  public class ServiceError
  {
    private IService IahvCQc8s;
    private ServiceErrorType LEe4FxE19;
    private DateTime aM4hDOmPf;
    private string rXu7MiqdF;

    public IService Service
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.IahvCQc8s;
      }
    }

    public ServiceErrorType ErrorType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LEe4FxE19;
      }
    }

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aM4hDOmPf;
      }
    }

    public string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rXu7MiqdF;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ServiceError(IService service, ServiceErrorType errorType, DateTime datetime, string text)
    {
      BjOiEgGuG7SsSXTumY.w07s1ndzACihi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.IahvCQc8s = service;
      this.LEe4FxE19 = errorType;
      this.aM4hDOmPf = datetime;
      this.rXu7MiqdF = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return string.Format(vHt2WFcHP7xf9AvlUc.NIyE6a865(716), (object) this.IahvCQc8s.Name, (object) this.LEe4FxE19, (object) this.rXu7MiqdF);
    }
  }
}
