using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day4_백준_for문_사용해보기
{
    class Baekjoon_2439
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++) //n번 반복
            {
                for(int j=n; j>i; j--)
                {
                    Console.Write(" ");
                }
                for(int j=0;j<i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
