using FreeQuant.FIX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace FreeQuant.Instruments
{
  public class PortfolioDbServer : IPortfolioServer
  {
    private IDbConnection connection;
    private Dictionary<int, Instrument> lgrEa297JL;

    
    public PortfolioDbServer()
    {
      this.lgrEa297JL = new Dictionary<int, Instrument>();
    }

    
    public void Open(Type connectionType, string connectionString)
    {
			this.connection = (IDbConnection) Activator.CreateInstance(connectionType); 
      this.connection.ConnectionString = connectionString;
      this.connection.Open();
      this.iguEIPjIAg();
    }

    
    public void Close()
    {
      this.connection.Close();
    }

    
    public PortfolioList Load()
    {
      PortfolioList portfolioList = new PortfolioList();
      IDbCommand command = this.connection.CreateCommand();
//      command.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(6566);
      IDataReader dataReader = command.ExecuteReader();
      while (dataReader.Read())
      {
        int int32 = dataReader.GetInt32(0);
        string string1 = dataReader.GetString(1);
        string string2 = dataReader.GetString(2);
        string string3 = dataReader.GetString(3);
        string string4 = dataReader.GetString(4);
        bool flag = !dataReader.IsDBNull(5) && dataReader.GetBoolean(5);
				Portfolio portfolio = (Portfolio) Activator.CreateInstance(Type.GetType(string.Format("ds", string2, string1)), true);
        portfolio.Id = int32;
        portfolio.Name = string3;
        portfolio.Description = string4;
        portfolio.U70sR7lQYS(flag);
        portfolioList.VJDEDjQE7o(portfolio);
      }
      dataReader.Close();
      command.Dispose();
      foreach (Portfolio portfolio in portfolioList)
        this.DdBEZNiZyZ(portfolio);
      return portfolioList;
    }

    
    public void Save(Portfolio portfolio)
    {
      if (portfolio.Id == -1)
      {
        this.lwxEohW3ad(portfolio);
      }
      else
      {
        this.ospEgWBc0j(portfolio);
        this.GG5E1xwBnb(portfolio);
        this.k2YExH5Ue4(portfolio);
      }
      foreach (Transaction transaction in portfolio.Transactions)
        this.Add(portfolio, transaction);
      foreach (AccountTransaction transaction in portfolio.Account.Transactions)
        this.Add(portfolio, transaction);
    }

    
    public void Remove(Portfolio portfolio)
    {
      this.ospEgWBc0j(portfolio);
      this.GG5E1xwBnb(portfolio);
      IDbCommand command = this.connection.CreateCommand();
			command.CommandText = "command11";
			FIXDbServer.SetCommandParameter(command, "dd", DbType.Int32, (object) portfolio.Id);
      command.ExecuteNonQuery();
      command.Dispose();
    }

    
    public void Update(Portfolio portfolio)
    {
      if (portfolio.Id == -1)
        this.lwxEohW3ad(portfolio);
      else
        this.k2YExH5Ue4(portfolio);
    }

    
    public void Clear(Portfolio portfolio)
    {
      this.ospEgWBc0j(portfolio);
      this.GG5E1xwBnb(portfolio);
    }

    
    public void Add(Portfolio portfolio, Transaction transaction)
    {
      IDbCommand command1 = this.connection.CreateCommand();
			command1.CommandText = "commandtext";
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7290), DbType.Int32, (object) portfolio.Id);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7312), DbType.String, (object) transaction.ClOrdID);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7332), DbType.Int32, (object) transaction.ReportId);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7354), DbType.DateTime, (object) transaction.DateTime);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7376), DbType.Int32, (object) transaction.Instrument.Id);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7406), DbType.StringFixedLength, (object) FIXSide.ToFIX(transaction.Side));
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7420), DbType.Double, (object) transaction.Price);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7436), DbType.Double, (object) transaction.Qty);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7448), DbType.String, (object) transaction.Text);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7462), DbType.String, (object) transaction.TransactionCost.GetType().Assembly.FullName);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7492), DbType.String, (object) transaction.TransactionCost.GetType().FullName);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7514), DbType.Double, (object) transaction.TransactionCost.Commission);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7540), DbType.StringFixedLength, (object) FIXCommType.ToFIX(transaction.TransactionCost.CommType));
//      command1.ExecuteNonQuery();
//      command1.Dispose();
//      IDbCommand command2 = this.connection.CreateCommand();
//      command2.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7562);
//      transaction.nx8WA03O1L(Convert.ToInt32(command2.ExecuteScalar()));
//      command2.Dispose();
    }

    
    public void Add(Portfolio portfolio, AccountTransaction transaction)
    {
      IDbCommand command1 = this.connection.CreateCommand();
//      command1.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7600);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7862), DbType.Int32, (object) portfolio.Id);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7884), DbType.DateTime, (object) transaction.DateTime);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7906), DbType.String, (object) transaction.Currency.Code);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7928), DbType.Double, (object) transaction.Value);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7944), DbType.String, (object) transaction.Text);
//      command1.ExecuteNonQuery();
//      command1.Dispose();
      IDbCommand command2 = this.connection.CreateCommand();
//      command2.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7958);
      transaction.G7YBAhR7LA(Convert.ToInt32(command2.ExecuteScalar()));
      command2.Dispose();
    }

    
    private void DdBEZNiZyZ([In] Portfolio obj0)
    {
      obj0.LwTsbC870d(true);
      IDbCommand command1 = this.connection.CreateCommand();
//      command1.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(7996);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(8138), DbType.Int32, (object) obj0.Id);
      IDataReader dataReader1 = command1.ExecuteReader();
      while (dataReader1.Read())
      {
        int int32_1 = dataReader1.GetInt32(0);
        dataReader1.GetInt32(1);
        string string1 = dataReader1.GetString(2);
        int int32_2 = dataReader1.GetInt32(3);
        DateTime dateTime = dataReader1.GetDateTime(4);
        int int32_3 = dataReader1.GetInt32(5);
        string string2 = dataReader1.GetString(6);
        double double1 = dataReader1.GetDouble(7);
        double double2 = dataReader1.GetDouble(8);
        string string3 = dataReader1.GetString(9);
        string string4 = dataReader1.GetString(10);
        string string5 = dataReader1.GetString(11);
        double double3 = dataReader1.GetDouble(12);
        string string6 = dataReader1.GetString(13);
        Transaction transaction = new Transaction();
        transaction.nx8WA03O1L(int32_1);
        transaction.ClOrdID = string1;
        transaction.ReportId = int32_2;
        transaction.DateTime = dateTime;
        transaction.Instrument = InstrumentManager.Instruments.GetById(int32_3);
        transaction.Side = FIXSide.FromFIX(string2[0]);
        transaction.Price = double1;
        transaction.Qty = double2;
        transaction.Text = string3;
				TransactionCost transactionCost = (TransactionCost) Activator.CreateInstance(Type.GetType(string.Format("s", (object) string5, (object) string4)), true);
        transactionCost.CommType = FIXCommType.FromFIX(string6[0]);
        transactionCost.Commission = double3;
        transaction.TransactionCost = transactionCost;
        if (transaction.Instrument == null)
          transaction.Instrument = this.xKIEA4RkYI(int32_3);
        obj0.Add(transaction);
      }
      dataReader1.Close();
      command1.Dispose();
      IDbCommand command2 = this.connection.CreateCommand();
//      command2.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(8180);
			FIXDbServer.SetCommandParameter(command2, "sss", DbType.Int32, (object) obj0.Id);
      IDataReader dataReader2 = command2.ExecuteReader();
      while (dataReader2.Read())
      {
        int int32 = dataReader2.GetInt32(0);
        dataReader2.GetInt32(1);
        DateTime dateTime = dataReader2.GetDateTime(2);
        string @string = dataReader2.GetString(3);
        double @double = dataReader2.GetDouble(4);
        string str = dataReader2.IsDBNull(5) ? "" : dataReader2.GetString(5);
        AccountTransaction transaction = new AccountTransaction();
        transaction.G7YBAhR7LA(int32);
        transaction.DateTime = dateTime;
        transaction.Currency = CurrencyManager.Currencies[@string];
        transaction.Value = @double;
        transaction.Text = str;
        obj0.Account.Add(transaction);
      }
      dataReader2.Close();
      command2.Dispose();
      obj0.LwTsbC870d(false);
    }

    
    private Instrument xKIEA4RkYI([In] int obj0)
    {
      Instrument instrument;
      if (!this.lgrEa297JL.TryGetValue(obj0, out instrument))
      {
        instrument = (Instrument) Activator.CreateInstance(typeof (Instrument), true);
				instrument.Symbol = string.Format("dd", obj0);
        this.lgrEa297JL.Add(obj0, instrument);
      }
      return instrument;
    }

    
    private void ospEgWBc0j([In] Portfolio obj0)
    {
//      IDbCommand command = this.connection.CreateCommand();
//      command.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(8396);
//      FIXDbServer.SetCommandParameter(command, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(8500), DbType.Int32, (object) obj0.Id);
//      command.ExecuteNonQuery();
//      command.Dispose();
    }

    
    private void GG5E1xwBnb([In] Portfolio obj0)
    {
//      IDbCommand command = this.connection.CreateCommand();
//      command.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(8522);
//      FIXDbServer.SetCommandParameter(command, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(8642), DbType.Int32, (object) obj0.Id);
//      command.ExecuteNonQuery();
//      command.Dispose();
    }

    
    private void lwxEohW3ad([In] Portfolio obj0)
    {
//      IDbCommand command1 = this.connection.CreateCommand();
//      command1.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(8664);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(8922), DbType.String, (object) obj0.GetType().Assembly.FullName);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(8944), DbType.String, (object) obj0.GetType().FullName);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(8958), DbType.String, (object) obj0.Name);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(8972), DbType.String, (object) obj0.Description);
//      FIXDbServer.SetCommandParameter(command1, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9000), DbType.Boolean, (object) (bool) (obj0.Persistent ? 1 : 0));
//      command1.ExecuteNonQuery();
//      command1.Dispose();
//      IDbCommand command2 = this.connection.CreateCommand();
//      command2.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9026);
//      obj0.Id = Convert.ToInt32(command2.ExecuteScalar());
//      command2.Dispose();
    }

    
    private void k2YExH5Ue4([In] Portfolio obj0)
    {
      IDbCommand command = this.connection.CreateCommand();
//      command.CommandText = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9064);
//      FIXDbServer.SetCommandParameter(command, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9238), DbType.String, (object) obj0.Description);
//      FIXDbServer.SetCommandParameter(command, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9266), DbType.Boolean, (object) (bool) (obj0.Persistent ? 1 : 0));
//      FIXDbServer.SetCommandParameter(command, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9292), DbType.Int32, (object) obj0.Id);
      command.ExecuteNonQuery();
      command.Dispose();
    }

    
    private void iguEIPjIAg()
    {
//      this.FQ3ELAbSkh(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9302), gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9326), gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9352));
//      this.FQ3ELAbSkh(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9370), gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9414), gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9428));
    }

    
    private void FQ3ELAbSkh([In] string obj0, [In] string obj1, [In] string obj2)
    {
    }

    
    private void E0bEbeQ8fB()
    {
    }
  }
}
