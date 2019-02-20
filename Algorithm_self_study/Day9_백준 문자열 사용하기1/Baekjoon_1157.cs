using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day9_백준_문자열_사용하기1
{
    class Baekjoon_1157
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();    //문자열 입력
            int[] alphabet = new int[26];   //알파벳 수
            bool sameNumber = false;    //같은수 여부
            int max = 0;            //최대값
            char maxAlphabet;   //최대알파벳
            foreach(char tmp in str)
            {
                if(tmp >= 'A' && tmp <= 'Z')    //대문자 케이스
                {
                    alphabet[tmp - 'A']++;
                }
                else    //소문자 케이스
                {
                    alphabet[tmp - 'a']++;
                }
            }
            max = alphabet[0];
            maxAlphabet = 'A';
            for(int i = 1; i < 26; i++)
            {
                if(alphabet[i] > max)
                {
                    max = alphabet[i];
                    maxAlphabet = (char)(i + 'A');
                    sameNumber = false;
                }
                else if(alphabet[i] == max)
                {
                    sameNumber = true;
                }
            }

            if(sameNumber == false)
            {
                Console.Write((char)(maxAlphabet));
            }
            else
            {
                Console.Write("?");
            }
        }
    }
}
