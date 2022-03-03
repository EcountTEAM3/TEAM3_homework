using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_static
{
    class Program
    {
        /*
        static 자원
        1. 객체 생성 이전에 메모리에 올라가는 자원
        2. 객체를 생성하지 않고 직접적인 접근(사용) 가능
        3. 종류 static class, static field(point), static constructor, static method(point)
        4. static 한 단어로 : 공유자원(단 객체간)
        5. static 자원 접근(사용) 방법

        class Sample {
        public static int s;

        public static void print() {
             //static method 목적 및 이점
             - 자주 사용하는 함수여서 편하게 사용하기 위해서

        }
        static 자원의 소멸시점은 App 종료될때


         */
        
        public class Sample
        {
            public static int s; //static variable
            public int i;        //instance variable (new Sample() 하면 heap생성되고 사용 가능)

            public void print()
            {
                int l = 100;     //local variable ( 함수 호출되면 생성되고 함수가 끝나면 사라짐)
            }
            public void printstatic()
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            Sample.s = 100;

            Sample sa =new Sample();
            sa.printstatic();
            Sample sa1 = new Sample();
            sa1.printstatic();
            Sample sa2 = new Sample();
            sa2.printstatic();
        }
    }
}
