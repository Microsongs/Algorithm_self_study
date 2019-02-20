using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day9_백준_문자열_사용하기1
{
    class Baekjoon_2675
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());  //개수
            for (int i = 0; i < count; i++) //입력받는 횟수
            {
                string input = Console.ReadLine();
                for(int j=2; j<input.Length; j++)   //2번쨰 인자부터 길이-1까지 반복
                {
                    for (int k = 0; k < (int)input[0]-'0'; k++)
                    {
                        Console.Write(input[j]);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
