using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day4_백준_for문_사용해보기
{
    class Baekjoon_8393
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.Write(sum);
        }
    }
}
