using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day7_백준_1차원_배열_사용하기
{
    class Baekjoon_8958
    {
        static void Main(string[] args)
        {
            // 개수 입력
            int cnt = int.Parse(Console.ReadLine());

            for(int i = 0; i < cnt; i++)
            {
                // 문자열 입력
                string word = Console.ReadLine();
                // 반복문으로 내부 문자 비교
                int sum = 0;    // 결과값
                int score = 1;  //기본 값 
                for(int j=0; j<word.Length; j++)
                {
                    if(word[j] == 'O')
                    {
                        sum += score;
                        score++;
                    }
                    else
                    {
                        score = 1;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
