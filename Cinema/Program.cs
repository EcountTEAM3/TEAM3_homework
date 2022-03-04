using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
   

    class Cinema
    {
        

        public void Cancel()
        {
            string[,] book = new string[4, 5];
            string booking;
            int select;
            string[,] l = new string[4, 5];
            Console.WriteLine("예매번호를 입력해주세요");
            booking = Console.ReadLine();

            Console.WriteLine($"고객님이 예매하신 좌석은 {booking} 입니다. \n");

           
            select = Convert.ToInt32(Console.ReadLine());
            string booking_num_10 = booking.Substring(0, 1);
            string booking_num_1 = booking.Substring(2, 1);
            int low = Convert.ToInt32(booking_num_10);
            int col = Convert.ToInt32(booking_num_1);
            Console.WriteLine($"{low}, {col}");
            if(l[low,col] == "[예매]")
            {
                Console.WriteLine(@"예매를 취소하시겠습니까?
 네(1), 아니오(2) 중 하나를 입력해주세요.");
                if (select == 1)
                {

                    book[low, col] = $"[{low}]-[{col}]";

                }
                if (select == 2)
                    Console.WriteLine("예매 취소를 하지 않겠습니다.\n");
            }
            else Console.WriteLine("예매 번호를 확인해주세요");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int select=0;
            string[,] seat = new string[4, 5];
            Cinema cinema = new Cinema();
            Boolean auto = true;

            while(auto)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("*****영화 예매 시스템*****");
                Console.WriteLine("**************************");
                Console.WriteLine("1. 예매하기 \n \n");
                Console.WriteLine("2. 예매조회 \n \n");
                Console.WriteLine("3. 예매취소 \n \n");

                select = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                switch (select)
                {
                    case 1:

                        Console.WriteLine("좌석을 선택해주세요  예) 1-1");
                        Console.WriteLine("이미 예매된 자석은 예매라고 표시됩니다.");

                        break;
                    case 2:

                        break;
                    case 3:
                        cinema.Cancel();
                        break;

                    default:
                         auto = false;
                         break;
                }

            }
        }
    }
}
