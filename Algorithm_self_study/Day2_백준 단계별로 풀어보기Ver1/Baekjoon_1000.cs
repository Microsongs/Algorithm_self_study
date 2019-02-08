using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day2_백준_단계별로_풀어보기Ver1
{
    class Baekjoon_1000
    {
        static void Main(String[] args)
        {
            //a+b 출력 문제
            string s = Console.ReadLine();
            string[] p = s.Split(); //안의 내용 분리
            int a = int.Parse(p[0]);
            int b = int.Parse(p[1]);
            Console.WriteLine(a + b);
        }
    }
}
