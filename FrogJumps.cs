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

            int X = 10;
            int Y = 85;
            int D = 30;
            int a = 0;
            a = p.solution(X,Y,D);
            Console.WriteLine(a);

            X = 10;
            Y = 1000000;
            D = 1;

            a = p.solution(X, Y, D);
            Console.WriteLine(a);

            X = 1000;
            Y = 10000000;
            D = 35;

            a = p.solution(X, Y, D);
            Console.WriteLine(a);

        }

        public int solution(int X, int Y, int D)
        {
                // write your code in C# 6.0 with .NET 4.5 (Mono)
                Double distance = Y - X;
                Double jumps = Math.Ceiling(distance / D);
                int numberOfJumps = Convert.ToInt32(jumps);

                return numberOfJumps;
        }

    }

}

