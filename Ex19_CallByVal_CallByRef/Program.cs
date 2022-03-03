using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19_CallByVal_CallByRef
{
    /*
    class test
    {

        public void print()
        {
            printdata();
        }

        private int printdata()
        {
            return 10;
        }

        public void method(Car c)
        {

        }

        public void method2(int i) {

        }
    }

    */

    class Car
    {
        public int speed;
        public void run(int data)
        {
            speed += data;
        }
    }
    class Car2
    {
        public int speed;
        public void run(ref int data)// xx주소
        {
            speed += data;
            data = 50; //xx주소
        }
    }
    class Car3
    {
        public int speed;
        public void run(out int data)// xx주소
        {
            data = 100;
            speed += data;
            data = 50; //xx주소
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            int data2 = 20;
            car.run(data2);
            Console.WriteLine(car.speed);
            Console.WriteLine($"data2 : {data2}");

            Car2 car2 = new Car2();
            int data3 = 20; //xx번지
            car2.run(ref data3); //data3 변수가 가지는 값을 전달

            Console.WriteLine(car2.speed);
            Console.WriteLine($"data3 : {data3}");

            Car3 car3 = new Car3();
            int data4 = 20; //xx번지
            car3.run(out data4); //data3 변수가 가지는 값을 전달

            Console.WriteLine(car3.speed);
            Console.WriteLine($"data4 : {data4}");

        }
    }
}
