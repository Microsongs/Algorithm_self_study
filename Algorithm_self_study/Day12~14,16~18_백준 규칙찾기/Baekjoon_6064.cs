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
            for(int i=0; i<cycle; i++)  //싸이클
            {
                string tempInput = Console.ReadLine();
                string []tempData = tempInput.Split();
                int M = int.Parse(tempData[0]);
                int N = int.Parse(tempData[1]);
                int X = int.Parse(tempData[2]);
                int Y = int.Parse(tempData[3]);
                //이론
                //X값은 lcmNum을 넘지 않는다.
                //X == Y일경우 year이 나오고, 아니면 -1이다.
                /*
                 M = 10 N = 12, X = 3, Y = 9
                 3 < 9 이므로      X->13 Y->9
                 13 > 9 이므로     X->13 Y->21
                 13 < 21 이므로    X->23 Y->21
                 23 > 21 이므로    X->23 Y->33
                 23 < 33 이므로    X->33 Y->33
                 X == Y이므로 year은 X
                */

                int lcmNum = LCM(M, N);
                Console.WriteLine(lcmNum);
                while(X != Y && X <= lcmNum)
                {
                   Console.WriteLine("X : " + X + " " + "Y : " + Y);
                    if (X < Y)
                        X += M;
                    else
                        Y += N;
                }
                if (X != Y)
                    Console.WriteLine("-1");
                else
                    Console.WriteLine(X);
            }
        }
        //최대공약수
        static int GCD(int a,int b)
        {
            while(b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        //최소공배수
        static int LCM(int a,int b)
        {
            return a * b / GCD(a, b);
        }
    }
}
