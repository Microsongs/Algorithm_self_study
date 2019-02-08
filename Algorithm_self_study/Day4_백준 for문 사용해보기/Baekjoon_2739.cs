using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day4_백준_for문_사용해보기
{
    class Baekjoon_2739
    {
        static void Main(string[] args)
        {
            // 입력 받기
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= 9; i++)
            {
                Console.Write(n + " * " + i + " = " + (n * i) + "\n");
            }
        }
    }
}
