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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlInput = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.nets = new System.Windows.Forms.NumericUpDown();
            this.lblIPAdress = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.subMask = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.foOct = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tOct = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.sOct = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.fOct = new System.Windows.Forms.NumericUpDown();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblNewSubnetMask = new System.Windows.Forms.Label();
            this.broadcastAdressTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastHostAdressTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstHostAdressTextBoxClumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAdressTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subMask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foOct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            resources.ApplyResources(this.pnlInput, "pnlInput");
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
            this.pnlInput.Name = "pnlInput";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // nets
            // 
            resources.ApplyResources(this.nets, "nets");
            this.nets.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nets.Name = "nets";
            this.nets.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nets.ValueChanged += new System.EventHandler(this.fOct_ValueChanged);
            // 
            // lblIPAdress
            // 
            resources.ApplyResources(this.lblIPAdress, "lblIPAdress");
            this.lblIPAdress.Name = "lblIPAdress";
            // 
            // btnCalculate
            // 
            resources.ApplyResources(this.btnCalculate, "btnCalculate");
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // subMask
            // 
            resources.ApplyResources(this.subMask, "subMask");
            this.subMask.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.subMask.Name = "subMask";
            this.subMask.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.subMask.ValueChanged += new System.EventHandler(this.fOct_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // foOct
            // 
            resources.ApplyResources(this.foOct, "foOct");
            this.foOct.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.foOct.Name = "foOct";
            this.foOct.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.foOct.ValueChanged += new System.EventHandler(this.fOct_ValueChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tOct
            // 
            resources.ApplyResources(this.tOct, "tOct");
            this.tOct.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tOct.Name = "tOct";
            this.tOct.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tOct.ValueChanged += new System.EventHandler(this.fOct_ValueChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // sOct
            // 
            resources.ApplyResources(this.sOct, "sOct");
            this.sOct.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.sOct.Name = "sOct";
            this.sOct.Value = new decimal(new int[] {
            168,
            0,
            0,
            0});
            this.sOct.ValueChanged += new System.EventHandler(this.fOct_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // fOct
            // 
            resources.ApplyResources(this.fOct, "fOct");
            this.fOct.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.fOct.Name = "fOct";
            this.fOct.Value = new decimal(new int[] {
            192,
            0,
            0,
            0});
            this.fOct.ValueChanged += new System.EventHandler(this.fOct_ValueChanged);
            // 
            // dgwData
            // 
            resources.ApplyResources(this.dgwData, "dgwData");
            this.dgwData.AllowUserToAddRows = false;
            this.dgwData.AllowUserToDeleteRows = false;
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
            this.dgwData.Name = "dgwData";
            this.dgwData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lblNet
            // 
            resources.ApplyResources(this.lblNet, "lblNet");
            this.lblNet.ForeColor = System.Drawing.Color.Green;
            this.lblNet.Name = "lblNet";
            // 
            // lblHost
            // 
            resources.ApplyResources(this.lblHost, "lblHost");
            this.lblHost.Name = "lblHost";
            // 
            // lblNewSubnetMask
            // 
            resources.ApplyResources(this.lblNewSubnetMask, "lblNewSubnetMask");
            this.lblNewSubnetMask.Name = "lblNewSubnetMask";
            // 
            // broadcastAdressTextBoxColumn
            // 
            resources.ApplyResources(this.broadcastAdressTextBoxColumn, "broadcastAdressTextBoxColumn");
            this.broadcastAdressTextBoxColumn.Name = "broadcastAdressTextBoxColumn";
            // 
            // lastHostAdressTextBoxColumn
            // 
            resources.ApplyResources(this.lastHostAdressTextBoxColumn, "lastHostAdressTextBoxColumn");
            this.lastHostAdressTextBoxColumn.Name = "lastHostAdressTextBoxColumn";
            // 
            // firstHostAdressTextBoxClumn
            // 
            resources.ApplyResources(this.firstHostAdressTextBoxClumn, "firstHostAdressTextBoxClumn");
            this.firstHostAdressTextBoxClumn.Name = "firstHostAdressTextBoxClumn";
            // 
            // netAdressTextBoxColumn
            // 
            resources.ApplyResources(this.netAdressTextBoxColumn, "netAdressTextBoxColumn");
            this.netAdressTextBoxColumn.Name = "netAdressTextBoxColumn";
            // 
            // NumberTextBoxColumn
            // 
            resources.ApplyResources(this.NumberTextBoxColumn, "NumberTextBoxColumn");
            this.NumberTextBoxColumn.Name = "NumberTextBoxColumn";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNewSubnetMask);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgwData);
            this.Controls.Add(this.pnlInput);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subMask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foOct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOct)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblNewSubnetMask;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAdressTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstHostAdressTextBoxClumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastHostAdressTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn broadcastAdressTextBoxColumn;
    }
}

