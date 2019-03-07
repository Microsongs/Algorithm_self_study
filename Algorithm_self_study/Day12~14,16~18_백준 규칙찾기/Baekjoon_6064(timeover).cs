using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day12_14_16_18_백준_규칙찾기
{
    class Baekjoon_6064
    {
        static void Main(string[] args)
        {
            int cycle = int.Parse(Console.ReadLine());
            for(int i = 0; i < cycle; i++)
            {
                string tempData = Console.ReadLine();
                string[] splitData = tempData.Split();
                int M = int.Parse(splitData[0]);
                int N = int.Parse(splitData[1]);
                int x = int.Parse(splitData[2]);
                int y = int.Parse(splitData[3]);
                int year = 0;
                int myX = 1, myY = 1;
                //Console.WriteLine("x = " + x + "y = " + y);
                while (myX != M || myY != N)
                {
                    year++;
                    if (myX == M)
                    {   //myX가 X랑 동일할 경우
                        myX = 0;
                    }
                    if (myY == N)   //myY랑 N이랑 동일한 경우
                    {
                        myY = 0;
                    }
                    if (myX < M)  //myX가 M보다 작을 경우
                        myX++;
                    if (myY < N)
                        myY++;

                    if (myX == x && myY == y)   //myX가 X랑 동일하면서 myY가 Y일 때 탈출
                        break;
                }
                if (myX == M && myY == N)
                {
                    Console.WriteLine("-1");
                }
                else
                    Console.WriteLine(year+1);
            }
        }
    }
}
