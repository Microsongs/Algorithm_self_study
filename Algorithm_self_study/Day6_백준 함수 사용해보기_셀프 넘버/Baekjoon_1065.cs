using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day6_백준_함수_사용해보기_셀프_넘버
{
    class Baekjoon_1065
    {
        static int Hansu(int n)
        {
            int cnt = 0;
            int[] tmpNum = new int[4];
            for(int i=1; i<=n; i++)
            {
                if(i >= 1 && i < 100)
                {
                    cnt++;
                }
                else
                {
                    int a, b, c;
                    a = i / 100;
                    b = (i / 10) % 10;
                    c = i % 10;
                    if(b-a == c-b)
                    {
                        cnt++;
                    }
                    /*
                    int count = 0;
                    for(int temp = i; temp!=0; temp /= 10)
                    {
                        tmpNum[count++] = temp % 10;
                    }
                    if((tmpNum[1] - tmpNum[0]) == (tmpNum[2] - tmpNum[1]))
                    {
                        cnt++;
                    }
                    */
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //입력
            Console.WriteLine(Hansu(n));
        }
    }
}
