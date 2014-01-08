using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib
{
  public class ConnectionStringParser
  {
    private IDictionary<string, string> Ox5uKUf66D;

    public ConnectionStringParser(string connectionString)
    {
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

    public bool TryGetValue(string key, out string value)
    {
      return this.Ox5uKUf66D.TryGetValue(key, out value);
    }

    public bool TryGetValue(string key, out int value)
    {
      value = 0;
      string s;
      return this.TryGetValue(key, out s) && int.TryParse(s, out value);
    }
  }
}
