
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1_ping;

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
                foreach (MIp ip in addresses)
                {
                    Task task = Task.Factory.StartNew(() =>
                    {
                        new Pinger().ping(ip); 
                        output.add(ip);
                    });
                    tasks.Add(task);
                }
                try
                { 
                    Task.WaitAll(tasks.ToArray());
                    output.update(addresses);
                    /*foreach (MIp ip in addresses)
                    {
                        Debug.WriteLine("Out "+ip+" "+ip._status);
                        
                        // dataGridView.Invoke(new Set((s) => dataGridView.Rows.Add(s,s.hostname,s._status)),ip);
                    }*/
                   
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
