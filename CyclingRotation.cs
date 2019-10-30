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
            int[] a = new int[] { };
            Program p = new Program();

            int[] Arr = new int[] {1,2,3,4,5,6};
            int k = 3;
            a = p.solution(Arr,k);
            p.show(a);

            Arr = new int[] { };
            a = p.solution(Arr,k);
            p.show(a);

            Arr = new int[] { 0,0,0,0};
            a = p.solution(Arr,k);
            p.show(a);

        }
 
        /// /////////////////////
       
        public int[] solution(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length < 1)
            {
                return A;
            }
            for (int i = 0; i < K; i++)
            {
                int temp = A[A.Length - 1];
                for (int a = A.Length - 1; a > 0; a--)
                {
                    A[a] = A[a - 1];
                }
                A[0] = temp;
            }
            return A;
        }
        /// /////////////////////////////////////////////////////////

        public void show(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine(" ");
        }
    }

}

