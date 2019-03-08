using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day15_19__정렬해보기
{
    class Baekjoon_2751
    {
        static int[] sorted = new int[1000000];
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            int[] array = new int[len];
            StringBuilder stb = new StringBuilder();
            //sorted = new int[len*2];
            for(int i=0; i<len; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            MergeSort(array, 0, array.Length-1);
            foreach(int arr in array)
            {
                //Console.Write(arr+"\n");
                stb.Append(arr);
                stb.Append("\n");
            }
            Console.Write(stb);
        }

        static void MergeSort(int[] arr, int First, int Last)
        {
            if(First < Last)
            {
                int Middle = (First + Last) / 2;
                MergeSort(arr, First, Middle);      //분리
                MergeSort(arr, Middle + 1, Last);   //분리
                Merge(arr, First, Middle, Last);    //합병
            }
        }
        static void Merge(int[] arr, int First, int Middle, int Last)
        {

            int i, j, k, t;
            i = First;  //쪼개진 첫번째 배열의 인덱스
            j = Middle + 1; //쪼개진 두번쨰 배열의 인덱스
            k = First;  //합칠 인덱스

            while(i <= Middle && j <= Last)    //i가 middle보다 작으면서 j가 Last보다 작을 경우
            {
                if (arr[i] <= arr[j])   //앞이 더 작으면 앞에 넣고
                    sorted[k] = arr[i++];
                else if (arr[i] > arr[j])   //뒤가 더 작으면 뒤에 넣는다.
                    sorted[k] = arr[j++];
                k++;    
            }
            //배열의 남는 부분 처리
            if(i > Middle)
            {
                for(t = j; t <= Last; t++)
                {
                    sorted[k++] = arr[t];
                }
            }
            else
            {
                for(t = i; t <= Last; t++)
                {
                    sorted[k++] = arr[t];
                }
            }
            //정렬 이후 원래 배열에 대입
            for(t=First; t<=Last; t++)
            {
                arr[t] = sorted[t];
            }
            /*
            //정렬 과정을 출력
            Console.WriteLIne("합병 정렬 ↓");
            foreach(int data in arr){
                Console.WriteLine(data);
            }
            Console.WriteLine();
            */
        }
    }
}
