using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day15_19__정렬해보기
{
    public class Point : IComparable
    {
        private int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X
        {
            set { x = value;}
            get { return x; }
        }
        public int Y
        {
            set { y = value; }
            get { return y; }
        }
        public int CompareTo(object obj)
        {
            Point target = obj as Point;
            if(this.x < target.x)
            {
                return -1;
            }
            else if(this.x == target.x)
            {
                if (this.y < target.y)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 1;
            }
        }
    }
    class Baekjoon_11650
    {
        static void Main(string[] args)
        {
            // 길이 입력
            int len = int.Parse(Console.ReadLine());

            //입력, 배열인풋 전용 임시
            String tempInput;
            String[] tempArray;

            List<Point> arr = new List<Point>();
            //배열에 인풋
            for(int i=0; i<len; i++)
            {
                tempInput = Console.ReadLine();
                tempArray = tempInput.Split();
                arr.Add(new Point(int.Parse(tempArray[0]), int.Parse(tempArray[1])));
            }
            //정렬은 안전 정렬을 사용해야 한다. 퀵소트 등을 하면 꼬일 수 있음
            //안전 정렬 -> 버블 / 머지 / 레딕스

            //bubble(arr, 1);
            //bubble(arr, 0);
            //InsertionSort(arr, 1);
            //InsertionSort(arr, 0);
            arr.Sort();

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("{0} {1}", arr[i].X ,arr[i].Y);
            }
        }


        //삽입 정렬도 시간 초과
        /*
        static void InsertionSort(int[,] arr, int check)
        {
            int keyCheck, keytemp;
            int i, j;
            int temp = (check == 1) ? 0 : 1;
            for(i=1; i<arr.Length/2; i++)
            {
                keyCheck = arr[i, check];
                keytemp = arr[i, temp];
                for(j = i-1; j>=0 && arr[j,check]>keyCheck; j--)
                {
                    arr[j + 1, 0] = arr[j, 0];
                    arr[j + 1, 1] = arr[j, 1];
                }
                arr[j + 1, check] = keyCheck;
                arr[j + 1, temp] = keytemp;
            }
        }
        */

        /*
        //버블 정렬은 시간초과..
        static void bubble(int[,] arr,int check)
        {
            //check는 앞을 기준으로 정렬하는지 뒤를 기준으로 정렬하는지 결정하는 함수
            for (int i = 0; i < arr.Length/2; i++)
            {
                for (int j = i; j < arr.Length/2; j++)
                {
                    if (arr[i, check] > arr[j, check])
                    {
                        Swap(ref arr[i, 0], ref arr[j, 0]);
                        Swap(ref arr[i, 1], ref arr[j, 1]);
                    }
                }
            }
        }
        */

        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
