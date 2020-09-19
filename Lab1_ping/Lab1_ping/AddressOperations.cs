using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleApp1;

namespace Lab1_ping
{
    public class AddressOperations
    {
        ByteOperations _byteOperations=new ByteOperations();
       
        public Address getNetwork(Address a, Address b)
        {
            return _byteOperations.kon(a, b);
        }

        
    }
}