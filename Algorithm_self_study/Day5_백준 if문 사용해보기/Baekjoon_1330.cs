using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day5_백준_if문_사용해보기
{
    class Baekjoon_1330
    {
        static void Main(string[] args)
        {
            //입력받는 부분
            string input = Console.ReadLine();
            int[] data = new int[2];
            string[] temp = input.Split();
            for(int i=0; i<data.Length; i++)
            {
                data[i] = int.Parse(temp[i]);
            }
            if (data[0] > data[1])
                Console.WriteLine(">");
            else if (data[0] == data[1])
                Console.WriteLine("==");
            else
                Console.WriteLine("<");
        }
    }
}
