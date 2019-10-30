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
            int a = 0;
            Program p = new Program();

            int[] Arr = new int[] {1, 2, 1, 3, 2, 4, 3, 5, 6, 4, 5, 7, 8, 7, 8};
            a = p.solution(Arr);
            Console.WriteLine(a);

            Arr = new int[] { 1,2,3,4,1,2,4};
            a = p.solution(Arr);
            Console.WriteLine(a);

            Arr = new int[] { 1,2,3,4,1,2,3,4,1,3,4,1,2,3,4};
            a = p.solution(Arr);
            Console.WriteLine(a);

        }

        public int solution(int[] A)
        {
            int result = 0;
            foreach (int i in A)
            {
                result ^= i;
            }
            return result;
        }
    }

}

