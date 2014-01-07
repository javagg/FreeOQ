// Type: SmartQuant.Shared.Controls.EditObjectForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using p95SdfoId5q96Sg6A0;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Controls
{
  public class EditObjectForm : Form
  {
    private IContainer fNFxEwJ2JQ;
    private GroupBox hf9xQwqKbr;
    private PropertyGrid SrKxvcO88h;
    private Panel ytQxoPIln3;
    private Button xUAxPDR3CA;
    private Button lHTxAPX3WF;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EditObjectForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.e7nxtj9HA1();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.fNFxEwJ2JQ != null)
        this.fNFxEwJ2JQ.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void e7nxtj9HA1()
    {
      this.hf9xQwqKbr = new GroupBox();
      this.SrKxvcO88h = new PropertyGrid();
      this.ytQxoPIln3 = new Panel();
      this.lHTxAPX3WF = new Button();
      this.xUAxPDR3CA = new Button();
      this.hf9xQwqKbr.SuspendLayout();
      this.ytQxoPIln3.SuspendLayout();
      this.SuspendLayout();
      this.hf9xQwqKbr.Controls.Add((Control) this.SrKxvcO88h);
      this.hf9xQwqKbr.Dock = DockStyle.Fill;
      this.hf9xQwqKbr.Location = new Point(3, 3);
      this.hf9xQwqKbr.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6770);
      this.hf9xQwqKbr.Size = new Size(235, 249);
      this.hf9xQwqKbr.TabIndex = 0;
      this.hf9xQwqKbr.TabStop = false;
      this.SrKxvcO88h.Dock = DockStyle.Fill;
      this.SrKxvcO88h.HelpVisible = false;
      this.SrKxvcO88h.Location = new Point(3, 16);
      this.SrKxvcO88h.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6792);
      this.SrKxvcO88h.PropertySort = PropertySort.Categorized;
      this.SrKxvcO88h.Size = new Size(229, 230);
      this.SrKxvcO88h.TabIndex = 0;
      this.SrKxvcO88h.ToolbarVisible = false;
      this.ytQxoPIln3.Controls.Add((Control) this.lHTxAPX3WF);
      this.ytQxoPIln3.Controls.Add((Control) this.xUAxPDR3CA);
      this.ytQxoPIln3.Dock = DockStyle.Bottom;
      this.ytQxoPIln3.Location = new Point(3, 252);
      this.ytQxoPIln3.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6820);
      this.ytQxoPIln3.Size = new Size(235, 36);
      this.ytQxoPIln3.TabIndex = 3;
      this.lHTxAPX3WF.DialogResult = DialogResult.Cancel;
      this.lHTxAPX3WF.Location = new Point(120, 6);
      this.lHTxAPX3WF.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6836);
      this.lHTxAPX3WF.Size = new Size(58, 25);
      this.lHTxAPX3WF.TabIndex = 3;
      this.lHTxAPX3WF.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6858);
      this.lHTxAPX3WF.UseVisualStyleBackColor = true;
      this.xUAxPDR3CA.DialogResult = DialogResult.OK;
      this.xUAxPDR3CA.Location = new Point(56, 6);
      this.xUAxPDR3CA.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6874);
      this.xUAxPDR3CA.Size = new Size(58, 25);
      this.xUAxPDR3CA.TabIndex = 2;
      this.xUAxPDR3CA.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6896);
      this.xUAxPDR3CA.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.xUAxPDR3CA;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.lHTxAPX3WF;
      this.ClientSize = new Size(241, 291);
      this.Controls.Add((Control) this.hf9xQwqKbr);
      this.Controls.Add((Control) this.ytQxoPIln3);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6912);
      this.Padding = new Padding(3);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6944);
      this.hf9xQwqKbr.ResumeLayout(false);
      this.ytQxoPIln3.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDataObject(SmartQuant.Data.IDataObject dataObject, int position)
    {
      this.SrKxvcO88h.SelectedObject = (object) new wMm9k5v308ponwpwTK(dataObject, position);
    }
  }
}
