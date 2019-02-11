using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day5_백준_if문_사용해보기
{
    class Baekjoon_10817
    {
        static void Main(string[] args)
        {
            //세 수
            string temp = Console.ReadLine();
            string[] arr = temp.Split();

            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);
            int result;

            if (a >= b && a >= c)   //a가 제일 클 경우
            {
                result = (b >= c) ? b : c;
            }
            else if(b >= c && b >= a)
            {
                result = (a >= c) ? a : c;
            }
            else
            {
                result = (a >= b) ? a : b;
            }
            Console.WriteLine(result);
        }
    }
}
