using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.백준_While문_사용해보기
{
    class Baekjoon_10951
    {
        static void Main(string[] args)
        {
            string data;
            string[] temp;

            while((data = Console.ReadLine()) != null)
            {
                temp = data.Split();
                Console.WriteLine(int.Parse(temp[0]) + int.Parse(temp[1]));
            }
        }
    }
}
