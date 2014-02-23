namespace OpenQuant.Shared.TradingTools
{
    internal partial class OrderMiniBlotterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.NumericUpDown nudStopPrice;
        private System.Windows.Forms.NumericUpDown nudLimitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTIFs;
        private System.Windows.Forms.ComboBox cbxRoutes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTIFs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.nudStopPrice = new System.Windows.Forms.NumericUpDown();
            this.nudLimitPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(132, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 22);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            // 
            // btnSend
            // 
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSend.Location = new System.Drawing.Point(62, 158);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 22);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxTIFs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudQty);
            this.groupBox1.Controls.Add(this.nudStopPrice);
            this.groupBox1.Controls.Add(this.nudLimitPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 143);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            // 
            // cbxTIFs
            // 
            this.cbxTIFs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTIFs.FormattingEnabled = true;
            this.cbxTIFs.Location = new System.Drawing.Point(104, 112);
            this.cbxTIFs.Name = "cbxTIFs";
            this.cbxTIFs.Size = new System.Drawing.Size(98, 21);
            this.cbxTIFs.Sorted = true;
            this.cbxTIFs.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Time In Force";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(104, 80);
            this.nudQty.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(98, 20);
            this.nudQty.TabIndex = 15;
            this.nudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQty.ThousandsSeparator = true;
            // 
            // nudStopPrice
            // 
            this.nudStopPrice.DecimalPlaces = 2;
            this.nudStopPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudStopPrice.Location = new System.Drawing.Point(104, 48);
            this.nudStopPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudStopPrice.Name = "nudStopPrice";
            this.nudStopPrice.Size = new System.Drawing.Size(98, 20);
            this.nudStopPrice.TabIndex = 14;
            this.nudStopPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudStopPrice.ThousandsSeparator = true;
            this.nudStopPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudLimitPrice
            // 
            this.nudLimitPrice.DecimalPlaces = 2;
            this.nudLimitPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudLimitPrice.Location = new System.Drawing.Point(104, 16);
            this.nudLimitPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudLimitPrice.Name = "nudLimitPrice";
            this.nudLimitPrice.Size = new System.Drawing.Size(98, 20);
            this.nudLimitPrice.TabIndex = 13;
            this.nudLimitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLimitPrice.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Qty";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stop Price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Limit Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderMiniBlotterForm
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(241, 200);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderMiniBlotterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Blotter";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitPrice)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
