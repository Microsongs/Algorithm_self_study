using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day4_백준_for문_사용해보기
{
    class Baekjoon_2742
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for(int i=input; i>0; i--)
            {
                Console.Write(i + "\n");
            }
        }
    }
}
