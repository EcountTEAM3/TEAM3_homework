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
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }

            for(int i = 2; i <10; i++)
            {
                for(int j =1; j <10; j++)
                {
                    Console.Write($"{i}*{j}={i*j}\t");
                }
                Console.WriteLine();
            }
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
            
            //1~100까지 합
            int i=1;
            int i_sum = 0;
            while(i<=100)
            {
                i_sum += i;
                Console.WriteLine($"{i_sum}");
                i++;
            }
            
            int k = 1;
            int k_sum = 0;
            while(k <= 100)
            {
                if(k % 2 != 0)
                {
                    k_sum += k;
                }
                else
                {
                    k++;
                    continue;
                }
                Console.WriteLine($"{k_sum}");
                k++;
            }
            int even = 0;
            int odd = 0;
            for(int i =1; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    even += i;

                }
                else
                {
                    odd += i;
                }
                Console.WriteLine($"짝수는 {even}, 홀수는 {odd}");
            }
            
            Console.Write("id :");
            string in_id = Console.ReadLine();
            Console.WriteLine();
            Console.Write("password :");
            string in_pw = Console.ReadLine();
            if(in_id == "admin" && in_pw == "1234")
            {
                Console.WriteLine("로그인 성공");
            }
            else
            {
                Console.WriteLine("틀렸습니다.");
            }
            

            //연산자 암기 : 삼항연산자
            int p = 10;
            int k = -10;

            int result = (p == k) ? p : k;
            Console.WriteLine($"{result}");
            */

            int x1 = 3;
            int x2 = 5;
            string x3 = Convert.ToString(x1, 2);
            Console.WriteLine(Convert.ToString(x1, 2));
            //비트연산
            //3 십진수 값을 이진수
            //0 0 1 1 십진수 3
            //0 1 0 1 십진수 5
            //0 0 0 1 3 & 5
            //0 1 1 1 3 & 5


        }

    }
}
