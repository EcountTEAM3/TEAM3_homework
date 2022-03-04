using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21_Object_Arr
{

    class Ani
    {
        private string dogname;

        public Ani() { }
        public Ani(string dogname)
        {
            this.dogname = dogname;
        }

        public void anidisplay()
        {
            Console.WriteLine($"개이름 : {this.dogname}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ani[] ani = new Ani[4]; //heap 메모리에 방 3개(방 타입은 Ani) : 방의 값 null
            Ani a = new Ani("강아지");
            Ani a1 = new Ani("노리");
            Ani a2 = new Ani("아라");
            Ani a3 = new Ani("라라라");
            ani[0] = a;
            ani[1] = a1;
            ani[2] = a2;
            ani[3] = a3;

            ani[0].anidisplay();
            */

            Ani[] ani = new Ani[3];
            ani[0] = new Ani("아");
            ani[1] = new Ani("오");
            ani[2] = new Ani("래");

            Ani[] arr2 = new Ani[] { new Ani("라"), new Ani("카") };
            Ani[] arr3 = { new Ani("라"), new Ani("카") };

            for(int i = 0; i < ani.Length; i++)
            {
                ani[i].anidisplay();
            }
            foreach(Ani a in ani)
            {
                a.anidisplay();
            }
        }
    }
}
