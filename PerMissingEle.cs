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
            int[] A = new int[] {1,2,3,4,5,6,7,8,9,10,11,13,14,16,12 };

            a = p.solution(A);
            Console.WriteLine(a);

            A = new int[] { };

            a = p.solution(A);
            Console.WriteLine(a);

            A = new int[] {-1,-2, 0, 1, 3,4,5 };

            a = p.solution(A);
            Console.WriteLine(a);

        }

        public int solution(int[] A)
        {
            int missing = 1;

            Array.Sort(A);

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= 0)
                {
                    continue;
                }
                else if (A[i] == missing)
                {
                    missing++;
                }
            }
            return missing;
        }

    }

}

