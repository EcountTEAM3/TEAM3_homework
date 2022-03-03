using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int result=1;

            for(int i = a; i > 0; i--)
            {
                result *= i;
                
            }

            Console.WriteLine(result);
        }
    }
}
