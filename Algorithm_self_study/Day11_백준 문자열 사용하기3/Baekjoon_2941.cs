using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day11_백준_문자열_사용하기3
{
    class Baekjoon_2941
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int len = 0;
            for(int i=0; i<word.Length; i++)
            {
                //알파벳이 맞는지 확인
                if(word.Length-1 > i)
                {
                    switch (word[i])
                    {
                        case 'c':
                            if (word[i+1] == '=' || word[i+1] == '-')   //c= 와 c-
                                i++;
                            break;
                        case 'd':
                            if (word[i + 1] == '-') //d-
                                i++;
                            else if (word.Length+2 == i && word[i + 1] == 'z' || word[i + 2] == '=')  //dz=
                                i += 2;
                            break;
                        case 'l':
                            if (word[i + 1] == 'j')
                                i++;
                            break;
                        case 'n':
                            if (word[i + 1] == 'j')
                                i++;
                            break;
                        case 's':
                            if (word[i + 1] == '=')
                                i++;
                            break;
                        case 'z':
                            if (word[i + 1] == '=')
                                i++;
                            break;
                    }
                }
                len++;
            }
            Console.WriteLine(len);
        }
    }
}
