using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day5_백준_if문_사용해보기
{
    class Baekjoon_2884
    {
        static void Main(string[] args)
        {
            // 입력
            string input = Console.ReadLine();
            string[] temp = input.Split();

            // 시간/분에 입력하기
            int hours = int.Parse(temp[0]);
            int minutes = int.Parse(temp[1]);

            //알람 시간 변경하기
            // 1. 45분 이상 남은 경우
            if (minutes >= 45)
            {
                minutes -= 45;
            }
            // 2. 45분 이하 남은 경우
            else
            {
                //0시일 경우
                if(hours == 0)
                {
                    hours = 23;
                }
                else
                {
                    hours--;
                }
                minutes = minutes + 15;   //minutes + 60 - 45
            }
            Console.WriteLine("{0} {1}", hours, minutes);
        }
    }
}
