using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day15_19__정렬해보기
{
    class Baekjoon_2108
    {
        static void Main(string[] args)
        {
            int[] arr;
            // 개수 입력
            int len = int.Parse(Console.ReadLine());

            float avg = 0.0f;

            // 중앙값, 등장횟수, 현재횟수, 범위
            int mid, times = 0,current = 0, length;

            //최빈값
            int[] check = new int[8001];
            List<int> bin = new List<int>();

            arr = new int[len];
            // 개수만큼 input
            for(int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                check[arr[i] + 4000]++;
            }

            // 정렬
            sort(arr,0,len-1);

            //1. 산술평균
            foreach(int i in arr)
            {
                avg += i;
            }
            avg /= arr.Length;
            
            if(avg >= 0)
            {
                Console.Write((int)(avg + 0.5)+"\n");
            }
            else
            {
                Console.Write((int)(avg - 0.5)+"\n");
            }

            //2. 중앙값
            mid = arr[arr.Length / 2];
            Console.WriteLine(mid);

            //3. 최빈값
            int maxIndex = 0;
            for(int i = 0; i < 8001; i++)
            {
                if(check[maxIndex] < check[i])
                {
                    maxIndex = i;
                    bin.Clear();
                }
                else if(check[i] != 0 && check[i] == check[maxIndex])
                {
                    bin.Add(i - 4000);
                }
            }
            if (bin.Count() != 0)
                Console.Write(bin[0] + "\n");
            else
                Console.Write(maxIndex - 4000 + "\n");

            /*
            for(int i=0; i<arr.Length; i++)
            {
                //첫 데이터
                if(bin.Count == 0)
                {
                    times = 1;
                    current = 1;
                    bin.Add(arr[i]);
                }
                else
                {
                    //전 데이터랑 비교해서 같을 경우
                    if(arr[i-1] == arr[i])
                    {
                        current++;
                        //제일 클 경우 데이터 변경
                        if (current > times)
                        {
                            bin.Clear();
                            bin.Add(arr[i]);
                        }
                        //동일할 경우 데이터 삽입
                        else if (current == times)
                            bin.Add(arr[i]);
                    }
                    //데이터가 다를 경우
                    else
                    {
                        current = 1;    //첫 등장이므로
                        if(times == current)    //처음 등장하는것일 수 있음
                        {
                            bin.Add(arr[i]);
                        }
                    }

                }
            }

            if (bin.Count > 1)
            {
                Console.WriteLine(bin[1]);
            }
            else
            {
                Console.WriteLine(bin[0]);
            }
            */

            //4. 범위
            length = arr[arr.Length - 1] - arr[0];
            Console.WriteLine(length);
        }

        static void sort(int[] arr,int left, int right)
        {
            if(left < right)
            {
                int q = partition(arr, left, right);
                sort(arr, left, q - 1);
                sort(arr, q + 1, right);
            }
        }

        static int partition(int[] arr,int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for(int j=left; j<right; j++)
            {
                if(arr[j] <= pivot)
                {
                    i++;
                    swap(ref arr[i], ref arr[j]);
                }
            }
            swap(ref arr[i + 1], ref arr[right]);

            return i + 1;
        }
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
