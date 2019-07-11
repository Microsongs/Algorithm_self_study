using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.백준_1차원_배열_사용하기
{
    class Baekjoon_10818
    {
        static void Main(string[] args)
        {
            //배열 최대값을 입력받는 부분
            int len = int.Parse(Console.ReadLine());

            //배열의 최대&최소값을 저장하는 변수
            int max, min;

            //배열 내부 데이터를 입력받는 부분
            string input = Console.ReadLine();
            string[] temp = input.Split();

            int[] arr = new int[temp.Length];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(temp[i]);
            }

            //최대값과 최소값을 찾는 부분
            max = arr[0];
            min = arr[0];
            for(int i = 1; i<arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    continue;
                }
                if (min > arr[i])
                {
                    min = arr[i];
                    continue;
                }
            }

            //결과를 출력
            Console.Write("{0} {1}", min, max);
        }
    }
}
