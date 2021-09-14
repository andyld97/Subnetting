using Subnetting.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Subnetting
{
    public partial class frmMain : Form
    {
        private IPAdress currentIPAdress = null;
        private Subnet currentSubnet = null;

        public frmMain()
        {
            InitializeComponent();
            this.currentIPAdress = new IPAdress(192, 168, 2, 100, 8);
            this.currentSubnet = new Subnet(currentIPAdress, 16);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
         

        }

        private void fOct_ValueChanged(object sender, EventArgs e)
        {
            this.currentIPAdress = new IPAdress((int)fOct.Value, (int)sOct.Value, (int)tOct.Value, (int)foOct.Value, (int)this.subMask.Value);
            this.lblIPAdress.Text = $"{Properties.Resources.strIPAddress}: {currentIPAdress}/{(int)subMask.Value} @ {(int)nets.Value} {Properties.Resources.strNets}";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.currentSubnet = new Subnet(this.currentIPAdress, (int)this.nets.Value);
            double used = Math.Pow(2, IPAdress.GetBitsFromNet((int)this.nets.Value));

            if ((int)used == (int)this.nets.Value)
            {
                lblNet.Text = $"{(int)this.nets.Value} {Properties.Resources.strNetsUsed}";
                lblNet.ForeColor = Color.Green;
            }
            else
            {
                lblNet.Text = $"{used} {Properties.Resources.strOtherNumberOfNetsUsed} {(int)nets.Value}";
                lblNet.ForeColor = Color.Red;
            }

            this.lblHost.Text = $"{Properties.Resources.strHostAddress}: {currentSubnet.NetworkAdress}";
            this.lblNewSubnetMask.Text = $"{Properties.Resources.strNewSubnetmask}: {currentSubnet.SubnetMask}";

            this.dgwData.Rows.Clear();
            dgwData.Rows.Add(this.currentSubnet.BroadcastAdress.Length);

            // Fill in numbers:
            for (int s = 0; s <= this.currentSubnet.BroadcastAdress.Length - 1; s++)
                dgwData.Rows[s].Cells[0].Value = s + 1;

            // Add networkAdress
            for (int i = 0; i <= this.currentSubnet.HostAdresses.Length - 1; i++)
                dgwData.Rows[i].Cells[1].Value = this.currentSubnet.HostAdresses[i].ToString();

            // Add firstHostAdresss
            for (int m = 0; m <= this.currentSubnet.FirstHostAdresses.Length - 1; m++)
                dgwData.Rows[m].Cells[2].Value = this.currentSubnet.FirstHostAdresses[m].ToString();

            // Add lastHostAdress
            for (int b = 0; b <= this.currentSubnet.LastHostAdress.Length - 1; b++)
                dgwData.Rows[b].Cells[3].Value = this.currentSubnet.LastHostAdress[b].ToString();

            // Add BroadcastAdress
            for (int c = 0; c <= this.currentSubnet.BroadcastAdress.Length - 1; c++)
                dgwData.Rows[c].Cells[4].Value = this.currentSubnet.BroadcastAdress[c].ToString();
        }
    }
}
