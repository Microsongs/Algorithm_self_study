using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day4_백준_for문_사용해보기
{
    class Baekjoon_1924
    {
        static int WhatDay(int month,int date)
        {
            if(month == 1)  //1월달일 경우
            {
                return date % 7;
            }
            else if((month - 1) == 2)   //전 월이 2월달일경우
            {
                return WhatDay(--month, date + 28);
            }
            else if((month-1) == 4 || (month - 1) == 6 || (month - 1) == 9 || (month - 1) == 11){
                return WhatDay(--month, date + 30);
            }
            else
            {
                return WhatDay(--month, date + 31);
            }
        }

        static void Main(string[] args)
        {
            String temp = Console.ReadLine();   //입력
            String[] tmpArray = temp.Split();   //분리
            int month = int.Parse(tmpArray[0]); //월
            int date = int.Parse(tmpArray[1]);  //일
            switch (WhatDay(month, date))
            {
                case 0:
                    Console.Write("SUN");
                    break;
                case 1:
                    Console.Write("MON");
                    break;
                case 2:
                    Console.Write("TUE");
                    break;
                case 3:
                    Console.Write("WED");
                    break;
                case 4:
                    Console.Write("THU");
                    break;
                case 5:
                    Console.Write("FRI");
                    break;
                case 6:
                    Console.Write("SAT");
                    break;
            }
        }
    }
}
