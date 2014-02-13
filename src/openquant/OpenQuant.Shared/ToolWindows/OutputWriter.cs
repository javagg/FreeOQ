using System;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Shared.ToolWindows
{
	internal class OutputWriter : StringWriter
	{
		private TextBox textBox;

		public OutputWriter(TextBox textBox)
		{
			this.textBox = textBox;
		}

		public override void Write(bool value)
		{
			this.Add(value.ToString());
		}

		public override void Write(char value)
		{
			this.Add(value.ToString());
		}

		public override void Write(char[] buffer)
		{
			this.Write(new string(buffer));
		}

		public override void Write(Decimal value)
		{
			this.Add(value.ToString());
		}

		public override void Write(double value)
		{
			this.Add(value.ToString());
		}

		public override void Write(float value)
		{
			this.Add(value.ToString());
		}

		public override void Write(int value)
		{
			this.Add(value.ToString());
		}

		public override void Write(long value)
		{
			this.Add(value.ToString());
		}

		public override void Write(string value)
		{
			this.Add(value);
		}

		public override void Write(uint value)
		{
			this.Add(value.ToString());
		}

		public override void Write(ulong value)
		{
			this.Add(value.ToString());
		}

		public override void WriteLine()
		{
			this.AddLine(string.Empty);
		}

		public override void WriteLine(bool value)
		{
			this.AddLine(value.ToString());
		}

		public override void WriteLine(char value)
		{
			this.AddLine(value.ToString());
		}

		public override void WriteLine(Decimal value)
		{
			this.AddLine(value.ToString());
		}

		public override void WriteLine(double value)
		{
			this.AddLine(value.ToString());
		}

		public override void WriteLine(float value)
		{
			this.AddLine(value.ToString());
		}

		public override void WriteLine(int value)
		{
			this.AddLine(value.ToString());
		}

		public override void WriteLine(long value)
		{
			this.AddLine(value.ToString());
		}

		public override void WriteLine(uint value)
		{
			this.AddLine(value.ToString());
		}

		public override void WriteLine(ulong value)
		{
			this.AddLine(value.ToString());
		}

		public override void WriteLine(string value)
		{
			this.AddLine(value);
		}

		private void Add(string line)
		{
			Action action = (Action)(() =>
			{
				try
				{
					this.textBox.Font = OpenQuant.API.Appearance.OutputWindowFont;
					this.textBox.AppendText(line);
				}
				catch
				{
				}
			});
			if (this.textBox.InvokeRequired)
				this.textBox.Invoke((Delegate)action);
			else
				action();
		}

		private void AddLine(string line)
		{
			this.Add(string.Format("{0}{1}", line, Environment.NewLine));
		}
	}
}
