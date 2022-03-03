using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_statement3
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //do while
            //의무(강제) 선행되서 실행
            int inputdata = 0;
            do
            {
                Console.WriteLine("숫자를 입력해주세요(0~9)");
                inputdata = int.Parse(Console.ReadLine());

            } while (inputdata >= 10); //조건이 true do문을 계속 실행
                                       // 조건이 false 탈출
            Console.WriteLine($"당신이 입력한 숫자는 : {inputdata}");

            int a = 0, b = 1, c = 0;
            for (int i =0; i<10; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine($"{a}, {b}, {c}");
                Console.WriteLine($"{c}");
                //1,1,2,3,5,8
            }

            string opr = "+";
            if(opr == "+")
            {
                Console.WriteLine("같은 문자열");
            }
        }
    }
}
