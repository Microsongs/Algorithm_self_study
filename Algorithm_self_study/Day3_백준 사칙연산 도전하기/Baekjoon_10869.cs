using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day3_백준_사칙연산_도전하기
{
    class Baekjoon_10869
    {
        static void Main(string[] args)
        {
            string temp = Console.ReadLine();
            string[] all = temp.Split();
            int a = int.Parse(all[0]);
            int b = int.Parse(all[1]);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
    }
}
