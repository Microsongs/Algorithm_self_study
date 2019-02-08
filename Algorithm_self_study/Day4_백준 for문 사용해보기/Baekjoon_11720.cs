using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day4_백준_for문_사용해보기
{
    class Baekjoon_11720
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //입력받을 개수
            String temp = Console.ReadLine();
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += temp[i] - '0';
            }
            Console.Write(sum);
        }
    }
}
