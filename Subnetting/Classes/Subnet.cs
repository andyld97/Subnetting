namespace Subnetting.Classes
{
    public class Subnet
    {
        #region Private Members
        public readonly IPAdress Adress;
        private IPAdress subnetMask, networkAdress;
        private IPAdress[] hostAdresses, firstHostAdresses, lastHostAdresses, broadcastAdresses;
        private int net = 0;
        #endregion

        #region Public Properties
        public int Net
        {
            get => net;
            set
            {
                this.net = value;
                this.Calculate();
            }
        }

        public IPAdress SubnetMask => subnetMask;

        public IPAdress NetworkAdress => networkAdress;

        public IPAdress[] FirstHostAdresses => firstHostAdresses;

        public IPAdress[] HostAdresses => hostAdresses;

        public IPAdress[] LastHostAdress => lastHostAdresses;

        public IPAdress[] BroadcastAdress => broadcastAdresses;

        #endregion

        public Subnet(IPAdress Adress, int net)
        {
            this.Adress = Adress;
            this.Net = net;
        }

        private void Calculate()
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
