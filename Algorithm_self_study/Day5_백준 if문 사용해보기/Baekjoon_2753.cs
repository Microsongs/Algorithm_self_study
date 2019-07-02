using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day5_백준_if문_사용해보기
{
    class Baekjoon_2753
    {
        static void Main(string[] args)
        {
            // 입력
            int year = int.Parse(Console.ReadLine());

            // 윤년 체크
            if (year % 400 == 0)   //윤년
                Console.Write("1");
            else if (year % 100 == 0)   //윤년아님
                Console.Write("0");
            else if (year % 4 == 0) //윤년
                Console.Write("1");
            else    //윤년아님
                Console.Write("0");
        }
    }
}
