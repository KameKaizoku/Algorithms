using System;
using System.Diagnostics;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Console.WriteLine(MyAlgorithms.Tribonacci(new double []{1,1,1},10));
            double[] arr = MyAlgorithms.Tribonacci(new double[] {1, 1, 1}, 10);
            foreach (var el in arr)
                Console.Write(el+" ");
            {
                
            }
        }
    }
  
  
}