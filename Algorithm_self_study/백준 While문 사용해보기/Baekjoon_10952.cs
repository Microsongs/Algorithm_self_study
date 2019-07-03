using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.백준_While문_사용해보기
{
    class Baekjoon_10952
    {
        static void Main(string[] args)
        {
            string input;
            string[] temp;
            int a, b;
            while (true)
            {
                input = Console.ReadLine();
                temp = input.Split();
                a = int.Parse(temp[0]);
                b = int.Parse(temp[1]);
                if ((a == 0) && (b == 0))
                    break;
                else
                    Console.WriteLine(a+b);
            }
        }
    }
}
