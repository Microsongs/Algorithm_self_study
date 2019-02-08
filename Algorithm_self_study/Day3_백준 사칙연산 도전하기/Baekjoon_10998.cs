using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day3_백준_사칙연산_도전하기
{
    class Baekjoon_10998
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] multiple = s.Split();
            int a = int.Parse(multiple[0]);
            int b = int.Parse(multiple[1]);
            Console.WriteLine(a * b);
        }
    }
}
