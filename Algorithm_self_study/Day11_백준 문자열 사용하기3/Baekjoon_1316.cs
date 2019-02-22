using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day11_백준_문자열_사용하기3
{
    class Baekjoon_1316
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int groupChecker = 0;
            bool state = false;
            for(int i=0; i<number; i++)
            {
                int[] alphabet = new int[26];
                string word = Console.ReadLine();   //문자열 입력
                for(int j=0; j<word.Length; j++)
                {
                    if(alphabet[word[j] - 'a'] == 0)    //처음 나오는 단어인가?
                    {
                        alphabet[word[j] - 'a'] = 1;
                    }
                    else if(alphabet[word[j] - 'a'] == 1 && (word[j-1] != word[j])) //앞뒤로 다른 단어이면서 이미 들어가있는 단어일 경우
                    {
                        alphabet[word[j] - 'a'] = 2;
                    }
                }
                //개수 체크
                foreach(int checker in alphabet)
                {
                    if(checker == 2)
                    {
                        state = false;
                        break;
                    }
                    if(checker == 1)
                    {
                        state = true;
                    }
                }
                groupChecker = (state == true) ? groupChecker+1 : groupChecker;
            }
            Console.Write(groupChecker);
        }
    }
}
