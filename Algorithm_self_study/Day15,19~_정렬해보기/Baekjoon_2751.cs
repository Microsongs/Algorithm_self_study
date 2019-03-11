using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//입출력 속도로 의해 무조건 틀렸다고 나옴 -> C++로 문제풀이
namespace Algorithm_self_study.Day15_19__정렬해보기
{
    class Baekjoon_2751
    {
        static int[] sorted; // = new int[1000000]; //사용될 배열
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] arr = new int[input];
            sorted = new int[input];
            //입력
            for(int i = 0; i < input; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //정렬
            MergeSort(arr, 0, arr.Length-1);
            Print(arr);
        }
        //합병정렬
        static void MergeSort(int[] arr, int Left,int Right)
        {
            if (Left < Right)
            {
                //divide and Conquer, MergeSort를 먼저 호출하여 divide 이후 Merge로 Conquer
                int Mid = (Right + Left) / 2;
                MergeSort(arr, Left, Mid);
                MergeSort(arr, Mid + 1, Right);
                Merge(arr, Left, Mid, Right);
            }
        }

        static void Merge(int[] arr, int Left, int Mid, int Right)
        {
            int first = Left;   //첫 번쨰 배열
            int second = Mid + 1; //두 번째 배열
            int order = Left;   //요소가 들어갈 위치

            //1~10까지인 배열이라면 1~5 / 6~10까지 반반 나눈것이라 보면 된다.
            //첫번째 배열의 시작 위치가 중간보다 작으면서 두번째 배열 위치가 right보다 작거나 같을 때
            while (first <= Mid && second <= Right)
            {
                //앞이 더 작으면 앞의 것을 넣는다.
                if(arr[first] <= arr[second])
                {
                    sorted[order] = arr[first];
                    first++;
                }
                //뒤가 더 작으면 뒤의 것을 넣는다.
                else
                {
                    sorted[order] = arr[second];
                    second++;
                }
                order++;
            }
            //한 배열이 끝났으면 남은 배열을 처리해야 한다.
            //두 번쨰 배열이 남았을 경우
            if(first > Mid)
            {
                for(int t = second; t<=Right; t++, order++)
                {
                    sorted[order] = arr[t];
                }
            }
            else
            {
                for(int t = first; t<=Mid; t++, order++)
                {
                    sorted[order] = arr[t];
                }
            }
            //sorted에 넣은 배열들을 arr에 정리
            for(int t=Left; t<=Right; t++)
            {
                arr[t] = sorted[t];
            }
        }
        //출력 함수
        static void Print(int[] arr)
        {
            foreach(int print in arr)
            {
                Console.Write(print+"\n");
            }
        }
    }
}
