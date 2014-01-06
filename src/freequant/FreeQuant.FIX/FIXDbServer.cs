// Type: SmartQuant.FIX.FIXDbServer
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public static class FIXDbServer
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SaveFIXGroup(IDbConnection connection, FIXGroup group, string table, int outerID)
    {
      FIXDbServer.SaveFIXGroup(connection, group, table, outerID, -1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SaveFIXGroup(IDbConnection connection, FIXGroup group, string table, int outerID, int innerID)
    {
      foreach (FIXField fixField in group.Fields)
      {
        if (fixField.FIXType != FIXType.NumInGroup)
        {
          IDbCommand command = connection.CreateCommand();
          command.CommandText = string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(37516), (object) table);
          FIXDbServer.SetCommandParameter(command, Ugjylcah9mCMM4kO7N.tLah92SpBQ(37716), DbType.Int32, (object) outerID);
          FIXDbServer.SetCommandParameter(command, Ugjylcah9mCMM4kO7N.tLah92SpBQ(37736), DbType.Int32, (object) innerID);
          FIXDbServer.SetCommandParameter(command, Ugjylcah9mCMM4kO7N.tLah92SpBQ(37756), DbType.Int32, (object) fixField.FIXType);
          FIXDbServer.SetCommandParameter(command, Ugjylcah9mCMM4kO7N.tLah92SpBQ(37770), DbType.Int32, (object) fixField.Tag);
          string str = fixField.ToInvariantString();
          if (str.Length > (int) byte.MaxValue)
            str = str.Remove((int) byte.MaxValue);
          FIXDbServer.SetCommandParameter(command, Ugjylcah9mCMM4kO7N.tLah92SpBQ(37782), DbType.String, (object) str);
          command.ExecuteNonQuery();
          command.Dispose();
        }
      }
      foreach (ArrayList arrayList in group.Groups)
      {
        IDbCommand command1 = connection.CreateCommand();
        command1.CommandText = Ugjylcah9mCMM4kO7N.tLah92SpBQ(37798);
        Convert.ToInt32(command1.ExecuteScalar());
        command1.Dispose();
        IDbCommand command2 = connection.CreateCommand();
        command2.CommandText = string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(37836), (object) table);
        FIXDbServer.SetCommandParameter(command2, Ugjylcah9mCMM4kO7N.tLah92SpBQ(38006), DbType.Int32, (object) outerID);
        command2.ExecuteNonQuery();
        command2.Dispose();
        IDbCommand command3 = connection.CreateCommand();
        command3.CommandText = Ugjylcah9mCMM4kO7N.tLah92SpBQ(38026);
        int num = Convert.ToInt32(command3.ExecuteScalar());
        command3.Dispose();
        foreach (FIXGroup group1 in arrayList)
        {
          IDbCommand command4 = connection.CreateCommand();
          command4.CommandText = string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(38064), (object) table);
          FIXDbServer.SetCommandParameter(command4, Ugjylcah9mCMM4kO7N.tLah92SpBQ(38246), DbType.Int32, (object) outerID);
          FIXDbServer.SetCommandParameter(command4, Ugjylcah9mCMM4kO7N.tLah92SpBQ(38266), DbType.Int32, (object) num);
          command4.ExecuteNonQuery();
          command4.Dispose();
          IDbCommand command5 = connection.CreateCommand();
          command5.CommandText = Ugjylcah9mCMM4kO7N.tLah92SpBQ(38286);
          int innerID1 = Convert.ToInt32(command5.ExecuteScalar());
          command5.Dispose();
          FIXDbServer.SaveFIXGroup(connection, group1, table, outerID, innerID1);
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LoadFIXGroups(IDbConnection connection, FIXGroupList groups, string table)
    {
      IDbCommand command = connection.CreateCommand();
      command.CommandText = string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(38324), (object) table);
      IDataReader dataReader = command.ExecuteReader();
      while (dataReader.Read())
      {
        dataReader.GetInt32(0);
        dataReader.GetInt32(1);
        int int32_1 = dataReader.GetInt32(2);
        int int32_2 = dataReader.GetInt32(3);
        int int32_3 = dataReader.GetInt32(4);
        string @string = dataReader.GetString(5);
        if (int32_3 != -1 && int32_3 != 55)
        {
          FIXField field = FIXField.Field((FIXType) int32_2, int32_3, @string, true);
          groups.GetById(int32_1).AddField(field);
        }
      }
      dataReader.Close();
      command.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveFIXGroup(IDbConnection connection, string table, int outerId)
    {
      IDbCommand command = connection.CreateCommand();
      command.CommandText = string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(38438), (object) table);
      FIXDbServer.SetCommandParameter(command, Ugjylcah9mCMM4kO7N.tLah92SpBQ(38520), DbType.Int32, (object) outerId);
      command.ExecuteNonQuery();
      command.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetCommandParameter(IDbCommand command, string name, DbType type, object value)
    {
      IDbDataParameter parameter = command.CreateParameter();
      parameter.ParameterName = name;
      parameter.DbType = type;
      parameter.Value = value;
      command.Parameters.Add((object) parameter);
    }
  }
}
