using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int unit = 10000;
            int num = 0;
            int sw = 0;
            Boolean auto = true;

            Console.Write("얼마있어? :");
            int money = Convert.ToInt32(Console.ReadLine());
            while(auto)
            {
                num = money / unit;
                Console.WriteLine($"{unit}원권 : {num}개");

                if (unit < 10)
                {
                    auto = false;
                }
                else
                {
                    money = money - unit * num;
                    if(sw == 0)
                    {
                        unit /= 2;
                        sw = 1;
                    }
                    else if(sw == 1)
                    {
                        unit = unit / 5;
                        sw = 0;
                    }
                }

            }
            

        }
    }
}
