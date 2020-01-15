using System;

namespace Algorithm
{
    public class MyAlgorithms
    {
        
        public int GetSum(int a, int b)
        {
            int sum = 0;
       
            for(int i =Math.Min(a,b); i<=Math.Max(a,b); i++)
                sum+=i;
            return sum;
        }
        
        public static int FindEvenIndex(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int sum_l = 0, sum_r = 0;
                for (int j = 0; j < i; j++)
                    sum_l+=arr[j];
                for (int j = i+1; j < arr.Length; j++)
                    sum_r+=arr[j];
                if (sum_l == sum_r) return i;
            }
            
            return -1;
        }
        
    }
}