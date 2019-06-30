using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_self_study.Day2_백준_단계별로_풀어보기Ver1
{
    class 문제_2558_곱셈
    {
        static void Main(string[] args)
        {
            //두 개의 숫자를 입력받는다.
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            //3, 4, 5의 결과 출력
            Console.Write("{0}\n{1}\n{2}\n",
                firstNum * (secondNum % 10),
                firstNum * ((secondNum / 10) % 10),
                firstNum * (secondNum / 100));

            //6의 결과출력1 -> 그대로 출력
            //Console.Write(firstNum * secondNum);

            //6의 결과출력2 -> 위에서의 연산결과 기반으로 출력
            Console.Write(
                (firstNum * (secondNum % 10)) +
                (firstNum * ((secondNum / 10) % 10)) * 10 +
                (firstNum * (secondNum / 100) * 100)
                );
        }
    }
}
