using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day12_14_백준_규칙찾기
{
    class Baekjoon_10250
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());  //테스트 케이스
            int H, W, N;   //H는 층수 / W는 방수 / N은 n번째 사람;
            int currentFloor;   //현재 층
            int currentRoom;    //현재 방
            for(int i=0; i<T; i++)
            {
                string str = Console.ReadLine();    //W, H, 손님 입력
                string[] temp = str.Split();    //분리
                H = int.Parse(temp[0]);
                W = int.Parse(temp[1]);
                N = int.Parse(temp[2]);

                if (N % H == 0) //N이 H의 배수일 경우
                {
                    currentFloor = H;
                    currentRoom = N / H;
                }
                else
                {
                    currentFloor = (N % H);
                    currentRoom = N / H + 1;
                }
                if (currentRoom >= 10)  //01~09 이후
                {
                    Console.WriteLine(currentFloor + "" + currentRoom);
                }
                else
                {
                    Console.WriteLine(currentFloor + "0" + currentRoom);
                }
            }
        }
    }
}
