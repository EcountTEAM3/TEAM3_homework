using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_class
{
    //연습 class 생성
    //class는 설계도 = data type

    class Person //설계도 : 속성 + 기능
    {            //속성(정보를 담는 그릇 : 크기 +이름 > 변수)
        int num; //class가 가지는 변수 : instance variable : 객체마다 가지는 변수
                 // Person p = new Person();
                 //기본적은 접근자 private로 처리
                 //객체지향 언어의 특징(캡슐화, 은닉화) > 보호 기술 : private
                 //1. private : class 내부에서 사용 가능, 객체에서 사용 불가
                 //2. public : 클래스 내부에서와 외부에서 사용(보호문제(직접할당))
                 //3. 
                 //3.1 함수생성 : public : 캡슐화된 자원에 read, write
        private int k;
        public int p;
        string ename;
        //property : private member field에 대해서 간접적인 데이터 처리 목적 : read, write
        //int num
        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public string Ename
        {
            get { return ename + "님"; }
            set { ename = value; }
        }


    }

    #region
    /*
     1. 클래스 = 설계도 = 데이터 타입
     2.클래스 가장 기본적인 구소 요소 > 속성(정보): member field + 기능(함수) : method
     3. 클래스 요소 중에 : 속성(instance variable, member field)
     3.1. private 접근자를 통해서 캡슐화
     3.2 객체 입장에서 read, write(직접할당 불가)
     3.3 별도의 함수를(public) 통해서 get, set 구현
     3.4 전용(read, write) > property
     3.4 member field property 구현함으로써 간접적인 데이터 처리 가능
     */
    #endregion

    class Apt
    {
        private string aptname;
        private string aptcolor;

        
        //함수이용
        //특수한 목적의 함수(사용방법 member field 의 초기화)
        //설계약속 : 함수의 이름 클래스 이름과 같이
        public Apt() //원칙적으로 함수는 void or int or string
                     //생성자 함수(constructor) >> 객체가 생성될 때 호출되는 함수
                     //Apt apt = new Apt();
                     //member field가 먼저 memory올라가고 생성자 함수가 실행된다.
        {
            aptname = "삼성";
            aptcolor = "red";

        }

        public Apt(string aptname, string aptcolor) // 생성자 함수 overloading(함수의 이름은 같은데 parameter의 개수와 타입을 다르게)
        {
            this.aptname = aptname;
            this.aptcolor = aptcolor;
        }
        public string Aptname
        {
            get { return aptname; }
        }
        public string Aptcolor
        {
            get { return aptcolor; }
        }



    }
    //요구사항
    //아파트를 만들때 특별한 요구사항이 없으면 이름과 색상은 기본설정을 한다.
    //그리고 필요시 강제로 이름, 색상을 넣을 수 있게 한다.
    // Apt apt = new Apt(); null, null


    class Program
    {
        static void Main(string[] args)
        {
            
            Person p = new Person();
            Person p1 = new Person();
            // p.num = 100라는 변수가 직접적으로 num변수에 접근을 막는다
            p.p = 100; //직접할당
            p1.p = 200; //직접할당

            p.Num = 555;
            Console.WriteLine($"get{p.Num}");

            p.Ename = "안재영";
            Console.WriteLine($"get ename : {p.Ename}");

            Apt apt = new Apt();
            Console.WriteLine($"apt.name : {apt.Aptname}");
            Console.WriteLine($"apt.color : {apt.Aptcolor}");

            Apt new2 = new Apt("LG","Yellow");
            Console.WriteLine();
            Console.WriteLine($"apt.name : {new2.Aptname}");
            Console.WriteLine($"apt.color : {new2.Aptcolor}");




        }
    }
}