using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TD.SandDock;

namespace FreeQuant.Docking.WinForms
{
	public class DockManager : SandDockManager
	{
		private DockControlWorkingSet controls;
		private Dictionary<System.Type, DockControlSettings> settingsTable;

		public DockManager(Control dockSystemContainer, Form ownerForm)
		{
			this.DockSystemContainer = dockSystemContainer;
			this.OwnerForm = ownerForm;
			this.controls = new DockControlWorkingSet();
			this.settingsTable = new Dictionary<System.Type, DockControlSettings>();
		}

		public new DockControl[] GetDockControls()
		{
			List<DockControl> list = new List<DockControl>();
			foreach (TD.SandDock.DockControl dockControl in base.GetDockControls())
			{
				if (dockControl is DockControl)
					list.Add((DockControl)dockControl);
			}
			return list.ToArray();
		}

		public DockControl Open(System.Type type, object key, bool focus)
		{
			DockControl control;
			if (this.controls.TryGetControl(type, key, out control))
			{
				control.Open();
			}
			else
			{
				control = (DockControl)Activator.CreateInstance(type);
				DockControlSettings settings;
				if (!this.settingsTable.TryGetValue(type, out settings))
				{
					settings = new DockControlSettings();
					this.settingsTable.Add(type, settings);
				}
				control.Init(key, settings);
				control.Manager = this;
				if (control.ShowFloating)
				{
					control.OpenFloating();
				}
				else
				{
					DockContainer dockContainer = this.FindDockContainer(control.DefaultDockLocation);
					WindowOpenMethod openMethod = focus ? WindowOpenMethod.OnScreenActivate : WindowOpenMethod.OnScreenSelect;
					if (dockContainer == null)
					{
						control.OpenDocked(control.DefaultDockLocation, openMethod);
					}
					else
					{
						foreach (TD.SandDock.DockControl existingWindow in this.GetDockControls())
						{
							if (existingWindow != control && existingWindow.LayoutSystem.DockContainer == dockContainer)
							{
								control.DockNextTo(existingWindow);
								((TD.SandDock.DockControl)control).Open(openMethod);
								break;
							}
						}
					}
				}
				this.controls.Add(type, key, control);
			}
			return control;
		}

		public DockControl Open(System.Type type, object key)
		{
			return this.Open(type, key, true);
		}

		public DockControl Open(System.Type type)
		{
			return this.Open(type, (object)null);
		}

		public void CloseAll(bool documentsOnly)
		{
			foreach (DockControl dockControl in new List<DockControl>((IEnumerable<DockControl>) this.controls))
			{
				if (documentsOnly)
				{
					if (dockControl.LastDockedPosition == ContainerDockLocation.Center)
						dockControl.Close();
				}
				else
					dockControl.Close();
			}
		}

		protected override void OnDockControlAdded(DockControlEventArgs e)
		{
			base.OnDockControlAdded(e);
		}

		protected override void OnDockControlClosing(DockControlClosingEventArgs e)
		{
			base.OnDockControlClosing(e);
		}

		protected override void OnDockControlRemoved(DockControlEventArgs e)
		{
			if (e.DockControl is DockControl)
			{
				DockControl dockControl = (DockControl)e.DockControl;
				this.controls.Remove(dockControl.GetType(), dockControl.Key);
			}
			base.OnDockControlRemoved(e);
		}

		public new LayoutInfo GetLayout()
		{
			LayoutInfo layoutInfo = new LayoutInfo();
			List<LayoutLink> list = new List<LayoutLink>();
			foreach (DockControl dockControl in this.controls)
			{
				if (dockControl.PersistState)
					list.Add(new LayoutLink()
					{
						TypeName = string.Format("{0}, {1}", dockControl.GetType().FullName, dockControl.GetType().Assembly.GetName().Name),
						Guid = dockControl.Guid
					});
			}
			layoutInfo.Links = list.ToArray();
			layoutInfo.Layout = base.GetLayout();
			return layoutInfo;
		}

		public void SetLayout(LayoutInfo layout)
		{
			Dictionary<Guid, System.Type> types = new Dictionary<Guid, System.Type>();
			foreach (LayoutLink layoutLink in layout.Links)
			{
				System.Type type = System.Type.GetType(layoutLink.TypeName, false);
				if (type != (System.Type)null)
				{
					this.Open(type);
					types.Add(layoutLink.Guid, type);
				}
			}
			ResolveDockControlEventHandler controlEventHandler = (ResolveDockControlEventHandler)((sender, e) =>
			{
				System.Type local_0;
				DockControl local_1;
				if (!types.TryGetValue(e.Guid, out local_0) || !this.controls.TryGetControl(local_0, null, out local_1))
					return;
				e.DockControl = (TD.SandDock.DockControl)local_1;
			});
			try
			{
				this.ResolveDockControl += controlEventHandler;
				base.SetLayout(layout.Layout);
			}
			finally
			{
				this.ResolveDockControl -= controlEventHandler;
			}
		}

		public SettingsInfo GetSettings()
		{
			SettingsInfo settingsInfo = new SettingsInfo();
			List<SettingsGroup> list1 = new List<SettingsGroup>();
			foreach (KeyValuePair<System.Type, DockControlSettings> keyValuePair1 in this.settingsTable)
			{
				SettingsGroup settingsGroup = new SettingsGroup();
				settingsGroup.TypeName = string.Format("{0}, {1}", keyValuePair1.Key.FullName, keyValuePair1.Key.Assembly.GetName().Name);
				List<SettingsItem> list2 = new List<SettingsItem>();
				foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair1.Value)
					list2.Add(new SettingsItem() { Key = keyValuePair2.Key, Value = keyValuePair2.Value });
				settingsGroup.Items = list2.ToArray();
				list1.Add(settingsGroup);
			}
			settingsInfo.Groups = list1.ToArray();
			return settingsInfo;
		}

		public void SetSettings(SettingsInfo settings)
		{
			this.settingsTable.Clear();
			foreach (SettingsGroup settingsGroup in settings.Groups)
			{
				System.Type type = System.Type.GetType(settingsGroup.TypeName, false);
				if (type != (System.Type)null)
				{
					DockControlSettings dockControlSettings = new DockControlSettings();
					this.settingsTable.Add(type, dockControlSettings);
					foreach (SettingsItem settingsItem in settingsGroup.Items)
						dockControlSettings.SetValue(settingsItem.Key, settingsItem.Value);
				}
			}
		}
	}
}
