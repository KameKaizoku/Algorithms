using System;

namespace Algoritm
{
    public class MyAlgoritmas
    {
        
        public int GetSum(int a, int b)
        {
            int sum = 0;
       
            for(int i =Math.Min(a,b); i<=Math.Max(a,b); i++)
                sum+=i;
            return sum;
        }
        
    }
}