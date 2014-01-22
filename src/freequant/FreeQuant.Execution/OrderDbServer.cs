using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Execution
{
  public class OrderDbServer : IOrderServer
  {
    private IDbConnection cMOyAvus8;
    private Dictionary<int, Type> jW5iqEmeD;
    private Dictionary<Type, int> t1OfD4U1U;

    
    public OrderDbServer()
    {
      this.jW5iqEmeD = new Dictionary<int, Type>();
      this.t1OfD4U1U = new Dictionary<Type, int>();
    }

    public void Open(Type connectionType, string connectionString)
    {
      this.cMOyAvus8 = (IDbConnection) Activator.CreateInstance(connectionType, true);
      this.cMOyAvus8.ConnectionString = connectionString;
      this.cMOyAvus8.Open();
      this.TQt5NviMg();
      this.zNagDpvUO();
    }

    public void AddOrder(IOrder order)
    {
      if (order.Id != -1)
				throw new InvalidOperationException("");
      lock (this)
      {
        IDbCommand local_0 = this.cMOyAvus8.CreateCommand();
//        local_0.CommandText = p9eligYgcNHo8cieFV.RdvEpVlLR7(756);
//        FIXDbServer.SetCommandParameter(local_0, p9eligYgcNHo8cieFV.RdvEpVlLR7(1004), DbType.Int32, (object) this.Hblu18jwZ(order));
//        FIXDbServer.SetCommandParameter(local_0, p9eligYgcNHo8cieFV.RdvEpVlLR7(1022), DbType.Int32, (object) order.Instrument.Id);
//        FIXDbServer.SetCommandParameter(local_0, p9eligYgcNHo8cieFV.RdvEpVlLR7(1052), DbType.Int32, (object) order.Provider.Id);
//        FIXDbServer.SetCommandParameter(local_0, p9eligYgcNHo8cieFV.RdvEpVlLR7(1078), DbType.Int32, (object) order.Portfolio.Id);
        local_0.ExecuteNonQuery();
        local_0.Dispose();
        IDbCommand local_0_1 = this.cMOyAvus8.CreateCommand();
				local_0_1.CommandText = "";
        order.Id = Convert.ToInt32(local_0_1.ExecuteScalar());
        local_0_1.Dispose();
				FIXDbServer.SaveFIXGroup(this.cMOyAvus8, (FIXGroup) (order as SingleOrder),"", order.Id);
      }
    }

    public void AddReport(IOrder order, FIXExecutionReport report)
    {
      lock (this)
      {
//        FIXDbServer.RemoveFIXGroup(this.cMOyAvus8, p9eligYgcNHo8cieFV.RdvEpVlLR7(1172), order.Id);
//        FIXDbServer.SaveFIXGroup(this.cMOyAvus8, (FIXGroup) (order as SingleOrder), p9eligYgcNHo8cieFV.RdvEpVlLR7(1200), order.Id);
//        IDbCommand local_0 = this.cMOyAvus8.CreateCommand();
//        local_0.CommandText = p9eligYgcNHo8cieFV.RdvEpVlLR7(1228);
//        FIXDbServer.SetCommandParameter(local_0, p9eligYgcNHo8cieFV.RdvEpVlLR7(1330), DbType.Int32, (object) order.Id);
//        local_0.ExecuteNonQuery();
//        local_0.Dispose();
//        IDbCommand local_0_1 = this.cMOyAvus8.CreateCommand();
//        local_0_1.CommandText = p9eligYgcNHo8cieFV.RdvEpVlLR7(1352);
//        report.Id = Convert.ToInt32(local_0_1.ExecuteScalar());
//        local_0_1.Dispose();
//        FIXDbServer.SaveFIXGroup(this.cMOyAvus8, (FIXGroup) report, p9eligYgcNHo8cieFV.RdvEpVlLR7(1390), report.Id);
      }
    }

    public void Remove(IOrder order)
    {
      lock (this)
      {
//        IDbCommand local_0 = this.cMOyAvus8.CreateCommand();
//        local_0.CommandText = p9eligYgcNHo8cieFV.RdvEpVlLR7(1420);
//        FIXDbServer.SetCommandParameter(local_0, p9eligYgcNHo8cieFV.RdvEpVlLR7(1488), DbType.Int32, (object) order.Id);
//        local_0.ExecuteNonQuery();
//        local_0.Dispose();
      }
    }

    public void Close()
    {
      this.cMOyAvus8.Close();
    }

    private void zNagDpvUO()
    {
      IDbCommand command = this.cMOyAvus8.CreateCommand();
			command.CommandText = "";
      IDataReader dataReader = command.ExecuteReader();
      while (dataReader.Read())
      {
        int int32 = dataReader.GetInt32(0);
        Type type = Type.GetType(dataReader.GetString(1));
        this.jW5iqEmeD.Add(int32, type);
        this.t1OfD4U1U.Add(type, int32);
      }
      dataReader.Close();
      command.Dispose();
    }

    public OrderList Load()
    {
      lock (this)
      {
        OrderList local_2 = new OrderList();
        IDbCommand local_0 = this.cMOyAvus8.CreateCommand();
				local_0.CommandText = "";
        IDataReader local_1 = local_0.ExecuteReader();
        while (local_1.Read())
        {
          int local_3 = local_1.GetInt32(0);
          Type local_4 = this.jW5iqEmeD[local_1.GetInt32(1)];
          int local_5 = local_1.IsDBNull(2) ? -1 : local_1.GetInt32(2);
          int local_6 = local_1.IsDBNull(3) ? -1 : local_1.GetInt32(3);
          int local_7 = local_1.IsDBNull(4) ? -1 : local_1.GetInt32(4);
          IOrder local_8 = (IOrder) Activator.CreateInstance(local_4, true);
          local_8.Id = local_3;
          local_8.Instrument = InstrumentManager.Instruments.GetById(local_5);
          local_8.Provider = ProviderManager.ExecutionProviders[(byte) local_6];
          local_8.Portfolio = PortfolioManager.Portfolios.GetById(local_7);
          local_8.Persistent = true;
          local_2.Add(local_8);
        }
        local_1.Close();
        local_0.Dispose();
				FIXDbServer.LoadFIXGroups(this.cMOyAvus8, (FIXGroupList) local_2, "");
        ExecutionReportList local_9 = new ExecutionReportList();
        IDbCommand local_0_1 = this.cMOyAvus8.CreateCommand();
				local_0_1.CommandText = "commadn";
        IDataReader local_1_1 = local_0_1.ExecuteReader();
        while (local_1_1.Read())
        {
          int local_10 = local_1_1.GetInt32(0);
          int local_11 = local_1_1.GetInt32(1);
          ExecutionReport local_12 = new ExecutionReport();
          local_12.Id = local_10;
          local_2.GetById(local_11).Reports.Add((FIXGroup) local_12);
          local_9.Add((FIXGroup) local_12);
        }
        local_1_1.Close();
        local_0_1.Dispose();
				FIXDbServer.LoadFIXGroups(this.cMOyAvus8, (FIXGroupList) local_9, "");
        return local_2;
      }
    }

    private int Hblu18jwZ([In] IOrder obj0)
    {
      Type type = obj0.GetType();
      if (!this.t1OfD4U1U.ContainsKey(type))
      {
//        string str = type.FullName + p9eligYgcNHo8cieFV.RdvEpVlLR7(1700) + type.Assembly.GetName().Name;
//        IDbCommand command1 = this.cMOyAvus8.CreateCommand();
//        command1.CommandText = p9eligYgcNHo8cieFV.RdvEpVlLR7(1708);
//        FIXDbServer.SetCommandParameter(command1, p9eligYgcNHo8cieFV.RdvEpVlLR7(1802), DbType.String, (object) string.Format(p9eligYgcNHo8cieFV.RdvEpVlLR7(1816), (object) type.FullName, (object) type.Assembly.GetName().Name));
//        command1.ExecuteNonQuery();
//        command1.Dispose();
//        IDbCommand command2 = this.cMOyAvus8.CreateCommand();
//        command2.CommandText = p9eligYgcNHo8cieFV.RdvEpVlLR7(1836);
//        int key = Convert.ToInt32(command2.ExecuteScalar());
//        command2.Dispose();
//        this.jW5iqEmeD.Add(key, type);
//        this.t1OfD4U1U.Add(type, key);
      }
      return this.t1OfD4U1U[type];
    }

    private void TQt5NviMg()
    {
//      this.GvA89FjyZ(p9eligYgcNHo8cieFV.RdvEpVlLR7(1874), p9eligYgcNHo8cieFV.RdvEpVlLR7(1890), p9eligYgcNHo8cieFV.RdvEpVlLR7(1920));
//      this.GvA89FjyZ(p9eligYgcNHo8cieFV.RdvEpVlLR7(1930), p9eligYgcNHo8cieFV.RdvEpVlLR7(1946), p9eligYgcNHo8cieFV.RdvEpVlLR7(1972));
//      this.GvA89FjyZ(p9eligYgcNHo8cieFV.RdvEpVlLR7(1982), p9eligYgcNHo8cieFV.RdvEpVlLR7(1998), p9eligYgcNHo8cieFV.RdvEpVlLR7(2026));
    }

    private void GvA89FjyZ([In] string obj0, [In] string obj1, [In] string obj2)
    {
    }
  }
}
