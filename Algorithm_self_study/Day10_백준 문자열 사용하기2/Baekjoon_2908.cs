using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day10_백준_문자열_사용하기2
{
    class Baekjoon_2908
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] number = input.Split();
            int n1, n2;
            n1 = int.Parse(number[0]);  //첫번쨰 숫자
            n2 = int.Parse(number[1]);  //두번째 숫자
            n1 = ((n1 % 10) * 100) + (n1/10%10)*10 + n1/100;
            n2 = ((n2 % 10) * 100) + (n2 / 10 % 10) * 10 + n2 / 100; ;
            Console.WriteLine((n1 > n2) ? n1 : n2);
        }
    }
}
