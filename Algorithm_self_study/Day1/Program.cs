using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Algorithm_self_study
{
    class Program
    {
        static int zero;
        static int one;
        static int[] dynamic;
        static int fibonacci(int n)
        {
            if (n == 0)
            {
                zero++;
                return dynamic[n];
            }
            else if (n == 1)
            {
                one++;
                return dynamic[n];
            }
            else if(dynamic[n] != 0)
            {
                return dynamic[n];
            }
            else
            {
                dynamic[n] = fibonacci(n - 1) + fibonacci(n - 2);
                return dynamic[n];
            }
        }
        
        static void Main(string[] args)
        {
            //입력 횟수
            int cycle;
            cycle = int.Parse(Console.ReadLine());
            dynamic = new int[1000];    //적당한 배열 크기
            dynamic[0] = 0;
            dynamic[1] = 1;

            int temp;   //입력 변수
            //입력 횟수만큼 반복
            for(int i = 0; i < cycle; i++)
            {
                temp = int.Parse(Console.ReadLine());   //임시 변수에 저장
                fibonacci(temp);
                if (temp == 0)
                {
                    Console.WriteLine(1 + " " + 0);
                }
                else
                {
                    Console.WriteLine(dynamic[temp-1] + " " + dynamic[temp]);
                }
            }
        }
    }
}
