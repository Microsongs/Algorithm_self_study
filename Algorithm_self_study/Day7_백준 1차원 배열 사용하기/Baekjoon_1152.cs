using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day7_백준_1차원_배열_사용하기
{
    class Baekjoon_1152
    {
        static void Main(string[] args)
        {
            int size;
            string str = Console.ReadLine();
            string[] tmp = str.Split();
            size = tmp.Length;
            if(str.IndexOf(" ") == 0)
            {
                size--;
            }
            if(str.LastIndexOf(" ") == str.Length-1)
            {
                size--;
            }
            Console.WriteLine(size);
        }
    }
}
