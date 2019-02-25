using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day12_백준_규칙찾기1
{
    class Baekjoon_2292
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //입력받는 수
            int bee = 1;  //지나가는 벌집 수
            int cnt = 0;
            do
            {
                bee = bee + (6 * cnt++);
            } while (n > bee);
            Console.WriteLine(cnt);
        }
    }
}
