﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement an extension method Substring(int index, int length) for the
//class StringBuilder that returns new StringBuilder and has the same functionality
//    as Substring in the class String.

namespace III___03___ламбда__LINQ___Част_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder opa = new StringBuilder();
            opa.Append("ssssssssssssssssaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            opa = opa.Substring(15, 3);
            Console.WriteLine( opa);
           
        }
       
        
    }
}
