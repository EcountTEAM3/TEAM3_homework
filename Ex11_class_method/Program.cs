using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_class_method
{
    //설계도 : 속성 + 기능

    //기능 == 행위 == method(함수)

    class Test
    {
        private int i; //instance variable, member field

        //행위 기능
        //method는 호출되면 실행
        //4가지
        //void, parameter(x)    : public void m(){실행코드}
        //void, parameter(o)    : public void m(int i){실행코드}
        //return, parameter(x)  : public int m(){return 값;}
        //return, parameter(o)  : public int m(int m){return i;}

        public void call_method() 
        {
            Console.WriteLine("안뇽");
        }

        public void call_method1(int i)
        {
            if (i == 1) Console.WriteLine("1이다");
            else Console.WriteLine("치지마");
        }
        public string call_method2()
        {
            return "메롱";
        }
        public string call_method3(string j)
        {
            return j + "방가";
        }
        public int call_method4(int i, int j, int z)
        {
            return i + j + z;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {

            Test test = new Test();
            //함수는 호출에 의해서 실행
            test.call_method();
            test.call_method1(1);
            string a=test.call_method2();
            Console.WriteLine(a);
            string b = test.call_method3("나");
            Console.WriteLine(b);

            int value = test.call_method4(3, 2, 1);
            Console.WriteLine(value);
        }
    }
}
