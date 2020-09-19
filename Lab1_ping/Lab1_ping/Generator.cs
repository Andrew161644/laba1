
using System.Collections;

using System.Diagnostics;
using System.Threading.Tasks;


namespace Lab1_ping
{
    public class Generator
    {
        public ArrayList generate(Address start, Address end)
        {
           ArrayList list=new ArrayList();
             int[,] arr = { { start.S1, start.S2, start.S3, start.S4 }, { end.S1, end.S2, end.S3, end.S4 } };

            while( (arr[0,0]!= arr[1, 0])|| (arr[0, 1] != arr[1, 1]) || (arr[0, 2] != arr[1, 2]) || (arr[0, 3] != arr[1, 3]))
            {
               list.Add(new MIp(arr[0, 0],arr[0, 1],arr[0, 2],arr[0, 3]));
                incrementIP(arr);
            } 
           
            /*list.Add(new MIp(127,0,0,0));
            list.Add(new MIp(127,5,0,10));
            list.Add(new MIp(173,194,73,102));
            list.Add(new MIp(193,233,146,33));*/
            return list;
        }
        private void incrementIP(int[,] IP)
        {
            if (IP[0,3] != 255)
                IP[0, 3]++;
            else
            {
                IP[0, 3] = 0;
                if (IP[0, 2] != 255)
                    IP[0, 2]++;
                else
                {
                    IP[0, 2] = 0;
                    if (IP[0, 1] != 255)
                        IP[0, 1]++;
                    else
                    {
                        IP[0, 1] = 0;
                        IP[0, 0]++;
                    }
                }
            }

        }
    }
    
}