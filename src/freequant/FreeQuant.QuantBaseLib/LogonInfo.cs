using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantBaseLib
{
  [Serializable]
  public class LogonInfo
  {
		public string Username {   get;  set; }

		public string Password { get;  set; }

    public LogonInfo()
    {
      this.Username = string.Empty;
      this.Password = string.Empty;
    }
  }
}
