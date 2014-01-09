using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant
{
  public class Configuration
  {
    private const string KMfmCD6RBk = "Trace";
    private const string HWgm8mfSmm = "Defaults";
    private const string qSTmIZYQno = "Error Management";
    private const string TvkmlyTube = "framework.xml";
    private const System.Diagnostics.TraceLevel p5bm2wAvJs = System.Diagnostics.TraceLevel.Info;
    private const string T3Qm9usnId = "Currency";
    private const string PfXmVQJjCq = "Portfolio";
    private const string gVemgBLiKH = "Exchange";
    private const string LAtmbbgnaa = "ExecutionProvider";
    private const string KjrmvsKr1v = "MarketDataProvider";
    private ReferenceList DQjmfsNtrs;
    private PluginList OKampyn3AK;
    private System.Diagnostics.TraceLevel Rk0mdunFrb;
    private string ytrmcAy4ir;
    private string eVlmZNmmA4;
    private string GIMm15xSFy;
    private string V8kmoMRt7L;
    private string DtLmLipQKg;
    private ReferenceEventHandler wolmFIfJrc;
    private ReferenceEventHandler QPAm7LZQjA;
    private ReferenceEventHandler IA7meCFNnh;
    private PluginEventHandler yOymK0FHSy;
    private PluginEventHandler u0GmutLxYQ;
    private PluginEventHandler XwdmO0txOf;
    private EventHandler Nd9mA8lB6n;

    [Browsable(false)]
    public ReferenceList References
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (ReferenceList) null;
      }
    }

    [Browsable(false)]
    public PluginList Plugins
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (PluginList) null;
      }
    }

    [DefaultValue(System.Diagnostics.TraceLevel.Info)]
    [Description("Gets or sets trace level")]
    [Category("Trace")]
    public System.Diagnostics.TraceLevel TraceLevel
    {
      get
      {
        return \u003CPrivateImplementationDetails\u003E\u007BBC86C0EF\u002D576E\u002D453D\u002D8BFD\u002DFAB33B893C15\u007D.fieldimpl5;
      }
       set
      {
      }
    }

    [Category("Error Management")]
    [DisplayName("Enabled")]
    [DefaultValue(true)]
    public bool RuntimeErrorManagerEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return true;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
      }
    }

    [DisplayName("Target")]
    [Category("Error Management")]
    [DefaultValue(RuntimeErrorOutputTarget.PopupWindow)]
    public RuntimeErrorOutputTarget RuntimeErrorOutputTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return \u003CPrivateImplementationDetails\u003E\u007BBC86C0EF\u002D576E\u002D453D\u002D8BFD\u002DFAB33B893C15\u007D.fieldimpl4;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
      }
    }

    [Description("Gets or sets default currency")]
    [Category("Defaults")]
    public string DefaultCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (string) null;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
      }
    }

    [Description("Gets or sets default exchange")]
    [Category("Defaults")]
    public string DefaultExchange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (string) null;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
      }
    }

    [Description("Gets or sets default execution provider")]
    [Category("Defaults")]
    public string DefaultExecutionProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (string) null;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
      }
    }

    [Category("Defaults")]
    [Description("Gets or sets default market data provider")]
    public string DefaultMarketDataProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (string) null;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
      }
    }

    [Description("Gets or sets default portfolio")]
    [Category("Defaults")]
    public string DefaultPortfolio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (string) null;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
      }
    }

    public event ReferenceEventHandler ReferenceAdded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add
      {
      }
      [MethodImpl(MethodImplOptions.NoInlining)] remove
      {
      }
    }

    public event ReferenceEventHandler ReferenceRemoved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add
      {
      }
      [MethodImpl(MethodImplOptions.NoInlining)] remove
      {
      }
    }

    public event ReferenceEventHandler ReferenceEnabledChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add
      {
      }
      [MethodImpl(MethodImplOptions.NoInlining)] remove
      {
      }
    }

    public event PluginEventHandler PluginAdded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add
      {
      }
      [MethodImpl(MethodImplOptions.NoInlining)] remove
      {
      }
    }

    public event PluginEventHandler PluginRemoved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add
      {
      }
      [MethodImpl(MethodImplOptions.NoInlining)] remove
      {
      }
    }

    public event PluginEventHandler PluginEnabledChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add
      {
      }
      [MethodImpl(MethodImplOptions.NoInlining)] remove
      {
      }
    }

    public event EventHandler TraceLevelChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add
      {
      }
      [MethodImpl(MethodImplOptions.NoInlining)] remove
      {
      }
    }

    static Configuration()
    {
      GItcYDqSxj5aE60JeS.GRAroVBQNR();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Configuration()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void MKvmw0X4h6()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddReference(Reference reference)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveReference(Reference reference)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPlugin(Plugin plugin)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemovePlugin(Plugin plugin)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void r4omhfJxrr([In] Reference obj0)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void i7WmspOSjr([In] Reference obj0)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void iVCmyqqsve([In] Reference obj0)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void cTdmESFHjc([In] Plugin obj0)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void rRLmTCXR6E([In] Plugin obj0)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void S6RmWfq0Ij([In] Plugin obj0)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void L7GmG9IG7M()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void XQDm0HUSTN()
    {
    }
  }
}
