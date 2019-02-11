using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day5_백준_if문_사용해보기
{
    class Baekjoon_1110
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());  //값 입력

            //변하는 값
            int changeValue = value;

            //카운트
            int cnt = 0;
            do
            {
                int one = changeValue % 10;
                changeValue = ((changeValue / 10) + (one));
                changeValue = changeValue % 10 + one * 10;
                cnt++;
            } while (changeValue != value);
            Console.WriteLine(cnt);
        }
    }
}
