using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day5_백준_if문_사용해보기
{
    class Baekjoon_4344
    {
        static void Main(string[] args)
        {
            //테스트 케이스의 개수
            int len = int.Parse(Console.ReadLine());
            //반복문
            for (int i = 0; i < len; i++)
            {
                string temp = Console.ReadLine();
                string[] tempData = temp.Split();
                double avg = 0;
                double result = 0;
                int cnt = 0;    //넘는 사람들의 수
                
                //평균 구하기
                for(int j = 1; j < int.Parse(tempData[0])+1; j++)   //개수만큼반복
                {
                    avg += double.Parse(tempData[j]);
                }
                avg /= double.Parse(tempData[0]);

                //평균 넘는 개수 찾기
                for(int j=1; j<int.Parse(tempData[0])+1; j++)   //개수만큼반복
                {
                    if(double.Parse(tempData[j]) > avg)
                    {
                        cnt++;
                    }
                }
                result = (double)cnt / double.Parse(tempData[0]) * 100.0;
                Console.WriteLine(result.ToString("0.000")+"%");
            }
        }
    }
}
