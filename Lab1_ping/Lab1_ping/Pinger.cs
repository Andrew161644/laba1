﻿﻿using System;
  using System.Diagnostics;
  using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
  using System.Threading.Tasks;
  using Lab1_ping;
  using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    public class Pinger : ISping
    {
         public MIp  ping(MIp address)
        {

            /*Debug.WriteLine(Thread.CurrentThread.Name);*/
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 20;
            try
            {
                PingReply reply = pingSender.Send(address.ToString(), timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    try
                    {
                        IPHostEntry hostEntry = Dns.GetHostEntry(reply.Address);
                        string machineName = hostEntry.HostName;
                        /*Debug.WriteLine("Runned in thread ${2}\nAddress: {0} - Answered \n Hostname is {1}",
                            reply.Address.ToString(), machineName, Thread.CurrentThread.Name);*/
                        address._status = MIp.Status.AVALIBLE;
                        address.hostname = machineName;
                    }
                    catch (Exception e)
                    {
                        /*Debug.WriteLine("Address: ${0} - Answered \n Hostname is not found", reply.Address);*/
                        address._status = MIp.Status.AVALIBLE;


                    }
                    finally
                    {
                        Debug.WriteLine("");
                    }
                }
                else
                {
                    /*Debug.WriteLine ("No answer from ${0} \n",reply.Address);*/
                    address._status = MIp.Status.NOT_AVALIBLE;
                }
            }
            catch (Exception e)
            {
                /*Debug.WriteLine("Does not exist or no answer "+address);*/
                address._status = MIp.Status.NOT_AVALIBLE;
            }

            Debug.WriteLine(address+" "+address._status);
            return address;
        }
    }
}