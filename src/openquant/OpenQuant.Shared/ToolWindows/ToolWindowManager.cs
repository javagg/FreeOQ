//using OpenQuant.API;
using OpenQuant.Shared;
using OpenQuant.Shared.Compiler;
using FreeQuant.Docking.WinForms;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using FreeQuant.Providers.Design;
using FreeQuant.Simulation.Design;
using System;
using TD.SandDock;

namespace OpenQuant.Shared.ToolWindows
{
	public class ToolWindowManager
	{
		private DockManager manager;
		private PropertiesWindow wndProperties;
		private OutputWindow wndOutput;
		private ErrorListWindow wndErrorList;

		public event EventHandler<PropertyObjectEventArgs> PropertyValueChanged;

		public ToolWindowManager(DockManager manager)
		{
			this.manager = manager;
			manager.DockControlAdded += new DockControlEventHandler(this.manager_DockControlAdded);
			manager.DockControlRemoved += new DockControlEventHandler(this.manager_DockControlRemoved);
			manager.DockControlActivated += new DockControlEventHandler(this.manager_DockControlActivated);
			BarFactoryItemListEditor.ListChanged += new EventHandler(this.BarFactoryItemListEditor_ListChanged);
			BarFilterItemListEditor.ListChanged += new EventHandler(this.BarFilterItemListEditor_ListChanged);
		}

		public void ShowProperties(IPropertyEditable control, bool focus)
		{
			if (focus)
				this.manager.Open(typeof(PropertiesWindow));
			if (this.wndProperties == null)
				return;
			this.wndProperties.PropertyObject = control.PropertyObject;
		}

		public void UpdateProperties()
		{
			if (this.wndProperties == null)
				return;
			this.wndProperties.PropertyObject = this.wndProperties.PropertyObject;
		}

		public void ClearOutput()
		{
			if (this.wndOutput == null)
				return;
			this.wndOutput.ClearOutput();
		}

		public void ShowOutput()
		{
			Global.DockManager.Open(typeof(OutputWindow));
		}

		public void ShowErrorList<T>() where T : ErrorListWindow
		{
			Global.DockManager.Open(typeof(T));
		}

		public void ClearErrorList()
		{
			if (this.wndErrorList == null)
				return;
			this.wndErrorList.ClearErrors();
		}

		public void CloseErrorList()
		{
			if (this.wndErrorList == null)
				return;
			this.wndErrorList.Close();
		}

		public void SetErrors<T>(Error[] errors) where T : ErrorListWindow
		{
			if (this.wndErrorList == null)
				this.ShowErrorList<T>();
			this.wndErrorList.SetErrors(errors);
		}

		private void manager_DockControlAdded(object sender, DockControlEventArgs e)
		{
			if (e.DockControl is PropertiesWindow)
			{
				this.wndProperties = (PropertiesWindow)e.DockControl;
				this.wndProperties.PropertyValueChanged += new EventHandler(this.wndProperties_PropertyValueChanged);
			}
			if (e.DockControl is OutputWindow)
				this.wndOutput = (OutputWindow)e.DockControl;
			if (!(e.DockControl is ErrorListWindow))
				return;
			this.wndErrorList = (ErrorListWindow)e.DockControl;
		}

		private void manager_DockControlRemoved(object sender, DockControlEventArgs e)
		{
			if (e.DockControl is PropertiesWindow)
				this.wndProperties = (PropertiesWindow)null;
			if (e.DockControl is OutputWindow)
				this.wndOutput = (OutputWindow)null;
			if (!(e.DockControl is ErrorListWindow))
				return;
			this.wndErrorList = (ErrorListWindow)null;
		}

		private void manager_DockControlActivated(object sender, DockControlEventArgs e)
		{
			if (e.DockControl is PropertiesWindow || !(e.DockControl is IPropertyEditable))
				return;
			this.ShowProperties((IPropertyEditable)e.DockControl, false);
		}

		private void wndProperties_PropertyValueChanged(object sender, EventArgs e)
		{
			object propertyObject = this.wndProperties.PropertyObject;
			if (propertyObject is Instrument)
				InstrumentManager.Instruments[(propertyObject as Instrument).Symbol].Save();
			if (propertyObject is IProvider)
				ProviderManager.SaveProviderProperties();
			if (this.PropertyValueChanged == null)
				return;
			this.PropertyValueChanged(this, new PropertyObjectEventArgs(propertyObject));
		}

		private void BarFactoryItemListEditor_ListChanged(object sender, EventArgs e)
		{
			if (this.wndProperties == null || !(this.wndProperties.PropertyObject is IProvider))
				return;
			ProviderManager.SaveProviderProperties();
		}

		private void BarFilterItemListEditor_ListChanged(object sender, EventArgs e)
		{
			if (this.wndProperties == null || !(this.wndProperties.PropertyObject is IProvider))
				return;
			ProviderManager.SaveProviderProperties();
		}
	}
}
