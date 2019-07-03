using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day4_백준_for문_사용해보기
{
    class Baekjoon_11022
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());    //길이 입력
            int answer;
            int a, b;
            string input;
            string[] temp;

            //숫자들 입력
            for (int i = 0; i < len; i++)
            {
                input = Console.ReadLine();
                temp = input.Split();
                a = int.Parse(temp[0]);
                b = int.Parse(temp[1]);
                answer = a + b;
                Console.WriteLine("Case #{0}: {1} + {2} = {3}", (i + 1), a, b, answer);
            }
        }
    }
}
