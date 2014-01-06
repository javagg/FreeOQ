// Type: OpenQuant.Finam.Design.PasswordChangingForm
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using OpenQuant.Finam;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace OpenQuant.Finam.Design
{
  public class PasswordChangingForm : Form
  {
    public string password = "";
    private IContainer components;
    private Label label1;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label2;
    private TextBox textBox3;
    private Label label3;
    private Button button1;
    private Button button2;
    public DllSelector selectedDll;

    public PasswordChangingForm(DllSelector selectedDll)
    {
      this.InitializeComponent();
      this.selectedDll = selectedDll;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.label2 = new Label();
      this.textBox3 = new TextBox();
      this.label3 = new Label();
      this.button1 = new Button();
      this.button2 = new Button();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 12);
      this.label1.Name = "label1";
      this.label1.Size = new Size(78, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Last password:";
      this.textBox1.Location = new Point(135, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.PasswordChar = '*';
      this.textBox1.Size = new Size(158, 20);
      this.textBox1.TabIndex = 2;
      this.textBox2.Location = new Point(135, 45);
      this.textBox2.Name = "textBox2";
      this.textBox2.PasswordChar = '*';
      this.textBox2.Size = new Size(158, 20);
      this.textBox2.TabIndex = 4;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(12, 48);
      this.label2.Name = "label2";
      this.label2.Size = new Size(80, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "New password:";
      this.textBox3.Location = new Point(135, 80);
      this.textBox3.Name = "textBox3";
      this.textBox3.PasswordChar = '*';
      this.textBox3.Size = new Size(158, 20);
      this.textBox3.TabIndex = 6;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(12, 83);
      this.label3.Name = "label3";
      this.label3.Size = new Size(116, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Confirm new password:";
      this.button1.Location = new Point(15, 123);
      this.button1.Name = "button1";
      this.button1.Size = new Size(113, 44);
      this.button1.TabIndex = 7;
      this.button1.Text = "Change Password";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(180, 123);
      this.button2.Name = "button2";
      this.button2.Size = new Size(113, 44);
      this.button2.TabIndex = 8;
      this.button2.Text = "Cancel";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(310, 181);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox3);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "PasswordChanging";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Password Changing";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.textBox2.Text != this.textBox3.Text)
      {
        int num1 = (int) MessageBox.Show("Check new password again!!!", "Error");
      }
      else
      {
        string command = "<command id=\"change_pass\" oldpass=\"" + this.textBox1.Text + "\" newpass=\"" + this.textBox2.Text + "\"/>";
        try
        {
          TransaqResult transaqResult;
          if (this.selectedDll == DllSelector.txmlconnector_dll)
          {
            transaqResult = new TransaqResult(this.MessageParsing(TXmlConnector.Instance.SendCommand(command)));
          }
          else
          {
            if (this.selectedDll != DllSelector.txcn_dll)
              throw new ArgumentException("Unknown dll " + (object) this.selectedDll);
            transaqResult = new TransaqResult(this.MessageParsing(TXcnConnector.Instance.SendCommand(command)));
          }
          if (transaqResult.Success)
          {
            int num2 = (int) MessageBox.Show("Password change is completed", "Result", MessageBoxButtons.OK);
            this.password = this.textBox2.Text;
          }
          else
          {
            int num3 = (int) MessageBox.Show("Password change is not completed\n\n" + transaqResult.Message, "Result", MessageBoxButtons.OK);
          }
        }
        catch (Exception ex)
        {
          int num2 = (int) MessageBox.Show(ex.Message);
        }
      }
      this.Close();
    }

    private string MessageParsing(string xmlString)
    {
      XmlDocument xmlDocument = new XmlDocument();
      string str = "";
      xmlDocument.LoadXml(xmlString);
      XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("result");
      if (elementsByTagName.Count > 0)
      {
        for (int index = 0; index < elementsByTagName.Count; ++index)
        {
          foreach (XmlNode xmlNode in (XmlNamedNodeMap) elementsByTagName[index].Attributes)
          {
            if (xmlNode.Name == "success")
            {
              foreach (XmlAttribute xmlAttribute in (XmlNamedNodeMap) elementsByTagName[index].Attributes)
                str = str + xmlAttribute.Name + ";" + xmlAttribute.Value + ";";
              foreach (XmlElement xmlElement in elementsByTagName[index])
                str = str + xmlElement.Name + ";" + xmlElement.InnerText + ";";
              return str;
            }
          }
        }
      }
      return "";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
