using FreeQuant;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace FreeQuant.Instruments
{
  public class PortfolioManager
  {
    private static IPortfolioServer server;
    private static PortfolioList portfolios;
    private static IPortfolioPricer pricer;

    public static Portfolio DefaultPortfolio
    {
       get
      {
        return PortfolioManager.portfolios[Framework.Configuration.DefaultPortfolio];
      }
       set
      {
        Framework.Configuration.DefaultPortfolio = value.Name;
      }
    }

    public static PortfolioList Portfolios
    {
       get
      {
				return PortfolioManager.portfolios; 
      }
    }

    public static IPortfolioServer Server
    {
       get
      {
				return PortfolioManager.server; 
      }
       set
      {
        PortfolioManager.server = value;
      }
    }

    public static IPortfolioPricer Pricer
    {
       get
      {
				return PortfolioManager.pricer; 
      }
       set
      {
        PortfolioManager.pricer = value;
      }
    }

    public static event PortfolioEventHandler PortfolioAdded;

    public static event PortfolioEventHandler PortfolioRemoved;

    
    static PortfolioManager()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      PortfolioManager.pricer = (IPortfolioPricer) new PortfolioPricer();
      PortfolioManager.server = (IPortfolioServer) new PortfolioDbServer();
      Type connectionType = (Type) null;
      string connectionString = string.Empty;
      switch (Framework.Storage.ServerType)
      {
        case DbServerType.MS_ACCESS:
          connectionType = Type.GetType(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9868));
          connectionString = string.Format(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10098), (object) Framework.Installation.DataDir.FullName);
          break;
        case DbServerType.SQL_SERVER_COMPACT_EDITION_35:
          connectionType = Type.GetType(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10226));
          connectionString = string.Format(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10492), (object) Framework.Installation.DataDir.FullName);
          break;
      }
      PortfolioManager.server.Open(connectionType, connectionString);
      PortfolioManager.portfolios = PortfolioManager.server.Load();
    }

    
    public PortfolioManager()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    
    public static void Init()
    {
    }

    
    internal static void j2wssyCvhK([In] Portfolio obj0)
    {
      PortfolioManager.portfolios.VJDEDjQE7o(obj0);
      PortfolioManager.zAFsl21MLH(obj0);
    }

    
    public static void Remove(Portfolio portfolio)
    {
      PortfolioManager.server.Remove(portfolio);
      PortfolioManager.portfolios.kD1E0Sjpl1(portfolio);
      PortfolioManager.cDvsYRfr9s(portfolio);
    }

    
    internal static void HLQsd4XEGK([In] Portfolio obj0)
    {
      PortfolioManager.server.Save(obj0);
    }

    
    internal static void IDgsP9flDf([In] Portfolio obj0)
    {
      PortfolioManager.server.Update(obj0);
    }

    
    internal static void LfnseafCc7([In] Portfolio obj0, [In] Transaction obj1)
    {
      PortfolioManager.server.Add(obj0, obj1);
    }

    
    internal static void vwIs2WhnRQ([In] Portfolio obj0, [In] AccountTransaction obj1)
    {
      PortfolioManager.server.Add(obj0, obj1);
    }

    
    internal static void iY2s8gqb4S([In] Portfolio obj0)
    {
      PortfolioManager.server.Clear(obj0);
    }

    
    private static void zAFsl21MLH([In] Portfolio obj0)
    {
      if (PortfolioManager.C8wsJidmHP == null)
        return;
      PortfolioManager.C8wsJidmHP(new PortfolioEventArgs(obj0));
    }

    
    private static void cDvsYRfr9s([In] Portfolio obj0)
    {
      if (PortfolioManager.eDZsrqQCBW == null)
        return;
      PortfolioManager.eDZsrqQCBW(new PortfolioEventArgs(obj0));
    }
  }
}
