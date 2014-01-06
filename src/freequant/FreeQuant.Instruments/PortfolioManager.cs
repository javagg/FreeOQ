// Type: SmartQuant.Instruments.PortfolioManager
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using VFUvY5knK01pUIalDo;

namespace SmartQuant.Instruments
{
  public class PortfolioManager
  {
    private static IPortfolioServer N69sGK1Lwj;
    private static PortfolioList WHqsXijamb;
    private static IPortfolioPricer a1Ys4GqCY9;

    public static Portfolio DefaultPortfolio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return PortfolioManager.WHqsXijamb[Framework.Configuration.DefaultPortfolio];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        Framework.Configuration.DefaultPortfolio = value.Name;
      }
    }

    public static PortfolioList Portfolios
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return PortfolioManager.WHqsXijamb;
      }
    }

    public static IPortfolioServer Server
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return PortfolioManager.N69sGK1Lwj;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        PortfolioManager.N69sGK1Lwj = value;
      }
    }

    public static IPortfolioPricer Pricer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return PortfolioManager.a1Ys4GqCY9;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        PortfolioManager.a1Ys4GqCY9 = value;
      }
    }

    public static event PortfolioEventHandler PortfolioAdded;

    public static event PortfolioEventHandler PortfolioRemoved;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PortfolioManager()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      PortfolioManager.a1Ys4GqCY9 = (IPortfolioPricer) new PortfolioPricer();
      PortfolioManager.N69sGK1Lwj = (IPortfolioServer) new PortfolioDbServer();
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
      PortfolioManager.N69sGK1Lwj.Open(connectionType, connectionString);
      PortfolioManager.WHqsXijamb = PortfolioManager.N69sGK1Lwj.Load();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PortfolioManager()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Init()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void j2wssyCvhK([In] Portfolio obj0)
    {
      PortfolioManager.WHqsXijamb.VJDEDjQE7o(obj0);
      PortfolioManager.zAFsl21MLH(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Remove(Portfolio portfolio)
    {
      PortfolioManager.N69sGK1Lwj.Remove(portfolio);
      PortfolioManager.WHqsXijamb.kD1E0Sjpl1(portfolio);
      PortfolioManager.cDvsYRfr9s(portfolio);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void HLQsd4XEGK([In] Portfolio obj0)
    {
      PortfolioManager.N69sGK1Lwj.Save(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void IDgsP9flDf([In] Portfolio obj0)
    {
      PortfolioManager.N69sGK1Lwj.Update(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void LfnseafCc7([In] Portfolio obj0, [In] Transaction obj1)
    {
      PortfolioManager.N69sGK1Lwj.Add(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void vwIs2WhnRQ([In] Portfolio obj0, [In] AccountTransaction obj1)
    {
      PortfolioManager.N69sGK1Lwj.Add(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void iY2s8gqb4S([In] Portfolio obj0)
    {
      PortfolioManager.N69sGK1Lwj.Clear(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void zAFsl21MLH([In] Portfolio obj0)
    {
      if (PortfolioManager.C8wsJidmHP == null)
        return;
      PortfolioManager.C8wsJidmHP(new PortfolioEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void cDvsYRfr9s([In] Portfolio obj0)
    {
      if (PortfolioManager.eDZsrqQCBW == null)
        return;
      PortfolioManager.eDZsrqQCBW(new PortfolioEventArgs(obj0));
    }
  }
}
