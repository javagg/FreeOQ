namespace OpenQuant.Shared.Editor
{
    public partial class EditorWindow 
	{
		private System.ComponentModel.IContainer components;
		protected QWhale.Editor.SyntaxEdit textEditor;

        private QWhale.Syntax.Parsers.CsParser csParser;
        private QWhale.Syntax.Parsers.VbParser vbParser;

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
//			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(EditorWindow));
			this.textEditor = new QWhale.Editor.SyntaxEdit(this.components);
			this.csParser = new QWhale.Syntax.Parsers.CsParser();
			this.vbParser = new QWhale.Syntax.Parsers.VbParser();
			this.SuspendLayout();
			this.textEditor.BackColor = System.Drawing.SystemColors.Window;
			this.textEditor.Braces.BracesOptions = QWhale.Editor.TextSource.BracesOptions.Highlight | QWhale.Editor.TextSource.BracesOptions.HighlightBounds | QWhale.Editor.TextSource.BracesOptions.TempHighlight;
			this.textEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textEditor.Font = new System.Drawing.Font("Courier New", 10f);
			this.textEditor.Gutter.LineNumbersForeColor = System.Drawing.SystemColors.ControlText;
			this.textEditor.Location = new System.Drawing.Point(0, 0);
			this.textEditor.Name = "textEditor";
			this.textEditor.Outlining.AllowOutlining = true;
			this.textEditor.Size = new System.Drawing.Size(554, 356);
			this.textEditor.TabIndex = 0;
			this.textEditor.Text = "";
			this.csParser.DefaultState = 0;
			this.csParser.Options = QWhale.Syntax.SyntaxOptions.Outline | QWhale.Syntax.SyntaxOptions.SmartIndent | QWhale.Syntax.SyntaxOptions.CodeCompletion | QWhale.Syntax.SyntaxOptions.SyntaxErrors;
//			this.csParser.XmlScheme = componentResourceManager.GetString("csParser.XmlScheme");
			this.vbParser.DefaultState = 0;
			this.vbParser.Options = QWhale.Syntax.SyntaxOptions.Outline | QWhale.Syntax.SyntaxOptions.SmartIndent | QWhale.Syntax.SyntaxOptions.CodeCompletion | QWhale.Syntax.SyntaxOptions.SyntaxErrors;
//			this.vbParser.XmlScheme = componentResourceManager.GetString("vbParser.XmlScheme");
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textEditor);
			this.DefaultDockLocation = TD.SandDock.ContainerDockLocation.Center;
			this.Name = "EditorDocument";
			this.PersistState = false;
			this.Size = new System.Drawing.Size(554, 356);
			this.Text = "EditorDocument";
			this.ResumeLayout(false);
		}
	}
}
