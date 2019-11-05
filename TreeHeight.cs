using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            int a = 0;
            int[] A = new int[] { 0, 1, 0, 1, 1 }; 
            a = p.solution(A);
            Console.WriteLine(a);
            /*
              
            class Tree {
                public int x;
                public Tree l;
                public Tree r;
            };
            
            */
        }
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int carsR = 0;
            int passedCars = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    carsR++;
                }
                if (A[i] == 1)
                {
                    passedCars += carsR * 1;
                }
                if (passedCars > 1000000000)
                {
                    return -1;
                }
            }
            return passedCars;
        }
    }

}
