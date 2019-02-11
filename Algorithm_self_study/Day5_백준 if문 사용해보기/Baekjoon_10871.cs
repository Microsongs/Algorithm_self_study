using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day5_백준_if문_사용해보기
{
    class Baekjoon_10871
    {
        static void Main(string[] args)
        {
            string temp = Console.ReadLine();
            string []inputData = temp.Split();

            temp = Console.ReadLine();
            string[] resultData = temp.Split();
            foreach(string result in resultData)
            {
                if (int.Parse(inputData[1]) > int.Parse(result))
                {
                    Console.Write(int.Parse(result) + " ");
                }
            }
        }
    }
}
