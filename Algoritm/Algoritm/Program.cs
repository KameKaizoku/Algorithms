using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Console.WriteLine(MyAlgorithms.Tribonacci(new double []{1,1,1},10));
           List<String> arr = MyAlgorithms.wave("this is a few words");
           foreach (var el in arr)
           {
               Console.WriteLine(el);
           }

           // Console.WriteLine(MyAlgorithms.GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0"));
        }
    }
  
  
}