using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day5_백준_if문_사용해보기
{
    class Baekjoon_1546
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());   //개수 입력
            int max = 0;    //최대값
            decimal result = 0; //결과값
            string temp = Console.ReadLine();
            string[] data = temp.Split();   //분리
            //int로 변경
            int[] realData = new int[data.Length];
            for(int i = 0; i < data.Length; i++)
            {
                realData[i] = int.Parse(data[i]);
            }

            //최대값 찾기
            foreach(int tmp in realData)
            {
                max = (max > tmp) ? max : tmp;
            }
            //평균구하기
            foreach(int tmp in realData)
            {
                result += ((decimal)tmp / (decimal)max) * (decimal)100;
            }
            result /= len;
            Console.WriteLine(result);
        }
    }
}
