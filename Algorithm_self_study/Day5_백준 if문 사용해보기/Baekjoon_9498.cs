using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day5_백준_if문_사용해보기
{
    class Baekjoon_9498
    {
        static void Main(string[] args)
        {
            //문제 : 시험 성적
            int value = int.Parse(Console.ReadLine());

            if(value >= 90 && value <= 100) //90 <= x <= 100
            {
                Console.WriteLine("A");
            }
            else if(value >= 80 && value < 90)  //80 <= x < 90
            {
                Console.WriteLine("B");
            }
            else if(value >= 70 && value < 80)  //70 <= x < 80
            {
                Console.WriteLine("C");
            }
            else if(value >= 60 && value < 70)  //60 <= x < 70
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
