using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day10_백준_문자열_사용하기2
{
    class Baekjoon_5622
    {
        static void Main(string[] args)
        {
            string phone = Console.ReadLine();
            int time = 0;
            for (int i = 0; i < phone.Length; i++)
            {
                time++;
                switch (phone[i])
                {
                    case 'A':
                    case 'B':
                    case 'C':
                        time += 2;
                        break;
                    case 'D':
                    case 'E':
                    case 'F':
                        time += 3;
                        break;
                    case 'G':
                    case 'H':
                    case 'I':
                        time += 4;
                        break;
                    case 'J':
                    case 'K':
                    case 'L':
                        time += 5;
                        break;
                    case 'M':
                    case 'N':
                    case 'O':
                        time += 6;
                        break;
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                        time += 7;
                        break;
                    case 'T':
                    case 'U':
                    case 'V':
                        time += 8;
                        break;
                    case 'W':
                    case 'X':
                    case 'Y':
                    case 'Z':
                        time += 9;
                        break;
                    default:
                        time += 1;
                        break;
                }
            }
            Console.WriteLine(time);
        }
    }
}
