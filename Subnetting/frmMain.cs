using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Subnetting
{
    public partial class frmMain : Form
    {
        private Classes.IPAdress currentIPAdress = null;
        private Classes.Subnet mySubnet = null;

        public frmMain()
        {
            InitializeComponent();
            this.currentIPAdress = new Classes.IPAdress(192, 168, 2, 100, 8);
            this.mySubnet = new Classes.Subnet(this.currentIPAdress, 16);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
         

        }

        private void fOct_ValueChanged(object sender, EventArgs e)
        {
            this.currentIPAdress = new Classes.IPAdress((int)fOct.Value, (int)sOct.Value, (int)tOct.Value, (int)foOct.Value, (int)this.subMask.Value);
            this.lblIPAdress.Text = "IP-Adresse: " + this.currentIPAdress.ToString() + "/" + this.subMask.Value + " @ " + (int)this.nets.Value + " Netze";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.mySubnet = new Classes.Subnet(this.currentIPAdress, (int)this.nets.Value);
            double used = Math.Pow(2, Classes.IPAdress.GetBitsFromNet((int)this.nets.Value));

            if ((int)used == (int)this.nets.Value)
            {
                lblNet.Text = (int)this.nets.Value + " Netze wurden verwendet";
                lblNet.ForeColor = Color.Green;
            }
            else
            {
                lblNet.Text = used + " Netze wurden verwendet, statt " + this.nets.Value;
                lblNet.ForeColor = Color.Red;
            }

            this.lblHost.Text = "Hostadresse: " + this.mySubnet.NetworkAdress;
            this.lblNewSubnetMask.Text = "Neue Subnetzmaske: " + this.mySubnet.SubnetMask;

            this.dgwData.Rows.Clear();
            dgwData.Rows.Add(this.mySubnet.BroadcastAdress.Length);

            // Fill in numbers:
            for (int s = 0; s <= this.mySubnet.BroadcastAdress.Length - 1; s++)
                dgwData.Rows[s].Cells[0].Value = s + 1;

            // Add networkAdress
            for (int i = 0; i <= this.mySubnet.HostAdresses.Length - 1; i++)
                dgwData.Rows[i].Cells[1].Value = this.mySubnet.HostAdresses[i].ToString();

            // Add firstHostAdresss
            for (int m = 0; m <= this.mySubnet.FirstHostAdresses.Length - 1; m++)
                dgwData.Rows[m].Cells[2].Value = this.mySubnet.FirstHostAdresses[m].ToString();

            // Add lastHostAdress
            for (int b = 0; b <= this.mySubnet.LastHostAdress.Length - 1; b++)
                dgwData.Rows[b].Cells[3].Value = this.mySubnet.LastHostAdress[b].ToString();

            // Add BroadcastAdress
            for (int c = 0; c <= this.mySubnet.BroadcastAdress.Length - 1; c++)
                dgwData.Rows[c].Cells[4].Value = this.mySubnet.BroadcastAdress[c].ToString();
        }
    }
}
