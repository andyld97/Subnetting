using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subnetting.Classes
{
    public class Subnet
    {
        public readonly IPAdress Adress;
        private IPAdress subnetMask, networkAdress;
        private IPAdress[] hostAdresses, firstHostAdresses, lastHostAdresses, broadcastAdresses;
        private int net = 0;

        public int Net
        {
            get
            {
                return this.net;
            }
            set
            {
                this.net = value;
                this.calculate();
            }
        }

        public IPAdress SubnetMask
        {
            get
            {
                return this.subnetMask;
            }
        }

        public IPAdress NetworkAdress
        {
            get
            {
                return this.networkAdress;
            }
        }

        public IPAdress[] FirstHostAdresses
        {
            get
            {
                return this.firstHostAdresses;
            }
        }

        public IPAdress[] HostAdresses
        {
            get
            {
                return this.hostAdresses;
            }
        }

        public IPAdress[] LastHostAdress
        {
            get
            {
                return this.lastHostAdresses;
            }
        }

        public IPAdress[] BroadcastAdress
        {
            get
            {
                return this.broadcastAdresses;
            }
        }

        public Subnet(IPAdress Adress, int net)
        {
            this.Adress = Adress;
            this.Net = net;
        }

        private void calculate()
        {
            if (Adress != null)
            {
                this.subnetMask = this.Adress.BuildNewSubnetMask(this.net);
                this.networkAdress = this.Adress.BuildNetworkAdress();
                // ------------------------------------------------------------
                this.hostAdresses = this.Adress.BuildSubnetAdresses(this.net);
                this.firstHostAdresses = this.Adress.BuildFirstAdresses(this.net);
                this.lastHostAdresses = this.Adress.BuildLastNetAdress(this.net);
                this.broadcastAdresses = this.Adress.BuildBroadcastAdress(this.net);
                // ------------------------------------------------------------
            }
        }      
    }
}
