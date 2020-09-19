﻿using System;
using System.Collections;
using Lab1_ping;

namespace ConsoleApp1
{
     public class ByteOperations
    {
        /*v5*/
        public String getBytes(Address address)
        {
            return address.toDoubleC();
        }


       

        public Address kon(Address a, Address b)
        {
            Address address = new Address(0,0,0,0);
            address.S1 = a.S1 & b.S1;
            address.S2 = a.S2 & b.S2;
            address.S3 = a.S3 & b.S3;
            address.S4 = a.S4 & b.S4;
            return address;
        }

        public Address dizunk(Address a, Address b)
        {
            Address address = new Address(0,0,0,0);
            address.S1 = a.S1 | b.S1;
            address.S2 = a.S2 | b.S2;
            address.S3 = a.S3 | b.S3;
            address.S4 = a.S4 | b.S4;
            return address;
        }

        public Address not( Address b)
        {
           
            String s=b.toDoubleC();
            String ad = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]=='1')
                {
                    ad += "0";
                }
                else
                {
                    ad += "1";
                }
            }
            return getAdressFromStr(ad);
        }

        public Address getMask(Address a, Address b)
        {
            String s1 =a.toDoubleC();
            String s2=b.toDoubleC();
            String s3 = "";
            bool f = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i] && f==false)
                {
                    s3 += "1";
                }
                else
                {
                    f = true;
                    s3 += "0";
                }
            }
            Console.WriteLine(s3);
            return getAdressFromStr(s3);
        }

        public Address dizMany(ArrayList list)
        {
            Address final=(Address)list[0];
            list.RemoveAt(0);
            foreach (Address address in list)
            {
                final = kon(final,address);
            }

            return final;
        }

        public Address konMany(ArrayList list)
        {
            Address final=(Address)list[0];
            list.RemoveAt(0);
            foreach (Address address in list)
            {
                final = dizunk(final,address);
            }

            return final;
        } 
        public Address getMaskMany(ArrayList list)
        {
            Address final=(Address)list[0];
            list.RemoveAt(0);
            foreach (Address address in list)
            {
                final = getMask(final,address);
            }

            return final;
        }

        
        public Address getAdressFromStr(String str)
        {
            int a=(int) Convert.ToInt64(str.Substring(0, 8),2);
            int b=(int) Convert.ToInt64(str.Substring(8, 8),2);
            int c=(int) Convert.ToInt64(str.Substring(16, 8),2);
            int d=(int) Convert.ToInt64(str.Substring(24, 8),2);

            
            
            return new Address(a,b,c,d);

        }
        
    }
    
}