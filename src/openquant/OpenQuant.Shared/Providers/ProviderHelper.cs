using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Threading;
using System.Windows.Forms;

namespace OpenQuant.Shared.Providers
{
	public class ProviderHelper
	{
		private bool useMessageLoop;
		private Form parentForm;
		private Form form;

		public TimeSpan ConnectionTimeout { get; set; }

		public ProviderHelper(Form parentForm, bool useMessageLoop)
		{
			this.parentForm = parentForm;
			this.useMessageLoop = useMessageLoop;
			this.ConnectionTimeout = TimeSpan.FromSeconds(10.0);
			if (!useMessageLoop)
				return;
			Thread thread = new Thread(new ParameterizedThreadStart(this.MessageLoop));
			thread.Name = "ProviderHelper";
			thread.IsBackground = true;
			ManualResetEvent manualResetEvent = new ManualResetEvent(false);
			thread.Start((object)manualResetEvent);
			manualResetEvent.WaitOne();
		}

		private void MessageLoop(object state)
		{
			((EventWaitHandle)state).Set();
			this.form = new Form();
			this.form.ShowInTaskbar = false;
			this.form.Opacity = 0.0;
			this.form.Shown += new EventHandler(this.form_Shown);
			Application.Run(this.form);
		}

		private void form_Shown(object sender, EventArgs e)
		{
			this.form.Visible = false;
		}

		public void Connect(IProvider provider)
		{
			if (provider.IsConnected)
				return;
			if (this.useMessageLoop)
			{
				this.form.BeginInvoke((Action)(() => provider.Connect()));
				if ((int)provider.Id == 1 || (int)provider.Id == 2)
				{
					ProviderManager.WaitConnected(provider, (int)this.ConnectionTimeout.TotalMilliseconds);
				}
				else
				{
					ProviderHelperForm f = new ProviderHelperForm();
					f.Init(provider, (int)this.ConnectionTimeout.TotalSeconds);
					MethodInvoker methodInvoker = (MethodInvoker)(() =>
					{
						int temp_75 = (int)f.ShowDialog((IWin32Window)this.parentForm);
						f.Dispose();
					});
					if (this.parentForm.InvokeRequired)
						this.parentForm.Invoke((Delegate)methodInvoker);
					else
						methodInvoker();
				}
			}
			else
				provider.Connect((int)this.ConnectionTimeout.TotalMilliseconds);
		}

		public void Disconnect(IProvider provider)
		{
			if (!provider.IsConnected)
				return;
			if (this.useMessageLoop)
				this.form.BeginInvoke((Action)(() => provider.Disconnect()));
			else
				provider.Disconnect();
		}

		public void RequestMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType)
		{
			if (this.useMessageLoop)
				this.form.Invoke((Action)(() => instrument.RequestMarketData(provider, mdType)));
			else
				instrument.RequestMarketData(provider, mdType);
		}

		public void RequestMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, string suffix)
		{
			if (this.useMessageLoop)
				this.form.Invoke((Action)(() => instrument.RequestMarketData(provider, mdType, suffix)));
			else
				instrument.RequestMarketData(provider, mdType, suffix);
		}

		public void CancelMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType)
		{
			if (this.useMessageLoop)
				this.form.Invoke((Action)(() => instrument.CancelMarketData(provider, mdType)));
			else
				instrument.CancelMarketData(provider, mdType);
		}

		public void CancelMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, string suffix)
		{
			if (this.useMessageLoop)
				this.form.Invoke((Action)(() => instrument.CancelMarketData(provider, mdType, suffix)));
			else
				instrument.CancelMarketData(provider, mdType, suffix);
		}
	}
}
