using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day10_백준_문자열_사용하기2
{
    class Baekjoon_5622V2
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int time = 0;
            for(int i=0; i<word.Length; i++)
            {
                time++;
                if (word[i] >= 'W' && word[i] <= 'Z')
                    time += 9;
                else if (word[i] >= 'T')
                    time += 8;
                else if (word[i] >= 'P')
                    time += 7;
                else if (word[i] >= 'M')
                    time += 6;
                else if (word[i] >= 'J')
                    time += 5;
                else if (word[i] >= 'G')
                    time += 4;
                else if (word[i] >= 'D')
                    time += 3;
                else if (word[i] >= 'A')
                    time += 2;
                else
                    time++;
            }
            Console.WriteLine(time);
        }
    }
}
