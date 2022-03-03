using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }

            /*for(int i = 2; i <10; i++)
            {
                for(int j =1; j <10; j++)
                {
                    Console.Write($"{i}*{j}={i*j}\t");
                }
                Console.WriteLine();
            }*/
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i == j) continue;
                    Console.Write($"{i}*{j}={i * j}\t");
                }
                Console.WriteLine();
            }
            int result;
            Console.Write("숫자값을 입력하세요");
            result = int.Parse(Console.ReadLine());

           switch(result)
            {
                case 1: Console.WriteLine(result);
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
            





        }

    }
}
