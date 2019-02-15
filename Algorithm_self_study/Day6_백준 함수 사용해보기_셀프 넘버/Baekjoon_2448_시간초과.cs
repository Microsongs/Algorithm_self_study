using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day6_백준_함수_사용해보기_셀프_넘버
{
    class Baekjoon_2448_시간초과
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //값을 읽어들임
            int cycle = 1;  //사이클
            for (int i = 0; i < n / 3; i++)    //1사이클 -> 3줄
            {
                //////////////////////
                //사이클은 3줄
                for (int k = 0; k < 3; k++)
                {
                    //맨앞줄 space
                    for (int frontspace = (n - 4) - (i * 3); frontspace >= 0; frontspace--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < cycle; j++)
                    {
                        // 앞줄 space
                        for (int blank = k; blank < 2; blank++)
                        {
                            Console.Write(" ");
                        }
                        // 별
                        for (int star = 0; star < (k * 2) + 1; star++)
                        {
                            if (k == 1 && star == 1)
                            {
                                Console.Write(" ");
                            }
                            else if (cycle >= 3 && cycle % 2 == 1 && j % 2 == 1)
                            {
                                Console.Write(" ");
                            }
                            //1줄
                            else if (cycle >= 5 && cycle % 4 == 1 && j%4 != 0)
                            {
                                Console.Write(" ");
                            }
                            //2줄
                            else if (cycle >= 5 && cycle % 4 == 2 && (j%4 == 2 || j%4 == 3))
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                        //뒷줄 space
                        for (int blank = k; blank < 2; blank++)
                        {
                            Console.Write(" ");
                        }
                        //중간중간 띄어쓰기
                        if (cycle >= 2 && j >= 0)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("\n");
                }
                cycle++;
            }
        }
    }
}
