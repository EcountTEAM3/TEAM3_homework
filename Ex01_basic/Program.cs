using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_basic // 논리적인 묶음의 단위(class간 충돌방지)
{
    class Program
    {
        //class는 설계도 == class는 타입이다.
        // java, c# : class 만들기, class 이름을 붙이면 설계도 : 객체 생성가능
        //class 2가지 : main : 실행가능 class(exe), main x : 실행불가능(dll) 
        //원칙적인 방법 : 모든 클래스는 new 연산자를 통해서 memory 로드
        //program p = new program()

        class Car
        {

        }

        class Test
        {
            public int data;

        }

        static void Main(string[] args) //함수(method) > 기능 > static(독자적으로 메모리) > 이름에 main > 실행가능(exe)
        {
            // Console.WriteLine("hello world");

            //데이터 타입과 변수
            char c; //2byte  한글한자 : 2byte, 영문자, 특수문자, 공백 1byte
            c = 'A';

            char d;
            d = '가';
            Console.WriteLine($"{c},{d}");

            //지역변수는 반드시 초기화 후 사용
            short s = 10000;
            Console.WriteLine(s);

            int i = 10000000;
            Console.WriteLine(i);

            //실수 리터럴의 기본형을 double
            float f = 1.123456f;
            Console.WriteLine(f);

            double dd = 1.253746267;
            Console.WriteLine(dd);

            int aa = 100;
            int bb = aa;
            bb = 200;
            Console.WriteLine($"aa값은 {aa}");
            Console.WriteLine(aa.GetHashCode());

            Test t = new Test();
            Console.WriteLine(t.GetHashCode());
            t.data = 100;

            Test t2 = t;
            t2.data = 1111;
            Console.WriteLine($"t가 가지는 data 변수값 {t.data} 이다");
            Console.WriteLine(t == t2);
            Console.WriteLine($"{t.GetHashCode()}-{t2.GetHashCode()}");

        }
    }
}
