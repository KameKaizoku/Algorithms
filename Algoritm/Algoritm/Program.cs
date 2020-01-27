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
          /* List<String> arr = MyAlgorithms.wave("this is a few words");
           foreach (var el in arr)
           {
               Console.WriteLine(el);  new [] { 1 }
           }
*/
            Console.WriteLine(MyAlgorithms.Determinant(  new int[][] {  new [] { 2, 5, 3 }, new [] { 1, -2, -1 }, new [] { 1, 3, 4 }  }));
        }
    }
  
  
}