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
            int X = 7;
            int[] A = new int[] {1,2,3,4,5,6,7,1,2,3,4,5,6};

            a = p.solution(X,A);
            Console.WriteLine(a);

            X = 6;
            A = new int[] { 1,3,2,5,4,6,7,8,1,2,3,4,2,3,4,5,6};

            a = p.solution(X,A);
            Console.WriteLine(a);

            X = 3;
            A = new int[] { };

            a = p.solution(X,A);
            Console.WriteLine(a);

            X = 5;
            A = new int[] { 1,4,3,2,6,7,4,3,2,1};

            a = p.solution(X, A);
            Console.WriteLine(a);
        }

        public int solution(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int leafpos = 0;
            int fallenLeafs = 0;
            bool[] leafs = new bool[X + 1];

            for (int i = 0; i < A.Length; i++)
            {
                leafpos = A[i];
                if (leafpos <= X && !leafs[leafpos])
                {
                    leafs[leafpos] = true;
                    fallenLeafs++;
                }
                if (fallenLeafs == X)
                {
                    return i;

                }

            }
            return -1;
        }
    }

}