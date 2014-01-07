// Type: OpenQuant.RunnerErrorEventArgs
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;

namespace OpenQuant
{
  internal class RunnerErrorEventArgs : EventArgs
  {
    private RunnerError error;

    public RunnerError Error
    {
      get
      {
        return this.error;
      }
    }

    public RunnerErrorEventArgs(RunnerError error)
    {
      this.error = error;
    }
  }
}
