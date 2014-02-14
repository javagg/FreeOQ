using System.IO;
using System.Xml;
using TD.SandDock.Rendering;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
	[OptionsNode("Layout", typeof(LayoutOptionsPanel))]
	public class LayoutOptions : OptionsBase
	{
		private const LayoutRenderer DEFAULT_RENDERER = LayoutRenderer.Office2003;
		private const WindowsColorScheme DEFAULT_COLOR_SCHEME = WindowsColorScheme.Automatic;
		private const bool DEFAULT_INTEGRAL_CLOSE = false;
		private FileInfo configFile;

		public LayoutRenderer Renderer { get; set; }

		public WindowsColorScheme ColorScheme { get; set; }

		public bool IntegralClose { get; set; }

		public LayoutOptions(FileInfo configFile)
		{
			this.configFile = configFile;
		}

		public void Apply()
		{
			switch (this.Renderer)
			{
				case LayoutRenderer.VisualStudio2002:
					Global.DockManager.Renderer = (RendererBase)new EverettRenderer();
					break;
				case LayoutRenderer.VisualStudio2005:
					Global.DockManager.Renderer = (RendererBase)new WhidbeyRenderer();
					break;
				case LayoutRenderer.Office2003:
					Global.DockManager.Renderer = (RendererBase)new Office2003Renderer();
					break;
			}
			if (Global.DockManager.Renderer is ThemeAwareRendererBase)
				((ThemeAwareRendererBase)Global.DockManager.Renderer).ColorScheme = this.ColorScheme;
			Global.DockManager.IntegralClose = this.IntegralClose;
		}

		public void Restore()
		{
			this.Load();
			this.Apply();
		}

		protected override void OnLoad()
		{
			if (this.configFile.Exists)
			{
				LayoutXmlDocument layoutXmlDocument = new LayoutXmlDocument();
				((XmlDocument)layoutXmlDocument).Load(this.configFile.FullName);
				this.Renderer = layoutXmlDocument.Renderer.Value;
				this.ColorScheme = layoutXmlDocument.ColorScheme.Value;
				this.IntegralClose = layoutXmlDocument.IntegralClose.Value;
			}
			else
			{
				this.Renderer = LayoutRenderer.Office2003;
				this.ColorScheme = WindowsColorScheme.Automatic;
				this.IntegralClose = false;
			}
		}

		protected override void OnSave()
		{
			((XmlDocument)new LayoutXmlDocument()
			{
				Renderer =
				{
					Value = this.Renderer
				},
				ColorScheme =
				{
					Value = this.ColorScheme
				},
				IntegralClose =
				{
					Value = this.IntegralClose
				}
			}).Save(this.configFile.FullName);
		}
	}
}
