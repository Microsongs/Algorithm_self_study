using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day12_14_16_17_백준_규칙찾기
{
    class Baekjoon_1475
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int temp = 0;
            int[] set = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int cycle = 1;
            for (int i = input; i != 0; i /= 10)
            {
                temp = i % 10;
                if (set[temp] >= 1) //temp의 값이 1이상 있을경우
                    set[temp]--;
                else if ((temp == 6 || temp == 9) && (set[6] >= 1 || set[9] >= 1)) //6이나 9이면서 6ㅣㅇ나 9 카드가 있을 경우
                {
                    if (set[6] >= 1)
                        set[6]--;
                    else if (set[9] >= 1)
                        set[9]--;
                }
                else    //안에 카드가 없을 경우
                {
                    for (int j = 0; j < 10; j++)
                    {
                        set[j]++;
                    }
                    cycle++;
                    set[temp]--;
                }
            }
            Console.WriteLine(cycle);
        }
    }
}
