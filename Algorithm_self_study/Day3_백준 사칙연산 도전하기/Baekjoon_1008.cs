using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day3_백준_사칙연산_도전하기
{
    class Baekjoon_1008
    {
        static void Main(string[] args)
        {
            String temp = Console.ReadLine();
            String[] divide = temp.Split();
            decimal a = decimal.Parse(divide[0]);
            decimal b = decimal.Parse(divide[1]);
            Console.WriteLine(a / b);
        }
    }
}
