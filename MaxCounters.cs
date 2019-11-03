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

            int a;
            int[] A = new int[] { 1,2,3,5,6,7 };

            //a = p.solution(A);
            //p.show(a);

            
            //A = new int[] { 4, 3, 1 };
            
            a = p.solution(A);
            Console.WriteLine(a);
            /*
            A = new int[] { };

            a = p.solution(N,A);
            Console.WriteLine(a);


            A = new int[] { 1, 2 };

            a = p.solution(N,A);
            Console.WriteLine(a);
            */

        }
        public void show(int[] a)
        {
            foreach(int i in a)
            {
                Console.Write(i + ",");
            }
        }

        public int solution(int[] A)
        {

            int result = 1;
            int length = 0;
            int current = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    length += 1;
                }
            }
            if (length <= 0)
            {
                return 1;
            }

            int[] integers = new int[length];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    integers[current] = A[i];
                    current += 1;
                }
            }

            integers = integers.Distinct().ToArray();
            Array.Sort(integers);

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] == i + 1)
                {
                    result += 1;
                }
                else
                {
                    return result;
                }
            }

            return result;
        }
    }

}
