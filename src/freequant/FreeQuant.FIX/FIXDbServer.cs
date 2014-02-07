using System;
using System.Collections;
using System.Data;

namespace FreeQuant.FIX
{
	public static class FIXDbServer
	{
		public static void SaveFIXGroup(IDbConnection connection, FIXGroup group, string table, int outerID)
		{
			FIXDbServer.SaveFIXGroup(connection, group, table, outerID, -1);
		}

		public static void SaveFIXGroup(IDbConnection connection, FIXGroup group, string table, int outerID, int innerID)
		{
			foreach (FIXField fixField in group.Fields)
			{
				if (fixField.FIXType != FIXType.NumInGroup)
				{
					IDbCommand command = connection.CreateCommand();
					command.CommandText = string.Format("commmd1", (object)table);
					FIXDbServer.SetCommandParameter(command, "outerID", DbType.Int32, (object)outerID);
					FIXDbServer.SetCommandParameter(command, "innerID", DbType.Int32, (object)innerID);
					FIXDbServer.SetCommandParameter(command, "FIXType", DbType.Int32, (object)fixField.FIXType);
					FIXDbServer.SetCommandParameter(command, "Tag", DbType.Int32, (object)fixField.Tag);
					string str = fixField.ToInvariantString();
					if (str.Length > (int)byte.MaxValue)
						str = str.Remove((int)byte.MaxValue);
					FIXDbServer.SetCommandParameter(command, "Str", DbType.String, (object)str);
					command.ExecuteNonQuery();
					command.Dispose();
				}
			}
			foreach (ArrayList arrayList in group.Groups)
			{
				IDbCommand command1 = connection.CreateCommand();
				command1.CommandText = "command1";
				Convert.ToInt32(command1.ExecuteScalar());
				command1.Dispose();
				IDbCommand command2 = connection.CreateCommand();
				command2.CommandText = string.Format("command2", (object)table);
				FIXDbServer.SetCommandParameter(command2, "outerID", DbType.Int32, (object)outerID);
				command2.ExecuteNonQuery();
				command2.Dispose();
				IDbCommand command3 = connection.CreateCommand();
				command3.CommandText = "command3";
				int num = Convert.ToInt32(command3.ExecuteScalar());
				command3.Dispose();
				foreach (FIXGroup group1 in arrayList)
				{
					IDbCommand command4 = connection.CreateCommand();
					command4.CommandText = string.Format("command4", (object)table);
					FIXDbServer.SetCommandParameter(command4, "outerID", DbType.Int32, (object)outerID);
					FIXDbServer.SetCommandParameter(command4, "num", DbType.Int32, (object)num);
					command4.ExecuteNonQuery();
					command4.Dispose();
					IDbCommand command5 = connection.CreateCommand();
					command5.CommandText = "command5";
					int innerID1 = Convert.ToInt32(command5.ExecuteScalar());
					command5.Dispose();
					FIXDbServer.SaveFIXGroup(connection, group1, table, outerID, innerID1);
				}
			}
		}

		public static void LoadFIXGroups(IDbConnection connection, FIXGroupList groups, string table)
		{
			IDbCommand command = connection.CreateCommand();
			command.CommandText = string.Format("command 12234", (object)table);
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
					FIXField field = FIXField.Field((FIXType)int32_2, int32_3, @string, true);
					groups.GetById(int32_1).AddField(field);
				}
			}
			dataReader.Close();
			command.Dispose();
		}

		public static void RemoveFIXGroup(IDbConnection connection, string table, int outerId)
		{
			IDbCommand command = connection.CreateCommand();
			command.CommandText = string.Format("RemoveFIXGroup", (object)table);
			FIXDbServer.SetCommandParameter(command, "outerId", DbType.Int32, (object)outerId);
			command.ExecuteNonQuery();
			command.Dispose();
		}

		public static void SetCommandParameter(IDbCommand command, string name, DbType type, object value)
		{
			IDbDataParameter parameter = command.CreateParameter();
			parameter.ParameterName = name;
			parameter.DbType = type;
			parameter.Value = value;
			command.Parameters.Add((object)parameter);
		}
	}
}
