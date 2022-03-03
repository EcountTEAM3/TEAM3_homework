using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_ValueType
{

    #region +값 타입 : 구조체

    struct Book
    {
        public string name;
        public int price;

        public Book(string _name, int _price) //생성자 함수 - Book이 가지는 member 초기화
        {
            name = _name;
            price = _price;
        }
    }

    struct Human
    {
        public string ename;
        public int age;
    }

    class Car
    {
        public string name;
        public int price;

        public Car(string _name, int _price)
        {
            name = _name;
            price = _price;
        }
    }

    #endregion : 작은 타입을 모아서 의미있는 집합

    #region : +열거형 : 하나의 값타입

    enum mycolor {black, white, red, green, blue}; //열거타입//내부적으로 상수값 0 > 1++ 자동 설정
    enum week { mon, tue = 101, sat, sun}; //명시적으로 상수값 설정

    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            float f = 3.14f;

            Book book = new Book("홍길동전", 5000);

            //구조체에서 new는 객체를 생성하는 연산자가 아니고 초기화(생성자)
            Book book2 = book; //구조체의 할당은 새로운 구조체 생성

            book2.name = "New";
            book2.price = 2000;

            Console.WriteLine($"book {book.name},{book.price}");
            Console.WriteLine($"book2 {book2.name},{book2.price}");

            Car car = new Car("GV80", 1000);
            //new 연산자는 객체를 생성하는 연산자(new를 통해서 만들어진 객체는 heap에 생성)

            Car car2 = car; 
            car2.name = "New_Car";
            car2.price = 6000;

            Console.WriteLine($"car {car.name}, {car.price}");
            Console.WriteLine($"car2 {car2.name},{car2.price}");

            Human h;
            h.ename = "안재영"; //초기화 하고 사용하는 것은 동일
            h.age = 23;
            Console.WriteLine(h.ename);


            //열거타입
            mycolor m;
            //열거 타입 변수는 열거형 중 하나를 가질수 있다.
            m = mycolor.black;

            Console.WriteLine(m);
            Console.WriteLine((int)m);

            Console.BackgroundColor = ConsoleColor.Green;

            week w;
            w = week.sat;
            Console.WriteLine($"w : {w}");

            int a = 10;
            int b = 20;
            Console.WriteLine("{0} + {1} = {2}",a,b,a+b);
            Console.WriteLine($"{a}+{b} = {a+b}");

            const double PI = 3.14; //상수 : 관용적 표현 : 상수의 이름 대문자


            //형변환

            int num = 1234;
            long num1 = num; // long은 int크기보다 크다
            //long lon = (long)num;

            //명시적 형변환 (개발자가 의도를 가지고 실제 코드로 작업)
            long num2 = 234511;
            int num3 = Convert.ToInt32(num2); //값으로 보지말고 가지고 있는 타입으로 확인
            //형변환 값이 int 범위 내일시 값을 가질수 있다.
            Console.WriteLine(num3);//쓰래기 값 발생

            //큰 타입을 작은 타입으로 형변환하는 것은 손실을 감안하여야한다.

            int x = 254;
            byte y = (byte)x;
            Console.WriteLine($"y : {y}");

            var name = "문자열"; //string
            Console.WriteLine(name.GetType());
            var version = 8.0;
            Console.WriteLine(version.GetType());

            //참고
            int i2 = default;
            Console.WriteLine(i2);
            int d2 = default;
            Console.WriteLine(d2);


        }
    }
}
