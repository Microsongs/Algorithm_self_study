using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.백준_1차원_배열_사용하기
{
    class Baekjoon_2562
    {
        static void Main(string[] args)
        {
            int[] arr = new int[9];
            // 입력 받는 부분
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // 최대 값과 위치를 찾는 부분
            int max = arr[0];
            int loc = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    loc = i;
                }
            }

            // 값을 출력하는 부분
            Console.Write("{0}\n{1}\n", max, ++loc);
        }
    }
}
