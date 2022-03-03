using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Opr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(100+100); //숫자 : 산술
            Console.WriteLine("100"+"100"); //문자열 : 결합
            Console.WriteLine("100"+100); // 결합

            int i = 10; //지역변수 형상 초기화
            int j;
            j = i++; //후치증가
            Console.WriteLine($"i:{i},j:{j}");
            j = ++i; //전치증가
            Console.WriteLine($"i:{i},j:{j}");

            int k = 100;

            k++;
            ++k;
            //혼자 있으면 전치, 후치 무관

            int sum = 0;
            int s2 = 100;
            sum += s2;// sum = sum +s2;

            int ysum;
            int y = 10;
            ysum = y++ + 10;
            Console.WriteLine($"y = {y}, ysum = {ysum}");

            int a = 10;
            int b = 20;

            if(a > b && a >10)
            {
                
            }
        }
    }
}
