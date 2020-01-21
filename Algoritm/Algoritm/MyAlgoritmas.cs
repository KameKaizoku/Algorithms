using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

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
        
        public static char FindMissingLetter(char[] array)
        {
            int num = (int) array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (num != (int) array[i]) 
                    return (char)(num);
                num++;
            }
            return ' ';
        }
        
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            String[] res = new String[data.Length];

            for (int i = 0; i < data.Length; i++)
           
                res[i]= data[i][0] >= 55 && data[i][1] > 7 ? "Senior" : "Open";
           
            return res;
        }
        
        public static double[] Tribonacci(double[] signature, int n)
            {
                double[] arr = new double[n];
                for (int i = 0; i < n; i++)
                {
                    if (i < 3) arr[i] = signature[i];
                    else arr[i] = arr[i - 3] + arr[i - 2] + arr[i - 1];
                }

                return arr;
              
            }
        
    }
}