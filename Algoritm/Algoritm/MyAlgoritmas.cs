using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace Algorithm
{
    public class MyAlgorithms
    {
        public static bool ValidParentheses(string input)
        {
            Stack<Char> stack = new Stack<char>();
            foreach (var t in input)
                if(t == '(') stack.Push(t);
                else if (t==')' && (!stack.Any()  || stack.Pop()!='(')) return false;
            
            return !stack.Any();
        }
        
        public static int Determinant(int[][] matrix)
        {
            int det = 0;
            if (matrix[0].Length == 1) return matrix[0][0];
            if (matrix.Length == 2) return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];

            for (int i = 0; i < matrix[0].Length; i++)
            {
                int[][] temp  = new int[matrix.Length-1][];
                for (int j = 1; j < matrix.Length; j++)
                {
                    int[] num = new int[matrix[0].Length-1];
                    int count = 0;
                    for (int k = 0; k < matrix[0].Length; k++)
                    {
                        if (k != i)
                        {
                            num[count] = matrix[j][k];
                            count++;
                        }
                       
                    }
                    temp[j - 1] = num;
                }
                if(i%2 == 0)
                      det += matrix[0][i] * Determinant(temp);
                else det -= matrix[0][i] * Determinant(temp);
                
            }

            return det;
        }

          
        
        
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