using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day2_백준_단계별로_풀어보기Ver1
{
    class Baekjoon_1001
    {
        static void Main(string[] args)
        {
            //a-b 출력 문제
            string s = Console.ReadLine();
            string[] minus = s.Split();
            int a = int.Parse(minus[0]);
            int b = int.Parse(minus[1]);
            Console.WriteLine(a - b);
        }
    }
}
