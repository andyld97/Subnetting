using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subnetting.Classes
{
    public class IPAdress
    {
        private int mask = 0;

        // First oct:
        private int _fOct = 0;
        private Bit[] fOct = new Bit[8];

        // Second oct:
        private int _sOct = 0;
        private Bit[] sOct = new Bit[8];

        // Third oct:
        private int _tOct = 0;
        private Bit[] tOct = new Bit[8];

        // Fourth oct:
        private int _foOct = 0;
        private Bit[] foOct = new Bit[8];

        public int FOct
        {
            get
            {
                return _fOct;
            }
            set
            {
                _fOct = value;
                this.fOct = Bit.FromInt(value);
            }
        }

        public int SOct
        {
            get
            {
                return _sOct;
            }
            set
            {
                _sOct = value;
                this.sOct = Bit.FromInt(value);
            }
        }

        public int TOct
        {
            get
            {
                return _tOct;
            }
            set
            {
                _tOct = value;
                this.tOct = Bit.FromInt(value);
            }
        }

        public int FoOct
        {
            get
            {
                return _foOct;
            }
            set
            {
                _foOct = value;
                this.foOct = Bit.FromInt(value);
            }
        }

        public Bit[] AsBitArray
        {
            get
            {
                Bit[] mBit = new Bit[32];
                int counter = 0;

                for (int i = 0; i <= this.getBitArraysAsList().Count() - 1; i++)
                    for (int s = 0; s <= this.getBitArraysAsList()[i].Length - 1; s++)
                        mBit[counter++] = this.getBitArraysAsList()[i][s];

                return mBit;
            }
        }

        public IPAdress(int f, int s, int t, int fo, int mask)
        {
            this.FOct = f;
            this.SOct = s;
            this.TOct = t;
            this.FoOct = fo;
            this.mask = mask;
        }

        public List<Bit[]> getBitArraysAsList()
        {
            List<Bit[]> bitArrays = new List<Bit[]>();
            bitArrays.Add(fOct);
            bitArrays.Add(sOct);
            bitArrays.Add(tOct);
            bitArrays.Add(foOct);
            return bitArrays;
        }

        public IPAdress BuildNetworkAdress()
        {
            Bit[] ip = new Bit[32];
            Bit[] sub = new Bit[32];

            int counter = 0;
            foreach (Bit[] arr in this.getBitArraysAsList())
                for (int i = 0; i <= arr.Length - 1; i++)
                    ip[counter++] = arr[i];

            for (int i = 0; i <= 32-1; i++)
                sub[i] = (i <= this.mask - 1 ? new Bit(1) : new Bit(0));

            // Combine both:
            Bit[] finalIP = new Bit[32];
            for (int x = 0; x <= 32 - 1; x++)   // & 1 => source &0 => zero
                finalIP[x] = (sub[x].Value == 1 ? ip[x] : new Bit(0));

            return this.BuildIPAdressFromBit(finalIP, this.mask);
        }

        private IPAdress BuildIPAdressFromBit(Bit[] value, int mask)
        {
            IPAdress currentAdress = new IPAdress(10, 10, 10, 10, mask);
            int currentOct = 0;
            int otherCounter = 0;
            var lst = currentAdress.getBitArraysAsList();

            for (int i = 1; i <= value.Length; i++)
            {
                if (i % 8 == 0)
                {
                    lst[currentOct][otherCounter] = value[i - 1];
                    currentOct++;
                    otherCounter = 0;
                }
                else
                {
                    lst[currentOct][otherCounter] = value[i - 1];
                    otherCounter++;
                }
            }

            for (int f = 0; f <= lst.Count - 1; f++)
            {
                string currentStr = string.Empty;
                for (int b = 0; b <= lst[f].Length - 1; b++)
                { currentStr += lst[f][b].Value; }

                if (f == 0)
                    currentAdress.FOct = Convert.ToInt32(currentStr, 2);
                else if (f == 1)
                    currentAdress.SOct = Convert.ToInt32(currentStr, 2);
                else if (f == 2)
                    currentAdress.TOct = Convert.ToInt32(currentStr, 2);
                else if (f == 3)
                    currentAdress.FoOct = Convert.ToInt32(currentStr, 2);
            }

            return currentAdress;
        }

        public static int GetBitsFromNet(int net)
        {
            List<int> items = new List<int>();

            for (int i = 1; i <= 32768; i *= 2)
                if (i - net >= 0)
                    items.Add(i - net);
            items.Sort();

            double newItem = Math.Log((double)items[0] + (double)net, 10.0) / Math.Log(2.0, 10.0);
            return Convert.ToInt32(newItem);
        }

        private Bit[] linkAnd(Bit[] ip, Bit[] sub)
        {
            Bit[] finalIP = new Bit[32];

            for (int i = 0; i <= 32 - 1; i++)
                finalIP[i] = (sub[i].Value == 1 ? ip[i] : new Bit(0));

            return finalIP;
        }

        public IPAdress BuildNewSubnetMask(int net)
        {
            // Get bits for this network
            int bits = GetBitsFromNet(net);
            IPAdress currentAdress = new IPAdress(this.FOct, this.SOct, this.TOct, this.FoOct, this.mask); // this.mask + bits
            Bit[] ip = new Bit[32];
            for (int i = 0; i <= 32 - 1; i++)
                ip[i] = new Bit(1);

            Bit[] subNet = new Bit[32];
            for (int i = 0; i <= 32 - 1; i++)
                subNet[i] = (i <= currentAdress.mask - 1 ? new Bit(1) : new Bit(0));

            Bit[] finalIP = linkAnd(ip, subNet);

            return this.BuildIPAdressFromBit(finalIP, currentAdress.mask);
        }

        public IPAdress[] BuildSubnetAdresses(int net)
        {
            IPAdress subnetMask = this.BuildNewSubnetMask(net);
            int bitsFromNet = GetBitsFromNet(net);
            double steps = 256.0 / Math.Pow(2, bitsFromNet);

            List<IPAdress> addresses = new List<IPAdress>();

            // Which oct?
            int start = subnetMask.mask;

            Bit[] ip = new Bit[32];
            for (int i = 0; i <= start - 1; i++)
                ip[i] = this.BuildNetworkAdress().AsBitArray[i];

            // Add subnet
            for (int i = 0; i <= Math.Pow(2, bitsFromNet) - 1; i++)
            {
                int step = i * (int)steps;
                Bit[] bits = Bit.FromInt(step); // > start - 1 + 1 + i = > start + i

                // Clear old one
                for (int m = start; m <= 32 - 1; m++)
                    ip[m] = new Bit(0);

                //for (int s = 0; s <= bits.Length - 1; s++)
                //        ip[start + s] = bits[s];
                int counter = 0;
                for (int s = start; s <= 32 - 1; s++)
                {
                    ip[s] = bits[counter++];
                    if (counter == 7)
                        break;
                }

                addresses.Add(this.BuildIPAdressFromBit(ip, subnetMask.mask));
            }
            return addresses.ToArray();            
        }

        public IPAdress[] BuildFirstAdresses(int net)
        {
            IPAdress[] ipAdresses = this.BuildSubnetAdresses(net);

            for (int i = 0; i <= ipAdresses.Length - 1; i++)
            {
                Bit[] lastOct = ipAdresses[i].foOct;
                lastOct[lastOct.Length - 1] = new Bit(1);
                ipAdresses[i].FoOct = Bit.FromBitArr(lastOct);
            }

            return ipAdresses;
        }

        public IPAdress[] BuildLastNetAdress(int net)
        {
            IPAdress subnetMask = this.BuildNewSubnetMask(net);
            int bitsFromNet = GetBitsFromNet(net);

            int start = subnetMask.mask + bitsFromNet;

            IPAdress[] networkAdress = this.BuildFirstAdresses(net);

            foreach (IPAdress adress in networkAdress)
            {
                Bit[] ip = new Bit[32];
                for (int i = 0; i <= start - 1; i++)
                    ip[i] = adress.AsBitArray[i];

                // From 0 to start => & source. From start to 30 1 and 31 => 0
                for (int x = start; x <= 32 - 2; x++)
                    ip[x] = new Bit(1);
                ip[31] = new Bit(0);

                networkAdress[Array.IndexOf<IPAdress>(networkAdress, adress)] = this.BuildIPAdressFromBit(ip, subnetMask.mask);
            }

            return networkAdress;
        }

        public IPAdress[] BuildBroadcastAdress(int net)
        {
            IPAdress[] lastnetAdress = this.BuildLastNetAdress(net);

            foreach (IPAdress adress in lastnetAdress)
            {
                Bit[] lastBitArray = adress.foOct;
                lastBitArray[lastBitArray.Length - 1] = new Bit(1);
                adress.FoOct = Bit.FromBitArr(lastBitArray);
            }

            return lastnetAdress;
        }

        public override string ToString()
        {
            return FOct + "." + SOct + "." + TOct + "." + FoOct;
        }

    }
}