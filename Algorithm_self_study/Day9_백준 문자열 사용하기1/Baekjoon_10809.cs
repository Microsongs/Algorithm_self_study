using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day9_백준_문자열_사용하기1
{
    class Baekjoon_10809
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[] alphabet = new int[26];   //알파벳을 담는 배열
            int i = 0;
            for(int j=0; j<26; j++)
            {
                alphabet[j] = -1;   //일단 전부 -1 삽입
            }
            
            foreach(char ch in s)
            {
                int location = ch - 'a';    //알파벳 숫자 찾기
                if(alphabet[location] == -1)
                {
                    alphabet[location] = i;
                }
                i++;
            }
            foreach(int temp in alphabet)
            {
                Console.Write(temp + " ");
            }
        }
    }
}
