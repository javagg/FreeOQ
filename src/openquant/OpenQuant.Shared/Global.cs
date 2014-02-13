using System;
using System.Collections.Generic;
using FreeQuant.Docking.WinForms;
using OpenQuant.Shared.Charting;
using OpenQuant.Shared.Editor;
using OpenQuant.Shared.Options;
using OpenQuant.Shared.Plugins;
using OpenQuant.Shared.Providers;
using OpenQuant.Shared.Scripts;
using OpenQuant.Shared.ToolWindows;

namespace OpenQuant.Shared
{
	class Global
	{
		private static Dictionary<string, object> objects = new Dictionary<string, object>();

		public static DockManager DockManager
		{
			get
			{
				return Global.GetObject<DockManager>();
			}
			set
			{
				Global.SetObject(value);
			}
		}

		public static ToolWindowManager ToolWindowManager
		{
			get
			{
				return Global.GetObject<ToolWindowManager>();
			}
			set
			{
				Global.SetObject(value);
			}
		}

		public static ProviderHelper ProviderHelper
		{
			get
			{
				return Global.GetObject<ProviderHelper>();
			}
			set
			{
				Global.SetObject(value);
			}
		}

		public static TimerManager TimerManager
		{
			get
			{
				return Global.GetObject<TimerManager>();
			}
			set
			{
				Global.SetObject(value);
			}
		}

		public static SetupInfo Setup
		{
			get
			{
				return Global.GetObject<SetupInfo>("setup_info");
			}
			set
			{
				Global.SetObject("setup_info", value);
			}
		}

		public static AppOptions Options
		{
			get
			{
				return Global.GetObject<AppOptions>("options");
			}
			set
			{
				Global.SetObject("options", value);
			}
		}

		public static PluginManager PluginManager
		{
			get
			{
				return Global.GetObject<PluginManager>();
			}
			set
			{
				Global.SetObject((object)value);
			}
		}

		public static EditorManager EditorManager
		{
			get
			{
				return Global.GetObject<EditorManager>("editor_manager");
			}
			set
			{
				Global.SetObject("editor_manager", value);
			}
		}

		public static ScriptManager ScriptManager
		{
			get
			{
				return Global.GetObject<ScriptManager>("script_manager");
			}
			set
			{
				Global.SetObject("script_manager", value);
			}
		}

		public static ChartManager ChartManager
		{
			get
			{
				return Global.GetObject<ChartManager>("chart_manager");
			}
			set
			{
				Global.SetObject("chart_manager", (object)value);
			}
		}

		static Global()
		{
		}

		public Global()
		{
			throw new NotSupportedException("Instance creation of this class is not supported");
		}

		protected static void SetObject(string key, object obj)
		{
			Global.objects.Add(key, obj);
		}

		protected static void SetObject(object obj)
		{
			Global.SetObject(obj.GetType().FullName, obj);
		}

		protected static T GetObject<T>(string key) where T : class
		{
			object obj;
			if (!Global.objects.TryGetValue(key, out obj))
				return default(T);
			if (obj is T)
				return (T)obj;
			else
				return default(T);
		}

		protected static T GetObject<T>() where T : class
		{
			return Global.GetObject<T>(typeof(T).FullName);
		}
	}
}
