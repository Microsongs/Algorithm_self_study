using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day8_백준_1차원_배열_사용하기2
{
    class Baekjoon_10039
    {
        static void Main(string[] args)
        {
            int[] stu = new int[5];
            int sum = 0;
            for(int i = 0; i < 5; i++)
            {
                stu[i] = int.Parse(Console.ReadLine());
                if(stu[i] < 40)
                {
                    stu[i] = 40;
                }
                sum += stu[i];
            }
            Console.WriteLine(sum / 5);
        }
    }
}
