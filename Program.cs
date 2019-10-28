using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int result = 0;
            int N = 1041;
            result = p.solution(N);
            Console.WriteLine(result);
            N = 5;
            result = p.solution(N);
            Console.WriteLine(result);
            N = 15;
            result = p.solution(N);
            Console.WriteLine(result);
            N = 252424583;
            result = p.solution(N);
            Console.WriteLine(result);

        }

        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string binary = Convert.ToString(N, 2);
            int longest = 0;
            int currentNum = 0;
            bool first = false;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0' && first)
                {
                    if (currentNum > 0)
                    {
                        currentNum++;
                    }
                    else currentNum = 1;
                }
                if (binary[i] == '1')
                {
                    if (!first)
                    {
                        first = true;
                    }
                    if (currentNum > longest)
                    {
                        longest = currentNum;
                    }
                    currentNum = 0;
                }

            }

            return longest;
        }
    }

}
