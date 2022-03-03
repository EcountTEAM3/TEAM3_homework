using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_static_scope
{
    /*
    public class Test //원칙 : class 내부에서 public과 private 구분 x
    {
        static int i;          //private 접근자 > 클래스 이름 접근 불가 > Test.i x
        public static int j;   //public 접근자 > 클래스 이름 접근 가능  > Test.j o

        //클래스가 일반자원과 static 자원을 다 가지고 있는 경우
        //일반함수에서 static member 사용가능(메모리 생성 시점이 항상 static 우선)
        //static함수에서 일반 member 사용 불가능
        public static void method()  
        {
            i = 100;
            j = 200;
            Console.WriteLine($"i:{i}, j:{j}");
        }

        public void gMethod() //일반함수 >> memory에서 >> Test t = new Test() 실행 >> memory
        {
            i = 111;
            j = 222;
            Console.WriteLine($"gMethod => i:{i}, j: {j}");
        }
    }

    class Test2
    {
        public static int sk; //static variable
        public int gk;        //instance variable, member field

        public void method()
        {   //sk static 변수 접근 o
            //gk 변수 접근 o
            sk = 100;
            gk = 200;

        }

        public static void sMethod()
        {
            //sk static 변수 접근 o
            //gk 변수 접근 x
            sk++;
            
        }

    }
    */
    class Program
    {
        private static int sint;
        private int gint;
        static void Main(string[] args)
        {
            /*
            Test.method();
            Test test = new Test();
            test.gMethod();

            Program.sint = 100;
            Program p = new Program();
            p.gint = 100;

            */


        }
    }
}
