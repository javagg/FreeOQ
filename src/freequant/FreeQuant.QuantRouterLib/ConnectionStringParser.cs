// Type: SmartQuant.QuantRouterLib.ConnectionStringParser
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib
{
  public class ConnectionStringParser
  {
    private IDictionary<string, string> Ox5uKUf66D;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConnectionStringParser(string connectionString)
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Ox5uKUf66D = (IDictionary<string, string>) new Dictionary<string, string>();
      string str1 = connectionString;
      char[] separator = new char[1]
      {
        ';'
      };
      int num = 1;
      foreach (string str2 in str1.Split(separator, (StringSplitOptions) num))
      {
        string[] strArray = str2.Split(new char[1]
        {
          '='
        });
        string str3;
        string str4;
        if (strArray.Length == 2)
        {
          str3 = strArray[0].Trim();
          str4 = strArray[1].Trim();
        }
        else
          str3 = str4 = str2.Trim();
        this.Ox5uKUf66D.Add(str3.ToUpper(), str4);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetValue(string key, out string value)
    {
      return this.Ox5uKUf66D.TryGetValue(key, out value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetValue(string key, out int value)
    {
      value = 0;
      string s;
      return this.TryGetValue(key, out s) && int.TryParse(s, out value);
    }
  }
}
