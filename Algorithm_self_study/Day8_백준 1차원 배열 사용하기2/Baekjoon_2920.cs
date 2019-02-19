using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day8_백준_1차원_배열_사용하기2
{
    class Baekjoon_2920
    {
        static void check(string[] data, int op)
        {
            for(int i = 2; i < data.Length; i++)
            {
                if(int.Parse(data[i]) != int.Parse(data[0]) + (i * op))
                {
                    Console.WriteLine("mixed");
                    return;
                }
            }
            if (op == -1)
            {
                Console.WriteLine("descending");
            }
            else {
                Console.WriteLine("ascending");
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] data = input.Split();
            int tmp = int.Parse(data[0]);
            if(int.Parse(data[1]) == tmp + 1)
            {
                check(data, 1);
            }
            else if(int.Parse(data[1]) == tmp - 1)
            {
                check(data, -1);
            }
            else
            {
                Console.WriteLine("mixed");
            }
        }
    }
}
