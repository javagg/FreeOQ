using OpenQuant.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.Editor
{
	public class EditorManager
	{
		private Dictionary<EditorKey, EditorWindow> editors;
		private EditorWindow activeEditor;
		private Dictionary<EditorAction, ToolStripItem[]> controls;

		public EditorManager()
		{
			this.editors = new Dictionary<EditorKey, EditorWindow>();
			this.activeEditor = (EditorWindow)null;
			this.controls = new Dictionary<EditorAction, ToolStripItem[]>();
			Global.DockManager.DockControlAdded += new DockControlEventHandler(this.DockManager_DockControlAdded);
			Global.DockManager.DockControlRemoved += new DockControlEventHandler(this.DockManager_DockControlRemoved);
			Global.DockManager.DockControlActivated += new DockControlEventHandler(this.DockManager_DockControlActivated);
		}

		public void Init(params EditorActionItem[] actions)
		{
			foreach (EditorActionItem editorActionItem in actions)
			{
				this.controls.Add(editorActionItem.Action, editorActionItem.Items);
				new EditorActionProxy(editorActionItem.Action, editorActionItem.Items).Click += new EventHandler<EditorActionEventArgs>(this.EditorManager_Click);
			}
			this.SetActiveEditor((EditorWindow)null);
		}

		public void Open(System.Type editorType, EditorKey editorKey)
		{
			if (!typeof(EditorWindow).IsAssignableFrom(editorType))
				throw new ArgumentException(string.Format("{0} is not subclass of EditorWindow", (object)editorType));
			Global.DockManager.Open(editorType, (object)editorKey);
		}

		public void Close(FileInfo file)
		{
			this.Close(new EditorKey(file));
		}

		public void Close(string filename)
		{
			this.Close(new EditorKey(filename));
		}

		private void Close(EditorKey key)
		{
			if (!this.editors.ContainsKey(key))
				return;
			this.editors[key].Close();
		}

		public void SaveAll()
		{
			foreach (EditorWindow editorWindow in this.editors.Values)
			{
				if (editorWindow.IsChanged)
					editorWindow.Save();
			}
		}

		public void Save(FileInfo file)
		{
			EditorWindow editorWindow;
			if (!this.editors.TryGetValue(new EditorKey(file), out editorWindow) || !editorWindow.IsChanged)
				return;
			editorWindow.Save();
		}

		public void MoveTo(System.Type editorType, EditorKey editorKey, int line, int column)
		{
			this.Open(editorType, editorKey);
			this.editors[editorKey].MoveTo(line - 1, column);
		}

		public void MoveTo(System.Type editorType, EditorKey editorKey, string methodName, string[] methodDefinition)
		{
			this.Open(editorType, editorKey);
			EditorWindow editorWindow = this.editors[editorKey];
			if (editorWindow.MoveTo(methodName))
				return;
			editorWindow.InsertMethod(methodDefinition, 2, 2);
		}

		private void DockManager_DockControlAdded(object sender, DockControlEventArgs e)
		{
			if (!(e.DockControl is EditorWindow))
				return;
			EditorWindow editorWindow = (EditorWindow)e.DockControl;
			this.editors.Add((EditorKey)(editorWindow.Key), editorWindow);
		}

		private void DockManager_DockControlRemoved(object sender, DockControlEventArgs e)
		{
			if (!(e.DockControl is EditorWindow))
				return;
			this.editors.Remove((EditorKey)((FreeQuant.Docking.WinForms.DockControl)e.DockControl).Key);
		}

		private void DockManager_DockControlActivated(object sender, DockControlEventArgs e)
		{
			EditorWindow editor = (EditorWindow)null;
			if (e.DockControl is EditorWindow)
				editor = (EditorWindow)e.DockControl;
			this.SetActiveEditor(editor);
		}

		private void activeEditor_FileChanged(object sender, EventArgs e)
		{
			this.UpdateControls();
		}

		private void activeEditor_FileSaved(object sender, EventArgs e)
		{
			this.UpdateControls();
		}

		private void activeEditor_SourceStateChanged(object sender, EventArgs e)
		{
			this.UpdateControls();
		}

		private void EditorManager_Click(object sender, EditorActionEventArgs args)
		{
			switch (args.Action)
			{
				case EditorAction.Save:
					this.activeEditor.Save();
					break;
				case EditorAction.Undo:
					this.activeEditor.Undo();
					break;
				case EditorAction.Redo:
					this.activeEditor.Redo();
					break;
				case EditorAction.Cut:
					this.activeEditor.Cut();
					break;
				case EditorAction.Copy:
					this.activeEditor.Copy();
					break;
				case EditorAction.Paste:
					this.activeEditor.Paste();
					break;
				case EditorAction.Find:
					this.activeEditor.ShowFindDialog();
					break;
				case EditorAction.Replace:
					this.activeEditor.ShowReplaceDialog();
					break;
				case EditorAction.Goto:
					this.activeEditor.ShowGoToLineDialog();
					break;
				default:
					throw new NotSupportedException(string.Format("Unsupported editor action - {0}", (object)args.Action));
			}
		}

		private void SetActiveEditor(EditorWindow editor)
		{
			if (this.activeEditor != null)
			{
				this.activeEditor.FileChanged -= new EventHandler(this.activeEditor_FileChanged);
				this.activeEditor.FileSaved -= new EventHandler(this.activeEditor_FileSaved);
				this.activeEditor.SourceStateChanged -= new EventHandler(this.activeEditor_SourceStateChanged);
			}
			this.activeEditor = editor;
			if (this.activeEditor != null)
			{
				this.activeEditor.FileChanged += new EventHandler(this.activeEditor_FileChanged);
				this.activeEditor.FileSaved += new EventHandler(this.activeEditor_FileSaved);
				this.activeEditor.SourceStateChanged += new EventHandler(this.activeEditor_SourceStateChanged);
			}
			this.UpdateControls();
		}

		private void UpdateControls()
		{
			if (this.activeEditor == null)
			{
				foreach (EditorAction action in this.controls.Keys)
					this.SetEnabled(action, false);
			}
			else
			{
				this.SetEnabled(EditorAction.Save, this.activeEditor.IsChanged);
				this.SetEnabled(EditorAction.Undo, this.activeEditor.CanUndo);
				this.SetEnabled(EditorAction.Redo, this.activeEditor.CanRedo);
				this.SetEnabled(EditorAction.Cut, this.activeEditor.CanCut);
				this.SetEnabled(EditorAction.Copy, this.activeEditor.CanCopy);
				this.SetEnabled(EditorAction.Paste, this.activeEditor.CanPaste);
				this.SetEnabled(EditorAction.Find, true);
				this.SetEnabled(EditorAction.Replace, true);
				this.SetEnabled(EditorAction.Goto, true);
			}
		}

		private void SetEnabled(EditorAction action, bool enabled)
		{
			ToolStripItem[] toolStripItemArray;
			if (!this.controls.TryGetValue(action, out toolStripItemArray))
				return;
			foreach (ToolStripItem toolStripItem in toolStripItemArray)
				toolStripItem.Enabled = enabled;
		}
	}
}
