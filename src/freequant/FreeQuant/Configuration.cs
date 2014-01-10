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
       get
      {
        return (ReferenceList) null;
      }
    }

    [Browsable(false)]
    public PluginList Plugins
    {
       get
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
       get
      {
        return true;
      }
       set
      {
      }
    }

    [DisplayName("Target")]
    [Category("Error Management")]
    [DefaultValue(RuntimeErrorOutputTarget.PopupWindow)]
    public RuntimeErrorOutputTarget RuntimeErrorOutputTarget
    {
       get
      {
        return \u003CPrivateImplementationDetails\u003E\u007BBC86C0EF\u002D576E\u002D453D\u002D8BFD\u002DFAB33B893C15\u007D.fieldimpl4;
      }
       set
      {
      }
    }

    [Description("Gets or sets default currency")]
    [Category("Defaults")]
    public string DefaultCurrency
    {
       get
      {
        return (string) null;
      }
       set
      {
      }
    }

    [Description("Gets or sets default exchange")]
    [Category("Defaults")]
    public string DefaultExchange
    {
       get
      {
        return (string) null;
      }
       set
      {
      }
    }

    [Description("Gets or sets default execution provider")]
    [Category("Defaults")]
    public string DefaultExecutionProvider
    {
       get
      {
        return (string) null;
      }
       set
      {
      }
    }

    [Category("Defaults")]
    [Description("Gets or sets default market data provider")]
    public string DefaultMarketDataProvider
    {
       get
      {
        return (string) null;
      }
       set
      {
      }
    }

    [Description("Gets or sets default portfolio")]
    [Category("Defaults")]
    public string DefaultPortfolio
    {
       get
      {
        return (string) null;
      }
       set
      {
      }
    }

    public event ReferenceEventHandler ReferenceAdded
    {
       add
      {
      }
       remove
      {
      }
    }

    public event ReferenceEventHandler ReferenceRemoved
    {
       add
      {
      }
       remove
      {
      }
    }

    public event ReferenceEventHandler ReferenceEnabledChanged
    {
       add
      {
      }
       remove
      {
      }
    }

    public event PluginEventHandler PluginAdded
    {
       add
      {
      }
       remove
      {
      }
    }

    public event PluginEventHandler PluginRemoved
    {
       add
      {
      }
       remove
      {
      }
    }

    public event PluginEventHandler PluginEnabledChanged
    {
       add
      {
      }
       remove
      {
      }
    }

    public event EventHandler TraceLevelChanged
    {
       add
      {
      }
       remove
      {
      }
    }

    static Configuration()
    {
      GItcYDqSxj5aE60JeS.GRAroVBQNR();
    }

    
    internal Configuration()
    {
    }

    
    internal void MKvmw0X4h6()
    {
    }

    
    public void AddReference(Reference reference)
    {
    }

    
    public void RemoveReference(Reference reference)
    {
    }

    
    public void AddPlugin(Plugin plugin)
    {
    }

    
    public void RemovePlugin(Plugin plugin)
    {
    }

    
    private void r4omhfJxrr([In] Reference obj0)
    {
    }

    
    private void i7WmspOSjr([In] Reference obj0)
    {
    }

    
    internal void iVCmyqqsve([In] Reference obj0)
    {
    }

    
    private void cTdmESFHjc([In] Plugin obj0)
    {
    }

    
    private void rRLmTCXR6E([In] Plugin obj0)
    {
    }

    
    internal void S6RmWfq0Ij([In] Plugin obj0)
    {
    }

    
    private void L7GmG9IG7M()
    {
    }

    
    private void XQDm0HUSTN()
    {
    }
  }
}
