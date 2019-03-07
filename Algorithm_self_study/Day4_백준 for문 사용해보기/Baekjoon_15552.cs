using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithm_self_study.Day4_백준_for문_사용해보기
{
    class Baekjoon_15552
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder("");
            StringReader strReader = new StringReader("");
            string temp = null;
            try
            {
                temp = strReader.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(temp);
            }
        }
    }
}
