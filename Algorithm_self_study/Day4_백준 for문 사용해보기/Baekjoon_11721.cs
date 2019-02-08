using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day4_백준_for문_사용해보기
{
    class Baekjoon_11721
    {
        static void Main(string[] args)
        {
            string temp = Console.ReadLine();
            for(int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i]);
                if (i % 10 == 9)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}
