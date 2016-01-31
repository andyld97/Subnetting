namespace Subnetting
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlInput = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fOct = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.sOct = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tOct = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.foOct = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.subMask = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblIPAdress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nets = new System.Windows.Forms.NumericUpDown();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.NumberTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAdressTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstHostAdressTextBoxClumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastHostAdressTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broadcastAdressTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblNewSubnetMask = new System.Windows.Forms.Label();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fOct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foOct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subMask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInput.Controls.Add(this.label7);
            this.pnlInput.Controls.Add(this.nets);
            this.pnlInput.Controls.Add(this.lblIPAdress);
            this.pnlInput.Controls.Add(this.btnCalculate);
            this.pnlInput.Controls.Add(this.label5);
            this.pnlInput.Controls.Add(this.subMask);
            this.pnlInput.Controls.Add(this.label4);
            this.pnlInput.Controls.Add(this.foOct);
            this.pnlInput.Controls.Add(this.label3);
            this.pnlInput.Controls.Add(this.tOct);
            this.pnlInput.Controls.Add(this.label2);
            this.pnlInput.Controls.Add(this.sOct);
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Controls.Add(this.fOct);
            this.pnlInput.Location = new System.Drawing.Point(12, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(423, 88);
            this.pnlInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "1";
            // 
            // fOct
            // 
            this.fOct.Location = new System.Drawing.Point(6, 20);
            this.fOct.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.fOct.Name = "fOct";
            this.fOct.Size = new System.Drawing.Size(54, 23);
            this.fOct.TabIndex = 2;
            this.fOct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fOct.Value = new decimal(new int[] {
            192,
            0,
            0,
            0});
            this.fOct.ValueChanged += new System.EventHandler(this.fOct_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "2";
            // 
            // sOct
            // 
            this.sOct.Location = new System.Drawing.Point(66, 20);
            this.sOct.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.sOct.Name = "sOct";
            this.sOct.Size = new System.Drawing.Size(54, 23);
            this.sOct.TabIndex = 4;
            this.sOct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sOct.Value = new decimal(new int[] {
            168,
            0,
            0,
            0});
            this.sOct.ValueChanged += new System.EventHandler(this.fOct_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "3";
            // 
            // tOct
            // 
            this.tOct.Location = new System.Drawing.Point(126, 20);
            this.tOct.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tOct.Name = "tOct";
            this.tOct.Size = new System.Drawing.Size(54, 23);
            this.tOct.TabIndex = 6;
            this.tOct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tOct.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tOct.ValueChanged += new System.EventHandler(this.fOct_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "4";
            // 
            // foOct
            // 
            this.foOct.Location = new System.Drawing.Point(186, 20);
            this.foOct.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.foOct.Name = "foOct";
            this.foOct.Size = new System.Drawing.Size(54, 23);
            this.foOct.TabIndex = 8;
            this.foOct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.foOct.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.foOct.ValueChanged += new System.EventHandler(this.fOct_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Subnetzmaske:";
            // 
            // subMask
            // 
            this.subMask.Location = new System.Drawing.Point(246, 20);
            this.subMask.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.subMask.Name = "subMask";
            this.subMask.Size = new System.Drawing.Size(83, 23);
            this.subMask.TabIndex = 10;
            this.subMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subMask.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.subMask.ValueChanged += new System.EventHandler(this.fOct_ValueChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(335, 60);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(83, 23);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Berechnen";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblIPAdress
            // 
            this.lblIPAdress.AutoSize = true;
            this.lblIPAdress.Location = new System.Drawing.Point(3, 64);
            this.lblIPAdress.Name = "lblIPAdress";
            this.lblIPAdress.Size = new System.Drawing.Size(217, 15);
            this.lblIPAdress.TabIndex = 12;
            this.lblIPAdress.Text = "IP-Adresse: 192.168.2.100/24 @ 16 Netze";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Netze:";
            // 
            // nets
            // 
            this.nets.Location = new System.Drawing.Point(335, 20);
            this.nets.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nets.Name = "nets";
            this.nets.Size = new System.Drawing.Size(83, 23);
            this.nets.TabIndex = 14;
            this.nets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nets.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nets.ValueChanged += new System.EventHandler(this.fOct_ValueChanged);
            // 
            // dgwData
            // 
            this.dgwData.AllowUserToAddRows = false;
            this.dgwData.AllowUserToDeleteRows = false;
            this.dgwData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgwData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberTextBoxColumn,
            this.netAdressTextBoxColumn,
            this.firstHostAdressTextBoxClumn,
            this.lastHostAdressTextBoxColumn,
            this.broadcastAdressTextBoxColumn});
            this.dgwData.Location = new System.Drawing.Point(12, 106);
            this.dgwData.Name = "dgwData";
            this.dgwData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwData.Size = new System.Drawing.Size(768, 344);
            this.dgwData.TabIndex = 1;
            // 
            // NumberTextBoxColumn
            // 
            this.NumberTextBoxColumn.HeaderText = "Netz";
            this.NumberTextBoxColumn.Name = "NumberTextBoxColumn";
            // 
            // netAdressTextBoxColumn
            // 
            this.netAdressTextBoxColumn.HeaderText = "Netzadresse";
            this.netAdressTextBoxColumn.Name = "netAdressTextBoxColumn";
            // 
            // firstHostAdressTextBoxClumn
            // 
            this.firstHostAdressTextBoxClumn.HeaderText = "1. Hostadresse";
            this.firstHostAdressTextBoxClumn.Name = "firstHostAdressTextBoxClumn";
            // 
            // lastHostAdressTextBoxColumn
            // 
            this.lastHostAdressTextBoxColumn.HeaderText = "Letzte Hostadresse";
            this.lastHostAdressTextBoxColumn.Name = "lastHostAdressTextBoxColumn";
            // 
            // broadcastAdressTextBoxColumn
            // 
            this.broadcastAdressTextBoxColumn.HeaderText = "Broadcast Adresse";
            this.broadcastAdressTextBoxColumn.Name = "broadcastAdressTextBoxColumn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Zusätzliche Informationen:";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.ForeColor = System.Drawing.Color.Green;
            this.lblNet.Location = new System.Drawing.Point(441, 32);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(153, 15);
            this.lblNet.TabIndex = 3;
            this.lblNet.Text = "16 Netze wurden verwendet";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(441, 47);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(134, 15);
            this.lblHost.TabIndex = 4;
            this.lblHost.Text = "Hostadresse: 192.168.2.0";
            // 
            // lblNewSubnetMask
            // 
            this.lblNewSubnetMask.AutoSize = true;
            this.lblNewSubnetMask.Location = new System.Drawing.Point(441, 62);
            this.lblNewSubnetMask.Name = "lblNewSubnetMask";
            this.lblNewSubnetMask.Size = new System.Drawing.Size(201, 15);
            this.lblNewSubnetMask.TabIndex = 5;
            this.lblNewSubnetMask.Text = "Neue Subnetzmaske: 255.255.255.224";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 462);
            this.Controls.Add(this.lblNewSubnetMask);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgwData);
            this.Controls.Add(this.pnlInput);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Subnetting";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fOct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foOct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subMask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nets;
        private System.Windows.Forms.Label lblIPAdress;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown subMask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown foOct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tOct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sOct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown fOct;
        private System.Windows.Forms.DataGridView dgwData;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAdressTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstHostAdressTextBoxClumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastHostAdressTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn broadcastAdressTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblNewSubnetMask;
    }
}

