
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1_ping;
using System.Threading;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    public class Scunner:IScunner
    {
        ArrayList addresses=new ArrayList();
       
        public Scunner(ArrayList list)
        {
            this.addresses = list;
            
        }

       
        public void scan(ScunnerOutputContent output)
        {
            Task t = Task.Factory.StartNew(() =>
            {
                List<Task> tasks = new List<Task>();
                MTaskShelder lcts = new MTaskShelder(100);
              
                TaskFactory factory = new TaskFactory(lcts);
                foreach (MIp ip in addresses)
                {
                    Task t1 =factory.StartNew(() =>
                    {
                        new Pinger().ping(ip); 
                        output.add(ip);
                    });
                    tasks.Add(t1);
                }
                
                /*int max = 255;
                int col = 0;
                foreach (MIp ip in addresses)
                {
                    Task task = Task.Factory.StartNew(() =>
                    {
                        new Pinger().ping(ip); 
                        output.add(ip);
                    });
                    tasks.Add(task);
                    col++;
                    if (col == max)
                    {
                        Task.WaitAll(tasks.ToArray());
                        col = 0;
                    }
                }*/

                
                try
                { 
                    Task.WaitAll(tasks.ToArray());
                    output.update(addresses);
                
                   
                }
                catch (Exception e)
                {
                    Debug.WriteLine("Exception"+ e);
                    Console.WriteLine(e);
                    throw;
                }
            });
        }
       
    }

    
}
