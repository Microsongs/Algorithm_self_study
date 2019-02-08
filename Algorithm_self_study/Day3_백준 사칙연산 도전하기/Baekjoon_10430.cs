using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day3_백준_사칙연산_도전하기
{
    class Baekjoon_10430
    {
        static void Main(string[] args)
        {
            string temp = Console.ReadLine();   //입력
            string[] arr = temp.Split();    //temp 내의 요소 분리하여 arr에 저장
            //숫자 저장
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);

            //첫 번째 연산 (A+B)%C
            Console.WriteLine((a + b) % c);

            //두 번째 연산 (A%C + B%C)%C
            Console.WriteLine((a % c + b % c) % c);

            //세 번째 연산 (A*B)%C
            Console.WriteLine((a * b) % c);

            //네 번째 연산 (A%C * B%C)%C
            Console.WriteLine((a % c * b % c) % c);
        }
    }
}
