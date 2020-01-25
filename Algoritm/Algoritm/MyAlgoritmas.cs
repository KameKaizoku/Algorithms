using System;
using System.Collections.Generic;
using System.Linq;
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
        
        public static string GoodVsEvil(string good, string evil)
        {
            int[] good_mas = good.Split(' ').Select(int.Parse).ToArray();
            int[] evil_mas = evil.Split(' ').Select(int.Parse).ToArray();
            int sum_good = good_mas[0] + good_mas[1] * 2 + good_mas[2] * 3 
                           + good_mas[3] * 3 + good_mas[4] * 4 + good_mas[5] * 10;
            int sum_evil = evil_mas[0] + evil_mas[1] * 2 + evil_mas[2] * 2 +evil_mas[3] * 2 
                           + evil_mas[4] * 3 + evil_mas[5] * 5 + evil_mas[6] * 10;
            if (sum_evil > sum_good) return "Battle Result: Evil eradicates all trace of Good";
            else if (sum_evil < sum_good) return "Battle Result: Good triumphs over Evil";
            else return "Battle Result: No victor on this battle field";
            
        }
        
        public static List<string> wave(string str)
        {
            List<String> res = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                String temp = " ";

                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    temp = str.Substring(0, i) + Char.ToUpper(str[i]) +
                           str.Substring(i + 1, str.Length - (i + 1));
                    
                    res.Add(temp);
                }
            }
            return res;
        }
        
        public static bool IsPrime(int n)
        {
            if (n <= 2 || n % 2 == 0) return n == 2;
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); i++)
                if (n % i == 0) return false;
            return true;
        }
        
    }
}