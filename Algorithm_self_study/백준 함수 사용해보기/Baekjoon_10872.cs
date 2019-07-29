using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.백준_함수_사용해보기
{
    class Baekjoon_10872
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(factorial(n));
        }
        static int factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * factorial(n - 1);
        }
    }
}
