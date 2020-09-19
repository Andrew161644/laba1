using System;
using System.Collections;
using System.Threading;
using System.Windows.Forms;

namespace Lab1_ping
{
    public class Address
    {
        protected int s1;
        protected int s2;
        protected int s3;
        protected int s4;
        
        public Address(int s1, int s2, int s3, int s4)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            this.s4 = s4;
        }

        public Address(string s)
        {
            string[] str=s.Split('.');
            s1 = (int)Int64.Parse(str[0]);
            s2 = (int)Int64.Parse(str[1]);
            s3 = (int)Int64.Parse(str[2]);
            s4 = (int)Int64.Parse(str[3]);
        }

        public static bool operator >(Address a, Address b)
        {
            
            if (a.s1 >= b.s1)
            {
                if (a.s1 > b.s1)
                {
                    return true;
                }
                
                if (a.s2 >= b.s2)
                {
                    if (a.s2 > b.s2)
                    {
                        return true;
                    }
                    if (a.s3 >= b.s3)
                    {
                        if (a.s3 > b.s3)
                        {
                            return true;
                        }
                        if (a.s4 > b.s4)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        public static bool operator <(Address a,Address b)
        {
            return !(a > b);
        }

        public String toDoubleC()
        {
            String v = Convert.ToString(s1, 2);
            while (v.Length<8)
            {
                v = "0" + v;
            }
            String v2 = Convert.ToString(s2, 2);
            while (v2.Length<8)
            {
                v2 = "0" + v2;
            }
            String v3 = Convert.ToString(s3, 2);
            while (v3.Length<8)
            {
                v3 = "0" + v3;
            }
            String v4 = Convert.ToString(s4, 2);
            while (v4.Length<8)
            {
                v4 = "0" + v4;
            }
            return v+v2+v3+v4;
        }
        public override string ToString()
        {
            return $"{s1}.{s2}.{s3}.{s4}";
        }
        public int S1
        {
            get => s1;
            set => s1 = value;
        }

        public int S2
        {
            get => s2;
            set => s2 = value;
        }

        public int S3
        {
            get => s3;
            set => s3 = value;
        }

        public int S4
        {
            get => s4;
            set => s4 = value;
        }
        
    }
}