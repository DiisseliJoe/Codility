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
            int[] A = new int[] { -1000, 1000 };

            a = p.solution(A);
            Console.WriteLine(a);

            A = new int[] { 3, 4, 5, 6, 2, 3, 2, 1, 5 };

            a = p.solution(A);
            Console.WriteLine(a);

            A = new int[] { -1, -2, 0, 1, 3, 4, 5 };

            a = p.solution(A);
            Console.WriteLine(a);

        }

        public int solution(int[] A)
        {

            int smallestDifference = 0;
            int difference;
            int firstPart = A[0];
            int secondPart = 0;

            for (int i = 1; i < A.Length; i++)
            {
                secondPart += A[i];
            }
            smallestDifference = Math.Abs(secondPart - firstPart);

            for (int i = 1; i < A.Length - 1; i++)
            {
                firstPart += A[i];
                secondPart -= A[i];

                difference = Math.Abs(secondPart - firstPart);

                if (difference < smallestDifference)
                {
                    smallestDifference = difference;
                }

            }
            return smallestDifference;

        }
    }
}
