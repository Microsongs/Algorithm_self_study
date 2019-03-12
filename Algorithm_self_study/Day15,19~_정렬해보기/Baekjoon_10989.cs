using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day15_19__정렬해보기
{
    class Baekjoon_10989
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] arr = new int[10001];
            for(int i=0; i<count; i++)
            {
                arr[int.Parse(Console.ReadLine())]++;
            }
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    for(int arri = 0; arri < arr[i]; arri++)
                    {
                        Console.Write(i + "\n");
                    }
                }
            }
        }
    }
}
