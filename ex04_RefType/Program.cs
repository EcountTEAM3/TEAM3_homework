using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_RefType
{
    class Test
    {
        public int i; //member field (instance variable), i변수는 class 내에서 유효

        public void print()
        {
            int data = 100; //local variable
            Console.WriteLine($"data : {data}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.print();

            Test test2 = new Test();
            test2.print();

            Test test3 = new Test();
            test3.print();

            //test, test2, test3는 참조 타입 (변수가 주소를 가지고 있다)

            for(int i = 0; i < 10; i++) //block variable > i는 for문 시작시 생성, for문 끝날시 소멸
            {

            }
        }
    }
}
