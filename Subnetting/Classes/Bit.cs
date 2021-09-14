using System;

namespace Subnetting.Classes
{
    public class Bit
    {
        private int value;

        public int Value
        {
            get => value;
            set
            {
                if (value == 1 || value == 0)
                    this.value = value;
            }
        }

        public Bit(int value)
        {
            this.value = value;
        }

        public static Bit[] FromInt(int value)
        {
            if (value < 0 && value > 255)
                return null;

            Bit[] currentArr = new Bit[8];
            string converted = Convert.ToString(value, 2);

            if (converted.Length < 8)
            {
                string nString = "";
                for (int i = 0; i <= 8 - converted.Length - 1; i++)
                    nString += "0";
                nString += converted;
                converted = nString;
            }

            for (int i = 0; i <= converted.Length - 1; i++)
                currentArr[i] = new Bit(int.Parse(converted[i].ToString()));

            return currentArr;
        }

        public static int FromBitArr(Bit[] arr)
        {
            string n = string.Empty;
            for (int i = 0; i <= arr.Length - 1; i++)
                n += arr[i].value.ToString();

            return Convert.ToInt32(n, 2);
        }
    }
}
