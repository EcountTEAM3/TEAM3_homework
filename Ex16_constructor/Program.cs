using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_constructor
{


    /*
     생성자 함수(특수한) : member field 초기화 목적
    생성방법 : 함수이름 > class 이름과 동일, 접근자 public , return 없음(void)
    종류 : default constructor (parameer (x)), overloading constructor (parameter 개수와 타입을 달리해서 만듬)
    실행시점 : 객체 생성과 동시에 호출되는 함수 (new Test(), new Test(100,200)) > 생성자 호출 전 member field 먼저 메모리에 존재
    */
    class Test
    {
        //1.생성자를 구현하지 않으면 컴파일러가 자동으로 생성자 하나 만든다.

    }

    class Test2
    {
        public Test2()
        {

        }
    }

    class Test3
    {
        public Test3()
        {

        }
        public Test3(int i)
        {

        }
    }
    class Test4
    {
        public Test4(int i) //overloading만 생성
        {

        }
        //overloading 생성자 하나라도 존재하면 defalut는 반드시 구현을 통해서 사용가능
        //개발자 의도 : 객체 생성 시 반드시 parameter 가지고 생성하세요
    }
        class Test5
        {
            public Test5(int i)
            {
            }
            public Test5(int i, int j)
            {
            }
            public Test5(int i, int j, int z)
            {
            }
        }

    class Book
    {
        string bname;
        int price;

        public Book(string bname)
        {
            this.bname = bname;
        }
        public Book(int price)
        {
            price = price;
        }
        public Book(string bname, int price)
        {
            this.bname = bname;
            this.price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
        }
    }
}
