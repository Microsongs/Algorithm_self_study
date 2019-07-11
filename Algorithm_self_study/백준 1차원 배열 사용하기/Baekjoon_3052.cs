using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.백준_1차원_배열_사용하기
{
    class Baekjoon_3052
    {
        static void Main(string[] args)
        {
            // 입력(10개)
            int[] arr = new int[10];

            //나머지의 개수를 보관할 변수
            int[] remainder = new int[42];

            //0이 아닌 것의 개수를 세는 변수
            int cnt = 0;

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //나머지에 넣는다.
            for(int i=0; i<arr.Length; i++)
            {
                remainder[arr[i]%42]++;
            }

            //0이 아닌 것의 개수를 세서 출력
            foreach(int data in remainder)
            {
                if (data != 0)
                    cnt++;
            }
            Console.Write(cnt);
        }
    }
}
