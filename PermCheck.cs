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

            int[] A = new int[] {1,2,3,4};

            a = p.solution(A);
            Console.WriteLine(a);

            
            A = new int[] { 4,3,1};

            a = p.solution(A);
            Console.WriteLine(a);

            A = new int[] { };

            a = p.solution(A);
            Console.WriteLine(a);


            A = new int[] { 1,2};

            a = p.solution(A);
            Console.WriteLine(a);
            
        
        }

        public int solution(int[] A)
        {
            Array.Sort(A);
            int num = 0;
            int numbersIn = 0;
            bool[] numpos = new bool[A.Length + 1];
            if (A.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < A.Length; i++)
            {
                num = A[i];
                if (num <= A.Length && !numpos[num])
                {
                    numpos[num] = true;
                    numbersIn++;
                }
            }
            if (numbersIn == A.Length)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }


}