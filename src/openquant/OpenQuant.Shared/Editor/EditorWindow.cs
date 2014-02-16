using OpenQuant.Shared;
using OpenQuant.Shared.Compiler;
using OpenQuant.Shared.Options;
using OpenQuant.Shared.ToolWindows;
using QWhale.Common;
using QWhale.Editor;
using QWhale.Editor.TextSource;
using QWhale.Syntax;
using QWhale.Syntax.Lexer;
using QWhale.Syntax.Parsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.Editor
{
    public partial class EditorWindow : FreeQuant.Docking.WinForms.DockControl, ITimerItem, IPropertyEditable
	{
		private FileInfo file;
		private bool isChanged;

		public virtual object PropertyObject
		{
			get
			{
				return  this.file;
			}
		}

		protected virtual BuildOptions BuildOptions
		{
			get
			{
				return  null;
			}
		}

		protected virtual EditorOptions EditorOptions
		{
			get
			{
				return  null;
			}
		}

		public FileInfo File
		{
			get
			{
				return this.file;
			}
		}

		public bool CanUndo
		{
			get
			{
				return this.textEditor.Source.CanUndo();
			}
		}

		public bool CanRedo
		{
			get
			{
				return this.textEditor.Source.CanRedo();
			}
		}

		public bool CanCopy
		{
			get
			{
				return this.textEditor.Selection.CanCopy();
			}
		}

		public bool CanCut
		{
			get
			{
				return this.textEditor.Selection.CanCut();
			}
		}

		public bool CanPaste
		{
			get
			{
				return this.textEditor.Selection.CanPaste();
			}
		}

		public bool IsChanged
		{
			get
			{
				return this.isChanged;
			}
		}

		public double Interval
		{
			get
			{
				if (this.EditorOptions != null)
					return this.EditorOptions.AutoSaveInterval.TotalMilliseconds;
				else
					return double.MaxValue;
			}
		}

		public ISynchronizeInvoke SynchronizingObject
		{
			get
			{
				return (ISynchronizeInvoke)this;
			}
		}

		public event EventHandler FileChanged;
		public event EventHandler FileSaved;
		public event EventHandler SourceStateChanged;

		public EditorWindow()
		{
			this.InitializeComponent();
			this.isChanged = false;
		}

		protected override void OnInit()
		{
			this.file = ((EditorKey)this.Key).File;
			CodeLang codeLang = CodeHelper.GetCodeLang(this.file);
			switch (codeLang)
			{
				case CodeLang.CSharp:
					if (this.BuildOptions != null)
					{
						foreach (BuildReference buildReference in this.BuildOptions.GetReferences())
						{
							if (buildReference.Valid)
							{
								try
								{
									this.csParser.RegisterAssembly(Assembly.Load(buildReference.Assembly));
								}
								catch
								{
								}
							}
						}
					}
					this.textEditor.Lexer = (ILexer)this.csParser;
					this.TabImage = (Image)OpenQuant.Shared.Properties.Resources.code_cs;
					break;
				case CodeLang.VisualBasic:
					if (this.BuildOptions != null)
					{
						foreach (BuildReference buildReference in this.BuildOptions.GetReferences())
						{
							if (buildReference.Valid)
							{
								try
								{
									this.vbParser.RegisterAssembly(Assembly.Load(buildReference.Assembly));
								}
								catch
								{
								}
							}
						}
					}
					this.textEditor.Lexer = (ILexer)this.vbParser;
					this.TabImage = (Image)OpenQuant.Shared.Properties.Resources.code_vb;
					break;
				default:
					throw new ArgumentException(string.Format("Unsupported code language - {0}", (object)codeLang));
			}
			if (this.EditorOptions != null)
			{
				if (this.EditorOptions.DisplayLineNumbers)
					this.textEditor.Gutter.Options |= GutterOptions.PaintLineNumbers;
				this.textEditor.Outlining.AllowOutlining = this.EditorOptions.AllowOutlining;
			}
			this.textEditor.Source.Text = System.IO.File.ReadAllText(this.file.FullName);
			this.textEditor.Source.FormatText();
			this.textEditor.Outlining.CollapseToDefinitions();
			List<IRange> list = new List<IRange>();
			this.textEditor.Outlining.GetOutlineRanges((IList<IRange>)list);
			foreach (IOutlineRange outlineRange in list)
			{
				if (outlineRange.Level > 1)
					outlineRange.Visible = false;
			}
			this.UpdateTitle();
			this.textEditor.TextChanged += new EventHandler(this.textEditor_TextChanged);
			this.textEditor.SourceStateChanged += new NotifyEvent(this.textEditor_SourceStateChanged);
			this.textEditor.Selection.SelectionChanged += new EventHandler(this.Selection_SelectionChanged);
			if (this.EditorOptions == null || !this.EditorOptions.AutoSaveEnabled)
				return;
			Global.TimerManager.Start((ITimerItem)this);
		}

		protected override void OnClosing(DockControlClosingEventArgs e)
		{
			if (this.isChanged && MessageBox.Show((IWin32Window)this, "The file was changed. Do you want to save it?", "File Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				this.Save();
			base.OnClosing(e);
		}

		protected override void OnClosed(EventArgs e)
		{
			Global.TimerManager.Stop((ITimerItem)this);
			base.OnClosed(e);
		}

		public void Undo()
		{
			this.textEditor.Source.Undo();
		}

		public void Redo()
		{
			this.textEditor.Source.Redo();
		}

		public void Copy()
		{
			this.textEditor.Selection.Copy();
		}

		public void Cut()
		{
			this.textEditor.Selection.Cut();
		}

		public void Paste()
		{
			this.textEditor.Selection.Paste();
		}

		public void SelectAll()
		{
			this.textEditor.Selection.SelectAll();
		}

		public void ShowReplaceDialog()
		{
			int num = (int)this.textEditor.SearchDialog.Execute((ISearch)this.textEditor, false, true);
		}

		public void ShowFindDialog()
		{
			int num = (int)this.textEditor.SearchDialog.Execute((ISearch)this.textEditor, false, false);
		}

		public void ShowGoToLineDialog()
		{
			if (typeof(Form).IsInstanceOfType((object)this.textEditor.GotoLineDialog))
				((Form)this.textEditor.GotoLineDialog).ShowInTaskbar = false;
			int y = this.textEditor.Position.Y;
			if (this.textEditor.GotoLineDialog.Execute((object)this.textEditor, this.textEditor.Lines.Count, ref y) != DialogResult.OK)
				return;
			this.textEditor.MoveToLine(y);
		}

		public void ToggleBookmark()
		{
			this.textEditor.Source.BookMarks.ToggleBookMark();
		}

		public void NextBookmark()
		{
			this.textEditor.Source.BookMarks.GotoNextBookMark();
		}

		public void PreviousBookmark()
		{
			this.textEditor.Source.BookMarks.GotoPrevBookMark();
		}

		public void ClearBookmarks()
		{
			this.textEditor.Source.BookMarks.ClearAllBookMarks();
		}

		public void Save()
		{
			if (!this.isChanged)
				return;
			this.textEditor.SaveFile(this.file.FullName);
			this.isChanged = false;
			this.UpdateTitle();
			if (this.FileSaved == null)
				return;
			this.FileSaved((object)this, EventArgs.Empty);
		}

		public void MoveTo(int line, int column)
		{
			this.textEditor.Source.MoveTo(column, line);
		}

		public bool MoveTo(string methodName)
		{
			string[] strArray = new List<string>((IEnumerable<string>)this.textEditor.Source.Lines).ToArray();
			for (int index = 0; index < strArray.Length; ++index)
			{
				string str = strArray[index];
				if (str.IndexOf(methodName) != -1)
				{
					this.textEditor.Source.MoveTo(str.Length - 1, index + 1);
					return true;
				}
			}
			return false;
		}

		public void InsertMethod(string[] methodDefinition, int cursorLine, int cursorColumn)
		{
			ITextStrings lines = this.textEditor.Source.Lines;
			int index1 = lines.Count - 1;
			while (index1 >= 0 && !(lines[index1].Trim() != string.Empty))
				--index1;
			cursorLine += index1 + 1;
			ITextStrings textStrings = lines;
			int index2 = index1;
			int num1 = 1;
			int num2 = index2 + num1;
			string str1 = string.Empty;
			textStrings.Insert(index2, str1);
			foreach (string str2 in methodDefinition)
				lines.Insert(num2++, string.Format("\t{0}", (object)str2));
			this.textEditor.Source.MoveTo(cursorColumn, cursorLine);
		}

		protected virtual void UpdateTitle()
		{
			if (this.file == null)
				return;
			this.Text = this.file.Name;
			if (!this.isChanged)
				return;
			EditorWindow editorWindow = this;
			string str = editorWindow.Text + "*";
			editorWindow.Text = str;
		}

		private void textEditor_SourceStateChanged(object sender, NotifyEventArgs e)
		{
			if (this.SourceStateChanged == null)
				return;
			this.SourceStateChanged((object)this, EventArgs.Empty);
		}

		private void Selection_SelectionChanged(object sender, EventArgs e)
		{
			if (this.SourceStateChanged == null)
				return;
			this.SourceStateChanged((object)this, EventArgs.Empty);
		}

		private void textEditor_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.isChanged;
			this.isChanged = true;
			if (!flag)
				return;
			this.UpdateTitle();
			if (this.FileChanged == null)
				return;
			this.FileChanged(this, EventArgs.Empty);
		}

		public void OnElapsed()
		{
			this.Save();
		}
	}
}
