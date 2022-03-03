using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_const_readonly
{
    class Test
    {   //const 상수 생성시
        //1. 객체간 공유자원 > 자동 static
        //2. 의무적 초기화 필요
        public const int MAXVALUE = 1000;

        //readonly 상수 생성시
        //1.반드시 초기화 할 필요없다.
        //2. 생성자에서 딱 한번 값을 할당 할 수 있다.
        public readonly int readdata;
        public Test(int data)
        {
            readdata = data;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //const test
            Console.WriteLine(Test.MAXVALUE);

            Test t = new Test(10);
            Console.WriteLine($"t.readdata : {t.readdata}");
            Test t1 = new Test(20);
            Console.WriteLine($"t.readdata : {t1.readdata}");
        }
    }
}
