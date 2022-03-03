using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_constructor_static
{

    public class Test
    {
        //public static int staticint = 0;

        public static int staticint;

        static Test() //static 생성자 > static member field가 메모리에 올라갈때 자동 호출
        {
            staticint = 100; //제어로직
        }

        public static void print()
        {
            Console.WriteLine($"staticint value : {staticint}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test.print();
        }
    }
}
