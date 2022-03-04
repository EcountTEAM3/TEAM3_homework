using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lotto
{

     class Lotto
    {
        int[] number;
        int[] array;
        Random random;

        public Lotto()
        {
            random = new Random();
            int y;

        }

        public void getnumber()
        {
            int[] num = new int[6];
            Random rand = new Random();
            int temp;

            for (int i = 0; i < 6; i++)
            {
                int a = rand.Next(1, 45);
                num[i] = a;
                for (int j = 0; j < i; j++)
                {
                    if (i == 0) break;
                    num[i] = (num[i] == num[j]) ? i-- : num[i];
                }
            }
            for (int i = 0; i < num.Length-1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if(num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }

            foreach (int num1 in num)
            {
                Console.WriteLine(num1);
            }


        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Lotto lotto = new Lotto();
            lotto.getnumber();
            
           
            


        }
    }
}
