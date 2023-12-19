using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms
{
    public class Recursion
    {
        public void CalculateTail(int n)
        {
            if (n>0)
            {
                int k = n * n;
                Console.WriteLine(k);
                CalculateTail(n-1);
            }    
        }

        public void CalculateHead(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                CalculateHead(n - 1);
            }
        }

        public void CalculateTree(int n)
        {
            if (n > 0)
            {
                CalculateTree(n - 1);
                int k = n * n;
                Console.WriteLine(k);
                CalculateTree(n - 1);
            }
        }


        ///1+2+3+4+5+5...+n
        public int sumrecursion(int n) {
            if (n==0)
            {
                return 1;
            }
            return sumrecursion(n-1)*n;
        }

        public int LinearSearch(int[]A,int key)
        {
            int index = 0;
            while (index<A.Length)
            {
                if (A[index]==key)
                {
                    return index;
                }
                index = index + 1;
            }
            return -1;
        }

        //Find Factorial
        public int factorialiterative(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;
        }

        public int factorialrecursive(int n)
        {
            if (n == 0)
                return 1;
            return factorialrecursive(n - 1) * n;
        }
    }
}
