using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day12_14_백준_규칙찾기
{
    class Baekjoon_2775
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());  //입력
            int[,] arr; //dp를하기위한 2차원 배열
            for (int i=0; i < input; i++)    //반복
            {
                int floor = int.Parse(Console.ReadLine());  //층수
                int people = int.Parse(Console.ReadLine());  //n명
                arr = new int[floor+1, people+1];    //k,n의 배열 생성
                for (int j=1; j <= people; j++)
                {
                    arr[0, j] = j;  //0층의 j번째는 j이다.
                }
                for(int j=1; j<=floor; j++) //층수
                {
                    for(int k=1; k<=people; k++) //명수
                    {
                        if (k == 1)
                            arr[j, k] = 1;
                        else
                            arr[j, k] = arr[j - 1, k] + arr[j, k - 1];
                    }
                }
                Console.WriteLine(arr[floor,people]);
            }
        }
    }
}
