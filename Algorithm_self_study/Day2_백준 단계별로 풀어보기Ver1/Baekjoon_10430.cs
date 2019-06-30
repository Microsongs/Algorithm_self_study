using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day2_백준_단계별로_풀어보기Ver1
{
    class Baekjoon_10430
    {
        static void Main(string[] args)
        {
            //i nput에 값을 넣고 temp배열로 임시치환 후 int형 데이터로 변경
            string input = Console.ReadLine();
            string[] temp = input.Split();
            int[] data = new int[temp.Length];
            for (int i=0; i<temp.Length; i++)
            {
                data[i] = int.Parse(temp[i]);
            }

            //값 출력
            Console.Write("{0}\n{1}\n{2}\n{3}\n",
                (data[0] + data[1]) % data[2],
                (data[0] % data[2] + data[1] % data[2]) % data[2],
                (data[0] * data[1]) % data[2],
                (data[0] % data[2] * data[1] % data[2]) % data[2]);
        }
    }
}
