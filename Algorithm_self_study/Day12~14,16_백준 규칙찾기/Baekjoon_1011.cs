using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Algorithm_self_study.Day12_13_백준_규칙찾기
{
    class Baekjoon_1011
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int i=0; i<T; i++) {
                string input = Console.ReadLine();
                string[] data = input.Split();
                int x, y;
                x = int.Parse(data[0]);
                y = int.Parse(data[1]);
                int n = 1;
                while (Math.Pow(n,2) < (y - x)) //1234321같이 되는 경우는 최대가 n^2였다.
                {
                    n++;
                }
                n = ((y - x) > Math.Pow(n, 2) - n) ? n * 2 - 1 : n * 2 - 2; //n^2-n보다 작으면 2n-2회, 아니면 2n-1회이다.
                Console.WriteLine(n);
            }
        }
    }
}
