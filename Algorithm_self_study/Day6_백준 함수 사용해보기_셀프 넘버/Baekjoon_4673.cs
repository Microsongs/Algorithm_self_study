using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day6_백준_함수_사용해보기
{
    class Baekjoon_4673
    {
        static int NumberCheck(int n)
        {
            for (int temp = n; temp != 0; temp /= 10)
            {
                n += temp % 10;
            }
            return n;
        }
        static void Main(string[] args0)
        {
            int n = 0;
            int[] arr = new int[10001];
            arr[0] = 1;
            for (int i = 1; i < 10000; i++)    //2부터 10001까지 삽입
            {
                arr[i] = arr[i - 1] + 1;
            }
            for(int i=0; i<10000; i++)
            {
                if(arr[i] != 0) //0이 아닐 경우
                {
                    n = i + 1;
                    while(n < 10000)
                    {
                        n = NumberCheck(n);
                        if(n <= 10000)
                        {
                            arr[n-1] = 0;
                        }
                    }
                }
            }
            for(int i = 0; i < 10000; i++)
            {
                if(arr[i] != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
