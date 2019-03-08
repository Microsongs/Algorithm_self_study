using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day15_정렬해보기
{
    class baekjoon_2750
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] arr = new int[input];
            for(int i = 0; i < input; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Bubble(arr);
            foreach(int data in arr)
            {
                Console.WriteLine(data);
            }
        }
        //Bubble Sort
        static void Bubble(int[] data)
        {
            for(int i=0; i<data.Length; i++)
            {
                for(int j=i; j<data.Length; j++)
                {
                    if(data[i] > data[j])   //앞에있는 수가 더 클경우 스왑
                    {
                        Swap(ref data[i], ref data[j]);
                    }
                }
            }
        }

        //Swap 함수
        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
