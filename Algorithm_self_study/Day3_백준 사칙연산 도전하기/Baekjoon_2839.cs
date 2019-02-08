using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day3_백준_사칙연산_도전하기
{
    class Baekjoon_2839
    {
        static int sugar(int n)
        {
            int result = 0; //결과값을 저장할 변수
            while(n > 0)    //n이 0보다 클 동안
            {
                if(n % 5 == 0)  //5로 나눈 나머지가 0이면 실행
                {
                    n -= 5;
                    result++;
                }
                else if(n % 3 == 0) //3으로 나는 나머지가 0이면 실행
                {
                    n -= 3;
                    result++;
                } 
                else    //둘 다 아닐경우
                {
                    if (n >= 5) //n이 5보다 클 경우 일단 제일 큰 5를 뺸다
                    {
                        n -= 5;
                        result++;
                    }
                    else //5보다 작다는 것은 답이 나오지 않음을 의미
                    {
                        return -1;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            //일단 입력을 받는다.
            int temp = int.Parse(Console.ReadLine());
            Console.WriteLine(sugar(temp));
        }
    }
}
