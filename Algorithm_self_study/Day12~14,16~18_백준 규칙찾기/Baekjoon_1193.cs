using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day12_13_백준_규칙찾기
{
    class Baekjoon_1193
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //숫자 입력
            int p = 0;      //숫자
            int cnt = 0;    //몇 번째 위치에 있는지
            int nume, deno; //분자/분모
            for (p = 0; n > p + cnt; p += cnt, cnt++) ;
            int temp = p + cnt - n;
            if(cnt%2 == 1)  //1로 나뉘는 경우 ->  분모가 내려갈수록 작아지고 분자가 내려갈수록 커짐
            {
                nume = 1 + temp;
                deno = cnt - temp;
            }
            else //0으로 나뉘는 경우 -> 분모가 내려갈수록 커지고 분자가 내려갈수록 작아짐
            {
                nume = cnt - temp;
                deno = 1 + temp;
            }
            Console.WriteLine(nume + "/" + deno);
        }
    }
}
