using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day15_19__정렬해보기
{
    class Baekjoon_1427
    {
        static void Main(string[] args)
        {
            int data = int.Parse(Console.ReadLine());
            List<int> myData = new List<int>();
            int len = 0;
            for(; data!=0; data /= 10, len++)
            {
                myData.Add(data % 10);  //데이터에 int를 넣는다.
            }
            for (int i = 0; i < len-1; i++)
            {
                for (int j = 0; j < len-1-i; j++)
                {
                    if (myData[j] < myData[j + 1])
                    {
                        int temp = myData[j];
                        myData[j] = myData[j + 1];
                        myData[j + 1] = temp;
                    }
                }
            }
            foreach(int arr in myData)
            {
                Console.Write(arr);
            }
        }
    }
}
