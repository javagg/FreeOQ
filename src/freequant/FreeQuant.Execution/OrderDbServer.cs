using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections.Generic;
using System.Data;

namespace FreeQuant.Execution
{
	public class OrderDbServer : IOrderServer
	{
		private IDbConnection connection;
		private Dictionary<int, Type> jW5iqEmeD;
		private Dictionary<Type, int> t1OfD4U1U;

		public OrderDbServer()
		{
			this.jW5iqEmeD = new Dictionary<int, Type>();
			this.t1OfD4U1U = new Dictionary<Type, int>();
		}

		public void Open(Type connectionType, string connectionString)
		{
			this.connection = (IDbConnection)Activator.CreateInstance(connectionType, true);
			this.connection.ConnectionString = connectionString;
			this.connection.Open();
//			this.TQt5NviMg();
			this.zNagDpvUO();
		}

		public void AddOrder(IOrder order)
		{
			if (order.Id != -1)
				throw new InvalidOperationException("");
			lock (this)
			{
				IDbCommand local_0 = this.connection.CreateCommand();
//        local_0.CommandText = p9eligYgcNHo8cieFV.RdvEpVlLR7(756);
//        FIXDbServer.SetCommandParameter(local_0, p9eligYgcNHo8cieFV.RdvEpVlLR7(1004), DbType.Int32, (object) this.Hblu18jwZ(order));
//        FIXDbServer.SetCommandParameter(local_0, p9eligYgcNHo8cieFV.RdvEpVlLR7(1022), DbType.Int32, (object) order.Instrument.Id);
//        FIXDbServer.SetCommandParameter(local_0, p9eligYgcNHo8cieFV.RdvEpVlLR7(1052), DbType.Int32, (object) order.Provider.Id);
//        FIXDbServer.SetCommandParameter(local_0, p9eligYgcNHo8cieFV.RdvEpVlLR7(1078), DbType.Int32, (object) order.Portfolio.Id);
				local_0.ExecuteNonQuery();
				local_0.Dispose();
				IDbCommand local_0_1 = this.connection.CreateCommand();
				local_0_1.CommandText = "";
				order.Id = Convert.ToInt32(local_0_1.ExecuteScalar());
				local_0_1.Dispose();
				FIXDbServer.SaveFIXGroup(this.connection, (FIXGroup)(order as SingleOrder), "", order.Id);
			}
		}

		public void AddReport(IOrder order, FIXExecutionReport report)
		{
			lock (this)
			{
				FIXDbServer.RemoveFIXGroup(this.connection, "atable", order.Id);
				FIXDbServer.SaveFIXGroup(this.connection, (FIXGroup) (order as SingleOrder), "ordertable", order.Id);
				IDbCommand cmd = this.connection.CreateCommand();
				cmd.CommandText = "";
				FIXDbServer.SetCommandParameter(cmd, "atable", DbType.Int32, order.Id);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
				IDbCommand cmd2 = this.connection.CreateCommand();
				cmd2.CommandText = "";
        report.Id = Convert.ToInt32(cmd2.ExecuteScalar());
        cmd2.Dispose();
				FIXDbServer.SaveFIXGroup(this.connection, report, "report.table", report.Id);
			}
		}

		public void Remove(IOrder order)
		{
			lock (this)
			{
				IDbCommand cmd = this.connection.CreateCommand();
				cmd.CommandText = "";
				FIXDbServer.SetCommandParameter(cmd, "name", DbType.Int32, (object) order.Id);
	        cmd.ExecuteNonQuery();
	        cmd.Dispose();
			}
		}

		public void Close()
		{
			this.connection.Close();
		}

		private void zNagDpvUO()
		{
			IDbCommand command = this.connection.CreateCommand();
			command.CommandText = "";
			IDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				int int32 = reader.GetInt32(0);
				Type type = Type.GetType(reader.GetString(1));
				this.jW5iqEmeD.Add(int32, type);
				this.t1OfD4U1U.Add(type, int32);
			}
			reader.Close();
			command.Dispose();
		}

		public OrderList Load()
		{
			lock (this)
			{
				OrderList orders = new OrderList();
				IDbCommand command = this.connection.CreateCommand();
				// TODO:
				command.CommandText = "select order from";
				IDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					int orderId = reader.GetInt32(0);
					Type orderType = this.jW5iqEmeD[reader.GetInt32(1)];
					int instrumentId = reader.IsDBNull(2) ? -1 : reader.GetInt32(2);
					int providerId = reader.IsDBNull(3) ? -1 : reader.GetInt32(3);
					int portfolioId = reader.IsDBNull(4) ? -1 : reader.GetInt32(4);
					IOrder order = (IOrder)Activator.CreateInstance(orderType, true);
					order.Id = orderId;
					order.Instrument = InstrumentManager.Instruments.GetById(instrumentId);
					order.Provider = ProviderManager.ExecutionProviders[(byte)providerId];
					order.Portfolio = PortfolioManager.Portfolios.GetById(portfolioId);
					order.Persistent = true;
					orders.Add(order);
				}
				reader.Close();
				command.Dispose();
				FIXDbServer.LoadFIXGroups(this.connection, orders, "order.table");
				ExecutionReportList reports = new ExecutionReportList();
				IDbCommand cmd = this.connection.CreateCommand();
				cmd.CommandText = "commadn";
				IDataReader reader2 = cmd.ExecuteReader();
				while (reader2.Read())
				{
					int reportId = reader2.GetInt32(0);
					int orderId = reader2.GetInt32(1);
					ExecutionReport report = new ExecutionReport();
					report.Id = reportId;
					orders.GetById(orderId).Reports.Add(report);
					reports.Add(report);
				}
				reader2.Close();
				cmd.Dispose();
				FIXDbServer.LoadFIXGroups(this.connection, reports, "report.table");
				return orders;
			}
		}

		private int Hblu18jwZ(IOrder order)
		{
			Type type = order.GetType();
			if (!this.t1OfD4U1U.ContainsKey(type))
			{
				string str = type.FullName + "" + type.Assembly.GetName().Name;
				IDbCommand command1 = this.connection.CreateCommand();
				command1.CommandText = "";
				FIXDbServer.SetCommandParameter(command1, "name", DbType.String, string.Format("format", (object) type.FullName, (object) type.Assembly.GetName().Name));
	        command1.ExecuteNonQuery();
	        command1.Dispose();
				IDbCommand command2 = this.connection.CreateCommand();
				command2.CommandText = "";
	        int key = Convert.ToInt32(command2.ExecuteScalar());
	        command2.Dispose();
	        this.jW5iqEmeD.Add(key, type);
	        this.t1OfD4U1U.Add(type, key);
			}
			return this.t1OfD4U1U[type];
		}

		private void TQt5NviMg()
		{
//      this.GvA89FjyZ(p9eligYgcNHo8cieFV.RdvEpVlLR7(1874), p9eligYgcNHo8cieFV.RdvEpVlLR7(1890), p9eligYgcNHo8cieFV.RdvEpVlLR7(1920));
//      this.GvA89FjyZ(p9eligYgcNHo8cieFV.RdvEpVlLR7(1930), p9eligYgcNHo8cieFV.RdvEpVlLR7(1946), p9eligYgcNHo8cieFV.RdvEpVlLR7(1972));
//      this.GvA89FjyZ(p9eligYgcNHo8cieFV.RdvEpVlLR7(1982), p9eligYgcNHo8cieFV.RdvEpVlLR7(1998), p9eligYgcNHo8cieFV.RdvEpVlLR7(2026));
		}

		private void GvA89FjyZ(string obj0, string obj1, string obj2)
		{
		}
	}
}
