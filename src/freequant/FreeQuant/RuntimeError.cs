using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant
{
  public class RuntimeError
  {
    private DateTime m82rNY2iEt;
    private RuntimeErrorLevel aahrHnStOQ;
    private string Fc3rxRwXEh;
    private string wEjrwRQkkw;
    private object BrHrhWyjZW;

    public DateTime DateTime
    {
       get
      {
				return m82rNY2iEt;
      }
    }

    public RuntimeErrorLevel Level
    {
       get
      {
				return aahrHnStOQ;
      }
    }

    public string Description
    {
       get
      {
        return null;
      }
    }

    public string Details
    {
      get
      {
        return (string) null;
      }
    }

    public object Source
    {
      get
      {
        return (object) null;
      }
    }

    public RuntimeError(DateTime datetime, RuntimeErrorLevel level, string description, string details, object source)
    {
    }

    public RuntimeError(RuntimeErrorLevel level, string description, string details, object source)
    {
    }

    public RuntimeError(RuntimeErrorLevel level, Exception e, object source)
    {
    }

    public RuntimeError(RuntimeErrorLevel level, Exception e)
    {
    }

    public override string ToString()
    {
      return (string) null;
    }
  }
}
