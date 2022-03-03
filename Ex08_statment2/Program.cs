using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_statment2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int result = 1;
            switch (result)
            {
                case 1:
                    Console.WriteLine(result);
                    break;
                case 2:
                    Console.WriteLine(result);
                    break;
                case 3:
                    Console.WriteLine(result);
                    break;
                case 4:
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("nothing");
                    break;
            }

            Console.Write("점수를 입력하세요 :");
            int grade = Convert.ToInt32(Console.ReadLine());
            string a;

            if(grade >= 90)
            {
                a = "A";
                a = (grade >= 95) ? a += "+" : a += "-";
            }
            else if(grade >= 80)
            {
                a = "B";
                if (grade >= 85)
                    a += "+";
                else
                    a += "-";

            }
            else if(grade >= 70)
            {
                a = "C";
                if (grade >= 75)
                    a += "+";
                else
                    a += "-";

            }
            else
            {
                a = "F";
            }

            Console.WriteLine($"점수 : {grade} 학점: {a}");

            

            //switch case가 break를 가지지 않는 경우

            int m = 3;
            string r = "";
            switch(m)
            {
                case 1:
                case 3:
                    Console.WriteLine(1);
                    break;
                case 5:
                case 7:
                default:
                    r = "월 데이터가 아닙니다.";
                    break;
            }
            Console.WriteLine(r);
            */

            Console.WriteLine(Convert.ToString(20, 2).PadLeft(8, '0'));

            var array = new int[] { 1, 2, 3 };
            int[] array1 = new int[3] { 1, 2, 3 };
            int[] array2 = { 1, 2, 3 };


        }
    }
}
