using System;
using System.ComponentModel;

namespace FreeQuant
{
    public class Configuration
    {
        private const string Trace = "Trace";
        private const string Defaults = "Defaults";
        private const string qSTmIZYQno = "Error Management";
        private const string TvkmlyTube = "framework.xml";
        private const string DEFAULT_CURRENCY = "USD";
        private const string DEFAULT_PORTFOLIO = "Portfolio";
        private const string DEFAULT_EXCHANGE = "NYSE";
        private const string DEFAULT_EXECUTION_PROVIDER = "ExecutionProvider";
        private const string DEFAULT_MARKETDATA_PROVIDER = "MarketDataProvider";
        private ReferenceList references;
        private PluginList plugins = new PluginList();
        private System.Diagnostics.TraceLevel traceLevel = TraceLevel.Info;
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
                return references;
            }
        }

        [Browsable(false)]
        public PluginList Plugins
        {
            get
            {
                return plugins;
            }
        }

        [DefaultValue(System.Diagnostics.TraceLevel.Info)]
        [Description("Gets or sets trace level")]
        [Category("Trace")]
        public TraceLevel TraceLevel { get; set; }

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
        public RuntimeErrorOutputTarget RuntimeErrorOutputTarget { get; private set; }

        [Description("Gets or sets default currency")]
        [Category("Defaults")]
        public string DefaultCurrency
        {
            get
            {
                return "USD";
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
                return DEFAULT_EXCHANGE;
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
                return DEFAULT_EXECUTION_PROVIDER;
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
                return DEFAULT_MARKETDATA_PROVIDER;
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
                return DEFAULT_PORTFOLIO;
            }
            set
            {
            }
        }

        public event ReferenceEventHandler ReferenceAdded;
        public event ReferenceEventHandler ReferenceRemoved;
        public event ReferenceEventHandler ReferenceEnabledChanged;
        public event PluginEventHandler PluginAdded;
        public event PluginEventHandler PluginRemoved;
        public event PluginEventHandler PluginEnabledChanged;
        public event EventHandler TraceLevelChanged;

//        static Configuration()
//        {
//
//        }

        internal Configuration()
        {
        }

        internal void MKvmw0X4h6()
        {
        }

        public void AddReference(Reference reference)
        {
            this.references.Add(reference);
            if (this.ReferenceAdded != null)
                this.ReferenceAdded(new ReferenceEventArgs(reference));
        }

        public void RemoveReference(Reference reference)
        {
            this.references.Remove(reference);
            if (this.ReferenceRemoved != null)
                this.ReferenceRemoved(new ReferenceEventArgs(reference));
        }

        public void AddPlugin(Plugin plugin)
        {
            this.plugins.Add(plugin);
            if (this.PluginAdded != null)
                this.PluginAdded(new PluginEventArgs(plugin));
        }

        public void RemovePlugin(Plugin plugin)
        {
            this.plugins.Remove(plugin);
            if (this.PluginRemoved != null)
                this.PluginRemoved(new PluginEventArgs(plugin));
        }

//        private void r4omhfJxrr(Reference obj0)
//        {
//        }
//
//        private void i7WmspOSjr(Reference obj0)
//        {
//        }
//
//        internal void iVCmyqqsve(Reference obj0)
//        {
//        }
//
//        private void cTdmESFHjc(Plugin obj0)
//        {
//        }
//
//        private void rRLmTCXR6E(Plugin obj0)
//        {
//        }
//
//        internal void S6RmWfq0Ij(Plugin obj0)
//        {
//        }

//        private void L7GmG9IG7M()
//        {
//        }
//
//        private void XQDm0HUSTN()
//        {
//        }
    }
}
