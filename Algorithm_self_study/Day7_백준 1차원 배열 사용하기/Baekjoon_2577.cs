using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day7_백준_1차원_배열_사용하기
{
    class Baekjoon_2577
    {
        static void Main(string[] args)
        {
            int multiple = 0;
            int[] arr = new int[10];    //0~9
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            multiple = n1 * n2 * n3;
            do
            {
                arr[multiple % 10]++;
                multiple /= 10;
            } while (multiple != 0);
            foreach(int result in arr)
            {
                Console.WriteLine(result);
            }
        }
    }
}
